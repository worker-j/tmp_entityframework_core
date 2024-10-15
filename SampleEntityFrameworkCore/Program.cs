using SampleEntityFrameworkCore.Model;

namespace SampleEntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();

            //
            using (var db = new BooksDbContext()) {
                ////
                //var authors = db.Author
                //                .Where(a => a.Books.Count() >= 2);
                //foreach (var author in authors)
                //{
                //    Console.WriteLine($"{author.Name}, {author.Gender}, {author.Birthday:yyyy-MM-dd}");
                //}

                var books = db.Books;
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id} {book.Title} {book.PublishedYear}");
                }

                ////
                //var books = db.Books
                //                .OrderBy(b => b.PublishedYear)
                //                .ThenBy(b => b.Author.Name != null ? b.Author.Name : "");
                //foreach (var book in books)
                //{
                //    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                //}

            }

        }

        private static void DeleteBook()
        {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 3);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        private static void UpdateBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title.StartsWith("별의"));
                var tmpPublishedYear = book.PublishedYear;
                book.PublishedYear = 2016;
                db.SaveChanges();

                Console.WriteLine($"db의 내용을 수정합니다. 수정전 {tmpPublishedYear} -> {book.PublishedYear}");
            }
        }

        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Author.Single(a => a.Name.StartsWith("애거사"));
                var book1 = new Book
                {
                    Title = "그리고 아무도 없었다",
                    PublishedYear = 1939,
                    Author = author1
                };
                db.Books.Add(book1);

                var author2 = db.Author.Single(a => a.Name.StartsWith("찰스"));
                var book2 = new Book
                {
                    Title = "두 도시 이야기",
                    PublishedYear = 1859,
                    Author = author2
                };
                db.Books.Add(book2);
                db.SaveChanges();
                Console.WriteLine($"{book1.Id}, {book1.Title}, {book2.Id} {book2.Title} 를 추가합니다. ");

            }
        }

        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1890, 09, 15),
                    Gender = Gender.Female,
                    Name = "애거사 크리스티"
                };

                db.Author.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1812, 02, 07),
                    Gender = Gender.Male,
                    Name = "찰스 디킨스"
                };
                db.Author.Add(author2);
                db.SaveChanges();


            }
        }

        private static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book = new Book
                {
                    Title = "book2",
                    PublishedYear = 2024,
                    AuthorId = 1
                };

                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine($"{book.Id}");
            };
        }
        private static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}, {book.PublishedYear}");
            }
        }

        private static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books
                    .Where(book => book.Author.Name.StartsWith("제임스"))
                    .ToList();
            }

        }



    }
}
