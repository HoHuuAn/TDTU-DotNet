namespace Exercise1
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
            login = new Button();
            reset = new Button();
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            remember = new CheckBox();
            SuspendLayout();
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(170, 222);
            login.Name = "login";
            login.Size = new Size(112, 43);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // reset
            // 
            reset.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            reset.Location = new Point(430, 222);
            reset.Name = "reset";
            reset.Size = new Size(114, 43);
            reset.TabIndex = 1;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 62);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 128);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(220, 59);
            username.Name = "username";
            username.Size = new Size(311, 33);
            username.TabIndex = 4;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(220, 125);
            password.Name = "password";
            password.Size = new Size(311, 33);
            password.TabIndex = 5;
            // 
            // remember
            // 
            remember.AutoSize = true;
            remember.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            remember.Location = new Point(220, 181);
            remember.Name = "remember";
            remember.Size = new Size(239, 21);
            remember.TabIndex = 6;
            remember.Text = "Remember username and password";
            remember.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 292);
            Controls.Add(remember);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reset);
            Controls.Add(login);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Button reset;
        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private CheckBox remember;
    }
}