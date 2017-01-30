namespace Portal
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
            this.BrndLblBox = new System.Windows.Forms.Label();
            this.BrndLocTxtBox = new System.Windows.Forms.TextBox();
            this.BrndBrowBtn = new System.Windows.Forms.Button();
            this.CompBrowBtn = new System.Windows.Forms.Button();
            this.CmpLocTxtBox = new System.Windows.Forms.TextBox();
            this.CompLblBox = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.RevertBtn = new System.Windows.Forms.Button();
            this.clseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrndLblBox
            // 
            this.BrndLblBox.AutoSize = true;
            this.BrndLblBox.Location = new System.Drawing.Point(109, 9);
            this.BrndLblBox.Name = "BrndLblBox";
            this.BrndLblBox.Size = new System.Drawing.Size(62, 13);
            this.BrndLblBox.TabIndex = 0;
            this.BrndLblBox.Text = "Brand Logo";
            this.BrndLblBox.Click += new System.EventHandler(this.LblBox_Click);
            // 
            // BrndLocTxtBox
            // 
            this.BrndLocTxtBox.Location = new System.Drawing.Point(28, 38);
            this.BrndLocTxtBox.Name = "BrndLocTxtBox";
            this.BrndLocTxtBox.Size = new System.Drawing.Size(143, 20);
            this.BrndLocTxtBox.TabIndex = 1;
            // 
            // BrndBrowBtn
            // 
            this.BrndBrowBtn.Location = new System.Drawing.Point(188, 36);
            this.BrndBrowBtn.Name = "BrndBrowBtn";
            this.BrndBrowBtn.Size = new System.Drawing.Size(75, 23);
            this.BrndBrowBtn.TabIndex = 2;
            this.BrndBrowBtn.Text = "Browse";
            this.BrndBrowBtn.UseVisualStyleBackColor = true;
            this.BrndBrowBtn.Click += new System.EventHandler(this.BrndBrowBtn_Click);
            // 
            // CompBrowBtn
            // 
            this.CompBrowBtn.Location = new System.Drawing.Point(188, 101);
            this.CompBrowBtn.Name = "CompBrowBtn";
            this.CompBrowBtn.Size = new System.Drawing.Size(75, 23);
            this.CompBrowBtn.TabIndex = 5;
            this.CompBrowBtn.Text = "Browse";
            this.CompBrowBtn.UseVisualStyleBackColor = true;
            this.CompBrowBtn.Click += new System.EventHandler(this.CompBrowBtn_Click);
            // 
            // CmpLocTxtBox
            // 
            this.CmpLocTxtBox.Location = new System.Drawing.Point(28, 103);
            this.CmpLocTxtBox.Name = "CmpLocTxtBox";
            this.CmpLocTxtBox.Size = new System.Drawing.Size(143, 20);
            this.CmpLocTxtBox.TabIndex = 4;
            // 
            // CompLblBox
            // 
            this.CompLblBox.AutoSize = true;
            this.CompLblBox.Location = new System.Drawing.Point(109, 74);
            this.CompLblBox.Name = "CompLblBox";
            this.CompLblBox.Size = new System.Drawing.Size(78, 13);
            this.CompLblBox.TabIndex = 3;
            this.CompLblBox.Text = "Company Logo";
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(12, 160);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(121, 23);
            this.CopyBtn.TabIndex = 6;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // RevertBtn
            // 
            this.RevertBtn.Location = new System.Drawing.Point(151, 160);
            this.RevertBtn.Name = "RevertBtn";
            this.RevertBtn.Size = new System.Drawing.Size(121, 23);
            this.RevertBtn.TabIndex = 7;
            this.RevertBtn.Text = "Revert";
            this.RevertBtn.UseVisualStyleBackColor = true;
            this.RevertBtn.Click += new System.EventHandler(this.RevertBtn_Click);
            // 
            // clseBtn
            // 
            this.clseBtn.Location = new System.Drawing.Point(97, 209);
            this.clseBtn.Name = "clseBtn";
            this.clseBtn.Size = new System.Drawing.Size(75, 23);
            this.clseBtn.TabIndex = 8;
            this.clseBtn.Text = "Close";
            this.clseBtn.UseVisualStyleBackColor = true;
            this.clseBtn.Click += new System.EventHandler(this.clseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clseBtn);
            this.Controls.Add(this.RevertBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.CompBrowBtn);
            this.Controls.Add(this.CmpLocTxtBox);
            this.Controls.Add(this.CompLblBox);
            this.Controls.Add(this.BrndBrowBtn);
            this.Controls.Add(this.BrndLocTxtBox);
            this.Controls.Add(this.BrndLblBox);
            this.Name = "Form1";
            this.Text = "Portal Imagine Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrndLblBox;
        private System.Windows.Forms.TextBox BrndLocTxtBox;
        private System.Windows.Forms.Button BrndBrowBtn;
        private System.Windows.Forms.Button CompBrowBtn;
        private System.Windows.Forms.TextBox CmpLocTxtBox;
        private System.Windows.Forms.Label CompLblBox;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button RevertBtn;
        private System.Windows.Forms.Button clseBtn;
    }
}

