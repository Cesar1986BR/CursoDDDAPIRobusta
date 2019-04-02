namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Jogador", "MeusJogo_ID", c => c.Guid());
            AddColumn("dbo.Plataforma", "Jogo_ID", c => c.Guid());
            CreateIndex("dbo.Jogador", "MeusJogo_ID");
            CreateIndex("dbo.Plataforma", "Jogo_ID");
            AddForeignKey("dbo.Plataforma", "Jogo_ID", "dbo.Jogo", "ID");
            AddForeignKey("dbo.Jogador", "MeusJogo_ID", "dbo.MeusJogo", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogador", "MeusJogo_ID", "dbo.MeusJogo");
            DropForeignKey("dbo.MeusJogo", "Jogo_ID", "dbo.Jogo");
            DropForeignKey("dbo.Plataforma", "Jogo_ID", "dbo.Jogo");
            DropIndex("dbo.Plataforma", new[] { "Jogo_ID" });
            DropIndex("dbo.MeusJogo", new[] { "Jogo_ID" });
            DropIndex("dbo.Jogador", new[] { "MeusJogo_ID" });
            DropColumn("dbo.Plataforma", "Jogo_ID");
            DropColumn("dbo.Jogador", "MeusJogo_ID");
            DropTable("dbo.Jogo");
            DropTable("dbo.MeusJogo");
        }
    }
}
