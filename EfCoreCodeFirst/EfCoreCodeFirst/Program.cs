using System;

namespace EfCoreCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                //int count = db.SaveChanges();
                int count = 5;
                // following line causes an exception with the message that Blogs not exist in current context.
                db.SaveChanges();
                Console.WriteLine($"{count} records saved to database.");

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($" - {blog.Url}");
                }
            }

            Console.ReadKey();
        }
    }
}
