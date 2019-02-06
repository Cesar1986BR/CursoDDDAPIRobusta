using System;

namespace XGame.Domain.Interface.Servico
{
    public class AlterarRequest
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }


    }
}