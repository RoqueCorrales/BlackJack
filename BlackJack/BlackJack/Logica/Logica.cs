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
       

 

        public int totalCartas(Carta c, List<Carta> lista)
        {
            int suma = 0;
            lista.Add(c);
            List<Carta> listaAces = new List<Carta>();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Value.Equals("ACE"))
                {
                    listaAces.Add(lista[i]);
                }else if (lista[i].Value.Equals("QUEEN") || lista[i].Value.Equals("KING") || lista[i].Value.Equals("JACK"))
                {
                    suma = suma + 10;
                }
                else
                {
                    suma = suma + int.Parse(lista[i].Value);
                }

            }
            if (listaAces.Count > 0)
            {
                for (int i = 0; i < listaAces.Count; i++)
                {
                    if(suma <= 10)
                    {
                        suma = suma + 11;
                    }else
                    {
                        suma = suma + 1;
                    }

                }
            }



            return suma;
        }
    }
}
