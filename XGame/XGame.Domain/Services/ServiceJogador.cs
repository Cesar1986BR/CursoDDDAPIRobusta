using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Servico;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;
        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }
        public AddJogadorResponse AddJogador(AddJogadorRequest request)
        {

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            Jogador jogador = new Jogador(nome, email, request.Senha);


            if (this.IsInvalid())
            {
                return null;
            }


            return (AddJogadorResponse)jogador;
        }
        public AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("Autenticacção", "atutenticação é obrigatoria");
            }


            //  var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            var jogador = new Jogador(null, email, request.Senha);

            AddNotifications(jogador, email);


            if (jogador.IsInvalid())
                return null;

            jogador = _repositoryJogador.Autenticar(jogador.Email.EmailEndereco, jogador.Senha);
            return (AutenticarJogadorResponse)jogador;
        }

        public AlterarResponse AlterarJogador(AlterarRequest request)
        {

            if (request == null)
            {
                AddNotification("Alteracao", "dados é obrigatorio");
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            var jogador = _repositoryJogador.GetJogadorById(request.ID);

            if (jogador == null)
            {
                AddNotification("ID","Jogador não encontrado");
                return null;
            }


            jogador.AlterarJogador(nome, email,jogador.Status);

            if (this.IsInvalid())
            {
                return null;
            }
            AddNotifications(jogador);

            _repositoryJogador.AlterarJogador(jogador);

            return (AlterarResponse)jogador;
        }



        public IEnumerable<JogadorResponse> ListaJogador()
        {
            return _repositoryJogador.ListaJogador().ToList().Select(jogador => (JogadorResponse)jogador).ToList(); ;
        }

    }
}
