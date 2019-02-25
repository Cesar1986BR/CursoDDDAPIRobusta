using System;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Infra2.Persistence.Repositories.Base;

namespace XGame.Infra2.Persistence.Repositories
{
    public class RepositoryJogo : RepositoryBase<Jogo, Guid>, IRepositoryJogo
    {
        protected readonly XGameContext _context;

        public RepositoryJogo(XGameContext context) : base(context)
        {
            _context = context;
        }
    }
}

