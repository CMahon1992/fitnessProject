using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace homeFitnessSite
{
    public partial class loginPage : Form
    {
        // Connection string to the SQL Server database
        private string connectionString = @"Data Source=GWNC31514\SQLEXPRESS;Initial Catalog=homeExercise;Integrated Security=True";

        public loginPage()
        {
            InitializeComponent();
            // Set the background image and adjust its layout
            SetBackgroundImage();
            //this should activate the button click event
            signIn.Click += signIn_Click;
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetBackgroundImage()
        {
            // Load the background image from file
            Image backgroundImage = Image.FromFile(@"C:\Users\CMaho\source\repos\fitnessProject\images\homePageImage.jpg");

            // Set the background image and adjust its layout
            this.BackgroundImageLayout = ImageLayout.Zoom; 
            this.BackgroundImage = backgroundImage;

            // Call ResizeBackgroundImage to adjust the background image when the form is resized
            this.Resize += new EventHandler(ResizeBackgroundImage);

            // Call CenterButtons to center the buttons initially
            CenterButtons();
        }

        private void ResizeBackgroundImage(object sender, EventArgs e)
        {
            // Resize the background image to match the size of the form
            if (this.BackgroundImage != null)
            {
                this.BackgroundImage = new Bitmap(this.BackgroundImage, this.ClientSize.Width, this.ClientSize.Height);
                CenterButtons(); // Center the buttons when the form is resized
            }
        }

        private void CenterButtons()
        {
            // Calculate the new position for buttons
            int buttonWidth = 100; //  button width
            int buttonHeight = 30; // button height

            // Center SignIn button horizontally
            signIn.Left = (ClientSize.Width - signIn.Width) / 2;
            // Place SignUp button below SignIn button with a vertical margin of 20 pixels
            // signUp.Right = (ClientSize.Width - signUp.Width) / 2;
            // signUp.Top = signIn.Bottom + 20; // Adjust the margin as needed
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
                    }
                    else
                    {
                        MessageBox.Show("Error: Please check your login credentials.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
