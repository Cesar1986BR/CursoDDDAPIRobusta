using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
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

        public AlterarJogoResponse AlterarJogo(AlterarJogoRequest request)
        {
            throw new NotImplementedException();
        }

        public ExcluirJogoResponse Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdicionarJogoResponse> ListarJogo()
        {
            throw new NotImplementedException();
        }
    }
}
