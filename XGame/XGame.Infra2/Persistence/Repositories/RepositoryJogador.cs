using System;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Infra2.Persistence.Repositories.Base;

namespace XGame.Infra2.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }
    }
}

