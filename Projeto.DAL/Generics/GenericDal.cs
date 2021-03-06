﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.DataSource;
using System.Data.Entity;

namespace Projeto.DAL.Generics
{
    public class GenericDal<TEntity> : IGenericDal<TEntity>, IDisposable
        where TEntity : class
    {
        protected Conexao Con;

        public GenericDal()
        {
            Con = new Conexao();
        }

        public void Insert(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Added;
            Con.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Modified;
            Con.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Deleted;
            Con.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return Con.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return Con.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            Con.Dispose();
        }
    }
}
