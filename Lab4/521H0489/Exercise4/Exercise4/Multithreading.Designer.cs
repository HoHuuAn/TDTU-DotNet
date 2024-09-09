namespace Exercise4
{
    partial class MainForm
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
            btnDownload = new Button();
            label1 = new Label();
            txtLink = new TextBox();
            process = new Label();
            listView = new ListBox();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(77, 181);
            btnDownload.Margin = new Padding(5);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(153, 45);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 1;
            label1.Text = "File Path";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(77, 95);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(921, 38);
            txtLink.TabIndex = 2;
            // 
            // process
            // 
            process.AutoSize = true;
            process.Location = new Point(77, 288);
            process.Name = "process";
            process.Size = new Size(225, 31);
            process.TabIndex = 3;
            process.Text = "download in process";
            // 
            // listView
            // 
            listView.FormattingEnabled = true;
            listView.ItemHeight = 31;
            listView.Location = new Point(77, 355);
            listView.Name = "listView";
            listView.Size = new Size(921, 190);
            listView.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 626);
            Controls.Add(listView);
            Controls.Add(process);
            Controls.Add(txtLink);
            Controls.Add(label1);
            Controls.Add(btnDownload);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Multithreading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private Label label1;
        private TextBox txtLink;
        private Label process;
        private ListBox listView;
    }
}