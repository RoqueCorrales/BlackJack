using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
   public class DATA
    {
        PetaPoco.Database db = new PetaPoco.Database("Pg");

        public void InsterJugador(Jugador jugador)
        {
            db.Insert("jugador", jugador);
        }
    }
}
