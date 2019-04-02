using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Entities.Base;

namespace XGame
{
    public class MeusJogo :EntityBase
    {

        public MeusJogo()
        {

        }
        public MeusJogo(string idJogo,string idJogador)
        {
            ID_Jogador = idJogador;
            ID_Jogo = idJogo;
        }
        public void  AlterarMeusJogo(string idJogo, string idJogador)
        {
            ID_Jogador = idJogador;
            ID_Jogo = idJogo;
        }
        public string ID_Jogador { get; set; }

        public string ID_Jogo { get; set; }
        public DateTime DataDaCompra { get; set; }


    }
}
