using BlackJack.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace BlackJack.Modelo
{
    class WebAPI
    {
        public static Carta requestCard(string code)
        {
            Uri uri = new Uri(@"https://deckofcardsapi.com/api/deck/" + code + "/draw/?count=1");
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            var outObject = JsonConvert.DeserializeObject<MasoCartas>(responseData);
            Carta oCarta = (Carta)outObject.cards[0];
            Juego.Partida.remaining = outObject.remaining;
            return oCarta;
        }
        public static List<Carta> requestCardStartGame(string code)
        {
            List<Carta> List = new List<Carta>();
            Uri url = new Uri(@"https://deckofcardsapi.com/api/deck/" + code + "/draw/?count=2");
            WebRequest webRequest = WebRequest.Create(url);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            var outObject = JsonConvert.DeserializeObject<MasoCartas>(responseData);
            Carta Carta = (Carta)outObject.cards[0];
            List.Add(Carta);
            Carta = (Carta)outObject.cards[1];
            List.Add(Carta);
            Juego.Partida.remaining = outObject.remaining;
            return List;
        }

        public static void newGame()
        {
            Uri uri = new Uri(@"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            Partida oPartida = JsonConvert.DeserializeObject<Partida>(responseData);
            Juego.Partida = oPartida;
            Juego.Partida.remaining = Juego.Partida.remaining - 2;
        }



        public static void reshuffleCards(string codigo)
        {
            Uri uri = new Uri(@"https://deckofcardsapi.com/api/deck/" + codigo + "/shuffle/");
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            Partida oPartida = JsonConvert.DeserializeObject<Partida>(responseData);
            Juego.Partida = oPartida;
        }

    }
}

