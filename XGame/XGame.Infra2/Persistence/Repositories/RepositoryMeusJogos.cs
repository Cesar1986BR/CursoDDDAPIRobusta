using System;
using XGame.Domain.Entities;
using XGame.Domain.Interface.Repositories;
using XGame.Infra2.Persistence.Repositories.Base;

namespace XGame.Infra2.Persistence.Repositories
{
    public class RepositoryMeusJogos : RepositoryBase<MeusJogo, Guid>, IRepositoryMeusJogos
    {
        protected readonly XGameContext _context;

        public RepositoryMeusJogos(XGameContext context) : base(context)
        {
            _context = context;
        }
    }
}

