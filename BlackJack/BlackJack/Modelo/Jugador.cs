using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    public class Jugador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string genero { get; set; }
        public string foto { get; set; }

        public Jugador()
        {

        }
        public Jugador(string nombre,string apellido,string genero,string foto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.foto = foto;
        }

    }
}
