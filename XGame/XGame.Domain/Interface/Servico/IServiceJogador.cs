using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interface.Servico
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);
        AddJogadorResponse AddJogador(AddJogadorRequest request);

        AlterarResponse AlterarJogador(AlterarRequest request);
        IEnumerable<JogadorResponse> ListaJogador();
        ReponseBase ExcluirJogador(Guid id);

    }
}
