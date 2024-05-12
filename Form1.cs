using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Connection string to the SQL Server database
        private string connectionString = @"Data Source=GWNC31514\SQLEXPRESS;Initial Catalog=homeExercise;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            // Hide panels
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            //this should activate the button click event
            signIn.Click += signIn_Click;
            signUp.Click += signUp_Click;


            //linkClicked event of the signout LinkLabel
            signOut.LinkClicked += signOut_LinkClicked;
            signOut2.LinkClicked += signOut2_LinkClicked;
            signOut3.LinkClicked += SignOut3_LinkClicked;

            progressLink.LinkClicked += progressLink_LinkClicked;
            progressLink3.LinkClicked += ProgressLink3_LinkClicked;
            routinesLink.LinkClicked += routinesLink_LinkClicked;
            routinesLink3.LinkClicked += RoutineLink3_LinkClicked;
            routinesLink2.LinkClicked += routinesLink2_LinkClicked;
            workoutLink.LinkClicked += WorkoutLink_LinkClicked;
            workoutLink2.LinkClicked += WorkoutLink_LinkClicked;

            // Event of the combobox
            routineDDB.SelectedIndexChanged += routineDDB_SelectedIndexChanged;
          
            // Click event for submitP2 button
            submitP2.Click += submitP2_Click;
            // Event handlers for textboxes to allow only numbers and limit input to 3 digits
            cWeight.KeyPress += NumericTextBox_KeyPress;
            gWeight.KeyPress += NumericTextBox_KeyPress;          
        }

        private void SignOut3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide panels and clear textboxes
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            emailText.Text = "";
            passwordText.Text = "";
        }

        // Event handler for routineLink3 linkLabel
        private void RoutineLink3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel1 and hide others
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        // Event handler for progressLink3 linkLabel
        private void ProgressLink3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel2 and hide others
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        // Event handler for workoutLink and workoutLink2
        private void WorkoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide both panels
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
      
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

        private void signUp_Click(object sender, EventArgs e)
        {
            // Get the user-entered email and password
            string email = emailText.Text;
            string password = passwordText.Text;

            // Check if the email already exists in the login table
            bool emailExists = CheckIfEmailExistsInLogin(email);

            if (!emailExists)
            {
                // If the email doesn't exist, add it to the login table
                AddEmailToLogin(email, password);
                MessageBox.Show("You have signed up successfully, please click login button to continue.");
            }
            else
            {
                // If the email already exists, display a message
                MessageBox.Show("E-Mail already exists, please login with your email and password.");
            }
        }

        private bool CheckIfEmailExistsInLogin(string email)
        {
            // Query to check if the email exists in the login table
            string query = "SELECT COUNT(*) FROM login WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // If count > 0, the email exists in the table
                    return count > 0;
                }
            }
        }

        private void AddEmailToLogin(string email, string password)
        {
            // Query to insert the email and password into the login table
            string insertQuery = "INSERT INTO login (email, password) VALUES (@Email, @Password)";

            // Create and open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object with the insert query and connection
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the insert query
                    command.ExecuteNonQuery();
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

        private void submitP2_Click(object sender, EventArgs e)
        {
            // Get the email entered in the emailText textbox
            string email = emailText.Text;

            // Check if the email exists in the fitnessProgress table
            bool emailExists = CheckIfEmailExists(email);

            // If the email doesn't exist in the fitnessProgress_new table, it needs to be added
            if (!emailExists)
            {
                AddEmailToFitnessProgress(email);
                MessageBox.Show("Email added to fitnessProgress table.");
            }
            else
            {
                MessageBox.Show("Email already exists in fitnessProgress table.");
            }

            // Insert the entered weights into the fitnessProgress_new table
            if (int.TryParse(cWeight.Text, out int currentWeight) && int.TryParse(gWeight.Text, out int goalWeight))
            {
                // Insert the weights into the fitnessProgress_new table
                AddWeightsToFitnessProgress(email, currentWeight, goalWeight);

                // Calculate the weight difference
                int weightDifference = currentWeight - goalWeight;

                // Clear previous messages in listBox2
                listBox2.Items.Clear();

                // Display appropriate message in listBox2 based on weight difference
                if (weightDifference > 0)
                {
                    // If cWeight is greater than gWeight
                    listBox2.Items.Add("You are " + weightDifference + " pounds from your goal weight.");
                }
                else if (weightDifference == 0)
                {
                    // If cWeight is equal to gWeight
                    listBox2.Items.Add("You have reached your goal weight!");
                }
                else
                {
                    // If cWeight is less than gWeight
                    listBox2.Items.Add("You are under your goal weight.");
                }

                MessageBox.Show("Weights added to fitnessProgress table.");
            }
            else
            {
                MessageBox.Show("Please enter valid weights (positive integers).");
            }
        }
        

         private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            // Limit input to 3 digits
            if ((sender as TextBox).Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool CheckIfEmailExists(string email)
        {
            // Query to check if the email exists in the fitnessProgress table
            string query = "SELECT COUNT(*) FROM fitnessProgress_new WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // If count > 0, the email exists in the table
                    return count > 0;
                }
            }
        }

        private void AddEmailToFitnessProgress(string email)
        {
            // Query to insert the email into the fitnessProgress table
            string insertQuery = "INSERT INTO fitnessProgress_new (email) VALUES (@Email)";

            // Create and open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object with the insert query and connection
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameter to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Email", email);

                    // Execute the insert query
                    command.ExecuteNonQuery();
                    
                    // Inform the user that the email has been added
                    MessageBox.Show("Email added to fitnessProgress table.");
                }
            }
        }

        private void AddWeightsToFitnessProgress(string email, int currentWeight, int goalWeight)
        {
            // Query to update CurrentWeight and GoalWeight columns in the fitnessProgress table
            string query = "UPDATE fitnessProgress_new SET CurrentWeight = @CurrentWeight, GoalWeight = @GoalWeight WHERE email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CurrentWeight", currentWeight);
                    command.Parameters.AddWithValue("@GoalWeight", goalWeight);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Event handler for generateBtn button click

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current day of the week
                DayOfWeek currentDay = DateTime.Today.DayOfWeek;

                // query to retrieve a random workout plan for the current day of the week
                string query = "SELECT TOP 1 PlanName, PlanDuration FROM workoutPlan WHERE dayOfTheWeek = @DayOfTheWeek ORDER BY NEWID()";

                // Create and open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the query to specify the current day of the week
                        command.Parameters.AddWithValue("@DayOfTheWeek", currentDay.ToString());

                        // Execute the query and read the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the workout plan name and duration
                                string planName = reader["PlanName"].ToString();
                                int planDuration = Convert.ToInt32(reader["PlanDuration"]);

                                // Construct the message for the workout plan
                                string message = "Hello, today is " + currentDay + " " + DateTime.Today.ToShortDateString() +
                                                 ". Your workout plan today is " + planName + ". This should last " +
                                                 planDuration + " minutes.";

                                // Split the message into lines based on periods followed by spaces
                                string[] lines = Regex.Split(message, @"\.\s");

                                // Display the workout plan information in listBox3
                                listBox3.Items.Clear();
                                foreach (string line in lines)
                                {
                                    listBox3.Items.Add(line);
                                }
                            }
                            else
                            {
                                // If no workout plan found for the current day, display a message
                                listBox3.Items.Clear();
                                listBox3.Items.Add("No workout plan found for today.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
