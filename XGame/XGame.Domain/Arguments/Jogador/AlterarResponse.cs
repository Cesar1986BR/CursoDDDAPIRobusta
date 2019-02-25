using System;

namespace XGame.Domain.Interface.Servico
{
    public class AlterarResponse
    {
        public Guid ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Message { get; set; }
        public string Email { get; private set; }

        public static explicit operator AlterarResponse(Entities.Jogador jogador)
        {

            return new AlterarResponse
            {
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Email = jogador.Email.EmailEndereco,
                Message = "Jogador Alterado com sucesso."

            };

        }
    }
}