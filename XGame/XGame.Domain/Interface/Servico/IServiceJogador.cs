using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interface.Servico.Base;

namespace XGame.Domain.Interface.Servico
{
    public interface IServiceJogador: IServiceBase
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);
        AddJogadorResponse AddJogador(AddJogadorRequest request);

        AlterarResponse AlterarJogador(AlterarRequest request);
        IEnumerable<JogadorResponse> ListaJogador();
        ResponseBase ExcluirJogador(Guid id);

    }
}
