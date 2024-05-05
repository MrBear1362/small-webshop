namespace ObligatoriskOpgave2.Migrations
{
    using ObligatoriskOpgave2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Type = Models.Type;

    internal sealed class Configuration : DbMigrationsConfiguration<ObligatoriskOpgave2.DAL.WebShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ObligatoriskOpgave2.DAL.WebShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            var products = new List<Product>
            {
            new Book{ProductId=0, Title="Lord of the Rings 1", StockStatus=false, Quantity=0, Type=Type.Book, TypeVariation="Paperback", Pic="LOTR.jpg", Price=250.0, Author="J.R.R Tolkien", Pages=350, Publisher="Gyldendal"},
            new Book{ProductId=1, Title="The Perks of Being a Wallflower", StockStatus=true, Quantity=3, Type=Type.Book, TypeVariation="Hardback", Pic="PerksOfBeingAWall.jpg", Price=120.0, Author="Stephen Chbosky", Pages=220, Publisher="Bears&CO"},
            new Movie{ProductId=2, Title="Interstellar", StockStatus=true, Quantity=20, Type=Type.Movie, TypeVariation="Blu-Ray", Pic="Interstellar.jpg", Price=150.50, Director="Christopher Nolan", ReleaseDate=new DateTime(2014, 11, 06) },
            new Movie{ProductId=3, Title="Gladiator", StockStatus=false, Quantity=0, Type=Type.Movie, TypeVariation="DVD", Pic="Gladiator.jpg", Price=50.25, Director="Ridley Scott", ReleaseDate=new DateTime(2000, 05, 19)},
            new Music{ProductId=4, Title="Thriller", StockStatus=true, Quantity=3, Type=Type.Music, TypeVariation="CD", Pic="Thriller.jpg", Price=100.00, Artist="Michael Jackson", Genre="Pop", Info="1: Wanna Be Starting Something" + "\n" + "2: Baby Be Mine" + "\n" + "3: The Girl Is Mine" + "\n" + 
            "4: Thriller" + "\n" + "5: Beat It" + "\n" + "6: Billie Jean" + "\n" + "7: Human Nature" + "\n" + "8: P.Y.T - Pretty Young Thing" + "\n" + "9: The Lady In My Life"},
            new Music{ProductId=5, Title="...Hits", StockStatus=true, Quantity=1, Type=Type.Music, TypeVariation="CD", Pic="hits.jpg", Price=139.95, Artist="Phil Collins", Genre="Pop/Rock", Info="1: Another Day in Paradise" + "\n" + "2: True Colors" + "\n" + "3: Easy Lover" + "\n" + "4: You Cant Hurry Love" + 
            "\n" + "5: Two Hearts" + "\n" + "6: I Wish It Would Rain Down" + "\n" + "7: Against All Odds (Take a Look at Me Now)" + "\n" + "8: Something Happened on the Way to Heaven" + "\n" + "9: Separate Lives" + "\n" + "10: Both Sides pf the Story" + "\n" + "11: One More Night" + "\n" + "12: Sussudio" + "\n" + "13: Dance into the Light" + "\n" + "14: A Groovy Kind of Love" + "\n" + "15: In the Air Tonight" + "\n" + "16: Take Me Home" }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var customers = new List<Customer>
            {
            new Customer{Name="Mika Højegaard", PersonId=0, Products={products[0]} },
            new Customer{Name="Jesper Hermansen", PersonId=1, Products={} }

            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

        }
    }
}
