using System;
 using XGame.Domain.Entities.Base;
using prmToolkit.NotificationPattern;

namespace XGame
{
    public class Plataforma: EntityBase
    {

        public Plataforma()
        {

        }
        public Plataforma(string nome)
        {
            Nome = nome;
        }  

        public void Alterar(string nome)
        {
            Nome = nome;
            ValidaDados();
        }
        public void ValidaDados()
        {
            new AddNotifications<Plataforma>(this)
                .IfNullOrInvalidLength(x => x.Nome, 2,20 ,"Nome deve conter no minimo 2 e no máximo 20 caracteres.");
        }
        public string Nome { get; set; }

    }
}
