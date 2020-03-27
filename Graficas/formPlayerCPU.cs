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
    public partial class formPlayerCPU : Form
    {
        
        //Instanciamos de forma global los dos objetos que usaremos
        public Combatiente P1;
        public Combatiente combatienteP2;
        public Combatiente P2;
        int num;

        /*Creamos un enumerador de las razas, para usar su valor a la hora
        cuando vayamos a asignarle un numero aleatorio para el combatiente del P2*/
        public enum razas { Mago = 1, Hada, Guerrero, Luchador, Freestyler };

        //Iniciamos el proyecto
        public formPlayerCPU()
        {
            InitializeComponent();

        }

        //Método creado para darle al label de Player 1 el valor del nick
        public void asignarNickALabel() {
            //Si el nick está vacío, que coloque Player 1, sino, que le asigne el nick
            if (txtNickP1.Text.Equals(""))
            {
                lblPlayer1.Text = "Player 1";
                lblP2.Text = txtNickP2.Text;
                } else
                {
                    lblPlayer1.Text = txtNickP1.Text;
                    lblP2.Text = txtNickP2.Text;
                }
        }

        //Evento que ocurre cuando querramos escoger la raza del combatiente
        private void cbRazaP1_Click(object sender, EventArgs e)
        {
            
        }

        //Evento que se dispara cuando escogemos la raza del combatiente
        private void cbRazaP1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Revisamos la raza escogida y en base a eso instanciamos el objeto.
            if (cbRazaP1.Text.Equals("Mago"))
            {
                P1 = new Mago(lblPlayer1.Text, "P1", cbRazaP1.Text);
            }
            else if (cbRazaP1.Text.Equals("Hada"))
            {
                P1 = new Hada(lblPlayer1.Text, "P1", cbRazaP1.Text);
            }
            else if (cbRazaP1.Text.Equals("Guerrero"))
            {
                P1 = new Guerrero(lblPlayer1.Text, "P1", cbRazaP1.Text);
            }
            else if (cbRazaP1.Text.Equals("Luchador"))
            {
                P1 = new Luchador(lblPlayer1.Text, "P1", cbRazaP1.Text);
            }
            else if (cbRazaP1.Text.Equals("Freestyler"))
            {
                P1 = new Freestyler(lblPlayer1.Text, "P1", cbRazaP1.Text);
            }
            else
            {
                P1 = new Combatiente();
            }

            pbAtaqueP1.Value = P1.ataque;
            pbDefensaP1.Value = P1.defensa;
            pbSuerteP1.Value = P1.suerte;

            //El no hay un valor en la raza, entonces que deshabilite todos los botones
            if (String.IsNullOrEmpty(cbRazaP1.Text))
            {
                btnP1Select.Enabled = false;
                btnP1Select.BackColor = Color.Gray;
                btnP1Select.FlatAppearance.BorderColor = Color.Gray;
                imgboxP1.Image = Graficas.Properties.Resources.picNadie;
            } else
            {
                btnP1Select.Enabled = true;
                btnP1Select.BackColor = Color.LawnGreen;
                btnP1Select.FlatAppearance.BorderColor = Color.LawnGreen;
                asignarImagen(P1); //Llamamos al método asignarImagen, enviandole el objeto player 1 y así tomar el número de la imagen que tenga segun su raza
                
            }
            
            
        }

        //Método que creamos para que dependiendo el número de la imagen de la raza, escojamos y asignemos
        public void asignarImagen(Combatiente Player) {
            //Método que recibe un combatiente y define si es desde P2 o desde PLAYER
            switch (Player.imagen)
            {
                case 1:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picMago1;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picMago1;
                    }
                    break;
                case 2:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picHada;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picHada;
                    }
                    break;
                case 3:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    break;
                case 4:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    break;
                case 5:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    break;
                default:
                    if (Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picNadie;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picNadie;
                    }
                    break;
            }

        }

        /*Una vez escojamos la raza, se habilita el boton de listo en el combatiente del PLAYER 1
        Entonces, cuando se le dé click, se habilita este evento en el que deshabilitamos el panel de PLAYER y habilitamos el de P2*/
        private void btnP1Select_Click(object sender, EventArgs e)
        {
            //Habilitando y deshabilitando paneles
            panelP2.Enabled = true;
            panelP2.BackColor = Color.Gainsboro;
            panelPlayer1.Enabled = false;
            panelPlayer1.BackColor = Color.Gray;
            

            //Usamos el objeto de P2 instanciado
            P2 = asignarP2(); //Llamamos el método que devuelve un objeto de tipo Combatiente, donde al azar, le asignamos valores basados en la enumeracion descrita arriba.

            //Como ya nuevo P2 tiene todos sus valores, se los asignamos a los controles del panel P2
            cbRazaP2.Text = P2.Raza;
            pbAtaqueP2.Value = P2.ataque;
            pbDefensaP2.Value = P2.defensa;
            pbSuerteP2.Value = P2.suerte;

            //Hay un bug en el asignar,así que si me trae la raza vacía, colocamos el botón listo deshabilitado y los valores en 0
            if (String.IsNullOrEmpty(cbRazaP2.Text))
            {
                btnP2Select.Enabled = false;
                btnP2Select.BackColor = Color.Gray;
                btnP2Select.FlatAppearance.BorderColor = Color.Gray;
                imgboxP2.Image = Graficas.Properties.Resources.picNadie;
            }
            else
            {
                //Si sí me manda una raza, que se habilite el botón y le asigne la imagen
                btnP2Select.Enabled = true;
                btnP2Select.BackColor = Color.LawnGreen;
                btnP2Select.FlatAppearance.BorderColor = Color.LawnGreen;
                asignarImagen(P2);

            }

            //Llamamos al método de asignar nick al label anterior.
            asignarNickALabel();

        }

        /*El botón de Cancelar, es para cuando quiero evitar batallar con los ecogidos
        Entonces deja todo como estaba*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelP2.Enabled = false;
            panelP2.BackColor = Color.Gray;
            btnP2Select.BackColor = Color.Gray;
            btnP2Select.FlatAppearance.BorderColor = Color.Gray;
            panelPlayer1.Enabled = true;
            panelPlayer1.BackColor = Color.Gainsboro;
            btnBattle.Enabled = false;
            btnBattle.BackColor = Color.Gray;
        }

        /*La función que creamos para asignarle un combatiente a la P2
         Tiene un bugazo, entonces el ciclo es para que se salga cuando me de un valor válido*/
        public Combatiente asignarP2() {
            Random aleatorio = new Random();

            String razaP2;


            do
            {
                num = aleatorio.Next(5) + 1;
                /*Como sacar el valor de un enumerador en base a un numero*/
                razaP2 = Enum.GetName(typeof(razas), num);

            } while (razaP2==null);

            //Revisamos la raza escogida y en base a eso instanciamos el objeto.
            if (razaP2.Equals("Mago"))
            {
                combatienteP2 = new Mago(lblP2.Text, "CPU", razaP2);
            }
            else if (razaP2.Equals("Hada"))
            {
                combatienteP2 = new Hada(lblP2.Text, "CPU", razaP2);
            }
            else if (razaP2.Equals("Guerrero"))
            {
                combatienteP2 = new Guerrero(lblP2.Text, "CPU", razaP2);
            }
            else if (razaP2.Equals("Luchador"))
            {
                combatienteP2 = new Luchador(lblP2.Text, "CPU", razaP2);
            }
            else if (razaP2.Equals("Freestyler"))
            {
                combatienteP2 = new Freestyler(lblP2.Text, "CPU", razaP2);
            }
            else
            {
                combatienteP2 = new Combatiente();
            }

            return combatienteP2;
        }


        public Combatiente GetCombatiente1()
        {

            return P1;
        }

        /*Funciones para mandarle los dos PLAYERS al otro formulario*/
        public Combatiente GetCombatiente2()
        {
            return combatienteP2;
        }

        private void btnP2Select_Click_1(object sender, EventArgs e)
        {
            
            btnBattle.Enabled = true;
            btnBattle.BackColor = Color.LawnGreen;
            panelP2.Enabled = false;
            panelP2.BackColor = Color.Gray;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            formPrincipal ventanaPrincipal = new formPrincipal();
            ventanaPrincipal.ShowDialog();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            P1.nick = lblPlayer1.Text;
            /*Cuando le dé click en "Batallar, llamo el nuevo formulario.
             llamamos una lista que él contiene y en ella almaceno los datos de los dos jugadores antes de abrirlo*/
            formPreviaBattle ventanaPrevia = new formPreviaBattle();
            ventanaPrevia.lisComba.Add(GetCombatiente1()); //Mando los valores de cada jugador a la lista creada en el otro formulario.
            ventanaPrevia.lisComba.Add(GetCombatiente2());
            this.Dispose(); //Cierro este formulario
            ventanaPrevia.ShowDialog();

        }
    }
}

