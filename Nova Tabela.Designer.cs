namespace Leitor_de_Mapa
{
    partial class Nova_Tabela
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNovaTabela = new System.Windows.Forms.Button();
            this.txtNovaTabela = new System.Windows.Forms.TextBox();
            this.lblNameNewTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(164, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNovaTabela
            // 
            this.btnNovaTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTabela.Location = new System.Drawing.Point(282, 182);
            this.btnNovaTabela.Name = "btnNovaTabela";
            this.btnNovaTabela.Size = new System.Drawing.Size(86, 32);
            this.btnNovaTabela.TabIndex = 0;
            this.btnNovaTabela.Text = "Criar";
            this.btnNovaTabela.UseVisualStyleBackColor = false;
            this.btnNovaTabela.Click += new System.EventHandler(this.btnNovaTabela_Click);
            // 
            // txtNovaTabela
            // 
            this.txtNovaTabela.Location = new System.Drawing.Point(164, 128);
            this.txtNovaTabela.Name = "txtNovaTabela";
            this.txtNovaTabela.Size = new System.Drawing.Size(204, 23);
            this.txtNovaTabela.TabIndex = 2;
            this.txtNovaTabela.TextChanged += new System.EventHandler(this.txtNovaTabela_TextChanged);
            // 
            // lblNameNewTable
            // 
            this.lblNameNewTable.AutoSize = true;
            this.lblNameNewTable.Font = new System.Drawing.Font("Dr.Marz", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameNewTable.Location = new System.Drawing.Point(164, 60);
            this.lblNameNewTable.Name = "lblNameNewTable";
            this.lblNameNewTable.Size = new System.Drawing.Size(204, 27);
            this.lblNameNewTable.TabIndex = 3;
            this.lblNameNewTable.Text = "Nome da Tabela:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNovaTabela);
            this.panel1.Controls.Add(this.txtNovaTabela);
            this.panel1.Controls.Add(this.lblNameNewTable);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-11, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 287);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Leitor_de_Mapa.Properties.Resources.RPPN_Portal_das_Nascentes;
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Nova_Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 252);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nova_Tabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Tabela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nova_Tabela_FormClosing);
            this.Load += new System.EventHandler(this.Nova_Tabela_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private Button btnNovaTabela;
        private TextBox txtNovaTabela;
        private Label lblNameNewTable;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}