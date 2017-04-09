using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
   public class MasoJuego
    {
        public MasoJuego()
        {

        }
        public bool shuffled { get; set; }
        public int remaining { get; set; }
        public string deck_id { get; set; }
        public bool success { get; set; }
    }
}
