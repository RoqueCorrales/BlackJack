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
            db.Insert("usuario", jugador);
        }

        public Jugador SelectLogin(string idFacebook)
        {
            Jugador p = new Jugador();
            foreach (var a in db.Query<Jugador>("SELECT * FROM usuario Where idFacebook = '" + idFacebook + "'"))
            {

                p.id = a.id;
                p.idFacebook = a.idFacebook;
                p.nombre = a.nombre;
                p.apellido = a.apellido;
                p.partidasGanadas = a.partidasGanadas;
                p.partidasJugadas = a.partidasJugadas;
                p.genero = a.genero;
             
            }

            return p;
        }

        public void UpdateJugador(Jugador p)
        {

            db.Update("usuario", "id", p);
        }
      

    }
}
