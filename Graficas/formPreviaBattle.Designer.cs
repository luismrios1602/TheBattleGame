namespace Graficas
{
    partial class formPreviaBattle
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
            this.imgboxVS = new System.Windows.Forms.PictureBox();
            this.imgboxP2 = new System.Windows.Forms.PictureBox();
            this.lblCargando = new System.Windows.Forms.Label();
            this.pbCargando = new System.Windows.Forms.ProgressBar();
            this.timerCargando = new System.Windows.Forms.Timer(this.components);
            this.lblNickP1 = new System.Windows.Forms.Label();
            this.lblNickP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgboxP1
            // 
            this.imgboxP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgboxP1.Image = global::Graficas.Properties.Resources.picNadie;
            this.imgboxP1.InitialImage = global::Graficas.Properties.Resources.picNadie;
            this.imgboxP1.Location = new System.Drawing.Point(54, 126);
            this.imgboxP1.Name = "imgboxP1";
            this.imgboxP1.Size = new System.Drawing.Size(177, 181);
            this.imgboxP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxP1.TabIndex = 0;
            this.imgboxP1.TabStop = false;
            // 
            // imgboxVS
            // 
            this.imgboxVS.BackColor = System.Drawing.Color.Transparent;
            this.imgboxVS.Image = global::Graficas.Properties.Resources.picVS;
            this.imgboxVS.ImageLocation = "";
            this.imgboxVS.Location = new System.Drawing.Point(237, 173);
            this.imgboxVS.Name = "imgboxVS";
            this.imgboxVS.Size = new System.Drawing.Size(109, 88);
            this.imgboxVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxVS.TabIndex = 1;
            this.imgboxVS.TabStop = false;
            // 
            // imgboxP2
            // 
            this.imgboxP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgboxP2.Image = global::Graficas.Properties.Resources.picNadie;
            this.imgboxP2.Location = new System.Drawing.Point(352, 126);
            this.imgboxP2.Name = "imgboxP2";
            this.imgboxP2.Size = new System.Drawing.Size(177, 181);
            this.imgboxP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboxP2.TabIndex = 2;
            this.imgboxP2.TabStop = false;
            // 
            // lblCargando
            // 
            this.lblCargando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargando.BackColor = System.Drawing.Color.Transparent;
            this.lblCargando.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.White;
            this.lblCargando.Location = new System.Drawing.Point(194, 323);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(189, 28);
            this.lblCargando.TabIndex = 3;
            this.lblCargando.Text = "Cargando...";
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCargando.UseCompatibleTextRendering = true;
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCargando.Location = new System.Drawing.Point(54, 368);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(475, 23);
            this.pbCargando.TabIndex = 4;
            // 
            // timerCargando
            // 
            this.timerCargando.Interval = 50;
            this.timerCargando.Tick += new System.EventHandler(this.timerCargando_Tick);
            // 
            // lblNickP1
            // 
            this.lblNickP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNickP1.BackColor = System.Drawing.Color.Transparent;
            this.lblNickP1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickP1.ForeColor = System.Drawing.Color.White;
            this.lblNickP1.Location = new System.Drawing.Point(54, 82);
            this.lblNickP1.Name = "lblNickP1";
            this.lblNickP1.Size = new System.Drawing.Size(177, 28);
            this.lblNickP1.TabIndex = 5;
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
            this.lblNickP2.Location = new System.Drawing.Point(352, 82);
            this.lblNickP2.Name = "lblNickP2";
            this.lblNickP2.Size = new System.Drawing.Size(177, 28);
            this.lblNickP2.TabIndex = 6;
            this.lblNickP2.Text = "CPU";
            this.lblNickP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNickP2.UseCompatibleTextRendering = true;
            // 
            // formPreviaBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graficas.Properties.Resources.background_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 489);
            this.Controls.Add(this.lblNickP2);
            this.Controls.Add(this.lblNickP1);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.imgboxVS);
            this.Controls.Add(this.imgboxP2);
            this.Controls.Add(this.imgboxP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPreviaBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formPreviaBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxP2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgboxP1;
        private System.Windows.Forms.PictureBox imgboxVS;
        private System.Windows.Forms.PictureBox imgboxP2;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.ProgressBar pbCargando;
        private System.Windows.Forms.Timer timerCargando;
        private System.Windows.Forms.Label lblNickP1;
        private System.Windows.Forms.Label lblNickP2;
    }
}