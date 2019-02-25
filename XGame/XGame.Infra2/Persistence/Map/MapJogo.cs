using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MapJogo : EntityTypeConfiguration<Jogo>
    {
        public MapJogo()
        {

            ToTable("Jogo");

            Property(p => p.Nome)
                .HasMaxLength(50).IsRequired();

            Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Genero)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Site)
                .HasMaxLength(200)
                .IsRequired();
            Property(p => p.Produtora)
                .HasMaxLength(50)
                .IsRequired();



        }
    }
}
