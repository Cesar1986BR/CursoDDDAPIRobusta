using XGame.Domain.Interface.Arguments;
using XGame.Domain.ValueObjects;
namespace XGame.Domain.Arguments.Jogador
{
    public class AddJogadorRequest : IRequest
    {

        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }

    }
}
