using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Guerrero : Combatiente
    {
        public Guerrero(String nick, String tipoPlayer, String raza)
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            this.ataque = 700;
            this.defensa = 400;
            this.suerte = 25;
            this.imagen = 3;
            this.Pwr1 = "Ira";
            this.Pwr2 = "Espada Sagrada";
            this.Pwr3 = "Caballo de Troya";
        }

        public int getPower1()
        {
            //Ataca con todo el ataque pero pierde el 50% de la vida y el ataque.
            Random agresion = new Random();
            //int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (this.ataque + agresionSuerte);
            this.vida /= 2;
            this.ataque /= 2;
            return valAgresion;
        }

        public int getPower2()
        {
            //Si el valor de la agresion es mayor a 200, aumenta su ataque general en 10.
            Random agresion = new Random();
            int agresionAtq = agresion.Next(ataque);
            int agresionSuerte = agresion.Next(suerte);
            int valAgresion = (agresionAtq + agresionSuerte);
            if (valAgresion > 200)
            {
                this.ataque += 10;
            }
            return valAgresion;
        }

        public int getPower3()
        {
            //Deja la vida en 1 pero la defensa en 999, así el rival cree que ganaría.
            this.vida = 1;
            this.defensa = 999;
            int valAgresion = 0;

            return valAgresion;
        }
    }
}
