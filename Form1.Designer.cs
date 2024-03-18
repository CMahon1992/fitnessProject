namespace homeFitnessSite
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signOut = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Velocity Fitness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(477, 180);
            this.emailText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(166, 27);
            this.emailText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(477, 239);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(166, 27);
            this.passwordText.TabIndex = 2;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email.Location = new System.Drawing.Point(369, 173);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(94, 32);
            this.email.TabIndex = 3;
            this.email.Text = "E-Mail:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(336, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 32);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(399, 349);
            this.signIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(86, 31);
            this.signIn.TabIndex = 5;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(594, 349);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(86, 31);
            this.signUp.TabIndex = 6;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 600);
            this.panel1.TabIndex = 7;
            // 
            // signOut
            // 
            this.signOut.AutoSize = true;
            this.signOut.BackColor = System.Drawing.Color.Transparent;
            this.signOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signOut.Location = new System.Drawing.Point(799, 9);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(94, 28);
            this.signOut.TabIndex = 0;
            this.signOut.TabStop = true;
            this.signOut.Text = "Sign Out";
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginPage";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox emailText;
        private TextBox passwordText;
        private Label email;
        private Label passwordLabel;
        private Button signIn;
        private Button signUp;
        private Panel panel1;
        private LinkLabel signOut;
    }
}