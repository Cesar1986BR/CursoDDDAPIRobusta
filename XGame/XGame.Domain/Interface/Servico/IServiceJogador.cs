﻿using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interface.Servico
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);
        AddJogadorResponse AddJogador(AddJogadorRequest request);

    }
}
