namespace Leitor_de_Mapa
{
    partial class telaloading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaloading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcarregando = new System.Windows.Forms.Label();
            this.lblcreate = new System.Windows.Forms.Label();
            this.btnNovaTabela = new System.Windows.Forms.Button();
            this.btnMinhaTabela = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(55)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 18);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblcarregando
            // 
            this.lblcarregando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcarregando.AutoSize = true;
            this.lblcarregando.Font = new System.Drawing.Font("Dr.Marz", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcarregando.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblcarregando.Location = new System.Drawing.Point(215, 289);
            this.lblcarregando.Name = "lblcarregando";
            this.lblcarregando.Size = new System.Drawing.Size(159, 27);
            this.lblcarregando.TabIndex = 2;
            this.lblcarregando.Text = "Carregando...";
            // 
            // lblcreate
            // 
            this.lblcreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcreate.AutoSize = true;
            this.lblcreate.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblcreate.Location = new System.Drawing.Point(0, 429);
            this.lblcreate.Name = "lblcreate";
            this.lblcreate.Size = new System.Drawing.Size(152, 16);
            this.lblcreate.TabIndex = 3;
            this.lblcreate.Text = "Criado por Mahatmã Titton";
            // 
            // btnNovaTabela
            // 
            this.btnNovaTabela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovaTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovaTabela.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovaTabela.Location = new System.Drawing.Point(294, 341);
            this.btnNovaTabela.Name = "btnNovaTabela";
            this.btnNovaTabela.Size = new System.Drawing.Size(93, 64);
            this.btnNovaTabela.TabIndex = 4;
            this.btnNovaTabela.Text = "Nova Tabela";
            this.btnNovaTabela.UseVisualStyleBackColor = false;
            this.btnNovaTabela.Visible = false;
            this.btnNovaTabela.Click += new System.EventHandler(this.btnNovaTabela_Click);
            // 
            // btnMinhaTabela
            // 
            this.btnMinhaTabela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMinhaTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMinhaTabela.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinhaTabela.Location = new System.Drawing.Point(166, 341);
            this.btnMinhaTabela.Name = "btnMinhaTabela";
            this.btnMinhaTabela.Size = new System.Drawing.Size(95, 64);
            this.btnMinhaTabela.TabIndex = 5;
            this.btnMinhaTabela.Text = "Minha Tabela";
            this.btnMinhaTabela.UseVisualStyleBackColor = false;
            this.btnMinhaTabela.Visible = false;
            this.btnMinhaTabela.Click += new System.EventHandler(this.btnMinhaTabela_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Leitor_de_Mapa.Properties.Resources.MINDFUNGA_PNG;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(528, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(27, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "X";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSair_MouseClick);
            // 
            // telaloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(554, 476);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMinhaTabela);
            this.Controls.Add(this.btnNovaTabela);
            this.Controls.Add(this.lblcreate);
            this.Controls.Add(this.lblcarregando);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaloading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaloading";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblcarregando;
        private Label lblcreate;
        private Button btnNovaTabela;
        private Button btnMinhaTabela;
        private PictureBox pictureBox2;
        private Label btnSair;
    }
}