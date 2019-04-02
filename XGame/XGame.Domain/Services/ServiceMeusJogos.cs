using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.MeusJogos;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Servico;

namespace XGame.Domain.Services
{
    public class ServiceMeusJogos : Notifiable, IServiceMeusJogos
    {
        private readonly IRepositoryMeusJogos _repositoryMeusJogos;
        private readonly IRepositoryJogo _repositoryJogo;
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceMeusJogos()
        {

        }
        public ServiceMeusJogos(IRepositoryMeusJogos repositoryMeusJogos, IRepositoryJogo repositoryJogo, IRepositoryJogador repositoryJogador)
        {
            _repositoryMeusJogos = repositoryMeusJogos;
            _repositoryJogo = repositoryJogo;
            _repositoryJogador = repositoryJogador;
        }

        public AddMeusJogosResponse AddMeusJogos(AddMeusJogosRequest request)
        {
            if (request == null)
            {
                AddNotification("Adiconar meus jogos", "Dados são obrigatórios");
            }

            var meusjogos = new MeusJogo(request.ID_Jogo,request.ID_Jogogador);
            AddNotifications(meusjogos);

            if (this.IsInvalid())
                return null;

            meusjogos = _repositoryMeusJogos.Adicionar(meusjogos);

            return (AddMeusJogosResponse)meusjogos;
        }

        public ResponseBase EditarMeusJogos(AlterarMeusJogosRequest request)
        {
            throw new NotImplementedException();
        }

        public ResponseBase Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

         public  MeusJogosResponse Listar(Guid jogadorId)
        {
            var meusjogos = new MeusJogosResponse();//cria uma isntancia de MeusJogos

            var meusjogosList = _repositoryMeusJogos.Listar().ToList();//retorna lista tabela MeusJogos
            var jogoList = _repositoryJogo.Listar().ToList();//retorna lista de todos os jogos

            var jogadoresList = _repositoryJogador.Listar().ToList();
            var jogadorResult  = jogadoresList.Where(jo => jo.ID == jogadorId).Select(j=>j.Nome).FirstOrDefault();

            meusjogos.NomeJogador = jogadorResult.PrimeiroNome;

            var jogador = meusjogosList.Where(j => j.ID_Jogador == jogadorId.ToString()).ToList();//pega todos os jogos de acordo com id do jogador

            foreach (var jogosjogador in jogador)
            {
                var gameresult = jogoList.Where(j=> j.ID == new Guid(jogosjogador.ID_Jogo)).FirstOrDefault();//pega jogo pelo id
                meusjogos.MeusJogos.Add(gameresult.Nome);

            }

            return meusjogos;
        }
    }
}
