namespace BookStore.Infra.Data.Migrations
{
    using BookStore.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.BookStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(new Book() { Id = 1, Title = "Where the Crawdads Sing", Author = "Delia Owens", ISBN = "0735219095" });
            context.Books.AddOrUpdate(new Book() { Id = 2, Title = "The Testaments: The Sequel to The Handmaid's Tale", Author = "Margaret Atwood", ISBN = "1784708216" });
            context.Books.AddOrUpdate(new Book() { Id = 3, Title = "The Institute: A Novel", Author = "Stephen King", ISBN = "1529355390" });
            context.Books.AddOrUpdate(new Book() { Id = 4, Title = "The Goldfinch: A Novel", Author = "Donna Tartt", ISBN = "0316055444" });
            context.Books.AddOrUpdate(new Book() { Id = 5, Title = "Thin Air (Jessica Shaw)", Author = "Lisa Gray", ISBN = "1542093643" });
            context.Books.AddOrUpdate(new Book() { Id = 6, Title = "Lying Next to Me", Author = "Gregg Olsen", ISBN = "1542040515" });
            context.Books.AddOrUpdate(new Book() { Id = 7, Title = "The Pillars of the Earth", Author = "Ken Follett", ISBN = "0451488334" });
            context.Books.AddOrUpdate(new Book() { Id = 8, Title = "Dog Man: For Whom the Ball Rolls (Dog Man #7)", Author = "Dav Pilkey", ISBN = "1338236598" });
            context.Books.AddOrUpdate(new Book() { Id = 9, Title = "Land of Wolves (Walt Longmire Mystery)", Author = "Craig Johnson", ISBN = "0525522506" });
        }
    }
}
