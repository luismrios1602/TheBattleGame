namespace Graficas
{
    partial class formPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPlayerCPU = new System.Windows.Forms.Button();
            this.btnPlayerPlayer = new System.Windows.Forms.Button();
            this.btnCPUCPU = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Old English Text MT", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(32, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(492, 77);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "The Battle Game";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayerCPU
            // 
            this.btnPlayerCPU.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerCPU.BackgroundImage = global::Graficas.Properties.Resources.PVCsinseleccion;
            this.btnPlayerCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerCPU.FlatAppearance.BorderSize = 0;
            this.btnPlayerCPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayerCPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayerCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerCPU.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerCPU.ForeColor = System.Drawing.Color.White;
            this.btnPlayerCPU.Location = new System.Drawing.Point(96, 173);
            this.btnPlayerCPU.Name = "btnPlayerCPU";
            this.btnPlayerCPU.Size = new System.Drawing.Size(174, 84);
            this.btnPlayerCPU.TabIndex = 1;
            this.btnPlayerCPU.UseVisualStyleBackColor = false;
            this.btnPlayerCPU.Click += new System.EventHandler(this.btnPlayerCPU_Click);
            this.btnPlayerCPU.MouseLeave += new System.EventHandler(this.btnPlayerCPU_MouseLeave);
            this.btnPlayerCPU.MouseHover += new System.EventHandler(this.btnPlayerCPU_MouseHover);
            // 
            // btnPlayerPlayer
            // 
            this.btnPlayerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerPlayer.BackgroundImage = global::Graficas.Properties.Resources.PVPsinseleccion;
            this.btnPlayerPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayerPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayerPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayerPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerPlayer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerPlayer.ForeColor = System.Drawing.Color.White;
            this.btnPlayerPlayer.Location = new System.Drawing.Point(327, 177);
            this.btnPlayerPlayer.Name = "btnPlayerPlayer";
            this.btnPlayerPlayer.Size = new System.Drawing.Size(160, 77);
            this.btnPlayerPlayer.TabIndex = 2;
            this.btnPlayerPlayer.UseVisualStyleBackColor = false;
            this.btnPlayerPlayer.Click += new System.EventHandler(this.btnPlayerPlayer_Click);
            this.btnPlayerPlayer.MouseLeave += new System.EventHandler(this.btnPlayerPlayer_MouseLeave);
            this.btnPlayerPlayer.MouseHover += new System.EventHandler(this.btnPlayerPlayer_MouseHover);
            // 
            // btnCPUCPU
            // 
            this.btnCPUCPU.BackColor = System.Drawing.Color.Transparent;
            this.btnCPUCPU.BackgroundImage = global::Graficas.Properties.Resources.CVCsinseleccion;
            this.btnCPUCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCPUCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPUCPU.FlatAppearance.BorderSize = 0;
            this.btnCPUCPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCPUCPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCPUCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPUCPU.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPUCPU.ForeColor = System.Drawing.Color.White;
            this.btnCPUCPU.Location = new System.Drawing.Point(220, 274);
            this.btnCPUCPU.Name = "btnCPUCPU";
            this.btnCPUCPU.Size = new System.Drawing.Size(160, 83);
            this.btnCPUCPU.TabIndex = 3;
            this.btnCPUCPU.UseVisualStyleBackColor = false;
            this.btnCPUCPU.MouseLeave += new System.EventHandler(this.btnCPUCPU_MouseLeave);
            this.btnCPUCPU.MouseHover += new System.EventHandler(this.btnCPUCPU_MouseHover);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(248, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graficas.Properties.Resources.background_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCPUCPU);
            this.Controls.Add(this.btnPlayerPlayer);
            this.Controls.Add(this.btnPlayerCPU);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Battle Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPlayerCPU;
        private System.Windows.Forms.Button btnPlayerPlayer;
        private System.Windows.Forms.Button btnCPUCPU;
        private System.Windows.Forms.Button btnSalir;
    }
}