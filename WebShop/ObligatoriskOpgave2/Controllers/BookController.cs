using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ObligatoriskOpgave2.DAL;
using ObligatoriskOpgave2.Models;

namespace ObligatoriskOpgave2.Controllers
{
    public class BookController : ApiController
    {
        private WebShopContext db = new WebShopContext();

        // GET: api/Book
        public IQueryable<Book> GetProducts()
        {
            return db.Books;
        }

        // GET: api/Book/5
        [ResponseType(typeof(Book))]
        public IHttpActionResult GetBook(int id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // PUT: api/Book/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBook(int id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.ProductId)
            {
                return BadRequest();
            }

            db.Entry(book).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Book
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var ctx = db)
            {
                ctx.Books.Add(new Book()
                {
                    Title = book.Title,
                    Publisher = book.Publisher,
                    Pages = book.Pages,
                    Quantity = book.Quantity,
                    Price = book.Price,
                    StockStatus = book.StockStatus,
                    Author = book.Author,
                    Type = book.Type,
                    TypeVariation = book.TypeVariation,
                    Pic = book.Pic
                });

                db.Books.Add(book);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = book.ProductId }, book);
            }
        }

      

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookExists(int id)
        {
            return db.Books.Count(e => e.ProductId == id) > 0;
        }
    }
}