using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid ID { get; private set; }
        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public string Email { get; private set; }
        public string Status { get; private set; }

        public static explicit operator JogadorResponse(Entities.Jogador jogador)
        {
            return new JogadorResponse {

                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                NomeCompleto = jogador.ToString(),
                Email = jogador.Email.EmailEndereco,
                Status = jogador.Status.ToString(),
                ID = jogador.ID

            };
        }
    }
}
