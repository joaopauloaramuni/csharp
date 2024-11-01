namespace Email
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
            this.remetente = new System.Windows.Forms.TextBox();
            this.destinatario = new System.Windows.Forms.TextBox();
            this.assunto = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labdel5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.ladbel4 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // remetente
            // 
            this.remetente.Location = new System.Drawing.Point(106, 99);
            this.remetente.Name = "remetente";
            this.remetente.Size = new System.Drawing.Size(180, 20);
            this.remetente.TabIndex = 8;
            // 
            // destinatario
            // 
            this.destinatario.Location = new System.Drawing.Point(106, 167);
            this.destinatario.Name = "destinatario";
            this.destinatario.Size = new System.Drawing.Size(180, 20);
            this.destinatario.TabIndex = 10;
            // 
            // assunto
            // 
            this.assunto.Location = new System.Drawing.Point(72, 223);
            this.assunto.Name = "assunto";
            this.assunto.Size = new System.Drawing.Size(91, 20);
            this.assunto.TabIndex = 11;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(72, 267);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(214, 130);
            this.body.TabIndex = 12;
            this.body.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Remetente";
            // 
            // labdel5
            // 
            this.labdel5.AutoSize = true;
            this.labdel5.Location = new System.Drawing.Point(13, 170);
            this.labdel5.Name = "labdel5";
            this.labdel5.Size = new System.Drawing.Size(91, 13);
            this.labdel5.TabIndex = 5;
            this.labdel5.Text = "Email Destinatário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Assunto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Conteúdo";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(72, 413);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(214, 23);
            this.enviar.TabIndex = 13;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP IP";
            // 
            // ip
            // 
            this.ip.ForeColor = System.Drawing.Color.Gray;
            this.ip.Location = new System.Drawing.Point(106, 22);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(86, 20);
            this.ip.TabIndex = 14;
            this.ip.Text = "Ex: 172.16.1.1";
            this.ip.Enter += new System.EventHandler(this.limpa_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SMTP Host";
            // 
            // email
            // 
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.Location = new System.Drawing.Point(106, 52);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(180, 20);
            this.email.TabIndex = 15;
            this.email.Text = "Ex: mail.exemplo.com.br";
            this.email.Enter += new System.EventHandler(this.limpa2_Enter);
            // 
            // ladbel4
            // 
            this.ladbel4.AutoSize = true;
            this.ladbel4.Location = new System.Drawing.Point(13, 132);
            this.ladbel4.Name = "ladbel4";
            this.ladbel4.Size = new System.Drawing.Size(38, 13);
            this.ladbel4.TabIndex = 4;
            this.ladbel4.Text = "Senha";
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(106, 129);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 9;
            this.senha.UseSystemPasswordChar = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(314, 457);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 15;
            this.lineShape2.X2 = 292;
            this.lineShape2.Y1 = 83;
            this.lineShape2.Y2 = 83;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 292;
            this.lineShape1.Y1 = 204;
            this.lineShape1.Y2 = 204;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 457);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.ladbel4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labdel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.body);
            this.Controls.Add(this.assunto);
            this.Controls.Add(this.destinatario);
            this.Controls.Add(this.remetente);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enviar Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remetente;
        private System.Windows.Forms.TextBox destinatario;
        private System.Windows.Forms.TextBox assunto;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labdel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label ladbel4;
        private System.Windows.Forms.TextBox senha;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}

