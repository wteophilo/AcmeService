namespace AcmeService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addteste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        descricao = c.String(nullable: false, maxLength: 50),
                        dataLimiteInscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Inscricaos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cursoId = c.Int(nullable: false),
                        estudanteId = c.Int(nullable: false),
                        dataInscricao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cursoes", t => t.cursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudantes", t => t.estudanteId, cascadeDelete: true)
                .Index(t => t.cursoId)
                .Index(t => t.estudanteId);
            
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        sobrenome = c.String(nullable: false, maxLength: 50),
                        dataMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProfessorCursoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cursoId = c.Int(nullable: false),
                        professorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cursoes", t => t.cursoId, cascadeDelete: true)
                .ForeignKey("dbo.Professors", t => t.professorId, cascadeDelete: true)
                .Index(t => t.cursoId)
                .Index(t => t.professorId);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        sobrenome = c.String(nullable: false, maxLength: 50),
                        titulacao = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessorCursoes", "professorId", "dbo.Professors");
            DropForeignKey("dbo.ProfessorCursoes", "cursoId", "dbo.Cursoes");
            DropForeignKey("dbo.Inscricaos", "estudanteId", "dbo.Estudantes");
            DropForeignKey("dbo.Inscricaos", "cursoId", "dbo.Cursoes");
            DropIndex("dbo.ProfessorCursoes", new[] { "professorId" });
            DropIndex("dbo.ProfessorCursoes", new[] { "cursoId" });
            DropIndex("dbo.Inscricaos", new[] { "estudanteId" });
            DropIndex("dbo.Inscricaos", new[] { "cursoId" });
            DropTable("dbo.Professors");
            DropTable("dbo.ProfessorCursoes");
            DropTable("dbo.Estudantes");
            DropTable("dbo.Inscricaos");
            DropTable("dbo.Cursoes");
        }
    }
}
