using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.MeusJogos;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Servico.Base;

namespace XGame.Domain.Interface.Servico
{
    public interface IServiceMeusJogos : IServiceBase
    {

        MeusJogosResponse Listar(Guid jogadorId);
        AddMeusJogosResponse AddMeusJogos(AddMeusJogosRequest request);
        ResponseBase Excluir(Guid id);
        ResponseBase EditarMeusJogos(AlterarMeusJogosRequest request);


    }
}
