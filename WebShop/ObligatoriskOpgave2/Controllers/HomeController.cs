using ObligatoriskOpgave2.DAL;
using ObligatoriskOpgave2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ObligatoriskOpgave2.Controllers
{
    public class HomeController : Controller
    {
        WebShopContext db = new WebShopContext();

        public ActionResult Index(string type, string search)
        {
            
            if (type == "Book")
            {
                //Index action method will return a view with a student records based on what a user specify the value in textbox  
                return View(db.Books.Where(x => x.Title == search || search == null).ToList());
            }
            else if (type == "Movies")
            {
                return View(db.Movies.Where(x => x.Title == search || search == null).ToList());
            }
            else if(type == "Music")
            {
                return View(db.Musics.Where(x => x.Title.StartsWith(search) || search == null).ToList());
            } else
            {
                return View();
            }
            
        }

        public ActionResult About()
        {
            

            return View();
        }

       


        //BooksController part-------------------------------------------------------------------------------------------------------------

        // GET: Book
        public ActionResult BookIndex()
        {
            return View(db.Books.ToList());
        }

        // GET: Book/Details/5
        public ActionResult BookDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //MovieController part-------------------------------------------------------------------------------------------------------------

        // GET: Movie
        public ActionResult MovieIndex()
        {
            return View(db.Movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult MovieDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // MusicController part ---------------------------------------------------------------------

        // GET: CoMusicntroller
        public ActionResult MusicIndex()
        {
            return View(db.Musics.ToList());
        }

        // GET: CoMusicntroller/Details/5
        public ActionResult MusicDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }


    }
}