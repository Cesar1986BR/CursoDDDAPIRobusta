using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories.Base;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogador :IRepositoryBase<Jogador,Guid>
    {
       // Jogador Autenticar(string email, string senha);

    }
}
