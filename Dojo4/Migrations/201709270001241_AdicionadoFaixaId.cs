namespace Dojo4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoFaixaId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alunoes", "FaixaId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alunoes", "FaixaId");
        }
    }
}
