using System;

namespace XGame.Domain.Arguments.Jogo
{
    public class AdicionarJogoResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarJogoResponse(Entities.Jogo jogo)
        {
            return new AdicionarJogoResponse
            {
                Id = Guid.NewGuid(),
                Message = "Jogo Cadastrado com sucesso."
            };
        }
    }
}
