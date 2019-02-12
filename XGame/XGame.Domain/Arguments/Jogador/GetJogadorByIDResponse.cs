using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.Jogador
{
    public class GetJogadorByIDResponse
    {
        public Guid ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Mesage { get; set; }
        public string Email { get; private set; }
        public string Status { get; set; }

        public static explicit operator GetJogadorByIDResponse(Entities.Jogador jogador)
        {
            return new GetJogadorByIDResponse
            {

                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Email = jogador.Email.EmailEndereco,
                Status = jogador.Status.ToString(),
            };
        }
    }
}
