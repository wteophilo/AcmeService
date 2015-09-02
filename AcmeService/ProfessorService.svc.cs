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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProfessorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProfessorService.svc or ProfessorService.svc.cs at the Solution Explorer and start debugging.
    public class ProfessorService : IProfessorService
    {
        private AppDBContext db = new AppDBContext();

        public void adiciona(Professor professor)
        {
            db.Professores.Add(professor);
            db.SaveChanges();
        }

        public void atualiza(Professor professor)
        {
            db.Entry(professor).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Professor detalhe(int? id)
        {
            Professor professor = db.Professores.Include(i => i.leciona).SingleOrDefault(x => x.id == id);
            return professor;
        }

        public ICollection<Professor> lista()
        {
            return db.Professores.ToList();
        }

        public Professor procura(int? id)
        {
            return db.Professores.Find(id);
        }

        public void remove(Professor professor)
        {
            db.Professores.Attach(professor);
            db.Professores.Remove(professor);
            db.SaveChanges();
        }
    }
}
