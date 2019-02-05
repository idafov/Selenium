namespace XrayJiraTool
{
    partial class Form1
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
            this.MyIssuesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyIssuesBtn
            // 
            this.MyIssuesBtn.Location = new System.Drawing.Point(0, 0);
            this.MyIssuesBtn.Name = "MyIssuesBtn";
            this.MyIssuesBtn.Size = new System.Drawing.Size(113, 23);
            this.MyIssuesBtn.TabIndex = 0;
            this.MyIssuesBtn.Text = "My Reported Issues";
            this.MyIssuesBtn.UseVisualStyleBackColor = true;
            this.MyIssuesBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyIssuesBtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MyIssuesBtn);
            this.Name = "Form1";
            this.Text = "Xray Personal Management Tool";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button MyIssuesBtn;
    }
}

