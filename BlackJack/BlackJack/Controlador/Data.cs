using BlackJack.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Controlador
{
   public class Data
    {
        Modelo.DATA data = new Modelo.DATA();
        public void insertarPartidaJugada(PartidaJugada partida)
        {
            data.insertarPartidaJugada(partida);

        }
    }
}
