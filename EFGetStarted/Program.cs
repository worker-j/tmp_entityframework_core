using System;
using System.Linq;

using var db = new BloggingContext();
// System.Console.WriteLine($"Database path: {db.DbPath}\n\n");

System.Console.WriteLine("Inserting a new blog");
db.Add(new Blog{Url = "http://blogs.msdn.com/adonet"});
db.SaveChanges();

System.Console.WriteLine();
System.Console.WriteLine("Querying for a blog");
var blog = db.Blogs
            .OrderBy(b=>b.BlogId)
            .First();
            // .Last();
System.Console.WriteLine($"{blog.BlogId}, {blog.Url}\n");

System.Console.WriteLine("Updating the blog and adding a post");
blog.Url = "http://devblogs.microsoft.com/dotnet";
blog.Posts.Add(
    new Post{Title="Hello World", Content="I wrote an app using EF Core"}
);
db.SaveChanges();

System.Console.WriteLine();
System.Console.WriteLine("Delete the blog");
db.Remove(blog);
db.SaveChanges();
