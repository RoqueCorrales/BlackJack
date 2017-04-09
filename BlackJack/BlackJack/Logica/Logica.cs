using BlackJack.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Logica
{
  public   class Logica
    {
       
        public Logica()
        {

        }
        public Boolean confirmarGanada(int cartas, int suma)
        {
            if(suma ==21 || cartas == 5)
            {
                return true;
            }
            return false;
        }

        public static int sumar(Carta c)
        {
            int suma = 0;
            if (c.Value.Equals("QUEEN") || c.Value.Equals("KING") || c.Value.Equals("JACK"))
            {
                suma = suma + 10;
            }
            else if (c.Value.Equals("ACE"))
            {
                if (suma < 7)
                {
                    suma = suma + 10;
                }
                else
                {
                    suma = suma + 10;
                }
            }
            else
            {
                suma = suma + int.Parse(c.Value);
            }
            return suma;
        }


    }
}
