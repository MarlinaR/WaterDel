using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fourth.Models;
using Microsoft.EntityFrameworkCore;

namespace fourth.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;
        public HomeController(BookContext context)
        {
            db = context;

        }

        // жадная загрузка
        public IActionResult EagerLoadingIndex()
        {
            var books = db.Books
                    .Include(x => x.Type)
                    .ToList();
            return View(books.ToList());
        }

        // явная загрузка
        public IActionResult ExplicitLoadingIndex()
        {
            db.Books.Load();
            db. BookKinds.Load();
            return View(db.Books.ToList());
        }

        // ленивая загрузка
        public IActionResult LazyLoadingIndex()
        {
            var books = db.Books.ToList();
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
