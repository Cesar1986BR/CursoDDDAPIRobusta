using System;
using XGame.Domain.Entities.Base;

namespace XGame.Domain.Entities
{
    public class MeusJogo :EntityBase
    {

        public Guid ID_Jogador { get; set; }

        public Jogo Jogo { get; set; }
        public bool Desejado { get; set; }
        public bool Troca { get; set; }
        public bool Vender { get; set; }
        public DateTime DataDesejado { get; set; }
    }
}
