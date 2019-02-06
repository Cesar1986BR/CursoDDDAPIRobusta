using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.ValueObjects
{
    public  class Nome: Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)//this porque quero validar a propria classe em que estou

            .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50)
            .IfNullOrInvalidLength(x => x.UltimoNome, 3, 50);
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
