namespace Exercise4
{
    partial class MainForm
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
            listBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            updateButton = new Button();
            inputTextBox = new TextBox();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 31;
            listBox.Location = new Point(26, 28);
            listBox.Margin = new Padding(6, 8, 6, 8);
            listBox.Name = "listBox";
            listBox.Size = new Size(428, 438);
            listBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(483, 28);
            addButton.Margin = new Padding(6, 8, 6, 8);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 54);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(483, 98);
            removeButton.Margin = new Padding(6, 8, 6, 8);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(162, 54);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(483, 167);
            updateButton.Margin = new Padding(6, 8, 6, 8);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(162, 54);
            updateButton.TabIndex = 3;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(483, 236);
            inputTextBox.Margin = new Padding(6, 8, 6, 8);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(212, 38);
            inputTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 546);
            Controls.Add(inputTextBox);
            Controls.Add(updateButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(listBox);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 8, 6, 8);
            Name = "MainForm";
            Text = "ObservableList Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Button addButton;
        private Button removeButton;
        private Button updateButton;
        private TextBox inputTextBox;
    }
}