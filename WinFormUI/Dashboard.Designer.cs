
namespace WinFormUI
{
    partial class Dashboard
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
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.MessageBoxDemoButton = new System.Windows.Forms.Button();
            this.TextBoxDemoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(246, 22);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(98, 25);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(246, 107);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(60, 25);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(245, 54);
            this.SubTotalTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(196, 31);
            this.SubTotalTextBox.TabIndex = 2;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(245, 138);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(196, 31);
            this.TotalTextBox.TabIndex = 3;
            // 
            // MessageBoxDemoButton
            // 
            this.MessageBoxDemoButton.Location = new System.Drawing.Point(16, 194);
            this.MessageBoxDemoButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MessageBoxDemoButton.Name = "MessageBoxDemoButton";
            this.MessageBoxDemoButton.Size = new System.Drawing.Size(196, 79);
            this.MessageBoxDemoButton.TabIndex = 4;
            this.MessageBoxDemoButton.Text = "MessageBox Demo";
            this.MessageBoxDemoButton.UseVisualStyleBackColor = true;
            this.MessageBoxDemoButton.Click += new System.EventHandler(this.MessageBoxDemoButton_Click);
            // 
            // TextBoxDemoButton
            // 
            this.TextBoxDemoButton.Location = new System.Drawing.Point(245, 194);
            this.TextBoxDemoButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TextBoxDemoButton.Name = "TextBoxDemoButton";
            this.TextBoxDemoButton.Size = new System.Drawing.Size(196, 79);
            this.TextBoxDemoButton.TabIndex = 5;
            this.TextBoxDemoButton.Text = "TextBox Demo";
            this.TextBoxDemoButton.UseVisualStyleBackColor = true;
            this.TextBoxDemoButton.Click += new System.EventHandler(this.TextBoxDemoButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 331);
            this.Controls.Add(this.TextBoxDemoButton);
            this.Controls.Add(this.MessageBoxDemoButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delegates Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button MessageBoxDemoButton;
        private System.Windows.Forms.Button TextBoxDemoButton;
    }
}

