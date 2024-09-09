namespace Exercise3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblDirectoryPath;
        private TextBox txtDirectoryPath;
        private Button btnBrowse;
        private ProgressBar progressBar;
        private Button btnDownload;

        private void InitializeComponent()
        {
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblDirectoryPath = new Label();
            txtDirectoryPath = new TextBox();
            btnBrowse = new Button();
            progressBar = new ProgressBar();
            btnDownload = new Button();
            SuspendLayout();
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(12, 15);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(60, 31);
            lblUrl.TabIndex = 0;
            lblUrl.Text = "URL:";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(197, 15);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(273, 38);
            txtUrl.TabIndex = 1;
            // 
            // lblDirectoryPath
            // 
            lblDirectoryPath.AutoSize = true;
            lblDirectoryPath.Location = new Point(12, 86);
            lblDirectoryPath.Name = "lblDirectoryPath";
            lblDirectoryPath.Size = new Size(163, 31);
            lblDirectoryPath.TabIndex = 2;
            lblDirectoryPath.Text = "Directory Path:";
            // 
            // txtDirectoryPath
            // 
            txtDirectoryPath.Location = new Point(197, 79);
            txtDirectoryPath.Name = "txtDirectoryPath";
            txtDirectoryPath.ReadOnly = true;
            txtDirectoryPath.Size = new Size(273, 38);
            txtDirectoryPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(504, 79);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(158, 38);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 148);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(458, 38);
            progressBar.TabIndex = 7;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(504, 148);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(158, 38);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(683, 212);
            Controls.Add(lblUrl);
            Controls.Add(txtUrl);
            Controls.Add(lblDirectoryPath);
            Controls.Add(txtDirectoryPath);
            Controls.Add(btnBrowse);
            Controls.Add(progressBar);
            Controls.Add(btnDownload);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "File Downloader";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}