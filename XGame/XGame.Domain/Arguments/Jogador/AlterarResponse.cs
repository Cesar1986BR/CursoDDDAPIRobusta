using System;
using XGame.Domain.Entities;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interface.Servico
{
    public class AlterarResponse
    {
        public Guid ID { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Mesage { get; set; }
        public string Email { get; private set; }

        public static explicit operator AlterarResponse(Jogador jogador)
        {

            return new AlterarResponse
            {
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Email = jogador.Email.EmailEndereco,
                Mesage = "Jogador Alterado com sucesso."

            };

        }
    }
}