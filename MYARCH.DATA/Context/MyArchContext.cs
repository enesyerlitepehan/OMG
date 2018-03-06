using MYARCH.CORE;
using System;
using System.Data.Entity;

namespace MYARCH.DATA.Context
{
    // Context: içerik
    public partial class MyArchContext : DbContext
    {
        private readonly MyArchContext _context;
        public MyArchContext()
            : base("name=MyArchEntities") //bağlanacağımız veri tabanı
        {
            Configuration.LazyLoadingEnabled = false; //tablolar arasındaki ilişkiler varsa bu özellik ya false yapılacak yada ilişkiler tanımlanacak
        }
        // virtual tablo tanımlanırken kullanılıyor
        public virtual DbSet<User> User { get; set; } //Tablolar tanımlanıyor
        public virtual DbSet<Post> Post { get; set; } //Tablolar tanımlanıyor
        public virtual DbSet<Category> Category { get; set; } //Tablolar tanımlanıyor

        // dbo varsayılan şema denebilir
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //tablolar için şema oluşturuluyor //dbo standart şema
        {   
            modelBuilder.Entity<User>().ToTable("User", "dbo");
            modelBuilder.Entity<Post>().ToTable("Post", "dbo");
            modelBuilder.Entity<Category>().ToTable("Category", "dbo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
