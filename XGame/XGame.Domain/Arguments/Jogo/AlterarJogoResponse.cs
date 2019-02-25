using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.Jogo
{
    public class AlterarJogoResponse
    {
        
        public string Message { get; set; }

        public static explicit operator AlterarJogoResponse(Entities.Jogo jogo)
        {
            return new AlterarJogoResponse
            {

                Message = "Jogo alterado com sucesso."
            };
        }
    }
}
