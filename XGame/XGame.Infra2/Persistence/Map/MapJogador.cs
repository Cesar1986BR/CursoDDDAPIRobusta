using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MapJogador: EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            Property(p => p.Email.EmailEndereco).HasMaxLength(200)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true }))
                .HasColumnName("Email");

            Property(p => p.Nome.PrimeiroNome)
                .HasMaxLength(50).IsRequired()
                .HasColumnName("PrimeiroNome");

            Property(p => p.Nome.UltimoNome).HasMaxLength(50)
                .IsRequired()
                .HasColumnName("UltimoNome");

            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();
        }
    }
}
