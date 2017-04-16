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

        public Jugador SelectLogin(string idfacebook)
        {
            Jugador p = new Jugador();
            foreach (var a in db.Query<Jugador>("SELECT * FROM usuario Where idfacebook = '" + idfacebook + "'"))
            {

                p.id = a.id;
                p.idfacebook = a.idfacebook;
                p.nombre = a.nombre;
                p.apellido = a.apellido;
                p.partidasganadas = a.partidasganadas;
                p.partidasjugadas = a.partidasjugadas;
                p.genero = a.genero;
                p.foto = a.foto;
             
            }

            return p;
        }

        public Boolean SelectID(string idFacebook)
        {
            Jugador p = new Jugador();
            List<Jugador> j = new List<Jugador>();
            foreach (var a in db.Query<Jugador>("SELECT * FROM usuario Where idfacebook = '" + idFacebook + "'"))
            {

                p.id = a.id;
                p.idfacebook = a.idfacebook;
                p.nombre = a.nombre;
                p.apellido = a.apellido;
                p.partidasganadas = a.partidasganadas;
                p.partidasjugadas = a.partidasjugadas;
                p.genero = a.genero;
                j.Add(p);

            }
            if (j.Count==0)
            {
                return true;
            }
            return false;
        }

        public void UpdateJugador(Jugador p)
        {

            db.Update("usuario", "id", p);
        }
      

    }
}
