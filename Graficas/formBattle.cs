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
    public partial class formBattle : Form
    {
        Combatiente P1,P2; //Instancia de los PLAYERS
        public List<Combatiente> lisComba = new List<Combatiente>(); //Lista para almacenar los combatientes
        formPrincipal ventanaPrincipal = new formPrincipal(); //Instancia de la principal para ir al inicio al final de la batalla
        int seg=0, Poder; //Variable de segundos para manejar el tiempo de ataque de la CPU
        String PoderUsado;
        public formBattle()
        {
            InitializeComponent();
        }

        private void formBattle_Load(object sender, EventArgs e)
        {
            /*Al cargar el formulario de batalla, cargará los players seleccionados previamente a las instancias locales*/ 
            P1 = lisComba[0];
            P2 = lisComba[1];
            asignarImagen(P1);
            asignarImagen(P2);
            pbVidaP1.Value = P1.vida; //Cargando los puntos del vida al ProgressBar
            pbVidaP2.Value = P2.vida;
            lblNickP1.Text = P1.nick; //Mostrando los nicks escogidos
            lblNickP2.Text = P2.nick;
            panelPowersP1.BackColor = Color.Lime;
            panelPowersP2.Enabled = false; //Panel de accion deshabilitado porque empieza el otro
            lblVidaP1.Text = P1.vida.ToString();
            lblVidaP2.Text = P2.vida.ToString();

            //Condicion para habilitar los botones del P1
            switch (P1.imagen)
            {
                case 1:
                    btnMagiaNegraP1.Enabled = true;
                    btnAbraCadabraP1.Enabled = true;
                    btnIlusionismoP1.Enabled = true;
                    btnMagiaNegraP1.Visible = true;
                    btnAbraCadabraP1.Visible = true;
                    btnIlusionismoP1.Visible = true;
                    break;
                case 2:
                    btnConLaVidaP1.Enabled = true;
                    btnDuplicarP1.Enabled = true;
                    btnUnAlmaPorOtraP1.Enabled = true;
                    btnConLaVidaP1.Visible = true;
                    btnDuplicarP1.Visible = true;
                    btnUnAlmaPorOtraP1.Visible = true;
                    break;
                case 3:
                    btnIraP1.Enabled = true;
                    btnEspadaSagradaP1.Enabled = true;
                    btnCaballoDeTroyaP1.Enabled = true;
                    btnIraP1.Visible = true;
                    btnEspadaSagradaP1.Visible = true;
                    btnCaballoDeTroyaP1.Visible = true;
                    break;
                case 4:
                    btnRelevoP1.Enabled = true;
                    btnContraLasCuerdasP1.Enabled = true;
                    btnAtaqueAereoP1.Enabled = true;
                    btnRelevoP1.Visible = true;
                    btnContraLasCuerdasP1.Visible = true;
                    btnAtaqueAereoP1.Visible = true;
                    break;
                case 5:
                    btnPunchlineP1.Enabled = true;
                    btnReplicaP1.Enabled = true;
                    btnTongoP1.Enabled = true;
                    btnPunchlineP1.Visible = true;
                    btnReplicaP1.Visible = true;
                    btnTongoP1.Visible = true;
                    break;
                default:
                    break;
            }

            //Condicion para habilitar los botones del P2
            switch (P2.imagen)
            {
                case 1:
                    btnMagiaNegraP2.Enabled = true;
                    btnAbraCadabraP2.Enabled = true;
                    btnIlusionismoP2.Enabled = true;
                    btnMagiaNegraP2.Visible = true;
                    btnAbraCadabraP2.Visible = true;
                    btnIlusionismoP2.Visible = true;
                    break;
                case 2:
                    btnConLaVidaP2.Enabled = true;
                    btnDuplicarP2.Enabled = true;
                    btnUnAlmaPorOtraP2.Enabled = true;
                    btnConLaVidaP2.Visible = true;
                    btnDuplicarP2.Visible = true;
                    btnUnAlmaPorOtraP2.Visible = true;
                    break;
                case 3:
                    btnIraP2.Enabled = true;
                    btnEspadaSagradaP2.Enabled = true;
                    btnCaballoDeTroyaP2.Enabled = true;
                    btnIraP2.Visible = true;
                    btnEspadaSagradaP2.Visible = true;
                    btnCaballoDeTroyaP2.Visible = true;
                    break;
                case 4:
                    btnRelevoP2.Enabled = true;
                    btnContraLasCuerdasP2.Enabled = true;
                    btnAtaqueAereoP2.Enabled = true;
                    btnRelevoP2.Visible = true;
                    btnContraLasCuerdasP2.Visible = true;
                    btnAtaqueAereoP2.Visible = true;
                    break;
                case 5:
                    btnPunchlineP2.Enabled = true;
                    btnReplicaP2.Enabled = true;
                    btnTongoP2.Enabled = true;
                    btnPunchlineP2.Visible = true;
                    btnReplicaP2.Visible = true;
                    btnTongoP2.Visible = true;
                    break;
                default:
                    break;
            }

            //Para bloquear los paneles de power
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                panelPowersP1.Cursor = Cursors.No;
                //panelPowersP1.Enabled = false;
                
            }

            if (P2.tipoPlayer.Equals("CPU"))
            {
                panelPowersP2.Cursor = Cursors.No;
                //panelPowersP2.Enabled = false;
                
            }

        }

        public void asignarImagen(Combatiente Player)
        {
            //Método que recibe un combatiente y define si es desde P2 o desde PLAYER
            switch (Player.imagen)
            {
                case 1:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picMago1;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picMago1;
                    }
                    break;
                case 2:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picHada;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picHada;
                    }
                    break;
                case 3:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picGuerrero;
                    }
                    break;
                case 4:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picLuchador;
                    }
                    break;
                case 5:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        imgboxP2.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    else
                    {
                        imgboxP1.Image = Graficas.Properties.Resources.picFreestyler;
                    }
                    break;
                default:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
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

        private void btnAbandonarP1_Click(object sender, EventArgs e)
        {
            P1.vida = 0;
            pbVidaP1.Value = P1.vida;
            MessageBox.Show($"{P2.nick} WIN!");
            ventanaPrincipal.Show();
            this.Dispose();
        }

        private void btnAbandonarP2_Click(object sender, EventArgs e)
        {
            P2.vida = 0;
            pbVidaP2.Value = P2.vida;
            MessageBox.Show($"{P1.nick} WIN!");
            ventanaPrincipal.Show();
            this.Dispose();
        }

        public void Combatir(Combatiente Player1, Combatiente Player2, int valAgresion, String PoderUsado)
        {
            int danho; //Variable que almacena el resultado de la resta.

            if (panelPowersP1.Enabled && P2.vida > 0)
            {
                danho = valAgresion - P2.Defender(P2.defensa);
                if (danho < 0) //Si el daño causado es menor que 0 entonces que no le quite porque después le suma :v 
                {
                    danho = 0;
                }
                lblBatalla.Text = $"{P1.nick} LANZA {PoderUsado}!\n{P2.nick} PIERDE {danho}";
                //MessageBox.Show($"Daño: -{danho}");
                
                P2.vida = P2.vida - danho;
                lblVidaP2.Text = P2.vida.ToString();


                if (P2.vida<0)
                {
                    P2.vida = 0;
                }
                pbVidaP2.Value = P2.vida;
                lblVidaP2.Text = P2.vida.ToString();

            }
            else if (panelPowersP2.BackColor == Color.Lime && P1.vida>0)
            {
                danho = valAgresion - P1.Defender(P1.defensa);
                if (danho < 0)
                {
                    danho = 0;
                }
                lblBatalla.Text = $"{P2.nick} LANZA {PoderUsado}!\n{P1.nick} PIERDE {danho}";
                //MessageBox.Show($"Daño: -{danho}");
                P1.vida = P1.vida - danho;
                lblVidaP1.Text = P1.vida.ToString();


                if (P1.vida < 0)
                {
                    P1.vida = 0;
                }
                pbVidaP1.Value = P1.vida;
                lblVidaP1.Text = P1.vida.ToString();
 
            }
            
            
            if (P2.vida <= 0)
            {
                MessageBox.Show($"{P1.nick} WIN!");
                
                ventanaPrincipal.Show();
                this.Dispose();
                timerTurno.Stop();
            }
            else if (P1.vida <= 0)
            {
                MessageBox.Show($"{P2.nick} WIN!");
                ventanaPrincipal.Show();
                this.Dispose();
                timerTurno.Stop();
            }

        }

        public void asignarImagenBatalla(Combatiente Player, Panel PPw1)
        {
            switch (Player.imagen)
            {
                case 1:
                    if (Player.tipoPlayer.Equals("P2")|| Player.tipoPlayer.Equals("CPU"))
                    {
                        if (!PPw1.Enabled)
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picMago_ataque;
                        } else
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picMago_defensa;
                        }
                        
                    }
                    else
                    {
                        if (PPw1.Enabled)
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picMago_ataque;
                        }
                        else
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picMago_defensa;
                        }
                        
                    }
                    break;
                case 2:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        if (!PPw1.Enabled)
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picHada_ataque;
                        }
                        else
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picHada_defensa;
                        }

                    }
                    else
                    {
                        if (PPw1.Enabled)
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picHada_ataque;
                        }
                        else
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picHada_defensa;
                        }

                    }
                    break;
                case 3:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        if (!PPw1.Enabled)
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picGuerrero_ataque;
                        }
                        else
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picGuerrero_defensa;
                        }

                    }
                    else
                    {
                        if (PPw1.Enabled)
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picGuerrero_ataque;
                        }
                        else
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picGuerrero_defensa;
                        }

                    }
                    break;
                case 4:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        if (!PPw1.Enabled)
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picLuchador_ataque;
                        }
                        else
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picLuchador_defensa;
                        }

                    }
                    else
                    {
                        if (PPw1.Enabled)
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picLuchador_ataque;
                        }
                        else
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picLuchador_defensa;
                        }

                    }
                    break;
                case 5:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
                    {
                        if (!PPw1.Enabled)
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picFreestyler_ataque;
                        }
                        else
                        {
                            imgboxP2.Image = Graficas.Properties.Resources.picFreestyler_defensa;
                        }

                    }
                    else
                    {
                        if (PPw1.Enabled)
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picFreestyler_ataque;
                        }
                        else
                        {
                            imgboxP1.Image = Graficas.Properties.Resources.picFreestyler_defensa;
                        }

                    }
                    break;
                default:
                    if (Player.tipoPlayer.Equals("P2") || Player.tipoPlayer.Equals("CPU"))
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

        private void btnMagiaNegraP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Aumenta en 50% el valor de la agresión del ataque
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte) + ((int)(agresionAtq * 0.50));
            
            PoderUsado = "Magia Negra";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnAbraCadabraP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //El valor de la suerte será el doble de la agresion por suerte usada.
            
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            P1.suerte = agresionSuerte * 2;

            PoderUsado = "AbraCadabra";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnIlusionismoP1_Click(object sender, EventArgs e)
        {
            //El valor de la agresion será la mitad de la vida del rival.
            //Aumenta la vida también en la mitad del rival.

            int valAgresion = P2.vida / 2;
            P1.vida += P2.vida / 2;
            if (P1.vida>999)
            {
                P1.vida = 999;
            }
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            PoderUsado = "Ilusionismo";
            Combatir(P1, P2, valAgresion, PoderUsado);
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnMagiaNegraP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Aumenta en 10% el valor de la agresión del ataque
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte) + ((int)(agresionAtq * 0.10));

            PoderUsado = "Magia Negra";
            Combatir(P2, P1, valAgresion, PoderUsado);
            
            panelPowersP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            btnAbandonarP2.Enabled = false;
            panelPowersP1.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }
       
        private void btnAbraCadabraP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //El valor de la suerte será el doble de la agresion por suerte usada.

            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            P2.suerte = agresionSuerte * 2;

            PoderUsado = "Abra Cadabra";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            btnAbandonarP2.Enabled = false;
            panelPowersP1.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnIlusionismoP2_Click(object sender, EventArgs e)
        {
            //El valor de la agresion será la mitad de la vida del rival.
            //Aumenta la vida también en la mitad del rival.

            int valAgresion = P1.vida / 2;
            P2.vida += P1.vida / 2;

            if (P2.vida>999)
            {
                P2.vida = 999;
            }
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            PoderUsado = "Ilusionismo";
            Combatir(P2, P1, valAgresion, PoderUsado);
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            panelPowersP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            btnAbandonarP2.Enabled = false;
            panelPowersP1.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnConLaVidaP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con todo el ataque, pero la defensa quedará en 1 el resto de la batalla.
            //Pierde 10% de ataque cada vez que se usa
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = P1.ataque + agresionSuerte;
            P1.defensa = 1;
            P1.ataque -= (int)(P1.ataque * 0.10);

            PoderUsado = "Con la vida";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }

        }

        private void btnDuplicarP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Copia la vida, ataque y defensa del rival. El golpe que genere se reduce a la mitad.
            Random agresion = new Random();
            
            P1.vida = P2.vida;
            P1.ataque = P2.ataque;
            P1.defensa = P2.defensa;

            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte) / 2;

            PoderUsado = "Duplicar";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnUnAlmaPorOtraP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Divide el ataque a la mitad del valor de la agresion pero le multiplica en el doble la defensa.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            P1.ataque = valAgresion / 2;
            P1.defensa = valAgresion * 2;

            PoderUsado = "Un alma por otra";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnConLaVidaP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con todo el ataque, pero la defensa quedará en 1 toda la batalla.
            //Pierde 10% de ataque cada vez que se usa
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = P2.ataque + agresionSuerte;
            P2.defensa = 1;
            P2.ataque -= (int)(P2.ataque * 0.10);

            PoderUsado = "Con la vida";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnDuplicarP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Copia la vida, ataque y defensa del rival. El golpe que genere se reduce a la mitad.
            Random agresion = new Random();

            P2.vida = P1.vida;
            P2.ataque = P1.ataque;
            P2.defensa = P1.defensa;

            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte) / 2;

            PoderUsado = "Duplicar";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnUnAlmaPorOtraP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Divide el ataque a la mitad del valor de la agresion pero le multiplica en el doble la defensa.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            P2.ataque = valAgresion / 2;
            P2.defensa = valAgresion * 2;

            PoderUsado = "Un alma por otra";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnIraP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con todo el ataque pero pierde el 50% de la vida y el ataque.
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (P1.ataque + agresionSuerte);
            P1.vida /= 2;
            P1.ataque /= 2;

            PoderUsado = "Ira";
            Combatir(P1, P2, valAgresion, PoderUsado);
            

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnEspadaSagradaP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Cada vez que se use la espada, aumenta su ataque general en 10.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            PoderUsado = "Espada Sagrada";
            Combatir(P1, P2, valAgresion, PoderUsado);
            P1.ataque += 10;

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnCaballoDeTroyaP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Deja la vida en 2 pero la defensa en 999, así el rival cree que ganaría.
            P1.vida = 2;
            P1.defensa = 999;
            int valAgresion = 0;

            PoderUsado = "Caballo de Troya";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnIraP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con todo el ataque pero pierde el 50% de la vida y el ataque.
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (P2.ataque + agresionSuerte);
            P2.vida /= 2;
            P2.ataque /= 2;

            PoderUsado = "Ira";
            Combatir(P2, P1, valAgresion, PoderUsado);


            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnEspadaSagradaP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Por cada vez que use la espada, aumenta su ataque general en 10.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            PoderUsado = "Espada Sagrada";
            Combatir(P2, P1, valAgresion, PoderUsado);
            P2.ataque += 10;

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }
             
        private void btnCaballoDeTroyaP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Deja la vida en 2 pero la defensa y el ataque en 999, así el rival cree que ganaría.
            P2.vida = 2;
            P2.defensa = 999;
            P2.ataque = 999;
            int valAgresion = 0;

            PoderUsado = "Caballo de Troya";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnRelevoP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //No ataca, pero aumenta en 100 la vida, el ataque y defensa.
            P1.ataque += 100;
            P1.defensa += 100;
            P1.vida += 100;
            int valAgresion = 0;

            PoderUsado = "Relevo";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            if (P1.vida > 999)
            {
                P1.vida = 999;
            }
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnContraLasCuerdasP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Disminuye la defensa del rival al 18% durante el golpe y luego vuelve a ser normal, pero la defensa del luchador baja 18% de lo que tenía.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            P1.defensa -= (int)(P1.defensa * 0.18);
            
            int defensaRivalAct = P2.defensa;
            P2.defensa *= (int)0.18;

            PoderUsado = "Contra las cuerdas";
            Combatir(P1, P2, valAgresion, PoderUsado);
            P2.defensa = defensaRivalAct;

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnAtaqueAereoP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con un ataque aleatorio pero con toda la suerte.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            //int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + P1.suerte);

            PoderUsado = "Ataque Aereo";
            Combatir(P1, P2, valAgresion,PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }

        }

        private void btnRelevoP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //No ataca, pero aumenta en 100 la vida, el ataque y defensa.
            P2.ataque += 100;
            P2.defensa += 100;
            P2.vida += 100;
            int valAgresion = 0;

            PoderUsado = "Relevo";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            if (P2.vida > 999)
            {
                P2.vida = 999;
            }
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnContraLasCuerdasP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Disminuye la defensa del rival al 18% durante el golpe y luego vuelve a ser normal, pero la defensa del luchador baja 18% de lo que tenía.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            P2.defensa -= (int)(P2.defensa * 0.18);

            int defensaRivalAct = P1.defensa;
            P1.defensa *= (int)0.18;

            PoderUsado = "Contra las Cuerdas";
            Combatir(P2, P1, valAgresion, PoderUsado);
            P1.defensa = defensaRivalAct;

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnAtaqueAereoP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Ataca con un ataque aleatorio pero con toda la suerte.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            //int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + P2.suerte);

            PoderUsado = "Ataque Aereo";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnPunchlineP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Por cada ataque aumenta la contundencia, aumentandole +50 en ataque
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P1.ataque);
            int agresionSuerte = agresion.Next(P1.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            PoderUsado = "Punchline";
            Combatir(P1, P2, valAgresion, PoderUsado);
            P1.ataque += 50;

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnReplicaP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Vuelve los valores de la vida del rival y propia a 999.
            P1.vida = 999;
            P2.vida = 999;
            int valAgresion = 0;

            PoderUsado = "Replica";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnTongoP1_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Cambia la vida del rival por la mía y viceversa.
            int vidaP1actual = P1.vida;
            int vidaP2actual = P2.vida;
            P1.vida = vidaP2actual;
            P2.vida = vidaP1actual;
            int valAgresion = 0;

            PoderUsado = "Tongo";
            Combatir(P1, P2, valAgresion, PoderUsado);

            panelPowersP1.Enabled = false;
            btnAbandonarP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.BackColor = Color.Lime;
            pbVidaP1.Value = P1.vida;
            lblVidaP1.Text = P1.vida.ToString();

            /*Si el P2 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P2.tipoPlayer.Equals("CPU"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP2.Enabled = true;
                btnAbandonarP2.Enabled = true;
            }
        }

        private void btnPunchlineP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Por cada ataque aumenta la contundencia, aumentandole +50 en ataque
            Random agresion = new Random();
            int agresionAtq = agresion.Next(P2.ataque);
            int agresionSuerte = agresion.Next(P2.suerte);
            int valAgresion = (agresionAtq + agresionSuerte);

            PoderUsado = "Punchline";
            Combatir(P2, P1, valAgresion, PoderUsado);
            P2.ataque += 50;

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnReplicaP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Vuelve los valores de la vida del rival y propios a 999.
            P2.vida = 999;
            P1.vida = 999;
            int valAgresion = 0;

            PoderUsado = "Replica";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnTongoP2_Click(object sender, EventArgs e)
        {
            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            //Cambia la vida del rival por la mía y viceversa.
            int vidaP2actual = P2.vida;
            int vidaP1actual = P1.vida;
            P2.vida = vidaP1actual;
            P1.vida = vidaP2actual;
            int valAgresion = 0;

            PoderUsado = "Tongo";
            Combatir(P2, P1, valAgresion, PoderUsado);

            panelPowersP2.Enabled = false;
            btnAbandonarP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.BackColor = Color.Lime;
            pbVidaP2.Value = P2.vida;
            lblVidaP2.Text = P2.vida.ToString();

            /*Si el P1 es la máquina, que realice la acción en el tiempo estípulado, sino que la haga el jugador*/
            if (P1.tipoPlayer.Equals("CPU1"))
            {
                timerTurno.Start();
            }
            else
            {
                panelPowersP1.Enabled = true;
                btnAbandonarP1.Enabled = true;
            }
        }

        private void btnPunchlineP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Punchline";
            toolTip1.SetToolTip(btnPunchlineP1, "Por cada ataque aumenta la contundencia, aumentandole +50 en ataque.");
        }

        private void btnReplicaP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Replica";
            toolTip1.SetToolTip(btnReplicaP1, "Vuelve los valores de la vida del rival y propios a 999.");
        }

        private void btnTongoP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Tongo";
            toolTip1.SetToolTip(btnTongoP1, "Cambia la vida del rival por la mía y viceversa.");
        }

        private void btnPunchlineP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Punchline";
            toolTip1.SetToolTip(btnPunchlineP2, "Por cada ataque aumenta la contundencia, aumentandole +50 en ataque.");
        }

        private void btnReplicaP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Replica";
            toolTip1.SetToolTip(btnReplicaP2, "Vuelve los valores de la vida del rival y propios a 999.");
        }

        private void btnTongoP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Tongo";
            toolTip1.SetToolTip(btnTongoP2, "Cambia la vida del rival por la mía y viceversa.");


        }

        private void btnRelevoP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Relevo";
            toolTip1.SetToolTip(btnRelevoP1, "No ataca, pero aumenta en 100 la vida, el ataque y defensa.");

        }

        private void btnContraLasCuerdasP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Contra las cuerdas";
            toolTip1.SetToolTip(btnContraLasCuerdasP1, "Disminuye la defensa del rival al 18% durante el golpe y luego vuelve a ser normal.\nPero la defensa del luchador baja 18% de lo que tenía.");

        }

        private void btnAtaqueAereoP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Ataque aereo";
            toolTip1.SetToolTip(btnAtaqueAereoP1, "Ataca con un ataque aleatorio pero con toda la suerte.");
        }

        private void btnRelevoP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Relevo";
            toolTip1.SetToolTip(btnRelevoP2, "No ataca, pero aumenta en 100 la vida, el ataque y defensa.");

        }

        private void btnContraLasCuerdasP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Contra las cuerdas";
            toolTip1.SetToolTip(btnContraLasCuerdasP2, "Disminuye la defensa del rival al 18% durante el golpe y luego vuelve a ser normal.\nPero la defensa del luchador baja 18% de lo que tenía.");

        }

        private void btnAtaqueAereoP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Ataque aereo";
            toolTip1.SetToolTip(btnAtaqueAereoP2, "Ataca con un ataque aleatorio pero con toda la suerte.");

        }

        private void btnIraP1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.ToolTipTitle = "Ira";
            toolTip1.SetToolTip(btnIraP1, "Ataca con todo el ataque pero pierde el 50 % de la vida y el ataque.");

        }

        private void btnEspadaSagradaP1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.ToolTipTitle = "Espada Sagrada";
            toolTip1.SetToolTip(btnEspadaSagradaP1, "Cada vez que se use la espada, aumenta su ataque general en 10.");

        }

        private void btnCaballoDeTroyaP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Caballo de Troya";
            toolTip1.SetToolTip(btnCaballoDeTroyaP1, "Deja la vida en 2 pero la defensa y el ataque en 999, así el rival cree que ganaría.");

        }

        private void btnIraP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Ira";
            toolTip1.SetToolTip(btnIraP2, "Ataca con todo el ataque pero pierde el 50 % de la vida y el ataque.");

        }

        private void btnEspadaSagradaP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Espada Sagrada";
            toolTip1.SetToolTip(btnEspadaSagradaP2, "Cada vez que se use la espada, aumenta su ataque general en 10.");

        }

        private void btnCaballoDeTroyaP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Caballo de Troya";
            toolTip1.SetToolTip(btnCaballoDeTroyaP2, "Deja la vida en 2 pero la defensa y el ataque en 999, así el rival cree que ganaría.");

        }

        private void btnConLaVidaP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Con la vida";
            toolTip1.SetToolTip(btnConLaVidaP1, "Ataca con todo el ataque, pero la defensa quedará en 1 el resto de la batalla.\nPierde 10% de ataque cada vez que se usa.");

        }

        private void btnDuplicarP1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.ToolTipTitle = "Duplicar";
            toolTip1.SetToolTip(btnDuplicarP1, "Copia la vida, ataque y defensa del rival. El golpe que genere se reduce a la mitad.");

        }

        private void btnUnAlmaPorOtraP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Un Alma por Otra";
            toolTip1.SetToolTip(btnUnAlmaPorOtraP1, "Divide el ataque a la mitad del valor de la agresion pero le multiplica en el doble la defensa.");

        }

        private void btnConLaVidaP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Con la vida";
            toolTip1.SetToolTip(btnConLaVidaP2, "Ataca con todo el ataque, pero la defensa quedará en 1 el resto de la batalla.\nPierde 10% de ataque cada vez que se usa.");

        }

        public void turnoCPU1()
        {

            object sender = new object();
            EventArgs e = new EventArgs();
            Random aleatorio = new Random();

            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            Poder = aleatorio.Next(3) + 1;

            if (P1.Raza.Equals("Mago"))
            {
                switch (Poder)
                {
                    case 1:
                        btnMagiaNegraP1_Click(sender, e);
                        break;
                    case 2:
                        btnAbraCadabraP1_Click(sender, e);
                        break;
                    case 3:
                        btnIlusionismoP1_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P1.Raza.Equals("Hada"))
            {
                switch (Poder)
                {
                    case 1:
                        btnConLaVidaP1_Click(sender, e);
                        break;
                    case 2:
                        btnDuplicarP1_Click(sender, e);
                        break;
                    case 3:
                        btnUnAlmaPorOtraP1_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P1.Raza.Equals("Guerrero"))
            {
                switch (Poder)
                {
                    case 1:
                        btnIraP1_Click(sender, e);
                        break;
                    case 2:
                        btnEspadaSagradaP1_Click(sender, e);
                        break;
                    case 3:
                        btnCaballoDeTroyaP1_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P1.Raza.Equals("Luchador"))
            {
                switch (Poder)
                {
                    case 1:
                        btnRelevoP1_Click(sender, e);
                        break;
                    case 2:
                        btnContraLasCuerdasP1_Click(sender, e);
                        break;
                    case 3:
                        btnAtaqueAereoP1_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P1.Raza.Equals("Freestyler"))
            {
                switch (Poder)
                {
                    case 1:
                        btnPunchlineP1_Click(sender, e);
                        break;
                    case 2:
                        btnReplicaP1_Click(sender, e);
                        break;
                    case 3:
                        btnTongoP1_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }


            panelPowersP1.Enabled = false;
            panelPowersP1.BackColor = Color.Gray;
            panelPowersP2.Enabled = true;
            panelPowersP1.BackColor = Color.Lime;
            btnAbandonarP2.Enabled = true;
        }

        private void btnDuplicarP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Duplicar";
            toolTip1.SetToolTip(btnDuplicarP2, "Copia la vida, ataque y defensa del rival. El golpe que genere se reduce a la mitad.");

        }

        private void btnUnAlmaPorOtraP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Un Alma por Otra";
            toolTip1.SetToolTip(btnUnAlmaPorOtraP2, "Divide el ataque a la mitad del valor de la agresion pero le multiplica en el doble la defensa.");

        }

        private void btnMagiaNegraP1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.ToolTipTitle = "Magia Negra";
            toolTip1.SetToolTip(btnMagiaNegraP1, "Aumenta en 10 % el valor de la agresión del ataque.");

        }

        private void btnMagiaNegraP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Magia Negra";
            toolTip1.SetToolTip(btnMagiaNegraP2, "Aumenta en 10 % el valor de la agresión del ataque.");

        }

        private void btnAbraCadabraP1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "AbraCadabra";
            toolTip1.SetToolTip(btnAbraCadabraP1, "El valor de la suerte será el doble de la agresion por suerte usada.");

        }

        private void btnAbraCadabraP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "AbraCadabra";
            toolTip1.SetToolTip(btnAbraCadabraP2, "El valor de la suerte será el doble de la agresion por suerte usada.");

        }

        private void btnIlusionismoP1_MouseHover(object sender, EventArgs e)
        {

            toolTip1.ToolTipTitle = "Ilusionismo";
            toolTip1.SetToolTip(btnIlusionismoP1, "El valor de la agresion será la mitad de la vida del rival.\nAumenta la vida también en la mitad de la vida rival.");

        }

        private void btnIlusionismoP2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Ilusionismo";
            toolTip1.SetToolTip(btnIlusionismoP2, "El valor de la agresion será la mitad de la vida del rival.\nAumenta la vida también en la mitad de la vida rival.");

        }

        public void turnoCPU()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            Random aleatorio = new Random();

            asignarImagenBatalla(P1, panelPowersP1);
            asignarImagenBatalla(P2, panelPowersP1);

            Poder = aleatorio.Next(3) + 1;

            if (P2.Raza.Equals("Mago"))
            {
                switch (Poder)
                {
                    case 1:
                        btnMagiaNegraP2_Click(sender, e);
                        break;
                    case 2:
                        btnAbraCadabraP2_Click(sender, e);
                        break;
                    case 3:
                        btnIlusionismoP2_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P2.Raza.Equals("Hada"))
            {
                switch (Poder)
                {
                    case 1:
                        btnConLaVidaP2_Click(sender, e);
                        break;
                    case 2:
                        btnDuplicarP2_Click(sender, e);
                        break;
                    case 3:
                        btnUnAlmaPorOtraP2_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P2.Raza.Equals("Guerrero"))
            {
                switch (Poder)
                {
                    case 1:
                        btnIraP2_Click(sender, e);
                        break;
                    case 2:
                        btnEspadaSagradaP2_Click(sender, e);
                        break;
                    case 3:
                        btnCaballoDeTroyaP2_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P2.Raza.Equals("Luchador"))
            {
                switch (Poder)
                {
                    case 1:
                        btnRelevoP2_Click(sender, e);
                        break;
                    case 2:
                        btnContraLasCuerdasP2_Click(sender, e);
                        break;
                    case 3:
                        btnAtaqueAereoP2_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else if (P2.Raza.Equals("Freestyler"))
            {
                switch (Poder)
                {
                    case 1:
                        btnPunchlineP2_Click(sender, e);
                        break;
                    case 2:
                        btnReplicaP2_Click(sender, e);
                        break;
                    case 3:
                        btnTongoP2_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }


            panelPowersP2.Enabled = false;
            panelPowersP2.BackColor = Color.Gray;
            panelPowersP1.Enabled = true;
            panelPowersP1.BackColor = Color.Lime;
            btnAbandonarP1.Enabled = true;


        }

        private void timerTurno_Tick(object sender, EventArgs e)
        {
            if (P1.vida <= 0 || P2.vida <= 0)
            {
                timerTurno.Stop();
            }
            else
            {
                seg++;
                if (seg == 3)
                {
                    timerTurno.Stop();
                    seg = 0;
                    turnoCPU();
                }
            }

        }

    }   
}
