using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.Jogador
{
    public class GetJogadorByIDRequest
    {
        public Guid ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Mesage { get; set; }
        public string Email { get; private set; }
    }
}
