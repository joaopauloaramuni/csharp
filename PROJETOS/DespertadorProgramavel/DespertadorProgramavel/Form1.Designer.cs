namespace DespertadorProgramavel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDesp = new System.Windows.Forms.Label();
            this.TbxHoraImput = new System.Windows.Forms.MaskedTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxMusica = new System.Windows.Forms.TextBox();
            this.AddMusic = new System.Windows.Forms.Button();
            this.labelAtual = new System.Windows.Forms.Label();
            this.timerAtual = new System.Windows.Forms.Timer(this.components);
            this.timerDesp = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesp
            // 
            this.labelDesp.AutoSize = true;
            this.labelDesp.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDesp.Location = new System.Drawing.Point(12, 132);
            this.labelDesp.Name = "labelDesp";
            this.labelDesp.Size = new System.Drawing.Size(118, 25);
            this.labelDesp.TabIndex = 0;
            this.labelDesp.Text = "00:00:00";
            // 
            // TbxHoraImput
            // 
            this.TbxHoraImput.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxHoraImput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbxHoraImput.Location = new System.Drawing.Point(12, 52);
            this.TbxHoraImput.Mask = "00:00:00";
            this.TbxHoraImput.Name = "TbxHoraImput";
            this.TbxHoraImput.Size = new System.Drawing.Size(143, 33);
            this.TbxHoraImput.TabIndex = 1;
            this.TbxHoraImput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(225, 52);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 52);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(225, 180);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(91, 44);
            this.Media.TabIndex = 3;
            this.Media.Visible = false;
            // 
            // textBoxMusica
            // 
            this.textBoxMusica.Location = new System.Drawing.Point(12, 17);
            this.textBoxMusica.Name = "textBoxMusica";
            this.textBoxMusica.Size = new System.Drawing.Size(190, 20);
            this.textBoxMusica.TabIndex = 4;
            // 
            // AddMusic
            // 
            this.AddMusic.Location = new System.Drawing.Point(225, 10);
            this.AddMusic.Name = "AddMusic";
            this.AddMusic.Size = new System.Drawing.Size(97, 33);
            this.AddMusic.TabIndex = 5;
            this.AddMusic.Text = "Adicionar Música";
            this.AddMusic.UseVisualStyleBackColor = true;
            this.AddMusic.Click += new System.EventHandler(this.AddMusic_Click);
            // 
            // labelAtual
            // 
            this.labelAtual.AutoSize = true;
            this.labelAtual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtual.ForeColor = System.Drawing.Color.LightGreen;
            this.labelAtual.Location = new System.Drawing.Point(12, 101);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(118, 25);
            this.labelAtual.TabIndex = 6;
            this.labelAtual.Text = "00:00:00";
            // 
            // timerAtual
            // 
            this.timerAtual.Enabled = true;
            this.timerAtual.Interval = 1000;
            this.timerAtual.Tick += new System.EventHandler(this.timerAtual_Tick);
            // 
            // timerDesp
            // 
            this.timerDesp.Tick += new System.EventHandler(this.timerDesp_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(225, 110);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(97, 52);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 169);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelAtual);
            this.Controls.Add(this.AddMusic);
            this.Controls.Add(this.textBoxMusica);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.TbxHoraImput);
            this.Controls.Add(this.labelDesp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesp;
        private System.Windows.Forms.MaskedTextBox TbxHoraImput;
        private System.Windows.Forms.Button buttonStart;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.TextBox textBoxMusica;
        private System.Windows.Forms.Button AddMusic;
        private System.Windows.Forms.Label labelAtual;
        private System.Windows.Forms.Timer timerAtual;
        private System.Windows.Forms.Timer timerDesp;
        private System.Windows.Forms.Button buttonStop;
    }
}

