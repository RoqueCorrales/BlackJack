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
       

        public  int sumar(Carta c , int total,List<Carta> lista)
        {
            int suma = 0;
            if (c.Value.Equals("QUEEN") || c.Value.Equals("KING") || c.Value.Equals("JACK"))
            {
                suma = suma  + 10;
            }
            else if (c.Value.Equals("ACE"))
            {
                if (total <= 10)
                {
                    suma = suma + 11;
                }
                else
                {
                    suma = suma + 1;
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
