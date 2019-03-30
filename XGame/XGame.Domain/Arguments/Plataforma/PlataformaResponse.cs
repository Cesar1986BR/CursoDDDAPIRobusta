using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame
{
    public class PlataformaResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public static explicit operator PlataformaResponse(Plataforma plataforma)
        {

            return new PlataformaResponse
            {
                Id = plataforma.ID,
                Nome = plataforma.Nome
            };
        }
    }
}
