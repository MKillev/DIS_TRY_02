using System;
using System.Collections.Generic;
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
        List<T> GetAll();
    }
    public class Repository<T>: IRepository<T> where T: class
    {
        private DbSet<T> dbSet { get; set; }
        private readonly DIS_Entities DBContext = new DIS_Entities();
        public Repository(DbContext dbContext)
        {
            
            dbContext = DBContext;
            dbSet = dbContext.Set<T>();          
        }

        public Repository()
        {
            
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
            //Update
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        } 
    }
}
