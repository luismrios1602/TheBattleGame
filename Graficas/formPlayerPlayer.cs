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
    public partial class formPlayerPlayer : Form
    {

        //Instanciamos de forma global los dos objetos que usaremos
        public Combatiente P1;
        public Combatiente P2;

        //Iniciamos el proyecto
        public formPlayerPlayer()
        {
            InitializeComponent();

        }

        //Método creado para darle al label de Player 1 el valor del nick
        public void asignarNickALabel()
        {
            //Si el nick está vacío, que coloque Player 1, sino, que le asigne el nick
            if (txtNickP1.Text.Equals(""))
            {
                lblPlayer1.Text = "Player 1";
            }
            else
            {
                lblPlayer1.Text = txtNickP1.Text;
            }

            //Si el nick está vacío, que coloque Player 2, sino, que le asigne el nick
            if (txtNickP2.Text.Equals(""))
            {
                lblPlayer2.Text = "Player 2";
            }
            else
            {
                lblPlayer2.Text = txtNickP2.Text;
            }

        }


        //Evento que se dispara cuando escogemos la raza del combatiente 1
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
            }
            else
            {
                btnP1Select.Enabled = true;
                btnP1Select.BackColor = Color.LawnGreen;
                btnP1Select.FlatAppearance.BorderColor = Color.LawnGreen;
                asignarImagen(P1); //Llamamos al método asignarImagen, enviandole el objeto player 1 y así tomar el número de la imagen que tenga segun su raza

            }
        }

        //Evento que se dispara cuando escogemos la raza del combatiente 1
        private void cbRazaP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Revisamos la raza escogida y en base a eso instanciamos el objeto.
            if (cbRazaP2.Text.Equals("Mago"))
            {
                P2 = new Mago(lblPlayer2.Text, "P2", cbRazaP2.Text);
            }
            else if (cbRazaP2.Text.Equals("Hada"))
            {
                P2 = new Hada(lblPlayer2.Text, "P2", cbRazaP2.Text);
            }
            else if (cbRazaP2.Text.Equals("Guerrero"))
            {
                P2 = new Guerrero(lblPlayer2.Text, "P2", cbRazaP2.Text);
            }
            else if (cbRazaP2.Text.Equals("Luchador"))
            {
                P2 = new Luchador(lblPlayer2.Text, "P2", cbRazaP2.Text);
            }
            else if (cbRazaP2.Text.Equals("Freestyler"))
            {
                P2 = new Freestyler(lblPlayer2.Text, "P2", cbRazaP2.Text);
            }
            else
            {
                P2 = new Combatiente();
            }

            pbAtaqueP2.Value = P2.ataque;
            pbDefensaP2.Value = P2.defensa;
            pbSuerteP2.Value = P2.suerte;

            //El no hay un valor en la raza, entonces que deshabilite todos los botones
            if (String.IsNullOrEmpty(cbRazaP2.Text))
            {
                btnP2Select.Enabled = false;
                btnP2Select.BackColor = Color.Gray;
                btnP2Select.FlatAppearance.BorderColor = Color.Gray;
                imgboxP2.Image = Graficas.Properties.Resources.picNadie;
            }
            else
            {
                btnP2Select.Enabled = true;
                btnP2Select.BackColor = Color.LawnGreen;
                btnP2Select.FlatAppearance.BorderColor = Color.LawnGreen;
                asignarImagen(P2); //Llamamos al método asignarImagen, enviandole el objeto player 1 y así tomar el número de la imagen que tenga segun su raza

            }
        }

        //Método que creamos para que dependiendo el número de la imagen de la raza, escojamos y asignemos
        public void asignarImagen(Combatiente Player)
        {
            //Método que recibe un combatiente y define si es desde P2 o desde PLAYER
            switch (Player.imagen)
            {
                case 1:
                    if (Player.tipoPlayer.Equals("P2"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picMago1;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picMago1;
                    }
                    break;
                case 2:
                    if (Player.tipoPlayer.Equals("P2"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picHada;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picHada;
                    }
                    break;
                case 3:
                    if (Player.tipoPlayer.Equals("P2"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    break;
                case 4:
                    if (Player.tipoPlayer.Equals("P2"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    break;
                case 5:
                    if (Player.tipoPlayer.Equals("P2"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    break;
                default:
                    if (Player.tipoPlayer.Equals("P2"))
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
            txtNickP2.Enabled = true;
            cbRazaP2.Enabled = true;
            pbAtaqueP2.Enabled = true;
            pbDefensaP2.Enabled = true;
            pbSuerteP2.Enabled = true;

            panelPlayer1.Enabled = false;
            panelPlayer1.BackColor = Color.Gray;

            //Llamamos al método de asignar nick al label anterior.
            asignarNickALabel();

            if (!cbRazaP2.Text.Equals(""))
            {
                btnP2Select.BackColor = Color.Lime;
            }
        }

        private void btnP2Select_Click(object sender, EventArgs e)
        {
            //Habilitando y deshabilitando paneles
            btnBattle.Enabled = true;
            btnBattle.BackColor = Color.LawnGreen;
            panelP2.Enabled = false;
            panelP2.BackColor = Color.Gray;

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

        private void btnBattle_Click(object sender, EventArgs e)
        {
            P1.nick = lblPlayer1.Text;
            P2.nick = lblPlayer2.Text;
            /*Cuando le dé click en "Batallar, llamo el nuevo formulario.
             llamamos una lista que él contiene y en ella almaceno los datos de los dos jugadores antes de abrirlo*/
            formPreviaBattle ventanaPrevia = new formPreviaBattle();
            ventanaPrevia.lisComba.Add(GetCombatiente1()); //Mando los valores de cada jugador a la lista creada en el otro formulario.
            ventanaPrevia.lisComba.Add(GetCombatiente2());
            this.Dispose(); //Cierro este formulario
            ventanaPrevia.ShowDialog();
        }

        public Combatiente GetCombatiente1()
        {

            return P1;
        }

        /*Funciones para mandarle los dos PLAYERS al otro formulario*/
        public Combatiente GetCombatiente2()
        {
            return P2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            formPrincipal ventanaPrincipal = new formPrincipal();
            ventanaPrincipal.ShowDialog();
        }


    }
}