using MYARCH.DATA.Context;
using MYARCH.DATA.GenericRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYARCH.DATA.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly MyArchContext _context; //savechanges işlemini yapabilmek için 
        private bool disposed = false;
        public UnitofWork(MyArchContext context)
        {
            Database.SetInitializer<MyArchContext>(null); //veritabanına bağlanıyor ?
            if (context == null)
                throw new ArgumentException("context is null");
            _context = context;
        }
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context);
        }
        public int SaveChanges()
        {
            return _context.SaveChanges(); //kayıt yapılıyor
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction(); //BeginTransaction hazır metod 
        }

        public void Commit()
        {
            Commit();
        }

        public void Rollback()
        {
            Rollback();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()//Durdurma işlemi yapmakta
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
