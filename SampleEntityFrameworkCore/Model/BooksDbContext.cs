using Microsoft.EntityFrameworkCore;

namespace SampleEntityFrameworkCore.Model
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer(@"Server=DESKTOP-3TDDG7N;Database=TestData;ConnectRetryCount=0;Integrated Security=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,                 // 초기 생성시에만 입력한다. 프로그램에서는 자동으로 생성된다. 
                        Title = "별의 계승자",
                        PublishedYear = 1977,
                        AuthorId = 1
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "타임머신",
                        PublishedYear = 1895,
                        AuthorId = 2
                    }
                );
            modelBuilder.Entity<Author>().HasData(
                    new Author
                    {
                        Id = 1,
                        Name = "제임스 P. 호건",
                        Gender = Gender.Male,
                        Birthday = new DateTime(1941, 6, 27)
                    },
                    new Author
                    {
                        Id = 2,
                        Name = "허버트 조지 웰즈",
                        Gender = Gender.Male,
                        Birthday = new DateTime(1866, 9, 21)
                    }
                );
        }
    }
}
