using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interface.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
