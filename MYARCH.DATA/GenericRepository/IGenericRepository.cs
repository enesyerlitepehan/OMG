using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYARCH.DATA.GenericRepository
{
    // gönderilen class'a göre dönen metodlar 
    //gelen sınıf ismi : TEntity  ve  bu classmı ?
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Sorgu işlemleri için GetAll metotdunu kullanıyoruz.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// id ye göre veri çekmek için Find metodu.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Find(int id); //gönderilen sınıfa göre bana değer döndürecek

        /// <summary>
        /// Gönderilen entity ye göre kayıt işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Gönderilen entity ye göre güncelleme işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Gönderilen entity ye göre silme işlemi
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);



    }
}
