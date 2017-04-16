using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Modelo;

namespace BlackJack.Controlador
{

    public class WebApi
    {
        

        public static void reshuffleCards(string codigo)
        {
            WebAPI.reshuffleCards(codigo);
        }

        public static Carta requestCard(string code)
        {
            return WebAPI.requestCard(code);
        }
        public static List<Carta> requestCardStartGame(string code)
        {
            return WebAPI.requestCardStartGame(code);
        }

        public static void newGame()
        {
            WebAPI.newGame();
        }
       


        }
}
