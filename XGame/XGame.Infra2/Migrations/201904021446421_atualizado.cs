namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MeusJogo", "Jogo_ID", "dbo.Jogo");
            DropIndex("dbo.MeusJogo", new[] { "Jogo_ID" });
            AddColumn("dbo.MeusJogo", "ID_Jogo", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.MeusJogo", "ID_Jogador", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.MeusJogo", "Desejado");
            DropColumn("dbo.MeusJogo", "Troca");
            DropColumn("dbo.MeusJogo", "Vender");
            DropColumn("dbo.MeusJogo", "DataDesejado");
            DropColumn("dbo.MeusJogo", "Jogo_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MeusJogo", "Jogo_ID", c => c.Guid());
            AddColumn("dbo.MeusJogo", "DataDesejado", c => c.DateTime(nullable: false));
            AddColumn("dbo.MeusJogo", "Vender", c => c.Boolean(nullable: false));
            AddColumn("dbo.MeusJogo", "Troca", c => c.Boolean(nullable: false));
            AddColumn("dbo.MeusJogo", "Desejado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MeusJogo", "ID_Jogador", c => c.Guid(nullable: false));
            DropColumn("dbo.MeusJogo", "ID_Jogo");
            CreateIndex("dbo.MeusJogo", "Jogo_ID");
            AddForeignKey("dbo.MeusJogo", "Jogo_ID", "dbo.Jogo", "ID");
        }
    }
}
