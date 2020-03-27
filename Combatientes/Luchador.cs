using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Luchador : Combatiente
    {
        public Luchador(String nick, String tipoPlayer, String raza)
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            this.ataque = 600;
            this.defensa = 450;
            this.suerte = 20;
            this.imagen = 4;
            this.Pwr1 = "Relevo";
            this.Pwr2 = "Contra las cuerdas";
            this.Pwr3 = "AtaqueAereo";
        }

        public int getPower1()
        {
            //No ataca, pero aumenta en 100 la vida, el ataque y defensa.
            this.ataque += 100;
            this.defensa += 100;
            this.vida += 100;

            return 0;
        }

        public int getPower2()
        {
            //Disminuye la defensa del rival al 18% durante el golpe y luego vuelve a ser normal, pero la defensa del luchador baja 18% de lo que tenía.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            this.defensa = (int)(this.defensa * 0.18);
            //La dismunucion de la defensa rival se hace directamente en el botón

            return valAgresion;

        }

        public int getPower3()
        {
            //Ataca con un ataque aleatorio pero con toda la suerte.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            //int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + this.suerte);


            return valAgresion;

        }
    }
}
