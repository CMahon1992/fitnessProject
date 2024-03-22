using System.Data.SqlClient;
using System.Windows.Forms;
using System;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Connection string to the SQL Server database
        private string connectionString = @"Data Source=GWNC31514\SQLEXPRESS;Initial Catalog=homeExercise;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            // Hide panel1
            panel1.Visible = false;
            panel2.Visible = false;
            //this should activate the button click event
            signIn.Click += signIn_Click;
            //linkClicked event of the signout LinkLabel
            signOut.LinkClicked += signOut_LinkClicked;
            progressLink.LinkClicked += progressLink_LinkClicked;
            routinesLink.LinkClicked += routinesLink_LinkClicked;
            // Event of the combobox
            routineDDB.SelectedIndexChanged += routineDDB_SelectedIndexChanged;
            // LinkClicked event for routinesLink in panel2
            routinesLink2.LinkClicked += routinesLink2_LinkClicked;
            // LinkClicked event for signOut2 in panel2
            signOut2.LinkClicked += signOut2_LinkClicked;
        }


        private void signIn_Click(object sender, EventArgs e)
        {
            // Get the user-entered email and password
            string email = emailText.Text;
            string password = passwordText.Text;

            // Create SQL query to check if the entered email and password match any records
            string query = "SELECT COUNT(*) FROM login WHERE email = @Email AND password = @Password";

            // Create and open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if login was successful
                    if (count > 0)
                    {
                        MessageBox.Show("Login success!");
                        // show panel1
                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Please check your login credentials.");
                    }
                }
            }

        }

        private void routineDDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing items in listBox1
            listBox1.Items.Clear();

            // Retrieve the selected option from the ComboBox
            string selectedRoutine = routineDDB.SelectedItem.ToString();

            // Query to fetch exercise names and YouTube links based on the selected option
            string query = "SELECT exercise_name, youtube FROM browseRoutines WHERE muscle_group = @MuscleGroup";

            // Create and open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@MuscleGroup", selectedRoutine);

                    // Execute the query and read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the results and add them to listBox1
                        while (reader.Read())
                        {
                            // Combine exercise name and YouTube link
                            string exerciseInfo = $"{reader["exercise_name"]} - {reader["youtube"]}";
                            // Add the combined string to listBox1
                            listBox1.Items.Add(exerciseInfo);
                        }
                    }
                }
            }
        }
        private void signOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide panel1 and panel2
            panel1.Visible = false;
            panel2.Visible = false;
            // Clear email and password textboxes
            emailText.Text = "";
            passwordText.Text = "";
        }

        private void progressLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel2 and hide panel1
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void routinesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel1 and hide panel2
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void routinesLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel1 and hide panel2 when routinesLink is clicked on panel2
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void signOut2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide both panels
            panel1.Visible = false;
            panel2.Visible = false;
            // Clear email and password textboxes
            emailText.Text = "";
            passwordText.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}