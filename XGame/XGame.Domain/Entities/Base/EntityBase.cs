using prmToolkit.NotificationPattern;
using System;

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
