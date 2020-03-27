using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Mago : Combatiente
    {
        public Mago(String nick, String tipoPlayer, String raza)
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            this.ataque = 500;
            this.defensa = 400;
            this.suerte = 50;
            this.imagen = 1;
            this.Pwr1 = "Magia Negra";
            this.Pwr2 = "Abra Cadabra";
            this.Pwr3 = "Ilusionismo";
        }

        public int getPower1()
        {
            //Aumenta en 10% el valor de la agresión del ataque
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + agresionSuerte) + ((int) (agresionAtq * 0.10));

            return valAgresion;
        }

        public int getPower2()
        {
            //Multiplica en el doble la suerte para hallar la agresión, y la devuelve al normal.
            this.suerte *= 2;
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            this.suerte /= 2;

            return valAgresion;
        }

        public int getPower3(int vidaRival)
        {
            //El valor de la agresion será la mitad de la vida del rival.
            int valAgresion = vidaRival / 2;
 
            return valAgresion;
        }
    }
}
