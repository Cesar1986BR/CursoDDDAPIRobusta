using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Servico.Base;

namespace XGame.Domain.Interface.Servico
{
    public interface IServicePlataforma : IServiceBase
    {

        IEnumerable<PlataformaResponse> Listar();
        AddPlataformaResponse AddPlataforma(AddPlataformaRequest request);
        ResponseBase Excluir(Guid id);
        ResponseBase EditarPlataforma(AlterarPlataformaRequest request);


    }
}
