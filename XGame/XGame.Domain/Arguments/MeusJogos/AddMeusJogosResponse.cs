using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.MeusJogos
{
    public class AddMeusJogosResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AddMeusJogosResponse(MeusJogo jogo)
        {
            return new AddMeusJogosResponse
            {
                Id = Guid.NewGuid(),
                Message = "Cadastrado na sua biblioteca com sucesso."
            };
        }
    }
}

