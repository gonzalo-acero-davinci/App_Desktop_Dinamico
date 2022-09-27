namespace tp_desktop
{
    partial class Form3
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
            this.User = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ConfirmPass = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.Usertext = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.ConPassText = new System.Windows.Forms.TextBox();
            this.MailText = new System.Windows.Forms.TextBox();
            this.DNIText = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(34, 41);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(43, 13);
            this.User.TabIndex = 0;
            this.User.Text = "Usuario";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(34, 96);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Contraseña";
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.AutoSize = true;
            this.ConfirmPass.Location = new System.Drawing.Point(34, 144);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(108, 13);
            this.ConfirmPass.TabIndex = 2;
            this.ConfirmPass.Text = "Confirmar Contraseña";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(34, 192);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(26, 13);
            this.Mail.TabIndex = 3;
            this.Mail.Text = "Mail";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(34, 241);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 4;
            this.DNI.Text = "DNI";
            // 
            // Usertext
            // 
            this.Usertext.Location = new System.Drawing.Point(156, 34);
            this.Usertext.Name = "Usertext";
            this.Usertext.Size = new System.Drawing.Size(153, 20);
            this.Usertext.TabIndex = 5;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(156, 89);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(153, 20);
            this.PassText.TabIndex = 6;
            // 
            // ConPassText
            // 
            this.ConPassText.Location = new System.Drawing.Point(156, 137);
            this.ConPassText.Name = "ConPassText";
            this.ConPassText.Size = new System.Drawing.Size(153, 20);
            this.ConPassText.TabIndex = 7;
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(156, 185);
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(153, 20);
            this.MailText.TabIndex = 8;
            // 
            // DNIText
            // 
            this.DNIText.Location = new System.Drawing.Point(156, 234);
            this.DNIText.Name = "DNIText";
            this.DNIText.Size = new System.Drawing.Size(153, 20);
            this.DNIText.TabIndex = 9;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(136, 288);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 10;
            this.Register.Text = "Registrarse";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(136, 317);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 11;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 394);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.DNIText);
            this.Controls.Add(this.MailText);
            this.Controls.Add(this.ConPassText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.Usertext);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ConfirmPass;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.TextBox Usertext;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox ConPassText;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.TextBox DNIText;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Volver;
    }
}