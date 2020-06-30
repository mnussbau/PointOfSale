namespace OOPFinalProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userLbl = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.InvalidLbl = new System.Windows.Forms.Label();
            this.validLbl = new System.Windows.Forms.Label();
            this.createAccounctBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.White;
            this.userLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userLbl.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Image = ((System.Drawing.Image)(resources.GetObject("userLbl.Image")));
            this.userLbl.Location = new System.Drawing.Point(183, 178);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(105, 26);
            this.userLbl.TabIndex = 0;
            this.userLbl.Text = "Username:";
            // 
            // userText
            // 
       
            //this.userText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.userText.HideSelection = false;
            this.userText.Location = new System.Drawing.Point(358, 184);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 1;
            this.userText.UseWaitCursor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.White;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswordLabel.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Image = ((System.Drawing.Image)(resources.GetObject("PasswordLabel.Image")));
            this.PasswordLabel.Location = new System.Drawing.Point(183, 217);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 26);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // passwordText
            // 
            this.passwordText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.passwordText.HideSelection = false;
            this.passwordText.Location = new System.Drawing.Point(358, 222);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 4;
            this.passwordText.UseWaitCursor = true;
            // 
            // validateButton
            // 
            this.validateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.validateButton.FlatAppearance.BorderSize = 2;
            this.validateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.validateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(311, 321);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(91, 47);
            this.validateButton.TabIndex = 5;
            this.validateButton.Text = "Done";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.IndianRed;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(12, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 47);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InvalidLbl
            // 
            this.InvalidLbl.AutoSize = true;
            this.InvalidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidLbl.Location = new System.Drawing.Point(139, 264);
            this.InvalidLbl.Name = "InvalidLbl";
            this.InvalidLbl.Size = new System.Drawing.Size(0, 18);
            this.InvalidLbl.TabIndex = 7;
            this.InvalidLbl.Visible = false;
            // 
            // validLbl
            // 
            this.validLbl.AutoSize = true;
            this.validLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validLbl.ForeColor = System.Drawing.Color.Lime;
            this.validLbl.Location = new System.Drawing.Point(191, 269);
            this.validLbl.Name = "validLbl";
            this.validLbl.Size = new System.Drawing.Size(0, 18);
            this.validLbl.TabIndex = 8;
            this.validLbl.Visible = false;
            // 
            // createAccounctBtn
            // 
            this.createAccounctBtn.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccounctBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createAccounctBtn.Location = new System.Drawing.Point(268, 269);
            this.createAccounctBtn.Name = "createAccounctBtn";
            this.createAccounctBtn.Size = new System.Drawing.Size(159, 23);
            this.createAccounctBtn.TabIndex = 9;
            this.createAccounctBtn.Text = "Create an account";
            this.createAccounctBtn.UseVisualStyleBackColor = true;
            this.createAccounctBtn.Click += new System.EventHandler(this.createAccounctBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccounctBtn);
            this.Controls.Add(this.validLbl);
            this.Controls.Add(this.InvalidLbl);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.userLbl);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox userText;
        protected internal System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label InvalidLbl;
        private System.Windows.Forms.Label validLbl;
        private System.Windows.Forms.Button createAccounctBtn;
    }
}