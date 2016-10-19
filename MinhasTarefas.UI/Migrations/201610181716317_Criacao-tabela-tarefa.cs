namespace MinhasTarefas.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacaotabelatarefa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoriaId = c.Int(nullable: false),
                        Titulo = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarefas", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Tarefas", new[] { "CategoriaId" });
            DropTable("dbo.Tarefas");
        }
    }
}
