﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    public class Jugador
    {
     
        public int id { get; set; }
        public string idFacebook { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int partidasJugadas { get; set; }
        public int partidasGanadas { get; set; }

        public string foto { get; set; }

        public string genero { get; set; }
       

        public Jugador()
        {

        }
       public string toString()
        {
            return nombre;
        }

    }
}
