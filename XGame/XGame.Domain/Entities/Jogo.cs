using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using XGame.Domain.Entities.Base;

namespace XGame.Domain.Entities
{
    public class Jogo : EntityBase
    {

        public Jogo()
        {

        }
        public Jogo(string nome, string descricao, string produtora, string distribuidora, string genero, string site, string plataformaId,string paltaformaNome)
        {
            Nome = nome;
            Descricao = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;
            Plataforma_ID = plataformaId;
            PlataformaNome = paltaformaNome;
            ValidaDados();

        }

        public void AlterarJogo(string nome, string descricao, string produtora, string distribuidora, string genero, string site, string plataformaId, string paltaformaNome)
        {
            Nome = nome;
            Descricao = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;
            Plataforma_ID = plataformaId;
            PlataformaNome = paltaformaNome;
            ValidaDados();

        }

        private void ValidaDados()
        {
            new AddNotifications<Jogo>(this)
              .IfNullOrInvalidLength(x => x.Nome, 1, 100, "Nome obrigatório e deve ter no minimo 1 até 100 caracteres")
              .IfNullOrInvalidLength(x => x.Descricao, 1, 255, "Descrição obrigatório e deve ter no minimo 1 até 255 caracteres")
              .IfNullOrInvalidLength(x => x.Genero, 1, 30, "Genero obrigatório e deve ter no minimo 1 até 30 caracteres")
              .IfNull(x=> x.Plataforma_ID,"Plataforma é obrigatoria");
        }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public string Produtora { get; private set; }

        public string Distribuidora { get; private set; }

        public string Genero { get; private set; }

        public string Site { get; private set; }
        public string Plataforma_ID { get; set; }
        public string PlataformaNome { get; set; }
        
    }
}
