using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;

namespace XGame.Domain.Services
{
    public class ServiceJogo : Notifiable, IServiceJogo
    {
        private readonly IRepositoryJogo _repositoryJogo;


        public ServiceJogo()
        {

        }   

        public ServiceJogo(IRepositoryJogo repositoryJogo)
        {
            _repositoryJogo = repositoryJogo;
        }

        public AdicionarJogoResponse AddJogo(AdicionarJogoRequest request)
        {
            if (request == null)
            {
                AddNotification("Adicionar","Dados são obrigatórios");
            }

            var jogo = new Jogo(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            AddNotifications(jogo);

            if (this.IsInvalid())
            {
                return null;
            }

            jogo = _repositoryJogo.Adicionar(jogo);


            return (AdicionarJogoResponse)jogo;
        }

        public ResponseBase AlterarJogo(AlterarJogoRequest request)
        {
            if (request == null)
            {
                AddNotification("Alterar", "Dados são obrigatórios");
            }
            var jogo = _repositoryJogo.ObterPorId(request.ID);
            if (request == null)
            {
                AddNotification("Alterar", "Jogo não encontrado");
            }
            jogo.AlterarJogo(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            AddNotifications(jogo);

            if (this.IsInvalid())
            {
                return null;
            }

            jogo = _repositoryJogo.Editar(jogo);


            return (ResponseBase)jogo;
        }


        public ResponseBase Excluir(Guid id)
        {
            var jogo = _repositoryJogo.ObterPorId(id);
            if (jogo == null)
            {
                AddNotification("Excluir", "Nehum jogo encontrado");
            }

            _repositoryJogo.Remover(jogo);


            return new ResponseBase() { Message = "Jogo Excluido com sucesso" };
        }

        IEnumerable<JogoResponse> IServiceJogo.ListarJogo()
        {
            return _repositoryJogo.Listar().ToList().Select(jogo => (JogoResponse)jogo).ToList();
        }
    }
}
