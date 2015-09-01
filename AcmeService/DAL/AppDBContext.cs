using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AcmeService.Model;
using System.Configuration;

namespace AcmeService.DAL
{
    public class AppDBContext: DbContext
    { 

        public AppDBContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<ProfessorCurso> Leciona { get; set; }
    }
}