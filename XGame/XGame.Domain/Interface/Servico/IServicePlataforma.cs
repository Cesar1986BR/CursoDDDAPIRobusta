using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.Entities;

namespace XGame.Domain.Interface.Servico
{
    public interface IServicePlataforma
    {

        AddPlataformaResponse AddPlataforma(AddPlataformaRequest request);

    }
}
