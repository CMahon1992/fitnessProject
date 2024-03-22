namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.muscleLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.workoutLink = new System.Windows.Forms.LinkLabel();
            this.progressLink = new System.Windows.Forms.LinkLabel();
            this.routinesLink = new System.Windows.Forms.LinkLabel();
            this.routineDDB = new System.Windows.Forms.ComboBox();
            this.signOut = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workoutLink2 = new System.Windows.Forms.LinkLabel();
            this.progressLink2 = new System.Windows.Forms.LinkLabel();
            this.routinesLink2 = new System.Windows.Forms.LinkLabel();
            this.signOut2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(159, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Velocity Fitness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(260, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(225, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(369, 161);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(132, 23);
            this.emailText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(369, 223);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(132, 23);
            this.passwordText.TabIndex = 4;
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(326, 297);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 5;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(460, 297);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 23);
            this.signUp.TabIndex = 6;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.muscleLabel);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.workoutLink);
            this.panel1.Controls.Add(this.progressLink);
            this.panel1.Controls.Add(this.routinesLink);
            this.panel1.Controls.Add(this.routineDDB);
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 448);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // muscleLabel
            // 
            this.muscleLabel.AutoSize = true;
            this.muscleLabel.BackColor = System.Drawing.Color.Transparent;
            this.muscleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muscleLabel.Location = new System.Drawing.Point(275, 211);
            this.muscleLabel.Name = "muscleLabel";
            this.muscleLabel.Size = new System.Drawing.Size(279, 30);
            this.muscleLabel.TabIndex = 7;
            this.muscleLabel.Text = "Choose Your Muscle Group";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(158, 314);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 94);
            this.listBox1.TabIndex = 6;
            // 
            // workoutLink
            // 
            this.workoutLink.AutoSize = true;
            this.workoutLink.Location = new System.Drawing.Point(589, 150);
            this.workoutLink.Name = "workoutLink";
            this.workoutLink.Size = new System.Drawing.Size(79, 15);
            this.workoutLink.TabIndex = 5;
            this.workoutLink.TabStop = true;
            this.workoutLink.Text = "Workout Plan";
            // 
            // progressLink
            // 
            this.progressLink.AutoSize = true;
            this.progressLink.Location = new System.Drawing.Point(368, 150);
            this.progressLink.Name = "progressLink";
            this.progressLink.Size = new System.Drawing.Size(91, 15);
            this.progressLink.TabIndex = 4;
            this.progressLink.TabStop = true;
            this.progressLink.Text = "Fitness Progress";
            // 
            // routinesLink
            // 
            this.routinesLink.AutoSize = true;
            this.routinesLink.Location = new System.Drawing.Point(150, 150);
            this.routinesLink.Name = "routinesLink";
            this.routinesLink.Size = new System.Drawing.Size(94, 15);
            this.routinesLink.TabIndex = 3;
            this.routinesLink.TabStop = true;
            this.routinesLink.Text = "Browse Routines";
            // 
            // routineDDB
            // 
            this.routineDDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routineDDB.FormattingEnabled = true;
            this.routineDDB.Items.AddRange(new object[] {
            "Arms",
            "Chest",
            "Legs",
            "Core",
            "Full Body"});
            this.routineDDB.Location = new System.Drawing.Point(353, 252);
            this.routineDDB.Name = "routineDDB";
            this.routineDDB.Size = new System.Drawing.Size(121, 23);
            this.routineDDB.TabIndex = 1;
            // 
            // signOut
            // 
            this.signOut.AutoSize = true;
            this.signOut.BackColor = System.Drawing.Color.Transparent;
            this.signOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOut.Location = new System.Drawing.Point(683, 22);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(71, 21);
            this.signOut.TabIndex = 0;
            this.signOut.TabStop = true;
            this.signOut.Text = "Sign Out";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.workoutLink2);
            this.panel2.Controls.Add(this.progressLink2);
            this.panel2.Controls.Add(this.routinesLink2);
            this.panel2.Controls.Add(this.signOut2);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 448);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // workoutLink2
            // 
            this.workoutLink2.AutoSize = true;
            this.workoutLink2.Location = new System.Drawing.Point(589, 152);
            this.workoutLink2.Name = "workoutLink2";
            this.workoutLink2.Size = new System.Drawing.Size(79, 15);
            this.workoutLink2.TabIndex = 9;
            this.workoutLink2.TabStop = true;
            this.workoutLink2.Text = "Workout Plan";
            // 
            // progressLink2
            // 
            this.progressLink2.AutoSize = true;
            this.progressLink2.Location = new System.Drawing.Point(368, 152);
            this.progressLink2.Name = "progressLink2";
            this.progressLink2.Size = new System.Drawing.Size(91, 15);
            this.progressLink2.TabIndex = 8;
            this.progressLink2.TabStop = true;
            this.progressLink2.Text = "Fitness Progress";
            // 
            // routinesLink2
            // 
            this.routinesLink2.AutoSize = true;
            this.routinesLink2.Location = new System.Drawing.Point(150, 152);
            this.routinesLink2.Name = "routinesLink2";
            this.routinesLink2.Size = new System.Drawing.Size(94, 15);
            this.routinesLink2.TabIndex = 7;
            this.routinesLink2.TabStop = true;
            this.routinesLink2.Text = "Browse Routines";
            // 
            // signOut2
            // 
            this.signOut2.AutoSize = true;
            this.signOut2.BackColor = System.Drawing.Color.Transparent;
            this.signOut2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOut2.Location = new System.Drawing.Point(683, 24);
            this.signOut2.Name = "signOut2";
            this.signOut2.Size = new System.Drawing.Size(71, 21);
            this.signOut2.TabIndex = 6;
            this.signOut2.TabStop = true;
            this.signOut2.Text = "Sign Out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailText;
        private TextBox passwordText;
        private Button signIn;
        private Button signUp;
        private Panel panel1;
        private LinkLabel signOut;
        private LinkLabel workoutLink;
        private LinkLabel progressLink;
        private LinkLabel routinesLink;
        private ComboBox routineDDB;
        private Label muscleLabel;
        private ListBox listBox1;
        private Panel panel2;
        private LinkLabel workoutLink2;
        private LinkLabel progressLink2;
        private LinkLabel routinesLink2;
        private LinkLabel signOut2;
    }
}