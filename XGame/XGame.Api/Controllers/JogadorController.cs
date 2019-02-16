using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interface.Servico;
using XGame.Infra2.Transaction;

namespace XGame.Api.Controllers
{
    [RoutePrefix("api/jogador")]
    public class JogadorController : ControllerBase
    {
        private readonly IServiceJogador _serviceJogador;

        public JogadorController(IUnitOfWork unitOfWork,  IServiceJogador serviceJogador) : base(unitOfWork)
        {
            _serviceJogador = serviceJogador;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AddJogadorRequest request)
        {
            try
            {
                var response = _serviceJogador.AddJogador(request);

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        //[Route("Listar")]
        //[HttpGet]
        //public async Task<HttpResponseMessage> Listar()
        //{
        //    try
        //    {
        //        var response = _serviceJogador.ListarJogador();

        //        return await ResponseAsync(response, _serviceJogador);
        //    }
        //    catch (Exception ex)
        //    {
        //        return await ResponseExceptionAsync(ex);
        //    }
        //}


    }
}