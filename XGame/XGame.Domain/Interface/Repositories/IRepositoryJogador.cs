using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador Autenticar(string email, string senha);
        Jogador AddJogador(Jogador request);

        IEnumerable<Jogador> ListaJogador();

        Jogador GetJogadorById(Guid Id);
        Jogador AlterarJogador(Jogador jogador);
    }
}
