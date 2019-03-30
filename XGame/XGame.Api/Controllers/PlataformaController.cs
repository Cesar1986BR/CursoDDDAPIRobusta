using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Interface.Servico;
using XGame.Infra2.Transaction;

namespace XGame.Api.Controllers
{

    [RoutePrefix("api/Plataforma")]
    public class PlataformaController : ControllerBase
    {
        private readonly IServicePlataforma _servicePlataforma;
        private readonly UnityContainer _container;


        public PlataformaController(IUnitOfWork unitOfWork, IServicePlataforma servicePlataforma, UnityContainer uityContainer) : base(unitOfWork)
        {
            _servicePlataforma = servicePlataforma;
            _container = uityContainer;
        }


        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddPlataforma(AddPlataformaRequest addPlataformaRequest)
        {

            try
            {
                var response = _servicePlataforma.AddPlataforma(addPlataformaRequest);
                return await ResponseAsync(response, _servicePlataforma);
            }
            catch (Exception ex)
            {

               return  await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> ListaPlataforma()
        {
            try
            {
                var response =  _servicePlataforma.Listar();
                return await ResponseAsync(response,_servicePlataforma);
            }
            catch (Exception ex)
            {

                return await ResponseExceptionAsync(ex);
            }

        }
        [Route("Excluir")]
        [HttpPost]
        public async Task<HttpResponseMessage> Excluir(Guid id)
        {
            try
            {
                var plataforma = _servicePlataforma.Excluir(id);
                return await ResponseAsync(plataforma, _servicePlataforma);
            }
            catch (Exception ex)
            {

                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Editar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarPlataformaRequest request)
        {
            try
            {
                var plataforma = _servicePlataforma.EditarPlataforma(request);
                return await ResponseAsync(plataforma,_servicePlataforma);
            }
            catch (Exception ex)
            {

                return await ResponseExceptionAsync(ex);
            }
        } 


    }
}
