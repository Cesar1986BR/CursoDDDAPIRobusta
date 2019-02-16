using System;
namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {

        public Guid Id { get; set; }

        public string PrimeiroNome { get; set; }

        public string Email { get; set; }

        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador entidade)
        {
            return new AutenticarJogadorResponse()
            {
                Id = entidade.ID,
                Email = entidade.Email.EmailEndereco,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                Status = (int)entidade.Status
            };
        }
    }
}
