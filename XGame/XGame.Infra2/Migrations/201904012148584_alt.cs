namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogo", "PlataformaNome", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogo", "PlataformaNome");
        }
    }
}
