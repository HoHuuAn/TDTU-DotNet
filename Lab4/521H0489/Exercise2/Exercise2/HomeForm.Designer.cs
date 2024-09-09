namespace Exercise2
{
    partial class HomeForm
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
            access = new Button();
            label1 = new Label();
            txtHome = new TextBox();
            SuspendLayout();
            // 
            // access
            // 
            access.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            access.Location = new Point(251, 124);
            access.Name = "access";
            access.Size = new Size(146, 40);
            access.TabIndex = 0;
            access.Text = "Access";
            access.UseVisualStyleBackColor = true;
            access.Click += access_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 76);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 1;
            label1.Text = "Click Access button to continue";
            // 
            // txtHome
            // 
            txtHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHome.Location = new Point(186, 214);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(275, 33);
            txtHome.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 335);
            Controls.Add(txtHome);
            Controls.Add(label1);
            Controls.Add(access);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button access;
        private Label label1;
        private TextBox txtHome;
    }
}