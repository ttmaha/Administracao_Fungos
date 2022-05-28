namespace Leitor_de_Mapa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtEnquadrar = new System.Windows.Forms.Button();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.btnPoligon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FileName_LBL = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lstFungos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_satelite = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_relevo = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTabelaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpontoadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblocorrencia = new System.Windows.Forms.Label();
            this.txtOcorrencia = new System.Windows.Forms.TextBox();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtcomboBoxStatusCon = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLat
            // 
            this.labelLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLat.AutoSize = true;
            this.labelLat.BackColor = System.Drawing.Color.Transparent;
            this.labelLat.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLat.Location = new System.Drawing.Point(13, 103);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(88, 13);
            this.labelLat.TabIndex = 2;
            this.labelLat.Text = "Latitude:";
            this.labelLat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(13, 119);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(227, 23);
            this.txtLat.TabIndex = 3;
            this.txtLat.TextChanged += new System.EventHandler(this.txtLat_TextChanged);
            this.txtLat.Enter += new System.EventHandler(this.txtLat_Enter);
            this.txtLat.Leave += new System.EventHandler(this.txtLat_Leave);
            // 
            // labelLong
            // 
            this.labelLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLong.AutoSize = true;
            this.labelLong.BackColor = System.Drawing.Color.Transparent;
            this.labelLong.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLong.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLong.Location = new System.Drawing.Point(13, 153);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(97, 13);
            this.labelLong.TabIndex = 4;
            this.labelLong.Text = "Longitude:";
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(13, 169);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(227, 23);
            this.txtLong.TabIndex = 5;
            this.txtLong.Enter += new System.EventHandler(this.txtLong_Enter);
            this.txtLong.Leave += new System.EventHandler(this.txtLong_Leave);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(1309, 677);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtEnquadrar
            // 
            this.txtEnquadrar.Location = new System.Drawing.Point(567, 673);
            this.txtEnquadrar.Name = "txtEnquadrar";
            this.txtEnquadrar.Size = new System.Drawing.Size(75, 23);
            this.txtEnquadrar.TabIndex = 12;
            this.txtEnquadrar.Text = "Enquadrar";
            this.txtEnquadrar.UseVisualStyleBackColor = true;
            this.txtEnquadrar.Click += new System.EventHandler(this.txtEnquadrar_Click);
            // 
            // labelDescricao
            // 
            this.labelDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.BackColor = System.Drawing.Color.Transparent;
            this.labelDescricao.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescricao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDescricao.Location = new System.Drawing.Point(13, 3);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(97, 13);
            this.labelDescricao.TabIndex = 14;
            this.labelDescricao.Text = "Descrição:";
            // 
            // labelGenero
            // 
            this.labelGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.Transparent;
            this.labelGenero.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGenero.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelGenero.Location = new System.Drawing.Point(13, 202);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(70, 13);
            this.labelGenero.TabIndex = 16;
            this.labelGenero.Text = "Gênero:";
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGenero.Location = new System.Drawing.Point(13, 218);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(227, 23);
            this.txtGenero.TabIndex = 17;
            this.txtGenero.Enter += new System.EventHandler(this.txtGenero_Enter);
            this.txtGenero.Leave += new System.EventHandler(this.txtGenero_Leave);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEspecie.Location = new System.Drawing.Point(13, 265);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(227, 23);
            this.txtEspecie.TabIndex = 18;
            this.txtEspecie.Enter += new System.EventHandler(this.txtEspecie_Enter);
            this.txtEspecie.Leave += new System.EventHandler(this.txtEspecie_Leave);
            // 
            // labelEspecie
            // 
            this.labelEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.BackColor = System.Drawing.Color.Transparent;
            this.labelEspecie.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEspecie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEspecie.Location = new System.Drawing.Point(13, 249);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(79, 13);
            this.labelEspecie.TabIndex = 19;
            this.labelEspecie.Text = "Espécie:";
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelData.Location = new System.Drawing.Point(10, 296);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(142, 13);
            this.labelData.TabIndex = 21;
            this.labelData.Text = "Data da amostra";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(1309, 610);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 31);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1228, 677);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 23;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(13, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(227, 23);
            this.txtDescricao.TabIndex = 26;
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.CustomFormat = "yyyy-MM-dd";
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(13, 312);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(227, 23);
            this.txtData.TabIndex = 25;
            this.txtData.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            // 
            // btnPoligon
            // 
            this.btnPoligon.Location = new System.Drawing.Point(394, 640);
            this.btnPoligon.Name = "btnPoligon";
            this.btnPoligon.Size = new System.Drawing.Size(104, 23);
            this.btnPoligon.TabIndex = 27;
            this.btnPoligon.Text = "Criar Polígono";
            this.btnPoligon.UseVisualStyleBackColor = true;
            this.btnPoligon.Click += new System.EventHandler(this.btnPoligon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1116, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileName_LBL
            // 
            this.FileName_LBL.AutoSize = true;
            this.FileName_LBL.Location = new System.Drawing.Point(642, 677);
            this.FileName_LBL.Name = "FileName_LBL";
            this.FileName_LBL.Size = new System.Drawing.Size(0, 15);
            this.FileName_LBL.TabIndex = 30;
            this.FileName_LBL.Click += new System.EventHandler(this.FileName_LBL_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(1134, 677);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(88, 23);
            this.btnImportar.TabIndex = 31;
            this.btnImportar.Text = "Atualizar Lista";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Adicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Adicionar.Location = new System.Drawing.Point(1147, 610);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 31);
            this.btn_Adicionar.TabIndex = 33;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lstFungos
            // 
            this.lstFungos.ContextMenuStrip = this.contextMenuStrip1;
            this.lstFungos.Location = new System.Drawing.Point(1137, 399);
            this.lstFungos.MultiSelect = false;
            this.lstFungos.Name = "lstFungos";
            this.lstFungos.Size = new System.Drawing.Size(291, 208);
            this.lstFungos.TabIndex = 34;
            this.lstFungos.UseCompatibleStateImageBehavior = false;
            this.lstFungos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFungos_ItemSelectionChanged);
            this.lstFungos.SelectedIndexChanged += new System.EventHandler(this.lstFungos_SelectedIndexChanged);
            this.lstFungos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFungos_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "Excluir Dados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1198, 645);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(186, 23);
            this.txtBuscar.TabIndex = 35;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(1374, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 15);
            this.lbl_id.TabIndex = 36;
            // 
            // btn_satelite
            // 
            this.btn_satelite.Location = new System.Drawing.Point(24, 645);
            this.btn_satelite.Name = "btn_satelite";
            this.btn_satelite.Size = new System.Drawing.Size(61, 23);
            this.btn_satelite.TabIndex = 37;
            this.btn_satelite.Text = "Satélite";
            this.btn_satelite.UseVisualStyleBackColor = true;
            this.btn_satelite.Click += new System.EventHandler(this.btn_satelite_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(24, 673);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(61, 23);
            this.btn_normal.TabIndex = 38;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_relevo
            // 
            this.btn_relevo.Location = new System.Drawing.Point(24, 618);
            this.btn_relevo.Name = "btn_relevo";
            this.btn_relevo.Size = new System.Drawing.Size(61, 23);
            this.btn_relevo.TabIndex = 39;
            this.btn_relevo.Text = "Relevo";
            this.btn_relevo.UseVisualStyleBackColor = true;
            this.btn_relevo.Click += new System.EventHandler(this.btn_relevo_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.SlateBlue;
            this.trackBar1.Location = new System.Drawing.Point(567, 611);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(403, 45);
            this.trackBar1.TabIndex = 40;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(513, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Zoom:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 25);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaTabelaToolStripMenuItem1,
            this.trocarTabelaToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.arquivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arquivosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // novaTabelaToolStripMenuItem1
            // 
            this.novaTabelaToolStripMenuItem1.Name = "novaTabelaToolStripMenuItem1";
            this.novaTabelaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novaTabelaToolStripMenuItem1.Text = "Nova Tabela";
            this.novaTabelaToolStripMenuItem1.Click += new System.EventHandler(this.novaTabelaToolStripMenuItem1_Click);
            // 
            // trocarTabelaToolStripMenuItem
            // 
            this.trocarTabelaToolStripMenuItem.Name = "trocarTabelaToolStripMenuItem";
            this.trocarTabelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarTabelaToolStripMenuItem.Text = "Trocar Tabela";
            this.trocarTabelaToolStripMenuItem.Click += new System.EventHandler(this.trocarTabelaToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // btnpontoadd
            // 
            this.btnpontoadd.Location = new System.Drawing.Point(394, 611);
            this.btnpontoadd.Name = "btnpontoadd";
            this.btnpontoadd.Size = new System.Drawing.Size(104, 23);
            this.btnpontoadd.TabIndex = 43;
            this.btnpontoadd.Text = "Adicionar Ponto";
            this.btnpontoadd.UseVisualStyleBackColor = true;
            this.btnpontoadd.Click += new System.EventHandler(this.btnpontoadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 611);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 89);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(408, 672);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "Remover";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblocorrencia
            // 
            this.lblocorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblocorrencia.AutoSize = true;
            this.lblocorrencia.BackColor = System.Drawing.Color.Transparent;
            this.lblocorrencia.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblocorrencia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblocorrencia.Location = new System.Drawing.Point(10, 52);
            this.lblocorrencia.Name = "lblocorrencia";
            this.lblocorrencia.Size = new System.Drawing.Size(106, 13);
            this.lblocorrencia.TabIndex = 46;
            this.lblocorrencia.Text = "Ocorrência:";
            // 
            // txtOcorrencia
            // 
            this.txtOcorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOcorrencia.Location = new System.Drawing.Point(13, 68);
            this.txtOcorrencia.Name = "txtOcorrencia";
            this.txtOcorrencia.Size = new System.Drawing.Size(227, 23);
            this.txtOcorrencia.TabIndex = 47;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalhes.BackColor = System.Drawing.Color.White;
            this.btnDetalhes.Enabled = false;
            this.btnDetalhes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetalhes.Location = new System.Drawing.Point(13, 340);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 31);
            this.btnDetalhes.TabIndex = 48;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtcomboBoxStatusCon);
            this.panel1.Controls.Add(this.labelDescricao);
            this.panel1.Controls.Add(this.btnDetalhes);
            this.panel1.Controls.Add(this.lblocorrencia);
            this.panel1.Controls.Add(this.txtOcorrencia);
            this.panel1.Controls.Add(this.labelLat);
            this.panel1.Controls.Add(this.labelLong);
            this.panel1.Controls.Add(this.labelEspecie);
            this.panel1.Controls.Add(this.labelGenero);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtLat);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.txtEspecie);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.txtLong);
            this.panel1.Location = new System.Drawing.Point(1134, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 376);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Leitor_de_Mapa.Properties.Resources._93631;
            this.pictureBox2.Location = new System.Drawing.Point(261, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtcomboBoxStatusCon
            // 
            this.txtcomboBoxStatusCon.FormattingEnabled = true;
            this.txtcomboBoxStatusCon.Items.AddRange(new object[] {
            "Não avaliada",
            "LC",
            "NT",
            "VU",
            "EN",
            "CR",
            "EW",
            "EX"});
            this.txtcomboBoxStatusCon.Location = new System.Drawing.Point(107, 341);
            this.txtcomboBoxStatusCon.Name = "txtcomboBoxStatusCon";
            this.txtcomboBoxStatusCon.Size = new System.Drawing.Size(133, 23);
            this.txtcomboBoxStatusCon.TabIndex = 49;
            this.txtcomboBoxStatusCon.Text = "IUCN";
            this.txtcomboBoxStatusCon.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusCon_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Leitor_de_Mapa.Properties.Resources.md_5aa8fcedbdd99;
            this.pictureBox1.Location = new System.Drawing.Point(1395, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 41);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1116, 564);
            this.gMapControl1.TabIndex = 50;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Leitor_de_Mapa.Properties.Resources.cityskyline;
            this.ClientSize = new System.Drawing.Size(1428, 704);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpontoadd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_relevo);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_satelite);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstFungos);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.FileName_LBL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPoligon);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtEnquadrar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl map;
        private Label labelLat;
        private TextBox txtLat;
        private Label labelLong;
        private TextBox txtLong;
        private Button btnRemover;
        private Button txtEnquadrar;
        private Label labelDescricao;
        private Label labelGenero;
        private TextBox txtGenero;
        private TextBox txtEspecie;
        private Label labelEspecie;
        private DateTimePicker txtData;
        private Label labelData;
        private Button btnEditar;
        private Button btnExportar;
        private TextBox txtDescricao;
        private Button btnPoligon;
        private Button button1;
        private Label FileName_LBL;
        private Button btnImportar;
        private Button btn_Adicionar;
        private ListView lstFungos;
        private TextBox txtBuscar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lbl_id;
        private Button btn_satelite;
        private Button btn_normal;
        private Button btn_relevo;
        private TrackBar trackBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivosToolStripMenuItem;
        private ToolStripMenuItem novaTabelaToolStripMenuItem1;
        private ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private ToolStripMenuItem trocarTabelaToolStripMenuItem;
        private Button btnpontoadd;
        private DataGridView dataGridView1;
        private Button btnLimpar;
        private Label lblocorrencia;
        private TextBox txtOcorrencia;
        private Button btnDetalhes;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox txtcomboBoxStatusCon;
        private PictureBox pictureBox2;
    }
}