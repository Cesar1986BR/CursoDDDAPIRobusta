using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interface.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {

        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador jogador)
        {
            return new AutenticarJogadorResponse
            {
                Email = jogador.Email.EmailEndereco,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                Status = (int)jogador.Status
            };
        }
    }
}
