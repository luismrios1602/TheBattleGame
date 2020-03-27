using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combatientes
{
    public class Freestyler : Combatiente
    {
        public Freestyler(String nick, String tipoPlayer, String raza)
        {
            this.nick = nick;
            this.tipoPlayer = tipoPlayer;
            this.Raza = raza;
            this.ataque = 550;
            this.defensa = 600;
            this.suerte = 20;
            this.imagen = 5;
            this.Pwr1 = "Punchline";
            this.Pwr2 = "Replica";
            this.Pwr3 = "Tongo";
        }

        public void getPower1()
        {
            //Atacara normal, algo me invento :v 
        }

        public void getPower2()
        {
            //Vuelve los valores del rival y propios a 999.
        }

        public void getPower3()
        {
            //Cambia la vida del rival por la mía y viceversa. La vida rival se maneja en el botón
        }
    }
}
