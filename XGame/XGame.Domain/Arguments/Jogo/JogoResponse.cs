using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace XGame.Domain
{
    public class JogoResponse
    {

        public Guid ID { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string Site { get; set; }
        public IEnumerable< Plataforma> Plataforma { get; set; }

        public static explicit operator JogoResponse(Entities.Jogo jogo)
        {

            return new JogoResponse
            {
                ID = jogo.ID,
                Nome = jogo.Nome,
                Descricao = jogo.Descricao,
                Produtora = jogo.Produtora,
                Distribuidora = jogo.Distribuidora,
                Genero = jogo.Genero,
                Site = jogo.Site,
                Plataforma = new List<Plataforma>()

            };
        }

    }
        
}
