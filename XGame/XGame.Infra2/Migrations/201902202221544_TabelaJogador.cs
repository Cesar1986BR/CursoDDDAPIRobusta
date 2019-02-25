namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaJogador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 200, unicode: false),
                        Produtora = c.String(nullable: false, maxLength: 50, unicode: false),
                        Distribuidora = c.String(maxLength: 100, unicode: false),
                        Genero = c.String(nullable: false, maxLength: 50, unicode: false),
                        Site = c.String(nullable: false, maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogo");
        }
    }
}
