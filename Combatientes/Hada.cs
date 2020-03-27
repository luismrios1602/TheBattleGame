using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Hada : Combatiente
    {
        public Hada(String nick, String tipoPlayer, String raza)
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            this.ataque = 400;
            this.defensa = 800;
            this.suerte = 45;
            this.imagen = 2;
            this.Pwr1 = "Con la Vida";
            this.Pwr2 = "Duplicar";
            this.Pwr3 = "Un alma por otra";
        }

        public int getPower1()
        {
            //Ataca con todo el ataque menos (-) el aleatorio de suerte por(*) 2, pero la defensa quedará en 1 toda la batalla.
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = this.ataque - (agresionSuerte*2);
            this.defensa = 1;

            return valAgresion;
        }

        public int getPower2(int vidaRival)
        {
            //El valor de la agresión total será 0, pero la vida de los dos será la misma.
            int valAgresion = 0;
            this.vida = vidaRival;

            return valAgresion;
        }

        public int getPower3()
        {
            //Divide el ataque a la mitad del valor de la agresion pero le multiplica en el doble la defensa.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            this.ataque = valAgresion / 2;
            this.defensa = valAgresion * 2;

            return valAgresion;
        }
    }
}
