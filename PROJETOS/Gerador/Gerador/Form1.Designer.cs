namespace Gerador
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
            this.Gerar = new System.Windows.Forms.Button();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPIS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Gerar
            // 
            this.Gerar.Location = new System.Drawing.Point(20, 219);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(190, 23);
            this.Gerar.TabIndex = 0;
            this.Gerar.Text = "Gerar";
            this.Gerar.UseVisualStyleBackColor = true;
            this.Gerar.Click += new System.EventHandler(this.Gerar_Click);
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(20, 45);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(190, 20);
            this.tbxCPF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF Válido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ Válido";
            // 
            // tbxCNPJ
            // 
            this.tbxCNPJ.Location = new System.Drawing.Point(20, 105);
            this.tbxCNPJ.Name = "tbxCNPJ";
            this.tbxCNPJ.Size = new System.Drawing.Size(190, 20);
            this.tbxCNPJ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PIS Válido";
            // 
            // tbxPIS
            // 
            this.tbxPIS.Location = new System.Drawing.Point(20, 165);
            this.tbxPIS.Name = "tbxPIS";
            this.tbxPIS.Size = new System.Drawing.Size(190, 20);
            this.tbxPIS.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.Gerar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPIS;
    }
}

