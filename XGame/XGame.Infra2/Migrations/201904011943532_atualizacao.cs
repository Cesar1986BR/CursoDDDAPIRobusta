namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plataforma", "Jogo_ID", "dbo.Jogo");
            DropIndex("dbo.Plataforma", new[] { "Jogo_ID" });
            DropColumn("dbo.Plataforma", "Jogo_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plataforma", "Jogo_ID", c => c.Guid());
            CreateIndex("dbo.Plataforma", "Jogo_ID");
            AddForeignKey("dbo.Plataforma", "Jogo_ID", "dbo.Jogo", "ID");
        }
    }
}
