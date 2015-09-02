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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProfessorCursoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProfessorCursoService.svc or ProfessorCursoService.svc.cs at the Solution Explorer and start debugging.
    public class ProfessorCursoService : IProfessorCursoService
    {
        private AppDBContext db = new AppDBContext();

        public void adiciona(ProfessorCurso professorCurso)
        {
            db.Leciona.Add(professorCurso);
            db.SaveChanges();
        }

        public void atualiza(ProfessorCurso professorCurso)
        {
            db.Entry(professorCurso).State = EntityState.Modified;
            db.SaveChanges();
        }

        public ProfessorCurso detalhe(int? id)
        {
            ProfessorCurso professorCurso = db.Leciona.Include(i => i.professor).SingleOrDefault(x => x.id == id);
            return professorCurso;

        }

        public ICollection<ProfessorCurso> lista()
        {
            return db.Leciona.ToList();
        }

        public ProfessorCurso procura(int? id)
        {
            return db.Leciona.Find(id);
        }

        public void remove(ProfessorCurso professorCurso)
        {
            db.Leciona.Attach(professorCurso);
            db.Leciona.Remove(professorCurso);
            db.SaveChanges();
        }
    }
}
