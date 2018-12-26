using System;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid ID { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }

        public string Status { get; set; }

    }
}
