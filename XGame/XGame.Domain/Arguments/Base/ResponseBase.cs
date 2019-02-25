using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string  Message { get; set; }

        public static explicit operator ResponseBase(Entities.Jogo jogo)
        {
            return new ResponseBase() { Message = "Jogo alterado com sucesso"};
        }
    }


}