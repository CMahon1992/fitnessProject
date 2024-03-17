namespace homeFitnessSite
{
    public partial class loginPage : Form

    {

        public loginPage()
        {
            InitializeComponent();
            // Set the background image and adjust its layout
            SetBackgroundImage();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CenterLabel()
        //this will ensure the label "Velocity Fitness stays at the top and centered no matter how large or small the form becomes"

        {
            if (label1 != null)
            {
                label1.Left = (ClientSize.Width - label1.Width) / 2;
                label1.Top = 0; // keeps label at the top
            }
        }
        private void SetBackgroundImage()
        {
            // Load the background image from file
            Image backgroundImage = Image.FromFile(@"C:\Users\CMaho\source\repos\fitnessProject\images\homePageImage.jpg");

            // Set the background image and adjust its layout
            this.BackgroundImageLayout = ImageLayout.Zoom; // Adjust as per your requirement
            this.BackgroundImage = backgroundImage;

            // Call ResizeBackgroundImage to adjust the background image when the form is resized
            this.Resize += new EventHandler(ResizeBackgroundImage);
        }

        private void ResizeBackgroundImage(object sender, EventArgs e)
        {
            // Resize the background image to match the size of the form
            if (this.BackgroundImage != null)
            {
                this.BackgroundImage = new Bitmap(this.BackgroundImage, this.ClientSize.Width, this.ClientSize.Height);
                CenterLabel(); // Center the label when the form is resized
                CenterButtons();
        
            }
        }

        private void CenterButtons()
        {
            // Calculate the new position for buttons
            int buttonWidth = 100; // Adjust according to your button width
            int buttonHeight = 30; // Adjust according to your button height

            // Center SignIn button horizontally
            signIn.Left = (ClientSize.Width - signIn.Width) / 2;
            // Place SignUp button below SignIn button with a vertical margin of 20 pixels
           // signUp.Right = (ClientSize.Width - signUp.Width) / 2;
            //signUp.Top = signIn.Bottom + 20; // Adjust the margin as needed
  
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}