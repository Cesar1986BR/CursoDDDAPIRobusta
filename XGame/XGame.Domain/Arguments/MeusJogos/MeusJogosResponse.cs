using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.MeusJogos
{
    public class MeusJogosResponse
    {

        public MeusJogosResponse()
        {
            MeusJogos = new List<string>();
        }
        public string NomeJogador { get; set; }
        public List<string> MeusJogos { get; set; }


    }
}
