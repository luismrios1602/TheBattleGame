using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficas
{
    public partial class formPrincipal : Form
    {
        formPlayerCPU ventanaPvC = new formPlayerCPU();
        formPlayerPlayer ventanaPvP = new formPlayerPlayer();

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnPlayerCPU_MouseHover(object sender, EventArgs e)
        {
            btnPlayerCPU.BackgroundImage= Graficas.Properties.Resources.PVCseleccion;
        }

        private void btnPlayerCPU_MouseLeave(object sender, EventArgs e)
        {
            btnPlayerCPU.BackgroundImage = Graficas.Properties.Resources.PVCsinseleccion;
        }


        private void btnPlayerPlayer_MouseHover(object sender, EventArgs e)
        {
            btnPlayerPlayer.BackgroundImage = Graficas.Properties.Resources.PVPseleccion;
        }

        private void btnPlayerPlayer_MouseLeave(object sender, EventArgs e)
        {
            btnPlayerPlayer.BackgroundImage = Graficas.Properties.Resources.PVPsinseleccion;
        }

        private void btnCPUCPU_MouseHover(object sender, EventArgs e)
        {
            btnCPUCPU.BackgroundImage = Graficas.Properties.Resources.CVCseleccion;
        }

        private void btnCPUCPU_MouseLeave(object sender, EventArgs e)
        {
            btnCPUCPU.BackgroundImage = Graficas.Properties.Resources.CVCsinseleccion;
        }

        private void btnPlayerCPU_Click(object sender, EventArgs e)
        {
            
            ventanaPvC.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayerPlayer_Click(object sender, EventArgs e)
        {
            ventanaPvP.Show();
            this.Hide();
        }
    }
}
