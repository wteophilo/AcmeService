using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AcmeService.Model;
using AcmeService.DAL;
using System.Data.Entity;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CursoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CursoService.svc or CursoService.svc.cs at the Solution Explorer and start debugging.
    public class CursoService : ICursoService
    {
        private AppDBContext db = new AppDBContext();

        public void adiciona(Curso curso)
        {
            db.Cursos.Add(curso);
            db.SaveChanges();
        }

        public void atualiza(Curso curso)
        {
            db.Entry(curso).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Curso detalhe(int? id)
        {
            Curso curso = db.Cursos.Include(i => i.inscricoes).SingleOrDefault(x => x.id == id);
            return curso;
        }

        public ICollection<Curso> lista()
        {
            return db.Cursos.ToList();
        }

        public Curso procura(int? id)
        {
            return db.Cursos.Find(id);
        }

        public void remove(Curso curso)
        {
            db.Cursos.Remove(curso);
            db.SaveChanges();
        }
    }
}
