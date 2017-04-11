using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
   public class Baraja
    {
        public Jugador jugador { set; get; }

        public List<Carta> cartas { set; get; }

        public Baraja()
        {
            cartas = new List<Carta>();
        }

    }

}
