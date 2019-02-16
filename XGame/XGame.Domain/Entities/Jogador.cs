using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Entities.Base;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : EntityBase
    {
        public Jogador()
        {

        }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;
            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x=>Senha,6,32,"Senha esta fora do padrão.");
            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            ID = Guid.NewGuid();
            Status = StatusJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32,"Deve conter entre 6 e 32 caracteres");

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }
            
            AddNotifications(nome, email);
        }

      //  public Guid ID { get; private set; }
        public Nome Nome { get; set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }
        public StatusJogador Status { get; private set; }


        public override string ToString()
        {
            return Nome.PrimeiroNome + " " + Nome.UltimoNome;
        }

        public void AlterarJogador(Nome nome,Email email,StatusJogador status)
        {
            Nome = nome;
            Email = email;

           new AddNotifications<Jogador>(this).IfFalse(status == StatusJogador.Ativo, "Esse Jogador não esta mais ativo.");

            AddNotifications(nome, email);
        }
    }
}
