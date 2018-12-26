using System;

namespace XGame.Domain.Entities
{
    public class MeusJogo
    {
        public Guid ID { get; set; }

        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejado { get; set; }
        public bool Troca { get; set; }
        public bool Vender { get; set; }
        public DateTime DataDesejado { get; set; }
    }
}
