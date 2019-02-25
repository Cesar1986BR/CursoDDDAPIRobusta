using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Base;
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

            AddNotifications(nome, email);

            if (_repositoryJogador.Existe(x => x.Email.EmailEndereco == request.Email))
            {
                AddNotification("E-mail", "Email informado ja está em uso.");
            }

            if (this.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.Adicionar(jogador);


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
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);


            if (jogador.IsInvalid())
                return null;

            jogador = _repositoryJogador.ObterPor(x => x.Email.EmailEndereco == jogador.Email.EmailEndereco &&  x.Senha == jogador.Senha);
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

            var jogador = _repositoryJogador.ObterPorId(request.ID);

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

            _repositoryJogador.Editar(jogador);

            return (AlterarResponse)jogador;
        }



        public IEnumerable<JogadorResponse> ListaJogador()
        {
            return _repositoryJogador.Listar().ToList().Select(jogador => (JogadorResponse)jogador).ToList(); 
        }
        public GetJogadorByIDResponse GetJogadorByID(GetJogadorByIDRequest request)
        {

            var jogador = _repositoryJogador.ObterPorId(request.ID);
            return (GetJogadorByIDResponse)jogador;
        }

        public ResponseBase ExcluirJogador(Guid id)
        {
            Jogador jogador = _repositoryJogador.ObterPorId(id);

            if (jogador ==  null)
            {
                AddNotification("ID", "Dados não encontrado.");
            }
            _repositoryJogador.Remover(jogador);

            return new ResponseBase() {Message = "Jogador excluido com sucesso"  }; 

        }
    }
}
