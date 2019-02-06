using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AddJogadorResponse: IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AddJogadorResponse(Entities.Jogador jogador)
        {
            return new AddJogadorResponse
            {
                Id = Guid.NewGuid(),
                Message = "Jogador Cadastrado com sucesso." 
            };
        }
    }
}
