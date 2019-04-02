using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Domain.Arguments.MeusJogos;
using XGame.Domain.Interface.Servico;
using XGame.Infra2.Transaction;

namespace XGame.Api.Controllers
{
    [RoutePrefix("api/MeusJogos")]
    public class MeusJogosController : ControllerBase
    {
        private readonly IServiceMeusJogos _serviceMeusJogos;
        public MeusJogosController(IUnitOfWork unitOfWork, IServiceMeusJogos serviceMeusJogos) : base(unitOfWork)
        {
            _serviceMeusJogos = serviceMeusJogos;
        }

        [HttpPost]
        [Route("Adicionar")]
        public async Task<HttpResponseMessage> AdicionarMeusJogo(AddMeusJogosRequest request)
        {
            try
            {
                var response = _serviceMeusJogos.AddMeusJogos(request);

                return await ResponseAsync(response, _serviceMeusJogos);
            }
            catch (Exception ex)
            {

                return await ResponseExceptionAsync(ex);
            }

        }
        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar(Guid jogadorId)
        {
            try
            {
                var response = _serviceMeusJogos.Listar(jogadorId);

                return await ResponseAsync(response, _serviceMeusJogos);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}
