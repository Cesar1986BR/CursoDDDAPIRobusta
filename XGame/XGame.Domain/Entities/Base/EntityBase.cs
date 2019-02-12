using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Entities.Base
{
    public abstract class EntityBase: Notifiable
    {

        protected EntityBase()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID  { get; set; }
    }
}
