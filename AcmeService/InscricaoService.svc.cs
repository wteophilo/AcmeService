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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InscricaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InscricaoService.svc or InscricaoService.svc.cs at the Solution Explorer and start debugging.
    public class InscricaoService : IInscricaoService
    {
        private AppDBContext db = new AppDBContext();

        public void adiciona(Inscricao inscricao)
        {
            db.Inscricoes.Add(inscricao);
            db.SaveChanges();
        }

        public void atualiza(Inscricao inscricao)
        {
            db.Entry(inscricao).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Inscricao detalhe(int? id)
        {
            Inscricao inscricao = db.Inscricoes.Include(i => i.curso).SingleOrDefault(x => x.id == id);
            return inscricao;
        }

        public ICollection<Inscricao> lista()
        {
            return db.Inscricoes.ToList();
        }

        public Inscricao procura(int? id)
        {
            return db.Inscricoes.Find(id);
        }

        public void remove(Inscricao inscricao)
        {
            db.Inscricoes.Attach(inscricao);
            db.Inscricoes.Remove(inscricao);
            db.SaveChanges();
        }
    }
}
