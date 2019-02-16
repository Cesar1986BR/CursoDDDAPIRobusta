using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.ValueObjects
{
    public class Email : Notifiable
    {

        public Email()
        {

        }
        public Email(string emailEndereco)
        {
            EmailEndereco = emailEndereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.EmailEndereco);
        }

        public string EmailEndereco { get; protected set; }
    }
}
