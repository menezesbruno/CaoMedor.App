namespace CaoMedor_App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btHoraSincPC = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updownAno = new System.Windows.Forms.NumericUpDown();
            this.updownMes = new System.Windows.Forms.NumericUpDown();
            this.updownDia = new System.Windows.Forms.NumericUpDown();
            this.updownMinuto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updownHora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelConectar = new System.Windows.Forms.Panel();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.pictureBoxConexao = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.metroLinkSite = new MetroFramework.Controls.MetroLink();
            this.Creditos = new System.Windows.Forms.Label();
            this.LogoImagem = new System.Windows.Forms.PictureBox();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabAjustarVezes = new MetroFramework.Controls.MetroTabPage();
            this.PainelHorarios = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updownMinuto1 = new System.Windows.Forms.NumericUpDown();
            this.updownHora1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updownMinuto2 = new System.Windows.Forms.NumericUpDown();
            this.updownHora2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updownMinuto3 = new System.Windows.Forms.NumericUpDown();
            this.updownHora3 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updownMinuto4 = new System.Windows.Forms.NumericUpDown();
            this.updownHora4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.trackbarVezes = new System.Windows.Forms.TrackBar();
            this.tabAjustarQuantidade = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.QuantRacao = new MetroFramework.Controls.MetroLabel();
            this.trackbarQuantidade = new System.Windows.Forms.TrackBar();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tabAjustarHora = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabAjustarOutros = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFirmware = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFirmware = new MetroFramework.Controls.MetroLabel();
            this.textInfoFirmwareValor = new MetroFramework.Controls.MetroLabel();
            this.metroLabelData = new MetroFramework.Controls.MetroLabel();
            this.textInfoDataValor = new MetroFramework.Controls.MetroLabel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelAvisoSonoro = new System.Windows.Forms.Panel();
            this.boxAvisoSonoro = new MetroFramework.Controls.MetroToggle();
            this.metroLabelAvisoSonoro = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelUmidadeConfig = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelUmidade = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.updownUmidadeMax = new System.Windows.Forms.NumericUpDown();
            this.updownUmidadeMin = new System.Windows.Forms.NumericUpDown();
            this.boxSensorUmidadeOn = new MetroFramework.Controls.MetroToggle();
            this.metroLabelIndicadorUmidade = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.boxDebug = new MetroFramework.Controls.MetroCheckBox();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinnerSalvar = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btSobre = new System.Windows.Forms.PictureBox();
            this.btSalvar = new System.Windows.Forms.PictureBox();
            this.textStatus = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.updownAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora)).BeginInit();
            this.panelConectar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConexao)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImagem)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.tabAjustarVezes.SuspendLayout();
            this.PainelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVezes)).BeginInit();
            this.tabAjustarQuantidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabAjustarHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabAjustarOutros.SuspendLayout();
            this.panelFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panelAvisoSonoro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelUmidadeConfig.SuspendLayout();
            this.panelUmidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownUmidadeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownUmidadeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalvar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHoraSincPC
            // 
            this.btHoraSincPC.Location = new System.Drawing.Point(314, 77);
            this.btHoraSincPC.Name = "btHoraSincPC";
            this.btHoraSincPC.Size = new System.Drawing.Size(89, 25);
            this.btHoraSincPC.TabIndex = 31;
            this.btHoraSincPC.Text = "S&inc. com o PC";
            this.btHoraSincPC.UseSelectable = true;
            this.btHoraSincPC.Click += new System.EventHandler(this.btHoraSincPC_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(149, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 47);
            this.panel3.TabIndex = 25;
            // 
            // updownAno
            // 
            this.updownAno.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownAno.Location = new System.Drawing.Point(246, 77);
            this.updownAno.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.updownAno.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.updownAno.Name = "updownAno";
            this.updownAno.Size = new System.Drawing.Size(55, 25);
            this.updownAno.TabIndex = 8;
            this.updownAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownAno.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // updownMes
            // 
            this.updownMes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMes.Location = new System.Drawing.Point(204, 77);
            this.updownMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updownMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownMes.Name = "updownMes";
            this.updownMes.Size = new System.Drawing.Size(36, 25);
            this.updownMes.TabIndex = 9;
            this.updownMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updownDia
            // 
            this.updownDia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownDia.Location = new System.Drawing.Point(162, 77);
            this.updownDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.updownDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownDia.Name = "updownDia";
            this.updownDia.Size = new System.Drawing.Size(36, 25);
            this.updownDia.TabIndex = 8;
            this.updownDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updownMinuto
            // 
            this.updownMinuto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMinuto.Location = new System.Drawing.Point(101, 77);
            this.updownMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownMinuto.Name = "updownMinuto";
            this.updownMinuto.Size = new System.Drawing.Size(36, 25);
            this.updownMinuto.TabIndex = 9;
            this.updownMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(201, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mês";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(244, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updownHora
            // 
            this.updownHora.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownHora.Location = new System.Drawing.Point(59, 77);
            this.updownHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.updownHora.Name = "updownHora";
            this.updownHora.Size = new System.Drawing.Size(36, 25);
            this.updownHora.TabIndex = 8;
            this.updownHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(159, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(98, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minuto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(56, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelConectar
            // 
            this.panelConectar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelConectar.Controls.Add(this.comboCOM);
            this.panelConectar.Controls.Add(this.pictureBoxConexao);
            this.panelConectar.Location = new System.Drawing.Point(15, 20);
            this.panelConectar.Name = "panelConectar";
            this.panelConectar.Size = new System.Drawing.Size(106, 33);
            this.panelConectar.TabIndex = 35;
            // 
            // comboCOM
            // 
            this.comboCOM.BackColor = System.Drawing.SystemColors.Window;
            this.comboCOM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Location = new System.Drawing.Point(37, 4);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(64, 25);
            this.comboCOM.TabIndex = 54;
            // 
            // pictureBoxConexao
            // 
            this.pictureBoxConexao.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConexao.Image = global::CaoMedor_App.Properties.Resources.Desconectado;
            this.pictureBoxConexao.Location = new System.Drawing.Point(4, 0);
            this.pictureBoxConexao.Name = "pictureBoxConexao";
            this.pictureBoxConexao.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxConexao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxConexao.TabIndex = 53;
            this.pictureBoxConexao.TabStop = false;
            this.metroToolTip.SetToolTip(this.pictureBoxConexao, "Conecta/Desconecta ao CãoMedor");
            this.pictureBoxConexao.Click += new System.EventHandler(this.pictureBoxConexao_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.metroLinkSite);
            this.panelLogo.Controls.Add(this.Creditos);
            this.panelLogo.Controls.Add(this.LogoImagem);
            this.panelLogo.Location = new System.Drawing.Point(15, 21);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(132, 180);
            this.panelLogo.TabIndex = 33;
            // 
            // metroLinkSite
            // 
            this.metroLinkSite.Location = new System.Drawing.Point(1, 119);
            this.metroLinkSite.Name = "metroLinkSite";
            this.metroLinkSite.Size = new System.Drawing.Size(130, 26);
            this.metroLinkSite.TabIndex = 21;
            this.metroLinkSite.Text = "www.caomedor.com";
            this.metroLinkSite.UseSelectable = true;
            this.metroLinkSite.Click += new System.EventHandler(this.metroLinkSite_Click);
            // 
            // Creditos
            // 
            this.Creditos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Creditos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Creditos.Location = new System.Drawing.Point(1, 142);
            this.Creditos.Margin = new System.Windows.Forms.Padding(0);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(130, 33);
            this.Creditos.TabIndex = 19;
            this.Creditos.Text = "Criado por\r\nBruno Menezes";
            this.Creditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoImagem
            // 
            this.LogoImagem.Image = global::CaoMedor_App.Properties.Resources.CaoMedor_Logo;
            this.LogoImagem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoImagem.Location = new System.Drawing.Point(0, 0);
            this.LogoImagem.Name = "LogoImagem";
            this.LogoImagem.Size = new System.Drawing.Size(132, 122);
            this.LogoImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoImagem.TabIndex = 20;
            this.LogoImagem.TabStop = false;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.tabAjustarVezes);
            this.metroTabControl.Controls.Add(this.tabAjustarQuantidade);
            this.metroTabControl.Controls.Add(this.tabAjustarHora);
            this.metroTabControl.Controls.Add(this.tabAjustarOutros);
            this.metroTabControl.Location = new System.Drawing.Point(149, 65);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(474, 319);
            this.metroTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl.TabIndex = 47;
            this.metroTabControl.UseSelectable = true;
            // 
            // tabAjustarVezes
            // 
            this.tabAjustarVezes.Controls.Add(this.PainelHorarios);
            this.tabAjustarVezes.HorizontalScrollbarBarColor = true;
            this.tabAjustarVezes.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAjustarVezes.HorizontalScrollbarSize = 10;
            this.tabAjustarVezes.Location = new System.Drawing.Point(4, 38);
            this.tabAjustarVezes.Name = "tabAjustarVezes";
            this.tabAjustarVezes.Size = new System.Drawing.Size(466, 277);
            this.tabAjustarVezes.TabIndex = 0;
            this.tabAjustarVezes.Text = "Ajustar Horários";
            this.tabAjustarVezes.VerticalScrollbarBarColor = true;
            this.tabAjustarVezes.VerticalScrollbarHighlightOnWheel = false;
            this.tabAjustarVezes.VerticalScrollbarSize = 10;
            // 
            // PainelHorarios
            // 
            this.PainelHorarios.AutoScroll = true;
            this.PainelHorarios.BackColor = System.Drawing.Color.Transparent;
            this.PainelHorarios.Controls.Add(this.pictureBox9);
            this.PainelHorarios.Controls.Add(this.pictureBox6);
            this.PainelHorarios.Controls.Add(this.pictureBox5);
            this.PainelHorarios.Controls.Add(this.pictureBox4);
            this.PainelHorarios.Controls.Add(this.pictureBox2);
            this.PainelHorarios.Controls.Add(this.tableLayoutPanel1);
            this.PainelHorarios.Controls.Add(this.metroLabel8);
            this.PainelHorarios.Controls.Add(this.trackbarVezes);
            this.PainelHorarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelHorarios.Location = new System.Drawing.Point(0, -8);
            this.PainelHorarios.Name = "PainelHorarios";
            this.PainelHorarios.Size = new System.Drawing.Size(466, 285);
            this.PainelHorarios.TabIndex = 15;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CaoMedor_App.Properties.Resources.Horarios;
            this.pictureBox9.Location = new System.Drawing.Point(72, 16);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CaoMedor_App.Properties.Resources.X4;
            this.pictureBox6.Location = new System.Drawing.Point(318, 91);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CaoMedor_App.Properties.Resources.X3;
            this.pictureBox5.Location = new System.Drawing.Point(248, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CaoMedor_App.Properties.Resources.X2;
            this.pictureBox4.Location = new System.Drawing.Point(181, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CaoMedor_App.Properties.Resources.X1;
            this.pictureBox2.Location = new System.Drawing.Point(112, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 154);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 78);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updownMinuto1);
            this.groupBox1.Controls.Add(this.updownHora1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horário 1";
            // 
            // updownMinuto1
            // 
            this.updownMinuto1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMinuto1.Location = new System.Drawing.Point(49, 37);
            this.updownMinuto1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownMinuto1.Name = "updownMinuto1";
            this.updownMinuto1.Size = new System.Drawing.Size(36, 25);
            this.updownMinuto1.TabIndex = 5;
            this.updownMinuto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updownHora1
            // 
            this.updownHora1.AllowDrop = true;
            this.updownHora1.CausesValidation = false;
            this.updownHora1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownHora1.Location = new System.Drawing.Point(7, 37);
            this.updownHora1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.updownHora1.Name = "updownHora1";
            this.updownHora1.Size = new System.Drawing.Size(36, 25);
            this.updownHora1.TabIndex = 4;
            this.updownHora1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(45, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Minuto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hora";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updownMinuto2);
            this.groupBox2.Controls.Add(this.updownHora2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(104, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horário 2";
            // 
            // updownMinuto2
            // 
            this.updownMinuto2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMinuto2.Location = new System.Drawing.Point(49, 37);
            this.updownMinuto2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownMinuto2.Name = "updownMinuto2";
            this.updownMinuto2.Size = new System.Drawing.Size(36, 25);
            this.updownMinuto2.TabIndex = 5;
            this.updownMinuto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updownHora2
            // 
            this.updownHora2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownHora2.Location = new System.Drawing.Point(7, 37);
            this.updownHora2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.updownHora2.Name = "updownHora2";
            this.updownHora2.Size = new System.Drawing.Size(36, 25);
            this.updownHora2.TabIndex = 4;
            this.updownHora2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(45, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Minuto";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Hora";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updownMinuto3);
            this.groupBox3.Controls.Add(this.updownHora3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(205, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horário 3";
            // 
            // updownMinuto3
            // 
            this.updownMinuto3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMinuto3.Location = new System.Drawing.Point(49, 37);
            this.updownMinuto3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownMinuto3.Name = "updownMinuto3";
            this.updownMinuto3.Size = new System.Drawing.Size(36, 25);
            this.updownMinuto3.TabIndex = 5;
            this.updownMinuto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updownHora3
            // 
            this.updownHora3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownHora3.Location = new System.Drawing.Point(7, 37);
            this.updownHora3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.updownHora3.Name = "updownHora3";
            this.updownHora3.Size = new System.Drawing.Size(36, 25);
            this.updownHora3.TabIndex = 4;
            this.updownHora3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(45, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Minuto";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Hora";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updownMinuto4);
            this.groupBox4.Controls.Add(this.updownHora4);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(306, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 72);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horário 4";
            // 
            // updownMinuto4
            // 
            this.updownMinuto4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownMinuto4.Location = new System.Drawing.Point(49, 37);
            this.updownMinuto4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updownMinuto4.Name = "updownMinuto4";
            this.updownMinuto4.Size = new System.Drawing.Size(36, 25);
            this.updownMinuto4.TabIndex = 5;
            this.updownMinuto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updownHora4
            // 
            this.updownHora4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownHora4.Location = new System.Drawing.Point(7, 37);
            this.updownHora4.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.updownHora4.Name = "updownHora4";
            this.updownHora4.Size = new System.Drawing.Size(36, 25);
            this.updownHora4.TabIndex = 4;
            this.updownHora4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(45, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Minuto";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(10, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Hora";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(3, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(461, 32);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Alimentar o seu Pet quantas vezes ao dia?";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackbarVezes
            // 
            this.trackbarVezes.BackColor = System.Drawing.Color.White;
            this.trackbarVezes.LargeChange = 1;
            this.trackbarVezes.Location = new System.Drawing.Point(114, 70);
            this.trackbarVezes.Maximum = 4;
            this.trackbarVezes.Minimum = 1;
            this.trackbarVezes.Name = "trackbarVezes";
            this.trackbarVezes.Size = new System.Drawing.Size(233, 45);
            this.trackbarVezes.TabIndex = 4;
            this.trackbarVezes.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarVezes.Value = 1;
            this.trackbarVezes.ValueChanged += new System.EventHandler(this.trackbarVezes_ValueChanged);
            // 
            // tabAjustarQuantidade
            // 
            this.tabAjustarQuantidade.Controls.Add(this.metroLabel6);
            this.tabAjustarQuantidade.Controls.Add(this.QuantRacao);
            this.tabAjustarQuantidade.Controls.Add(this.trackbarQuantidade);
            this.tabAjustarQuantidade.Controls.Add(this.pictureBox8);
            this.tabAjustarQuantidade.HorizontalScrollbarBarColor = true;
            this.tabAjustarQuantidade.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAjustarQuantidade.HorizontalScrollbarSize = 10;
            this.tabAjustarQuantidade.Location = new System.Drawing.Point(4, 38);
            this.tabAjustarQuantidade.Name = "tabAjustarQuantidade";
            this.tabAjustarQuantidade.Size = new System.Drawing.Size(466, 277);
            this.tabAjustarQuantidade.TabIndex = 1;
            this.tabAjustarQuantidade.Text = "Quantidade de Ração";
            this.tabAjustarQuantidade.VerticalScrollbarBarColor = true;
            this.tabAjustarQuantidade.VerticalScrollbarHighlightOnWheel = false;
            this.tabAjustarQuantidade.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(109, 8);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(293, 32);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Quantidade de ração a ser servida (em gramas)";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantRacao
            // 
            this.QuantRacao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.QuantRacao.Location = new System.Drawing.Point(193, 210);
            this.QuantRacao.Name = "QuantRacao";
            this.QuantRacao.Size = new System.Drawing.Size(79, 29);
            this.QuantRacao.TabIndex = 16;
            this.QuantRacao.Text = "0";
            this.QuantRacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackbarQuantidade
            // 
            this.trackbarQuantidade.AutoSize = false;
            this.trackbarQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.trackbarQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackbarQuantidade.LargeChange = 25;
            this.trackbarQuantidade.Location = new System.Drawing.Point(210, 43);
            this.trackbarQuantidade.Maximum = 2000;
            this.trackbarQuantidade.Name = "trackbarQuantidade";
            this.trackbarQuantidade.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarQuantidade.Size = new System.Drawing.Size(42, 173);
            this.trackbarQuantidade.SmallChange = 25;
            this.trackbarQuantidade.TabIndex = 12;
            this.trackbarQuantidade.TickFrequency = 80;
            this.trackbarQuantidade.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackbarQuantidade.ValueChanged += new System.EventHandler(this.trackbarQuantidade_ValueChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::CaoMedor_App.Properties.Resources.Balanca;
            this.pictureBox8.Location = new System.Drawing.Point(77, 8);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // tabAjustarHora
            // 
            this.tabAjustarHora.Controls.Add(this.metroLabel9);
            this.tabAjustarHora.Controls.Add(this.btHoraSincPC);
            this.tabAjustarHora.Controls.Add(this.panel3);
            this.tabAjustarHora.Controls.Add(this.updownAno);
            this.tabAjustarHora.Controls.Add(this.label5);
            this.tabAjustarHora.Controls.Add(this.updownMes);
            this.tabAjustarHora.Controls.Add(this.label4);
            this.tabAjustarHora.Controls.Add(this.updownDia);
            this.tabAjustarHora.Controls.Add(this.label1);
            this.tabAjustarHora.Controls.Add(this.updownMinuto);
            this.tabAjustarHora.Controls.Add(this.updownHora);
            this.tabAjustarHora.Controls.Add(this.label2);
            this.tabAjustarHora.Controls.Add(this.label3);
            this.tabAjustarHora.Controls.Add(this.pictureBox3);
            this.tabAjustarHora.HorizontalScrollbarBarColor = true;
            this.tabAjustarHora.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAjustarHora.HorizontalScrollbarSize = 10;
            this.tabAjustarHora.Location = new System.Drawing.Point(4, 38);
            this.tabAjustarHora.Name = "tabAjustarHora";
            this.tabAjustarHora.Size = new System.Drawing.Size(466, 277);
            this.tabAjustarHora.TabIndex = 2;
            this.tabAjustarHora.Text = "Data e Hora";
            this.tabAjustarHora.VerticalScrollbarBarColor = true;
            this.tabAjustarHora.VerticalScrollbarHighlightOnWheel = false;
            this.tabAjustarHora.VerticalScrollbarSize = 10;
            this.tabAjustarHora.Enter += new System.EventHandler(this.tabAjustarHora_Enter);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Location = new System.Drawing.Point(161, 8);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(140, 32);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "Ajuste de Data e Hora";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CaoMedor_App.Properties.Resources.Relogio;
            this.pictureBox3.Location = new System.Drawing.Point(126, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // tabAjustarOutros
            // 
            this.tabAjustarOutros.Controls.Add(this.panel1);
            this.tabAjustarOutros.Controls.Add(this.panelFirmware);
            this.tabAjustarOutros.Controls.Add(this.panelAvisoSonoro);
            this.tabAjustarOutros.Controls.Add(this.panelUmidadeConfig);
            this.tabAjustarOutros.HorizontalScrollbarBarColor = true;
            this.tabAjustarOutros.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAjustarOutros.HorizontalScrollbarSize = 10;
            this.tabAjustarOutros.Location = new System.Drawing.Point(4, 38);
            this.tabAjustarOutros.Name = "tabAjustarOutros";
            this.tabAjustarOutros.Size = new System.Drawing.Size(466, 277);
            this.tabAjustarOutros.TabIndex = 3;
            this.tabAjustarOutros.Text = "Outras Configurações";
            this.tabAjustarOutros.VerticalScrollbarBarColor = true;
            this.tabAjustarOutros.VerticalScrollbarHighlightOnWheel = false;
            this.tabAjustarOutros.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(245, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 125);
            this.panel1.TabIndex = 54;
            // 
            // panelFirmware
            // 
            this.panelFirmware.BackColor = System.Drawing.Color.Transparent;
            this.panelFirmware.Controls.Add(this.metroLabel5);
            this.panelFirmware.Controls.Add(this.metroLabelFirmware);
            this.panelFirmware.Controls.Add(this.textInfoFirmwareValor);
            this.panelFirmware.Controls.Add(this.metroLabelData);
            this.panelFirmware.Controls.Add(this.textInfoDataValor);
            this.panelFirmware.Controls.Add(this.pictureBox10);
            this.panelFirmware.Location = new System.Drawing.Point(3, 149);
            this.panelFirmware.Name = "panelFirmware";
            this.panelFirmware.Size = new System.Drawing.Size(236, 125);
            this.panelFirmware.TabIndex = 53;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(64, 5);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 32);
            this.metroLabel5.TabIndex = 47;
            this.metroLabel5.Text = "Firmware";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabelFirmware
            // 
            this.metroLabelFirmware.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelFirmware.Location = new System.Drawing.Point(66, 82);
            this.metroLabelFirmware.Name = "metroLabelFirmware";
            this.metroLabelFirmware.Size = new System.Drawing.Size(53, 19);
            this.metroLabelFirmware.TabIndex = 52;
            this.metroLabelFirmware.Text = "Firmware";
            this.metroLabelFirmware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textInfoFirmwareValor
            // 
            this.textInfoFirmwareValor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.textInfoFirmwareValor.Location = new System.Drawing.Point(125, 82);
            this.textInfoFirmwareValor.Name = "textInfoFirmwareValor";
            this.textInfoFirmwareValor.Size = new System.Drawing.Size(99, 19);
            this.textInfoFirmwareValor.TabIndex = 52;
            this.textInfoFirmwareValor.Text = "info";
            this.textInfoFirmwareValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabelData
            // 
            this.metroLabelData.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelData.Location = new System.Drawing.Point(66, 101);
            this.metroLabelData.Name = "metroLabelData";
            this.metroLabelData.Size = new System.Drawing.Size(53, 15);
            this.metroLabelData.TabIndex = 52;
            this.metroLabelData.Text = "Data";
            this.metroLabelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textInfoDataValor
            // 
            this.textInfoDataValor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.textInfoDataValor.Location = new System.Drawing.Point(125, 101);
            this.textInfoDataValor.Name = "textInfoDataValor";
            this.textInfoDataValor.Size = new System.Drawing.Size(99, 15);
            this.textInfoDataValor.TabIndex = 52;
            this.textInfoDataValor.Text = "info";
            this.textInfoDataValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::CaoMedor_App.Properties.Resources.Firmware;
            this.pictureBox10.Location = new System.Drawing.Point(29, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 49;
            this.pictureBox10.TabStop = false;
            // 
            // panelAvisoSonoro
            // 
            this.panelAvisoSonoro.BackColor = System.Drawing.Color.Transparent;
            this.panelAvisoSonoro.Controls.Add(this.boxAvisoSonoro);
            this.panelAvisoSonoro.Controls.Add(this.metroLabelAvisoSonoro);
            this.panelAvisoSonoro.Controls.Add(this.metroLabel4);
            this.panelAvisoSonoro.Controls.Add(this.pictureBox7);
            this.panelAvisoSonoro.Location = new System.Drawing.Point(245, 3);
            this.panelAvisoSonoro.Name = "panelAvisoSonoro";
            this.panelAvisoSonoro.Size = new System.Drawing.Size(221, 140);
            this.panelAvisoSonoro.TabIndex = 51;
            // 
            // boxAvisoSonoro
            // 
            this.boxAvisoSonoro.AutoSize = true;
            this.boxAvisoSonoro.DisplayFocus = true;
            this.boxAvisoSonoro.DisplayStatus = false;
            this.boxAvisoSonoro.Location = new System.Drawing.Point(113, 60);
            this.boxAvisoSonoro.Name = "boxAvisoSonoro";
            this.boxAvisoSonoro.Size = new System.Drawing.Size(50, 17);
            this.boxAvisoSonoro.TabIndex = 48;
            this.boxAvisoSonoro.Text = "Off";
            this.boxAvisoSonoro.UseCustomBackColor = true;
            this.boxAvisoSonoro.UseCustomForeColor = true;
            this.boxAvisoSonoro.UseSelectable = true;
            this.boxAvisoSonoro.UseStyleColors = true;
            this.boxAvisoSonoro.CheckedChanged += new System.EventHandler(this.boxAvisoSonoro_CheckedChanged);
            // 
            // metroLabelAvisoSonoro
            // 
            this.metroLabelAvisoSonoro.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelAvisoSonoro.Location = new System.Drawing.Point(49, 60);
            this.metroLabelAvisoSonoro.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabelAvisoSonoro.Name = "metroLabelAvisoSonoro";
            this.metroLabelAvisoSonoro.Size = new System.Drawing.Size(65, 17);
            this.metroLabelAvisoSonoro.TabIndex = 49;
            this.metroLabelAvisoSonoro.Text = "Desligado";
            this.metroLabelAvisoSonoro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(68, 5);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 32);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "Aviso Sonoro";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CaoMedor_App.Properties.Resources.AvisoSonoro;
            this.pictureBox7.Location = new System.Drawing.Point(33, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panelUmidadeConfig
            // 
            this.panelUmidadeConfig.BackColor = System.Drawing.Color.Transparent;
            this.panelUmidadeConfig.Controls.Add(this.metroLabel1);
            this.panelUmidadeConfig.Controls.Add(this.panelUmidade);
            this.panelUmidadeConfig.Controls.Add(this.boxSensorUmidadeOn);
            this.panelUmidadeConfig.Controls.Add(this.metroLabelIndicadorUmidade);
            this.panelUmidadeConfig.Controls.Add(this.pictureBox1);
            this.panelUmidadeConfig.Location = new System.Drawing.Point(3, 3);
            this.panelUmidadeConfig.Name = "panelUmidadeConfig";
            this.panelUmidadeConfig.Size = new System.Drawing.Size(236, 140);
            this.panelUmidadeConfig.TabIndex = 50;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(64, 5);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(132, 32);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Sensor de Umidade";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUmidade
            // 
            this.panelUmidade.BackColor = System.Drawing.Color.Transparent;
            this.panelUmidade.Controls.Add(this.metroLabel3);
            this.panelUmidade.Controls.Add(this.metroLabel2);
            this.panelUmidade.Controls.Add(this.updownUmidadeMax);
            this.panelUmidade.Controls.Add(this.updownUmidadeMin);
            this.panelUmidade.Enabled = false;
            this.panelUmidade.Location = new System.Drawing.Point(45, 84);
            this.panelUmidade.Name = "panelUmidade";
            this.panelUmidade.Size = new System.Drawing.Size(157, 53);
            this.panelUmidade.TabIndex = 30;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(3, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 15);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Umidade máxima";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(3, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 15);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Umidade mínima";
            // 
            // updownUmidadeMax
            // 
            this.updownUmidadeMax.BackColor = System.Drawing.SystemColors.Window;
            this.updownUmidadeMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updownUmidadeMax.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownUmidadeMax.Location = new System.Drawing.Point(107, 29);
            this.updownUmidadeMax.Name = "updownUmidadeMax";
            this.updownUmidadeMax.Size = new System.Drawing.Size(44, 21);
            this.updownUmidadeMax.TabIndex = 31;
            this.updownUmidadeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownUmidadeMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // updownUmidadeMin
            // 
            this.updownUmidadeMin.BackColor = System.Drawing.SystemColors.Window;
            this.updownUmidadeMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updownUmidadeMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.updownUmidadeMin.Location = new System.Drawing.Point(107, 3);
            this.updownUmidadeMin.Name = "updownUmidadeMin";
            this.updownUmidadeMin.Size = new System.Drawing.Size(44, 21);
            this.updownUmidadeMin.TabIndex = 30;
            this.updownUmidadeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxSensorUmidadeOn
            // 
            this.boxSensorUmidadeOn.AutoSize = true;
            this.boxSensorUmidadeOn.DisplayFocus = true;
            this.boxSensorUmidadeOn.DisplayStatus = false;
            this.boxSensorUmidadeOn.Location = new System.Drawing.Point(125, 60);
            this.boxSensorUmidadeOn.Name = "boxSensorUmidadeOn";
            this.boxSensorUmidadeOn.Size = new System.Drawing.Size(50, 17);
            this.boxSensorUmidadeOn.TabIndex = 44;
            this.boxSensorUmidadeOn.Text = "Off";
            this.boxSensorUmidadeOn.UseCustomBackColor = true;
            this.boxSensorUmidadeOn.UseCustomForeColor = true;
            this.boxSensorUmidadeOn.UseSelectable = true;
            this.boxSensorUmidadeOn.UseStyleColors = true;
            this.boxSensorUmidadeOn.CheckedChanged += new System.EventHandler(this.boxChecarUmidade_CheckedChanged);
            // 
            // metroLabelIndicadorUmidade
            // 
            this.metroLabelIndicadorUmidade.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelIndicadorUmidade.Location = new System.Drawing.Point(61, 60);
            this.metroLabelIndicadorUmidade.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabelIndicadorUmidade.Name = "metroLabelIndicadorUmidade";
            this.metroLabelIndicadorUmidade.Size = new System.Drawing.Size(65, 17);
            this.metroLabelIndicadorUmidade.TabIndex = 47;
            this.metroLabelIndicadorUmidade.Text = "Desligado";
            this.metroLabelIndicadorUmidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CaoMedor_App.Properties.Resources.Umidade;
            this.pictureBox1.Location = new System.Drawing.Point(29, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 5000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DiscardNull = true;
            // 
            // boxDebug
            // 
            this.boxDebug.AutoSize = true;
            this.boxDebug.Location = new System.Drawing.Point(15, 1);
            this.boxDebug.Name = "boxDebug";
            this.boxDebug.Size = new System.Drawing.Size(140, 15);
            this.boxDebug.TabIndex = 45;
            this.boxDebug.Text = "Primeira configuração";
            this.boxDebug.UseCustomBackColor = true;
            this.boxDebug.UseSelectable = true;
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Location = new System.Drawing.Point(127, 23);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinner.TabIndex = 46;
            this.metroProgressSpinner.UseSelectable = true;
            // 
            // metroProgressSpinnerSalvar
            // 
            this.metroProgressSpinnerSalvar.Location = new System.Drawing.Point(556, 23);
            this.metroProgressSpinnerSalvar.Maximum = 100;
            this.metroProgressSpinnerSalvar.Name = "metroProgressSpinnerSalvar";
            this.metroProgressSpinnerSalvar.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinnerSalvar.TabIndex = 48;
            this.metroProgressSpinnerSalvar.UseSelectable = true;
            this.metroProgressSpinnerSalvar.Visible = false;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.Transparent;
            this.btSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSobre.Image = global::CaoMedor_App.Properties.Resources.Sobre;
            this.btSobre.Location = new System.Drawing.Point(587, 38);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(32, 32);
            this.btSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSobre.TabIndex = 52;
            this.btSobre.TabStop = false;
            this.metroToolTip.SetToolTip(this.btSobre, "Sobre o CãoMedor");
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Enabled = false;
            this.btSalvar.Image = global::CaoMedor_App.Properties.Resources.Salvar;
            this.btSalvar.Location = new System.Drawing.Point(587, 20);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(32, 32);
            this.btSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSalvar.TabIndex = 49;
            this.btSalvar.TabStop = false;
            this.metroToolTip.SetToolTip(this.btSalvar, "Salvar ajustes");
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.textStatus.Location = new System.Drawing.Point(156, 20);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(327, 29);
            this.textStatus.TabIndex = 53;
            this.textStatus.Text = "Localizando o CãoMedor...";
            this.textStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textStatus);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.metroProgressSpinnerSalvar);
            this.panel2.Controls.Add(this.metroProgressSpinner);
            this.panel2.Controls.Add(this.boxDebug);
            this.panel2.Controls.Add(this.panelConectar);
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 60);
            this.panel2.TabIndex = 54;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSobre);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.panelLogo);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.updownAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora)).EndInit();
            this.panelConectar.ResumeLayout(false);
            this.panelConectar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConexao)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImagem)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.tabAjustarVezes.ResumeLayout(false);
            this.PainelHorarios.ResumeLayout(false);
            this.PainelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMinuto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownHora4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVezes)).EndInit();
            this.tabAjustarQuantidade.ResumeLayout(false);
            this.tabAjustarQuantidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabAjustarHora.ResumeLayout(false);
            this.tabAjustarHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabAjustarOutros.ResumeLayout(false);
            this.panelFirmware.ResumeLayout(false);
            this.panelFirmware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panelAvisoSonoro.ResumeLayout(false);
            this.panelAvisoSonoro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelUmidadeConfig.ResumeLayout(false);
            this.panelUmidadeConfig.PerformLayout();
            this.panelUmidade.ResumeLayout(false);
            this.panelUmidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownUmidadeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownUmidadeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalvar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown updownAno;
        private System.Windows.Forms.NumericUpDown updownMes;
        private System.Windows.Forms.NumericUpDown updownDia;
        private System.Windows.Forms.NumericUpDown updownMinuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updownHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelConectar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label Creditos;
        private System.Windows.Forms.PictureBox LogoImagem;
        private System.Windows.Forms.Panel panelUmidade;
        private System.Windows.Forms.NumericUpDown updownUmidadeMax;
        private System.Windows.Forms.NumericUpDown updownUmidadeMin;
        private System.Windows.Forms.Panel PainelHorarios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown updownMinuto4;
        private System.Windows.Forms.NumericUpDown updownHora4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown updownMinuto3;
        private System.Windows.Forms.NumericUpDown updownHora3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown updownMinuto2;
        private System.Windows.Forms.NumericUpDown updownHora2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown updownMinuto1;
        private System.Windows.Forms.NumericUpDown updownHora1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackbarQuantidade;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort;
        private MetroFramework.Controls.MetroLink metroLinkSite;
        private MetroFramework.Controls.MetroCheckBox boxDebug;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btHoraSincPC;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage tabAjustarVezes;
        private MetroFramework.Controls.MetroTabPage tabAjustarQuantidade;
        private MetroFramework.Controls.MetroTabPage tabAjustarHora;
        private MetroFramework.Controls.MetroTabPage tabAjustarOutros;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.TrackBar trackbarVezes;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle boxSensorUmidadeOn;
        private MetroFramework.Controls.MetroLabel metroLabelIndicadorUmidade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btSalvar;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Panel panelAvisoSonoro;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panelUmidadeConfig;
        private System.Windows.Forms.PictureBox btSobre;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle boxAvisoSonoro;
        private MetroFramework.Controls.MetroLabel metroLabelAvisoSonoro;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel QuantRacao;
        private System.Windows.Forms.PictureBox pictureBoxConexao;
        private MetroFramework.Controls.MetroLabel textStatus;
        private System.Windows.Forms.ComboBox comboCOM;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MetroFramework.Controls.MetroLabel textInfoFirmwareValor;
        private MetroFramework.Controls.MetroLabel textInfoDataValor;
        private MetroFramework.Controls.MetroLabel metroLabelData;
        private MetroFramework.Controls.MetroLabel metroLabelFirmware;
        private System.Windows.Forms.Panel panelFirmware;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}