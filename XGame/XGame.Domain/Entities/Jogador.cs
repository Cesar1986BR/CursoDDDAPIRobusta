using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid ID { get; set; }


        public StatusJogador Status { get; set; }

    }
}
