namespace HD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalResp = new System.Windows.Forms.Label();
            this.usadoResp = new System.Windows.Forms.Label();
            this.livreResp = new System.Windows.Forms.Label();
            this.serialResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalResp
            // 
            this.totalResp.AutoSize = true;
            this.totalResp.Location = new System.Drawing.Point(12, 18);
            this.totalResp.Name = "totalResp";
            this.totalResp.Size = new System.Drawing.Size(0, 13);
            this.totalResp.TabIndex = 3;
            // 
            // usadoResp
            // 
            this.usadoResp.AutoSize = true;
            this.usadoResp.Location = new System.Drawing.Point(12, 58);
            this.usadoResp.Name = "usadoResp";
            this.usadoResp.Size = new System.Drawing.Size(0, 13);
            this.usadoResp.TabIndex = 4;
            // 
            // livreResp
            // 
            this.livreResp.AutoSize = true;
            this.livreResp.Location = new System.Drawing.Point(12, 98);
            this.livreResp.Name = "livreResp";
            this.livreResp.Size = new System.Drawing.Size(0, 13);
            this.livreResp.TabIndex = 5;
            // 
            // serialResp
            // 
            this.serialResp.AutoSize = true;
            this.serialResp.Location = new System.Drawing.Point(12, 138);
            this.serialResp.Name = "serialResp";
            this.serialResp.Size = new System.Drawing.Size(0, 13);
            this.serialResp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 174);
            this.Controls.Add(this.serialResp);
            this.Controls.Add(this.livreResp);
            this.Controls.Add(this.usadoResp);
            this.Controls.Add(this.totalResp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalResp;
        private System.Windows.Forms.Label usadoResp;
        private System.Windows.Forms.Label livreResp;
        private System.Windows.Forms.Label serialResp;
    }
}

