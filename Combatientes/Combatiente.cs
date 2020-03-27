using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Combatiente
    {
        public String nick, tipoPlayer;
        public int ataque, defensa, suerte, imagen, vida=999;
        public String Pwr1, Pwr2, Pwr3;
        public String Raza { get; set; }
        

        /* public Combatiente(String nick, String tipoPlayer, String raza )
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            

            switch (Raza)
            {

                case ("Mago"):
                    this.ataque = 500;
                    this.defensa = 400;
                    this.suerte = 50;
                    this.imagen = 1;
                    break;
                case ("Hada"):
                    this.ataque = 400;
                    this.defensa = 800;
                    this.suerte = 45;
                    this.imagen = 2;
                    break;
                case ("Guerrero"):
                    this.ataque = 700;
                    this.defensa = 400;
                    this.suerte = 25;
                    this.imagen = 3;
                    break;
                case ("Luchador"):
                    this.ataque = 600;
                    this.defensa = 450;
                    this.suerte = 20;
                    this.imagen = 4;
                    break;
                case ("Freestyler"):
                    this.ataque = 550;
                    this.defensa = 600;
                    this.suerte = 20;
                    this.imagen = 5;
                    break;
                default:
                    this.ataque = 0;
                    this.defensa = 0;
                    this.suerte = 0;
                    this.imagen = 0;
                    break;
            }

           
        }*/

            public Combatiente()
            {

            }

        public int Atacar(int ataque)
        {
            Random valAgresion = new Random();
            int agresion = valAgresion.Next(ataque) + valAgresion.Next(suerte);
            return agresion;
        }

        public int Defender(int defensa)
        {
            Random valProteccion = new Random();
            int proteccion = (valProteccion.Next(defensa)) + suerte;
            return proteccion;
        }

    }
}
