namespace MVCPagina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.FeatureId)
                .ForeignKey("dbo.Servicios", t => t.ServicioId)
                .Index(t => t.ServicioId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CantidadIconos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Features", "ServicioId", "dbo.Servicios");
            DropIndex("dbo.Features", new[] { "ServicioId" });
            DropTable("dbo.Servicios");
            DropTable("dbo.Features");
        }
    }
}
