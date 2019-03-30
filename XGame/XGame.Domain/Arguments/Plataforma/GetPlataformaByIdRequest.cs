using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.Plataforma
{
    public class GetPlataformaByIdRequest
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
