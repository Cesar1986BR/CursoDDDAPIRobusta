using System;
using XGame.Domain.Interface.Arguments;

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
