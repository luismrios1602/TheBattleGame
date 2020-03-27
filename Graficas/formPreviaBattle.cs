using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Combatientes;

namespace Graficas
{
    public partial class formPreviaBattle : Form
    {
        //Creamos una lista en la que vamos a almacenar los combatientes que vienen desde el otro formulario
        public List<Combatiente> lisComba = new List<Combatiente>();

        Combatiente P1, P2;
        formPlayerCPU formP1vsCPU = new formPlayerCPU();
        public int contador=0;

        private void timerCargando_Tick(object sender, EventArgs e)
        {
            

            if (pbCargando.Value==100)
            {

                timerCargando.Stop();
                formBattle ventanaBattle = new formBattle();
                ventanaBattle.lisComba.Add(P1);
                ventanaBattle.lisComba.Add(P2);
                this.Dispose();
                ventanaBattle.ShowDialog();

            } else
            {
                contador++;
                pbCargando.Value = contador;
            }
        }

        private void formPreviaBattle_Load(object sender, EventArgs e)
        {
            P1 = lisComba[0];
            P2 = lisComba[1];
            lblNickP1.Text = P1.nick;
            lblNickP2.Text = P2.nick;
            asignarImagen1(P1);
            asignarImagen2(P2);
            timerCargando.Start();

        }


        public formPreviaBattle()
        {
            InitializeComponent();        
            

        }

        //Método que creamos para que dependiendo el número de la imagen de la raza, escojamos y asignemos
        public void asignarImagen1(Combatiente Player)
        {
            //Método que recibe un combatiente 
            switch (Player.imagen)
            {
                case 1:
                    imgboxP1.Image = Graficas.Properties.Resources.picMago1;
                    break;
                case 2:
                    imgboxP1.Image = Graficas.Properties.Resources.picHada;
                    break;
                case 3:
                    imgboxP1.Image = Graficas.Properties.Resources.picGuerrero;
                    break;
                case 4:
                    imgboxP1.Image = Graficas.Properties.Resources.picLuchador;
                    break;
                case 5:
                    imgboxP1.Image = Graficas.Properties.Resources.picFreestyler;
                    break;
                default:
                    imgboxP1.Image = Graficas.Properties.Resources.picNadie;
                    break;
            }

        }

        public void asignarImagen2(Combatiente Player)
        {
            //Método que recibe un combatiente 
            switch (Player.imagen)
            {
                case 1:
                    imgboxP2.Image = Graficas.Properties.Resources.picMago1;
                    break;
                case 2:
                    imgboxP2.Image = Graficas.Properties.Resources.picHada;
                    break;
                case 3:
                    imgboxP2.Image = Graficas.Properties.Resources.picGuerrero;
                    break;
                case 4:
                    imgboxP2.Image = Graficas.Properties.Resources.picLuchador;
                    break;
                case 5:
                    imgboxP2.Image = Graficas.Properties.Resources.picFreestyler;
                    break;
                default:
                    imgboxP2.Image = Graficas.Properties.Resources.picNadie;
                    break;
            }


        }
    }
}
