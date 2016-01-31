using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;

namespace DIS_TRY_02.Repository
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetById(int id);
        List<T> GetAll();
        
    }
    public class Repository<T>: IRepository<T> where T: class
    {
        private DbSet<T> dbSet { get; set; }
        private  DIS_Entities DBContext { get; set; }
        public Repository(DIS_Entities dbContext)
        {
            
            DBContext = dbContext;
            dbSet = dbContext.Set<T>();          
        }

        public Repository()
        {
            
        }
        public T GetById(int id)
        {
            return dbSet.Find(id);
        }
        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            var entry = DBContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            entry.State = EntityState.Modified;
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        } 
    }
}
