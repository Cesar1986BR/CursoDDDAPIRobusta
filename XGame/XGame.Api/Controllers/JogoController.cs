using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Api.Security;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Servico;
using XGame.Domain.Services;
using XGame.Infra2.Transaction;

namespace XGame.Api.Controllers
{
    [RoutePrefix("api/jogo")]
    public class JogoController : ControllerBase
    {
        private readonly IServiceJogo _serviceJogo;
        private readonly UnityContainer _container;

        public JogoController(IUnitOfWork unitOfWork,  IServiceJogo serviceJogo, UnityContainer uityContainer) : base(unitOfWork)
        {
            _serviceJogo = serviceJogo;
            _container = uityContainer;
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
        [HttpPut]
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

        [Authorize]
        [Route("Excluir")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Excluir(Guid id)
        {
            //var jogador = new Jogador();
            //jogador.Email.EmailEndereco = "cesarpower20@yahoo.com.br";


            //("cesarpower20@yahoo.com.br", "10203040");
            //var context = new OAuthGrantResourceOwnerCredentialsContext(jogador.ID, jogador.Nome.PrimeiroNome, jogador.Senha);

            //var checkAuthorize = new AuthorizationProvider(_container);
            //checkAuthorize.GrantResourceOwnerCredentials();
            try
            {
                var response = _serviceJogo.Excluir(id);

                return await ResponseAsync(response, _serviceJogo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}