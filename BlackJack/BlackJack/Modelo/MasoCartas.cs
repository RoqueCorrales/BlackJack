using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
  public  class MasoCartas
    {
        public int remaining { get; set; }
        public List<Carta> cards { get; set; }
        public string deck_id { get; set; }
        public bool success { get; set; }
    }
}
