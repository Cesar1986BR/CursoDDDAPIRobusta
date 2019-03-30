using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame
{
    public class AlterarPlataformaResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public static explicit operator AlterarPlataformaResponse(Plataforma plataforma)
        {

            return new AlterarPlataformaResponse
            {
                Id = plataforma.ID,
                Nome = plataforma.Nome
            };
        }
    }
}
