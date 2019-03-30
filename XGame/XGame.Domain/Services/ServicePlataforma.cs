using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Servico;

namespace XGame.Domain.Services
{
    public class ServicePlataforma : Notifiable, IServicePlataforma
    {
        private readonly IRepositoryPlataforma _repositoryPlataforma;

        public ServicePlataforma()
        {

        }
        public ServicePlataforma(IRepositoryPlataforma repositoryPlataforma)
        {
            _repositoryPlataforma = repositoryPlataforma;
        }

        public AddPlataformaResponse AddPlataforma(AddPlataformaRequest request)
        {
            if (request == null)
            {
                AddNotification("Adiconar Plataforma","Dados são obrigatórios");
            }

            var plataforma = new Plataforma(request.Nome);
            AddNotifications(plataforma);

            if (this.IsInvalid())
                return null;

            plataforma = _repositoryPlataforma.Adicionar(plataforma);

            return (AddPlataformaResponse)plataforma;
            
                
        }

        public ResponseBase EditarPlataforma(AlterarPlataformaRequest request)
        {
            if (request == null)
                AddNotification("Alterar", "Dados são obrigatórios");

            var plataforma = _repositoryPlataforma.ObterPorId(request.Id);

            if (plataforma == null)
                AddNotification("Erro", "Plataforna não localizada");

            plataforma.Alterar(request.Nome);
            AddNotifications(plataforma);

            if (this.IsInvalid())
                return null;

            plataforma = _repositoryPlataforma.Editar(plataforma);


            return new ResponseBase { Message = "Jogo Alterado com sucesso" };
        }

        public ResponseBase Excluir(Guid id)
        {
            var plataforma = _repositoryPlataforma.ObterPorId(id);

            if (plataforma == null)
                AddNotification("Plataforma","Plataforma não localizada");

            _repositoryPlataforma.Remover(plataforma);

            return new ResponseBase {Message = "Plataforma excluida com sucesso." };

        }

        IEnumerable<PlataformaResponse> IServicePlataforma.Listar()
        {
            return _repositoryPlataforma.Listar().ToList().Select(p=>(PlataformaResponse)p).ToList();
        }
    }
}
