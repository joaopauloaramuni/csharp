namespace MountyHall
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
            this.btnPort1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPort1
            // 
            this.btnPort1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPort1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPort1.Location = new System.Drawing.Point(56, 49);
            this.btnPort1.Name = "btnPort1";
            this.btnPort1.Size = new System.Drawing.Size(101, 196);
            this.btnPort1.TabIndex = 0;
            this.btnPort1.Text = "1";
            this.btnPort1.UseVisualStyleBackColor = true;
            this.btnPort1.Click += new System.EventHandler(this.btnPort1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(163, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 196);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPort2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(270, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 196);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPort3_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(53, 19);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 18);
            this.lbl_Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPort1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monty Hall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_Result;
    }
}

