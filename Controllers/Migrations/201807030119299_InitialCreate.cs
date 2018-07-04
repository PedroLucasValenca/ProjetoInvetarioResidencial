namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        NomeItem = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Descricao = c.String(),
                        DataArmazenamento = c.DateTime(nullable: false),
                        LocalID = c.Int(nullable: false),
                        TipoUsoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Locals", t => t.LocalID, cascadeDelete: true)
                .ForeignKey("dbo.TipoUsoes", t => t.TipoUsoID, cascadeDelete: true)
                .Index(t => t.LocalID)
                .Index(t => t.TipoUsoID);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        LocalID = c.Int(nullable: false, identity: true),
                        NomeLocal = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.LocalID);
            
            CreateTable(
                "dbo.TipoUsoes",
                c => new
                    {
                        TipoUsoID = c.Int(nullable: false, identity: true),
                        NomeTipoUso = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TipoUsoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "TipoUsoID", "dbo.TipoUsoes");
            DropForeignKey("dbo.Items", "LocalID", "dbo.Locals");
            DropIndex("dbo.Items", new[] { "TipoUsoID" });
            DropIndex("dbo.Items", new[] { "LocalID" });
            DropTable("dbo.TipoUsoes");
            DropTable("dbo.Locals");
            DropTable("dbo.Items");
        }
    }
}
