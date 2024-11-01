namespace MU
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
            this.serial = new System.Windows.Forms.TextBox();
            this.conteudo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arquivo = new System.Windows.Forms.TextBox();
            this.cript = new System.Windows.Forms.Button();
            this.descript = new System.Windows.Forms.Button();
            this.erro1 = new System.Windows.Forms.Label();
            this.erro2 = new System.Windows.Forms.Label();
            this.atencao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.Location = new System.Drawing.Point(154, 89);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(105, 20);
            this.serial.TabIndex = 4;
            this.serial.UseSystemPasswordChar = true;
            // 
            // conteudo
            // 
            this.conteudo.BackColor = System.Drawing.SystemColors.Window;
            this.conteudo.Location = new System.Drawing.Point(27, 197);
            this.conteudo.Name = "conteudo";
            this.conteudo.Size = new System.Drawing.Size(232, 141);
            this.conteudo.TabIndex = 9;
            this.conteudo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chave de Segurança";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conteúdo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome do Arquivo";
            // 
            // arquivo
            // 
            this.arquivo.Location = new System.Drawing.Point(154, 44);
            this.arquivo.Name = "arquivo";
            this.arquivo.Size = new System.Drawing.Size(105, 20);
            this.arquivo.TabIndex = 0;
            // 
            // cript
            // 
            this.cript.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cript.Location = new System.Drawing.Point(27, 131);
            this.cript.Name = "cript";
            this.cript.Size = new System.Drawing.Size(105, 23);
            this.cript.TabIndex = 6;
            this.cript.Text = "Criptografar";
            this.cript.UseVisualStyleBackColor = true;
            this.cript.Click += new System.EventHandler(this.cript_Click_1);
            // 
            // descript
            // 
            this.descript.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript.Location = new System.Drawing.Point(154, 131);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(105, 23);
            this.descript.TabIndex = 7;
            this.descript.Text = "Descriptografar";
            this.descript.UseVisualStyleBackColor = true;
            this.descript.Click += new System.EventHandler(this.descript_Click_1);
            // 
            // erro1
            // 
            this.erro1.AutoSize = true;
            this.erro1.BackColor = System.Drawing.Color.Transparent;
            this.erro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erro1.Location = new System.Drawing.Point(152, 67);
            this.erro1.Name = "erro1";
            this.erro1.Size = new System.Drawing.Size(0, 12);
            this.erro1.TabIndex = 2;
            // 
            // erro2
            // 
            this.erro2.AutoSize = true;
            this.erro2.BackColor = System.Drawing.Color.Transparent;
            this.erro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erro2.Location = new System.Drawing.Point(154, 116);
            this.erro2.Name = "erro2";
            this.erro2.Size = new System.Drawing.Size(0, 12);
            this.erro2.TabIndex = 5;
            // 
            // atencao
            // 
            this.atencao.AutoSize = true;
            this.atencao.BackColor = System.Drawing.Color.Transparent;
            this.atencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atencao.Location = new System.Drawing.Point(27, 345);
            this.atencao.Name = "atencao";
            this.atencao.Size = new System.Drawing.Size(0, 12);
            this.atencao.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1HelpToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // f1HelpToolStripMenuItem
            // 
            this.f1HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.f1HelpToolStripMenuItem.Name = "f1HelpToolStripMenuItem";
            this.f1HelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.f1HelpToolStripMenuItem.Text = "F1 Help";
            this.f1HelpToolStripMenuItem.Click += new System.EventHandler(this.f1HelpToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptSecurityToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // encryptSecurityToolStripMenuItem
            // 
            this.encryptSecurityToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.encryptSecurityToolStripMenuItem.Name = "encryptSecurityToolStripMenuItem";
            this.encryptSecurityToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.encryptSecurityToolStripMenuItem.Text = "EncryptSecurity";
            this.encryptSecurityToolStripMenuItem.Click += new System.EventHandler(this.encryptSecurityToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.Controls.Add(this.atencao);
            this.Controls.Add(this.erro2);
            this.Controls.Add(this.erro1);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.cript);
            this.Controls.Add(this.arquivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conteudo);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptSecurity";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serial;
        private System.Windows.Forms.RichTextBox conteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arquivo;
        private System.Windows.Forms.Button cript;
        private System.Windows.Forms.Button descript;
        private System.Windows.Forms.Label erro1;
        private System.Windows.Forms.Label erro2;
        private System.Windows.Forms.Label atencao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptSecurityToolStripMenuItem;
    }
}

