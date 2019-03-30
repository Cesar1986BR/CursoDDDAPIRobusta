namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogador",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        UltimoNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                        MeusJogo_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MeusJogo", t => t.MeusJogo_ID)
                .Index(t => t.Email, unique: true, name: "UK_JOGADOR_EMAIL")
                .Index(t => t.MeusJogo_ID);
            
            CreateTable(
                "dbo.MeusJogo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ID_Jogador = c.Guid(nullable: false),
                        Desejado = c.Boolean(nullable: false),
                        Troca = c.Boolean(nullable: false),
                        Vender = c.Boolean(nullable: false),
                        DataDesejado = c.DateTime(nullable: false),
                        Jogo_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Jogo", t => t.Jogo_ID)
                .Index(t => t.Jogo_ID);
            
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
            
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Jogo_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Jogo", t => t.Jogo_ID)
                .Index(t => t.Jogo_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogador", "MeusJogo_ID", "dbo.MeusJogo");
            DropForeignKey("dbo.MeusJogo", "Jogo_ID", "dbo.Jogo");
            DropForeignKey("dbo.Plataforma", "Jogo_ID", "dbo.Jogo");
            DropIndex("dbo.Plataforma", new[] { "Jogo_ID" });
            DropIndex("dbo.MeusJogo", new[] { "Jogo_ID" });
            DropIndex("dbo.Jogador", new[] { "MeusJogo_ID" });
            DropIndex("dbo.Jogador", "UK_JOGADOR_EMAIL");
            DropTable("dbo.Plataforma");
            DropTable("dbo.Jogo");
            DropTable("dbo.MeusJogo");
            DropTable("dbo.Jogador");
        }
    }
}
