using AcmeService.DAL;
using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EstudanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstudanteService.svc or EstudanteService.svc.cs at the Solution Explorer and start debugging.
    public class EstudanteService : IEstudanteService
    {
        private AppDBContext db = new AppDBContext();


        public void adiciona(Estudante estudante)
        {
            db.Estudantes.Add(estudante);
            db.SaveChanges();
        }

        public Estudante find(Estudante estudante)
        {
            return db.Estudantes.Find(estudante);
        }

        public ICollection<Estudante> listaEstudante()
        {
            return db.Estudantes.ToList();
        }

        public void remove(Estudante estudante)
        {
            db.Estudantes.Remove(estudante);
            db.SaveChanges();
        }

        public void atualiza(Estudante estudante)
        {
            db.Entry(estudante).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Estudante procura(int? idestudante)
        {
            return db.Estudantes.Find(idestudante);
        }

       
        Estudante IEstudanteService.detalhe(int? idEstudante)
        {
            Estudante estudante = db.Estudantes.Include(i => i.inscricoes).SingleOrDefault(x => x.id == idEstudante);
            return estudante;
        }
    }
}
