using prmToolkit.NotificationPattern;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Interface.Servico;
using XGame.Domain.Services;
using XGame.Infra2.Transaction;

namespace XGame.Api.Controllers
{
    [RoutePrefix("api/jogo")]
    public class JogoController : ControllerBase
    {
        private readonly IServiceJogo _serviceJogo;

        public JogoController(IUnitOfWork unitOfWork,  IServiceJogo serviceJogo) : base(unitOfWork)
        {
            _serviceJogo = serviceJogo;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarJogoRequest request)
        {
            try
            {
                var response = _serviceJogo.AddJogo(request);

                return await ResponseAsync(response, _serviceJogo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Alterar(AlterarJogoRequest request)
        {
            try
            {
                var response = _serviceJogo.AlterarJogo(request);

                return await ResponseAsync(response, _serviceJogo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceJogo.ListarJogo();

                return await ResponseAsync(response, _serviceJogo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}