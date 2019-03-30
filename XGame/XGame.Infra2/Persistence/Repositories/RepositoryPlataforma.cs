using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interface.Repositories;
using XGame.Infra2.Persistence.Repositories.Base;

namespace XGame.Infra2.Persistence.Repositories
{
    public class RepositoryPlataforma : RepositoryBase<Plataforma,Guid>,IRepositoryPlataforma
    {
        protected readonly XGameContext _context;
        public RepositoryPlataforma(XGameContext context): base(context)
        {
            _context = context;
        }
    }
}
