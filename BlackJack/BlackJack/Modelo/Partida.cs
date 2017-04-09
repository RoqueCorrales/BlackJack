using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
   public class Partida
    {
        public Partida()
        {

        }
        public bool Shuffled { get; set; }
        public int Remaining { get; set; }
        public string Deck_Id { get; set; }
        public bool Success { get; set; }

      
    }
}
