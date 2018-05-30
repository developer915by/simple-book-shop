using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeregaFan.Models
{
    public class BookContexst : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContexst>
    {
        protected override void Seed(BookContexst db)
        {
            db.Books.Add(new Book { Name = "война и мир ", Author = "Л.Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "отцы и дети ", Author = "И. Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка ", Author = "А.Чехов", Price = 340 });

            base.Seed(db);
        }
    }
}