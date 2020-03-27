namespace Graficas
{
    partial class formBattle
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
            this.imgboxP1 = new System.Windows.Forms.PictureBox();
            this.pbVidaP1 = new System.Windows.Forms.ProgressBar();
            this.imgboxP2 = new System.Windows.Forms.PictureBox();
            this.pbVidaP2 = new System.Windows.Forms.ProgressBar();
            this.lblNickP1 = new System.Windows.Forms.Label();
            this.lblNickP2 = new System.Windows.Forms.Label();
            this.btnAbandonarP1 = new System.Windows.Forms.Button();
            this.btnAbandonarP2 = new System.Windows.Forms.Button();
            this.timerTurno = new System.Windows.Forms.Timer(this.components);
            this.lblVidaP1 = new System.Windows.Forms.Label();
            this.lblVidaP2 = new System.Windows.Forms.Label();
            this.panelPowersP1 = new System.Windows.Forms.Panel();
            this.btnIlusionismoP1 = new System.Windows.Forms.Button();
            this.btnAbraCadabraP1 = new System.Windows.Forms.Button();
            this.btnMagiaNegraP1 = new System.Windows.Forms.Button();
            this.btnUnAlmaPorOtraP1 = new System.Windows.Forms.Button();
            this.btnDuplicarP1 = new System.Windows.Forms.Button();
            this.btnConLaVidaP1 = new System.Windows.Forms.Button();
            this.btnTongoP1 = new System.Windows.Forms.Button();
            this.btnPunchlineP1 = new System.Windows.Forms.Button();
            this.btnAtaqueAereoP1 = new System.Windows.Forms.Button();
            this.btnReplicaP1 = new System.Windows.Forms.Button();
            this.btnContraLasCuerdasP1 = new System.Windows.Forms.Button();
            this.btnRelevoP1 = new System.Windows.Forms.Button();
            this.btnCaballoDeTroyaP1 = new System.Windows.Forms.Button();
            this.btnEspadaSagradaP1 = new System.Windows.Forms.Button();
            this.btnIraP1 = new System.Windows.Forms.Button();
            this.panelPowersP2 = new System.Windows.Forms.Panel();
            this.btnMagiaNegraP2 = new System.Windows.Forms.Button();
            this.btnAbraCadabraP2 = new System.Windows.Forms.Button();
            this.btnIlusionismoP2 = new System.Windows.Forms.Button();
            this.btnUnAlmaPorOtraP2 = new System.Windows.Forms.Button();
            this.btnDuplicarP2 = new System.Windows.Forms.Button();
            this.btnConLaVidaP2 = new System.Windows.Forms.Button();
            this.btnTongoP2 = new System.Windows.Forms.Button();
            this.btnReplicaP2 = new System.Windows.Forms.Button();
            this.btnPunchlineP2 = new System.Windows.Forms.Button();
            this.btnAtaqueAereoP2 = new System.Windows.Forms.Button();
            this.btnContraLasCuerdasP2 = new System.Windows.Forms.Button();
            this.btnRelevoP2 = new System.Windows.Forms.Button();
            this.btnCaballoDeTroyaP2 = new System.Windows.Forms.Button();
            this.btnEspadaSagradaP2 = new System.Windows.Forms.Button();
            this.btnIraP2 = new System.Windows.Forms.Button();
            this.lblBatalla = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP2)).BeginInit();
            this.panelPowersP1.SuspendLayout();
            this.panelPowersP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgboxP1
            // 
            this.imgboxP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgboxP1.Image = global::Graficas.Properties.Resources.picNadie;
            this.imgboxP1.Location = new System.Drawing.Point(42, 88);
            this.imgboxP1.Name = "imgboxP1";
            this.imgboxP1.Size = new System.Drawing.Size(201, 225);
            this.imgboxP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxP1.TabIndex = 0;
            this.imgboxP1.TabStop = false;
            // 
            // pbVidaP1
            // 
            this.pbVidaP1.Location = new System.Drawing.Point(82, 3);
            this.pbVidaP1.Maximum = 999;
            this.pbVidaP1.Name = "pbVidaP1";
            this.pbVidaP1.Size = new System.Drawing.Size(243, 23);
            this.pbVidaP1.Step = 1;
            this.pbVidaP1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVidaP1.TabIndex = 1;
            this.pbVidaP1.Tag = "";
            // 
            // imgboxP2
            // 
            this.imgboxP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgboxP2.Image = global::Graficas.Properties.Resources.picNadie;
            this.imgboxP2.Location = new System.Drawing.Point(480, 88);
            this.imgboxP2.Name = "imgboxP2";
            this.imgboxP2.Size = new System.Drawing.Size(201, 225);
            this.imgboxP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxP2.TabIndex = 2;
            this.imgboxP2.TabStop = false;
            // 
            // pbVidaP2
            // 
            this.pbVidaP2.Location = new System.Drawing.Point(399, 3);
            this.pbVidaP2.Maximum = 999;
            this.pbVidaP2.Name = "pbVidaP2";
            this.pbVidaP2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbVidaP2.RightToLeftLayout = true;
            this.pbVidaP2.Size = new System.Drawing.Size(243, 23);
            this.pbVidaP2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVidaP2.TabIndex = 3;
            // 
            // lblNickP1
            // 
            this.lblNickP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNickP1.BackColor = System.Drawing.Color.Transparent;
            this.lblNickP1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickP1.ForeColor = System.Drawing.Color.White;
            this.lblNickP1.Location = new System.Drawing.Point(42, 57);
            this.lblNickP1.Name = "lblNickP1";
            this.lblNickP1.Size = new System.Drawing.Size(201, 28);
            this.lblNickP1.TabIndex = 12;
            this.lblNickP1.Text = "Player 1";
            this.lblNickP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNickP1.UseCompatibleTextRendering = true;
            // 
            // lblNickP2
            // 
            this.lblNickP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNickP2.BackColor = System.Drawing.Color.Transparent;
            this.lblNickP2.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickP2.ForeColor = System.Drawing.Color.White;
            this.lblNickP2.Location = new System.Drawing.Point(480, 57);
            this.lblNickP2.Name = "lblNickP2";
            this.lblNickP2.Size = new System.Drawing.Size(201, 28);
            this.lblNickP2.TabIndex = 13;
            this.lblNickP2.Text = "Player 2";
            this.lblNickP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNickP2.UseCompatibleTextRendering = true;
            // 
            // btnAbandonarP1
            // 
            this.btnAbandonarP1.BackColor = System.Drawing.Color.Red;
            this.btnAbandonarP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbandonarP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbandonarP1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbandonarP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbandonarP1.Location = new System.Drawing.Point(104, 409);
            this.btnAbandonarP1.Name = "btnAbandonarP1";
            this.btnAbandonarP1.Size = new System.Drawing.Size(75, 23);
            this.btnAbandonarP1.TabIndex = 14;
            this.btnAbandonarP1.Text = "Abandonar";
            this.btnAbandonarP1.UseVisualStyleBackColor = false;
            this.btnAbandonarP1.Click += new System.EventHandler(this.btnAbandonarP1_Click);
            // 
            // btnAbandonarP2
            // 
            this.btnAbandonarP2.BackColor = System.Drawing.Color.Red;
            this.btnAbandonarP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbandonarP2.Enabled = false;
            this.btnAbandonarP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbandonarP2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbandonarP2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbandonarP2.Location = new System.Drawing.Point(545, 406);
            this.btnAbandonarP2.Name = "btnAbandonarP2";
            this.btnAbandonarP2.Size = new System.Drawing.Size(75, 23);
            this.btnAbandonarP2.TabIndex = 15;
            this.btnAbandonarP2.Text = "Abandonar";
            this.btnAbandonarP2.UseVisualStyleBackColor = false;
            this.btnAbandonarP2.Click += new System.EventHandler(this.btnAbandonarP2_Click);
            // 
            // timerTurno
            // 
            this.timerTurno.Interval = 1000;
            this.timerTurno.Tick += new System.EventHandler(this.timerTurno_Tick);
            // 
            // lblVidaP1
            // 
            this.lblVidaP1.AutoSize = true;
            this.lblVidaP1.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVidaP1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaP1.ForeColor = System.Drawing.Color.White;
            this.lblVidaP1.Location = new System.Drawing.Point(82, 29);
            this.lblVidaP1.Name = "lblVidaP1";
            this.lblVidaP1.Size = new System.Drawing.Size(25, 15);
            this.lblVidaP1.TabIndex = 16;
            this.lblVidaP1.Text = "999";
            this.lblVidaP1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVidaP2
            // 
            this.lblVidaP2.AutoSize = true;
            this.lblVidaP2.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVidaP2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaP2.ForeColor = System.Drawing.Color.White;
            this.lblVidaP2.Location = new System.Drawing.Point(615, 29);
            this.lblVidaP2.Name = "lblVidaP2";
            this.lblVidaP2.Size = new System.Drawing.Size(25, 15);
            this.lblVidaP2.TabIndex = 17;
            this.lblVidaP2.Text = "999";
            this.lblVidaP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPowersP1
            // 
            this.panelPowersP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPowersP1.Controls.Add(this.btnTongoP1);
            this.panelPowersP1.Controls.Add(this.btnAtaqueAereoP1);
            this.panelPowersP1.Controls.Add(this.btnPunchlineP1);
            this.panelPowersP1.Controls.Add(this.btnCaballoDeTroyaP1);
            this.panelPowersP1.Controls.Add(this.btnReplicaP1);
            this.panelPowersP1.Controls.Add(this.btnContraLasCuerdasP1);
            this.panelPowersP1.Controls.Add(this.btnUnAlmaPorOtraP1);
            this.panelPowersP1.Controls.Add(this.btnRelevoP1);
            this.panelPowersP1.Controls.Add(this.btnEspadaSagradaP1);
            this.panelPowersP1.Controls.Add(this.btnDuplicarP1);
            this.panelPowersP1.Controls.Add(this.btnIraP1);
            this.panelPowersP1.Controls.Add(this.btnConLaVidaP1);
            this.panelPowersP1.Controls.Add(this.btnMagiaNegraP1);
            this.panelPowersP1.Controls.Add(this.btnIlusionismoP1);
            this.panelPowersP1.Controls.Add(this.btnAbraCadabraP1);
            this.panelPowersP1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPowersP1.Location = new System.Drawing.Point(42, 320);
            this.panelPowersP1.Name = "panelPowersP1";
            this.panelPowersP1.Size = new System.Drawing.Size(200, 76);
            this.panelPowersP1.TabIndex = 18;
            // 
            // btnIlusionismoP1
            // 
            this.btnIlusionismoP1.BackgroundImage = global::Graficas.Properties.Resources.picIlusionismo;
            this.btnIlusionismoP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIlusionismoP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlusionismoP1.Enabled = false;
            this.btnIlusionismoP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlusionismoP1.Location = new System.Drawing.Point(129, 13);
            this.btnIlusionismoP1.Name = "btnIlusionismoP1";
            this.btnIlusionismoP1.Size = new System.Drawing.Size(47, 46);
            this.btnIlusionismoP1.TabIndex = 2;
            this.btnIlusionismoP1.UseVisualStyleBackColor = true;
            this.btnIlusionismoP1.Visible = false;
            this.btnIlusionismoP1.Click += new System.EventHandler(this.btnIlusionismoP1_Click);
            this.btnIlusionismoP1.MouseHover += new System.EventHandler(this.btnIlusionismoP1_MouseHover);
            // 
            // btnAbraCadabraP1
            // 
            this.btnAbraCadabraP1.BackgroundImage = global::Graficas.Properties.Resources.picAbraCadabra;
            this.btnAbraCadabraP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbraCadabraP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbraCadabraP1.Enabled = false;
            this.btnAbraCadabraP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbraCadabraP1.Location = new System.Drawing.Point(76, 13);
            this.btnAbraCadabraP1.Name = "btnAbraCadabraP1";
            this.btnAbraCadabraP1.Size = new System.Drawing.Size(47, 46);
            this.btnAbraCadabraP1.TabIndex = 1;
            this.btnAbraCadabraP1.UseVisualStyleBackColor = true;
            this.btnAbraCadabraP1.Visible = false;
            this.btnAbraCadabraP1.Click += new System.EventHandler(this.btnAbraCadabraP1_Click);
            this.btnAbraCadabraP1.MouseHover += new System.EventHandler(this.btnAbraCadabraP1_MouseHover);
            // 
            // btnMagiaNegraP1
            // 
            this.btnMagiaNegraP1.BackgroundImage = global::Graficas.Properties.Resources.picMagiaNegra;
            this.btnMagiaNegraP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagiaNegraP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagiaNegraP1.Enabled = false;
            this.btnMagiaNegraP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMagiaNegraP1.Location = new System.Drawing.Point(23, 13);
            this.btnMagiaNegraP1.Name = "btnMagiaNegraP1";
            this.btnMagiaNegraP1.Size = new System.Drawing.Size(47, 46);
            this.btnMagiaNegraP1.TabIndex = 0;
            this.btnMagiaNegraP1.UseVisualStyleBackColor = true;
            this.btnMagiaNegraP1.Visible = false;
            this.btnMagiaNegraP1.Click += new System.EventHandler(this.btnMagiaNegraP1_Click);
            this.btnMagiaNegraP1.MouseHover += new System.EventHandler(this.btnMagiaNegraP1_MouseHover);
            // 
            // btnUnAlmaPorOtraP1
            // 
            this.btnUnAlmaPorOtraP1.BackgroundImage = global::Graficas.Properties.Resources.picUnAlmaPorOtra;
            this.btnUnAlmaPorOtraP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnAlmaPorOtraP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnAlmaPorOtraP1.Enabled = false;
            this.btnUnAlmaPorOtraP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnAlmaPorOtraP1.Location = new System.Drawing.Point(129, 14);
            this.btnUnAlmaPorOtraP1.Name = "btnUnAlmaPorOtraP1";
            this.btnUnAlmaPorOtraP1.Size = new System.Drawing.Size(47, 46);
            this.btnUnAlmaPorOtraP1.TabIndex = 5;
            this.btnUnAlmaPorOtraP1.UseVisualStyleBackColor = true;
            this.btnUnAlmaPorOtraP1.Visible = false;
            this.btnUnAlmaPorOtraP1.Click += new System.EventHandler(this.btnUnAlmaPorOtraP1_Click);
            this.btnUnAlmaPorOtraP1.MouseHover += new System.EventHandler(this.btnUnAlmaPorOtraP1_MouseHover);
            // 
            // btnDuplicarP1
            // 
            this.btnDuplicarP1.BackgroundImage = global::Graficas.Properties.Resources.picDuplicar;
            this.btnDuplicarP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuplicarP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuplicarP1.Enabled = false;
            this.btnDuplicarP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplicarP1.Location = new System.Drawing.Point(76, 14);
            this.btnDuplicarP1.Name = "btnDuplicarP1";
            this.btnDuplicarP1.Size = new System.Drawing.Size(47, 46);
            this.btnDuplicarP1.TabIndex = 4;
            this.btnDuplicarP1.UseVisualStyleBackColor = true;
            this.btnDuplicarP1.Visible = false;
            this.btnDuplicarP1.Click += new System.EventHandler(this.btnDuplicarP1_Click);
            this.btnDuplicarP1.MouseHover += new System.EventHandler(this.btnDuplicarP1_MouseHover);
            // 
            // btnConLaVidaP1
            // 
            this.btnConLaVidaP1.BackgroundImage = global::Graficas.Properties.Resources.picConLaVida;
            this.btnConLaVidaP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConLaVidaP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConLaVidaP1.Enabled = false;
            this.btnConLaVidaP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConLaVidaP1.Location = new System.Drawing.Point(23, 14);
            this.btnConLaVidaP1.Name = "btnConLaVidaP1";
            this.btnConLaVidaP1.Size = new System.Drawing.Size(47, 46);
            this.btnConLaVidaP1.TabIndex = 3;
            this.btnConLaVidaP1.UseVisualStyleBackColor = true;
            this.btnConLaVidaP1.Visible = false;
            this.btnConLaVidaP1.Click += new System.EventHandler(this.btnConLaVidaP1_Click);
            this.btnConLaVidaP1.MouseHover += new System.EventHandler(this.btnConLaVidaP1_MouseHover);
            // 
            // btnTongoP1
            // 
            this.btnTongoP1.BackgroundImage = global::Graficas.Properties.Resources.picTongo;
            this.btnTongoP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTongoP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongoP1.Enabled = false;
            this.btnTongoP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTongoP1.Location = new System.Drawing.Point(129, 13);
            this.btnTongoP1.Name = "btnTongoP1";
            this.btnTongoP1.Size = new System.Drawing.Size(47, 47);
            this.btnTongoP1.TabIndex = 14;
            this.btnTongoP1.UseVisualStyleBackColor = true;
            this.btnTongoP1.Visible = false;
            this.btnTongoP1.Click += new System.EventHandler(this.btnTongoP1_Click);
            this.btnTongoP1.MouseHover += new System.EventHandler(this.btnTongoP1_MouseHover);
            // 
            // btnPunchlineP1
            // 
            this.btnPunchlineP1.BackgroundImage = global::Graficas.Properties.Resources.picPunchline;
            this.btnPunchlineP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPunchlineP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunchlineP1.Enabled = false;
            this.btnPunchlineP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunchlineP1.Location = new System.Drawing.Point(23, 13);
            this.btnPunchlineP1.Name = "btnPunchlineP1";
            this.btnPunchlineP1.Size = new System.Drawing.Size(47, 47);
            this.btnPunchlineP1.TabIndex = 12;
            this.btnPunchlineP1.UseVisualStyleBackColor = true;
            this.btnPunchlineP1.Visible = false;
            this.btnPunchlineP1.Click += new System.EventHandler(this.btnPunchlineP1_Click);
            this.btnPunchlineP1.MouseHover += new System.EventHandler(this.btnPunchlineP1_MouseHover);
            // 
            // btnAtaqueAereoP1
            // 
            this.btnAtaqueAereoP1.BackgroundImage = global::Graficas.Properties.Resources.picAtaqueAereo;
            this.btnAtaqueAereoP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtaqueAereoP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtaqueAereoP1.Enabled = false;
            this.btnAtaqueAereoP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaqueAereoP1.Location = new System.Drawing.Point(129, 14);
            this.btnAtaqueAereoP1.Name = "btnAtaqueAereoP1";
            this.btnAtaqueAereoP1.Size = new System.Drawing.Size(47, 46);
            this.btnAtaqueAereoP1.TabIndex = 11;
            this.btnAtaqueAereoP1.UseVisualStyleBackColor = true;
            this.btnAtaqueAereoP1.Visible = false;
            this.btnAtaqueAereoP1.Click += new System.EventHandler(this.btnAtaqueAereoP1_Click);
            this.btnAtaqueAereoP1.MouseHover += new System.EventHandler(this.btnAtaqueAereoP1_MouseHover);
            // 
            // btnReplicaP1
            // 
            this.btnReplicaP1.BackgroundImage = global::Graficas.Properties.Resources.picReplica;
            this.btnReplicaP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReplicaP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplicaP1.Enabled = false;
            this.btnReplicaP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplicaP1.Location = new System.Drawing.Point(76, 13);
            this.btnReplicaP1.Name = "btnReplicaP1";
            this.btnReplicaP1.Size = new System.Drawing.Size(47, 47);
            this.btnReplicaP1.TabIndex = 13;
            this.btnReplicaP1.UseVisualStyleBackColor = true;
            this.btnReplicaP1.Visible = false;
            this.btnReplicaP1.Click += new System.EventHandler(this.btnReplicaP1_Click);
            this.btnReplicaP1.MouseHover += new System.EventHandler(this.btnReplicaP1_MouseHover);
            // 
            // btnContraLasCuerdasP1
            // 
            this.btnContraLasCuerdasP1.BackgroundImage = global::Graficas.Properties.Resources.picContraLasCuerdas;
            this.btnContraLasCuerdasP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContraLasCuerdasP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraLasCuerdasP1.Enabled = false;
            this.btnContraLasCuerdasP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContraLasCuerdasP1.Location = new System.Drawing.Point(76, 13);
            this.btnContraLasCuerdasP1.Name = "btnContraLasCuerdasP1";
            this.btnContraLasCuerdasP1.Size = new System.Drawing.Size(47, 46);
            this.btnContraLasCuerdasP1.TabIndex = 10;
            this.btnContraLasCuerdasP1.UseVisualStyleBackColor = true;
            this.btnContraLasCuerdasP1.Visible = false;
            this.btnContraLasCuerdasP1.Click += new System.EventHandler(this.btnContraLasCuerdasP1_Click);
            this.btnContraLasCuerdasP1.MouseHover += new System.EventHandler(this.btnContraLasCuerdasP1_MouseHover);
            // 
            // btnRelevoP1
            // 
            this.btnRelevoP1.BackgroundImage = global::Graficas.Properties.Resources.picRelevo;
            this.btnRelevoP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelevoP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelevoP1.Enabled = false;
            this.btnRelevoP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelevoP1.Location = new System.Drawing.Point(23, 13);
            this.btnRelevoP1.Name = "btnRelevoP1";
            this.btnRelevoP1.Size = new System.Drawing.Size(47, 46);
            this.btnRelevoP1.TabIndex = 9;
            this.btnRelevoP1.UseVisualStyleBackColor = true;
            this.btnRelevoP1.Visible = false;
            this.btnRelevoP1.Click += new System.EventHandler(this.btnRelevoP1_Click);
            this.btnRelevoP1.MouseHover += new System.EventHandler(this.btnRelevoP1_MouseHover);
            // 
            // btnCaballoDeTroyaP1
            // 
            this.btnCaballoDeTroyaP1.BackgroundImage = global::Graficas.Properties.Resources.picCaballoDeTroya;
            this.btnCaballoDeTroyaP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaballoDeTroyaP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaballoDeTroyaP1.Enabled = false;
            this.btnCaballoDeTroyaP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaballoDeTroyaP1.Location = new System.Drawing.Point(129, 14);
            this.btnCaballoDeTroyaP1.Name = "btnCaballoDeTroyaP1";
            this.btnCaballoDeTroyaP1.Size = new System.Drawing.Size(47, 46);
            this.btnCaballoDeTroyaP1.TabIndex = 8;
            this.btnCaballoDeTroyaP1.UseVisualStyleBackColor = true;
            this.btnCaballoDeTroyaP1.Visible = false;
            this.btnCaballoDeTroyaP1.Click += new System.EventHandler(this.btnCaballoDeTroyaP1_Click);
            this.btnCaballoDeTroyaP1.MouseHover += new System.EventHandler(this.btnCaballoDeTroyaP1_MouseHover);
            // 
            // btnEspadaSagradaP1
            // 
            this.btnEspadaSagradaP1.BackgroundImage = global::Graficas.Properties.Resources.picEspadaSagrada;
            this.btnEspadaSagradaP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspadaSagradaP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspadaSagradaP1.Enabled = false;
            this.btnEspadaSagradaP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEspadaSagradaP1.Location = new System.Drawing.Point(76, 13);
            this.btnEspadaSagradaP1.Name = "btnEspadaSagradaP1";
            this.btnEspadaSagradaP1.Size = new System.Drawing.Size(47, 46);
            this.btnEspadaSagradaP1.TabIndex = 7;
            this.btnEspadaSagradaP1.UseVisualStyleBackColor = true;
            this.btnEspadaSagradaP1.Visible = false;
            this.btnEspadaSagradaP1.Click += new System.EventHandler(this.btnEspadaSagradaP1_Click);
            this.btnEspadaSagradaP1.MouseHover += new System.EventHandler(this.btnEspadaSagradaP1_MouseHover);
            // 
            // btnIraP1
            // 
            this.btnIraP1.BackgroundImage = global::Graficas.Properties.Resources.picIra;
            this.btnIraP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIraP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIraP1.Enabled = false;
            this.btnIraP1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIraP1.Location = new System.Drawing.Point(23, 13);
            this.btnIraP1.Name = "btnIraP1";
            this.btnIraP1.Size = new System.Drawing.Size(47, 46);
            this.btnIraP1.TabIndex = 6;
            this.btnIraP1.UseVisualStyleBackColor = true;
            this.btnIraP1.Visible = false;
            this.btnIraP1.Click += new System.EventHandler(this.btnIraP1_Click);
            this.btnIraP1.MouseHover += new System.EventHandler(this.btnIraP1_MouseHover);
            // 
            // panelPowersP2
            // 
            this.panelPowersP2.BackColor = System.Drawing.Color.Gray;
            this.panelPowersP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPowersP2.Controls.Add(this.btnTongoP2);
            this.panelPowersP2.Controls.Add(this.btnReplicaP2);
            this.panelPowersP2.Controls.Add(this.btnPunchlineP2);
            this.panelPowersP2.Controls.Add(this.btnAtaqueAereoP2);
            this.panelPowersP2.Controls.Add(this.btnContraLasCuerdasP2);
            this.panelPowersP2.Controls.Add(this.btnCaballoDeTroyaP2);
            this.panelPowersP2.Controls.Add(this.btnRelevoP2);
            this.panelPowersP2.Controls.Add(this.btnUnAlmaPorOtraP2);
            this.panelPowersP2.Controls.Add(this.btnEspadaSagradaP2);
            this.panelPowersP2.Controls.Add(this.btnDuplicarP2);
            this.panelPowersP2.Controls.Add(this.btnIraP2);
            this.panelPowersP2.Controls.Add(this.btnConLaVidaP2);
            this.panelPowersP2.Controls.Add(this.btnAbraCadabraP2);
            this.panelPowersP2.Controls.Add(this.btnIlusionismoP2);
            this.panelPowersP2.Controls.Add(this.btnMagiaNegraP2);
            this.panelPowersP2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPowersP2.Enabled = false;
            this.panelPowersP2.Location = new System.Drawing.Point(481, 317);
            this.panelPowersP2.Name = "panelPowersP2";
            this.panelPowersP2.Size = new System.Drawing.Size(200, 83);
            this.panelPowersP2.TabIndex = 19;
            // 
            // btnMagiaNegraP2
            // 
            this.btnMagiaNegraP2.BackgroundImage = global::Graficas.Properties.Resources.picMagiaNegra;
            this.btnMagiaNegraP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagiaNegraP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagiaNegraP2.Enabled = false;
            this.btnMagiaNegraP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMagiaNegraP2.Location = new System.Drawing.Point(19, 17);
            this.btnMagiaNegraP2.Name = "btnMagiaNegraP2";
            this.btnMagiaNegraP2.Size = new System.Drawing.Size(47, 46);
            this.btnMagiaNegraP2.TabIndex = 0;
            this.btnMagiaNegraP2.UseVisualStyleBackColor = true;
            this.btnMagiaNegraP2.Visible = false;
            this.btnMagiaNegraP2.Click += new System.EventHandler(this.btnMagiaNegraP2_Click);
            this.btnMagiaNegraP2.MouseHover += new System.EventHandler(this.btnMagiaNegraP2_MouseHover);
            // 
            // btnAbraCadabraP2
            // 
            this.btnAbraCadabraP2.BackgroundImage = global::Graficas.Properties.Resources.picAbraCadabra;
            this.btnAbraCadabraP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbraCadabraP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbraCadabraP2.Enabled = false;
            this.btnAbraCadabraP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbraCadabraP2.Location = new System.Drawing.Point(72, 18);
            this.btnAbraCadabraP2.Name = "btnAbraCadabraP2";
            this.btnAbraCadabraP2.Size = new System.Drawing.Size(47, 46);
            this.btnAbraCadabraP2.TabIndex = 1;
            this.btnAbraCadabraP2.UseVisualStyleBackColor = true;
            this.btnAbraCadabraP2.Visible = false;
            this.btnAbraCadabraP2.Click += new System.EventHandler(this.btnAbraCadabraP2_Click);
            this.btnAbraCadabraP2.MouseHover += new System.EventHandler(this.btnAbraCadabraP2_MouseHover);
            // 
            // btnIlusionismoP2
            // 
            this.btnIlusionismoP2.BackgroundImage = global::Graficas.Properties.Resources.picIlusionismo;
            this.btnIlusionismoP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIlusionismoP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlusionismoP2.Enabled = false;
            this.btnIlusionismoP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlusionismoP2.Location = new System.Drawing.Point(125, 18);
            this.btnIlusionismoP2.Name = "btnIlusionismoP2";
            this.btnIlusionismoP2.Size = new System.Drawing.Size(47, 46);
            this.btnIlusionismoP2.TabIndex = 2;
            this.btnIlusionismoP2.UseVisualStyleBackColor = true;
            this.btnIlusionismoP2.Visible = false;
            this.btnIlusionismoP2.Click += new System.EventHandler(this.btnIlusionismoP2_Click);
            this.btnIlusionismoP2.MouseHover += new System.EventHandler(this.btnIlusionismoP2_MouseHover);
            // 
            // btnUnAlmaPorOtraP2
            // 
            this.btnUnAlmaPorOtraP2.BackgroundImage = global::Graficas.Properties.Resources.picUnAlmaPorOtra;
            this.btnUnAlmaPorOtraP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnAlmaPorOtraP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnAlmaPorOtraP2.Enabled = false;
            this.btnUnAlmaPorOtraP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnAlmaPorOtraP2.Location = new System.Drawing.Point(125, 17);
            this.btnUnAlmaPorOtraP2.Name = "btnUnAlmaPorOtraP2";
            this.btnUnAlmaPorOtraP2.Size = new System.Drawing.Size(47, 46);
            this.btnUnAlmaPorOtraP2.TabIndex = 5;
            this.btnUnAlmaPorOtraP2.UseVisualStyleBackColor = true;
            this.btnUnAlmaPorOtraP2.Visible = false;
            this.btnUnAlmaPorOtraP2.Click += new System.EventHandler(this.btnUnAlmaPorOtraP2_Click);
            this.btnUnAlmaPorOtraP2.MouseHover += new System.EventHandler(this.btnUnAlmaPorOtraP2_MouseHover);
            // 
            // btnDuplicarP2
            // 
            this.btnDuplicarP2.BackgroundImage = global::Graficas.Properties.Resources.picDuplicar;
            this.btnDuplicarP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuplicarP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuplicarP2.Enabled = false;
            this.btnDuplicarP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplicarP2.Location = new System.Drawing.Point(72, 17);
            this.btnDuplicarP2.Name = "btnDuplicarP2";
            this.btnDuplicarP2.Size = new System.Drawing.Size(47, 46);
            this.btnDuplicarP2.TabIndex = 4;
            this.btnDuplicarP2.UseVisualStyleBackColor = true;
            this.btnDuplicarP2.Visible = false;
            this.btnDuplicarP2.Click += new System.EventHandler(this.btnDuplicarP2_Click);
            this.btnDuplicarP2.MouseHover += new System.EventHandler(this.btnDuplicarP2_MouseHover);
            // 
            // btnConLaVidaP2
            // 
            this.btnConLaVidaP2.BackgroundImage = global::Graficas.Properties.Resources.picConLaVida;
            this.btnConLaVidaP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConLaVidaP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConLaVidaP2.Enabled = false;
            this.btnConLaVidaP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConLaVidaP2.Location = new System.Drawing.Point(19, 17);
            this.btnConLaVidaP2.Name = "btnConLaVidaP2";
            this.btnConLaVidaP2.Size = new System.Drawing.Size(47, 46);
            this.btnConLaVidaP2.TabIndex = 3;
            this.btnConLaVidaP2.UseVisualStyleBackColor = true;
            this.btnConLaVidaP2.Visible = false;
            this.btnConLaVidaP2.Click += new System.EventHandler(this.btnConLaVidaP2_Click);
            this.btnConLaVidaP2.MouseHover += new System.EventHandler(this.btnConLaVidaP2_MouseHover);
            // 
            // btnTongoP2
            // 
            this.btnTongoP2.BackgroundImage = global::Graficas.Properties.Resources.picTongo;
            this.btnTongoP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTongoP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongoP2.Enabled = false;
            this.btnTongoP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTongoP2.Location = new System.Drawing.Point(125, 17);
            this.btnTongoP2.Name = "btnTongoP2";
            this.btnTongoP2.Size = new System.Drawing.Size(47, 48);
            this.btnTongoP2.TabIndex = 14;
            this.btnTongoP2.UseVisualStyleBackColor = true;
            this.btnTongoP2.Visible = false;
            this.btnTongoP2.Click += new System.EventHandler(this.btnTongoP2_Click);
            this.btnTongoP2.MouseHover += new System.EventHandler(this.btnTongoP2_MouseHover);
            // 
            // btnReplicaP2
            // 
            this.btnReplicaP2.BackgroundImage = global::Graficas.Properties.Resources.picReplica;
            this.btnReplicaP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReplicaP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplicaP2.Enabled = false;
            this.btnReplicaP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplicaP2.Location = new System.Drawing.Point(72, 17);
            this.btnReplicaP2.Name = "btnReplicaP2";
            this.btnReplicaP2.Size = new System.Drawing.Size(47, 47);
            this.btnReplicaP2.TabIndex = 13;
            this.btnReplicaP2.UseVisualStyleBackColor = true;
            this.btnReplicaP2.Visible = false;
            this.btnReplicaP2.Click += new System.EventHandler(this.btnReplicaP2_Click);
            this.btnReplicaP2.MouseHover += new System.EventHandler(this.btnReplicaP2_MouseHover);
            // 
            // btnPunchlineP2
            // 
            this.btnPunchlineP2.BackgroundImage = global::Graficas.Properties.Resources.picPunchline;
            this.btnPunchlineP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPunchlineP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunchlineP2.Enabled = false;
            this.btnPunchlineP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunchlineP2.Location = new System.Drawing.Point(19, 17);
            this.btnPunchlineP2.Name = "btnPunchlineP2";
            this.btnPunchlineP2.Size = new System.Drawing.Size(47, 47);
            this.btnPunchlineP2.TabIndex = 12;
            this.btnPunchlineP2.UseVisualStyleBackColor = true;
            this.btnPunchlineP2.Visible = false;
            this.btnPunchlineP2.Click += new System.EventHandler(this.btnPunchlineP2_Click);
            this.btnPunchlineP2.MouseHover += new System.EventHandler(this.btnPunchlineP2_MouseHover);
            // 
            // btnAtaqueAereoP2
            // 
            this.btnAtaqueAereoP2.BackgroundImage = global::Graficas.Properties.Resources.picAtaqueAereo;
            this.btnAtaqueAereoP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtaqueAereoP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtaqueAereoP2.Enabled = false;
            this.btnAtaqueAereoP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaqueAereoP2.Location = new System.Drawing.Point(125, 19);
            this.btnAtaqueAereoP2.Name = "btnAtaqueAereoP2";
            this.btnAtaqueAereoP2.Size = new System.Drawing.Size(47, 46);
            this.btnAtaqueAereoP2.TabIndex = 11;
            this.btnAtaqueAereoP2.UseVisualStyleBackColor = true;
            this.btnAtaqueAereoP2.Visible = false;
            this.btnAtaqueAereoP2.Click += new System.EventHandler(this.btnAtaqueAereoP2_Click);
            this.btnAtaqueAereoP2.MouseHover += new System.EventHandler(this.btnAtaqueAereoP2_MouseHover);
            // 
            // btnContraLasCuerdasP2
            // 
            this.btnContraLasCuerdasP2.BackgroundImage = global::Graficas.Properties.Resources.picContraLasCuerdas;
            this.btnContraLasCuerdasP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContraLasCuerdasP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraLasCuerdasP2.Enabled = false;
            this.btnContraLasCuerdasP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContraLasCuerdasP2.Location = new System.Drawing.Point(72, 19);
            this.btnContraLasCuerdasP2.Name = "btnContraLasCuerdasP2";
            this.btnContraLasCuerdasP2.Size = new System.Drawing.Size(47, 46);
            this.btnContraLasCuerdasP2.TabIndex = 10;
            this.btnContraLasCuerdasP2.UseVisualStyleBackColor = true;
            this.btnContraLasCuerdasP2.Visible = false;
            this.btnContraLasCuerdasP2.Click += new System.EventHandler(this.btnContraLasCuerdasP2_Click);
            this.btnContraLasCuerdasP2.MouseHover += new System.EventHandler(this.btnContraLasCuerdasP2_MouseHover);
            // 
            // btnRelevoP2
            // 
            this.btnRelevoP2.BackgroundImage = global::Graficas.Properties.Resources.picRelevo;
            this.btnRelevoP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelevoP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelevoP2.Enabled = false;
            this.btnRelevoP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelevoP2.Location = new System.Drawing.Point(19, 19);
            this.btnRelevoP2.Name = "btnRelevoP2";
            this.btnRelevoP2.Size = new System.Drawing.Size(47, 46);
            this.btnRelevoP2.TabIndex = 9;
            this.btnRelevoP2.UseVisualStyleBackColor = true;
            this.btnRelevoP2.Visible = false;
            this.btnRelevoP2.Click += new System.EventHandler(this.btnRelevoP2_Click);
            this.btnRelevoP2.MouseHover += new System.EventHandler(this.btnRelevoP2_MouseHover);
            // 
            // btnCaballoDeTroyaP2
            // 
            this.btnCaballoDeTroyaP2.BackgroundImage = global::Graficas.Properties.Resources.picCaballoDeTroya;
            this.btnCaballoDeTroyaP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaballoDeTroyaP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaballoDeTroyaP2.Enabled = false;
            this.btnCaballoDeTroyaP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaballoDeTroyaP2.Location = new System.Drawing.Point(125, 18);
            this.btnCaballoDeTroyaP2.Name = "btnCaballoDeTroyaP2";
            this.btnCaballoDeTroyaP2.Size = new System.Drawing.Size(47, 46);
            this.btnCaballoDeTroyaP2.TabIndex = 8;
            this.btnCaballoDeTroyaP2.UseVisualStyleBackColor = true;
            this.btnCaballoDeTroyaP2.Visible = false;
            this.btnCaballoDeTroyaP2.Click += new System.EventHandler(this.btnCaballoDeTroyaP2_Click);
            this.btnCaballoDeTroyaP2.MouseHover += new System.EventHandler(this.btnCaballoDeTroyaP2_MouseHover);
            // 
            // btnEspadaSagradaP2
            // 
            this.btnEspadaSagradaP2.BackgroundImage = global::Graficas.Properties.Resources.picEspadaSagrada;
            this.btnEspadaSagradaP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspadaSagradaP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspadaSagradaP2.Enabled = false;
            this.btnEspadaSagradaP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEspadaSagradaP2.Location = new System.Drawing.Point(72, 17);
            this.btnEspadaSagradaP2.Name = "btnEspadaSagradaP2";
            this.btnEspadaSagradaP2.Size = new System.Drawing.Size(47, 46);
            this.btnEspadaSagradaP2.TabIndex = 7;
            this.btnEspadaSagradaP2.UseVisualStyleBackColor = true;
            this.btnEspadaSagradaP2.Visible = false;
            this.btnEspadaSagradaP2.Click += new System.EventHandler(this.btnEspadaSagradaP2_Click);
            this.btnEspadaSagradaP2.MouseHover += new System.EventHandler(this.btnEspadaSagradaP2_MouseHover);
            // 
            // btnIraP2
            // 
            this.btnIraP2.BackgroundImage = global::Graficas.Properties.Resources.picIra;
            this.btnIraP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIraP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIraP2.Enabled = false;
            this.btnIraP2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIraP2.Location = new System.Drawing.Point(19, 17);
            this.btnIraP2.Name = "btnIraP2";
            this.btnIraP2.Size = new System.Drawing.Size(47, 46);
            this.btnIraP2.TabIndex = 6;
            this.btnIraP2.UseVisualStyleBackColor = true;
            this.btnIraP2.Visible = false;
            this.btnIraP2.Click += new System.EventHandler(this.btnIraP2_Click);
            this.btnIraP2.MouseHover += new System.EventHandler(this.btnIraP2_MouseHover);
            // 
            // lblBatalla
            // 
            this.lblBatalla.BackColor = System.Drawing.Color.Transparent;
            this.lblBatalla.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatalla.ForeColor = System.Drawing.Color.White;
            this.lblBatalla.Location = new System.Drawing.Point(269, 29);
            this.lblBatalla.Name = "lblBatalla";
            this.lblBatalla.Size = new System.Drawing.Size(189, 66);
            this.lblBatalla.TabIndex = 20;
            this.lblBatalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Probando";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Punchline";
            // 
            // formBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Graficas.Properties.Resources.background_Battle21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 489);
            this.ControlBox = false;
            this.Controls.Add(this.lblBatalla);
            this.Controls.Add(this.panelPowersP2);
            this.Controls.Add(this.panelPowersP1);
            this.Controls.Add(this.lblVidaP2);
            this.Controls.Add(this.lblVidaP1);
            this.Controls.Add(this.btnAbandonarP2);
            this.Controls.Add(this.btnAbandonarP1);
            this.Controls.Add(this.lblNickP2);
            this.Controls.Add(this.lblNickP1);
            this.Controls.Add(this.pbVidaP2);
            this.Controls.Add(this.pbVidaP1);
            this.Controls.Add(this.imgboxP2);
            this.Controls.Add(this.imgboxP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BATTLE!";
            this.Load += new System.EventHandler(this.formBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP2)).EndInit();
            this.panelPowersP1.ResumeLayout(false);
            this.panelPowersP2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgboxP1;
        private System.Windows.Forms.ProgressBar pbVidaP1;
        private System.Windows.Forms.PictureBox imgboxP2;
        private System.Windows.Forms.ProgressBar pbVidaP2;
        private System.Windows.Forms.Label lblNickP1;
        private System.Windows.Forms.Label lblNickP2;
        private System.Windows.Forms.Button btnAbandonarP1;
        private System.Windows.Forms.Button btnAbandonarP2;
        private System.Windows.Forms.Timer timerTurno;
        private System.Windows.Forms.Label lblVidaP1;
        private System.Windows.Forms.Label lblVidaP2;
        private System.Windows.Forms.Panel panelPowersP1;
        private System.Windows.Forms.Button btnTongoP1;
        private System.Windows.Forms.Button btnReplicaP1;
        private System.Windows.Forms.Button btnPunchlineP1;
        private System.Windows.Forms.Button btnAtaqueAereoP1;
        private System.Windows.Forms.Button btnContraLasCuerdasP1;
        private System.Windows.Forms.Button btnRelevoP1;
        private System.Windows.Forms.Button btnCaballoDeTroyaP1;
        private System.Windows.Forms.Button btnEspadaSagradaP1;
        private System.Windows.Forms.Button btnIraP1;
        private System.Windows.Forms.Button btnUnAlmaPorOtraP1;
        private System.Windows.Forms.Button btnDuplicarP1;
        private System.Windows.Forms.Button btnConLaVidaP1;
        private System.Windows.Forms.Button btnIlusionismoP1;
        private System.Windows.Forms.Button btnAbraCadabraP1;
        private System.Windows.Forms.Button btnMagiaNegraP1;
        private System.Windows.Forms.Panel panelPowersP2;
        private System.Windows.Forms.Button btnTongoP2;
        private System.Windows.Forms.Button btnReplicaP2;
        private System.Windows.Forms.Button btnPunchlineP2;
        private System.Windows.Forms.Button btnAtaqueAereoP2;
        private System.Windows.Forms.Button btnContraLasCuerdasP2;
        private System.Windows.Forms.Button btnRelevoP2;
        private System.Windows.Forms.Button btnCaballoDeTroyaP2;
        private System.Windows.Forms.Button btnEspadaSagradaP2;
        private System.Windows.Forms.Button btnIraP2;
        private System.Windows.Forms.Button btnUnAlmaPorOtraP2;
        private System.Windows.Forms.Button btnDuplicarP2;
        private System.Windows.Forms.Button btnConLaVidaP2;
        private System.Windows.Forms.Button btnIlusionismoP2;
        private System.Windows.Forms.Button btnAbraCadabraP2;
        private System.Windows.Forms.Button btnMagiaNegraP2;
        private System.Windows.Forms.Label lblBatalla;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}