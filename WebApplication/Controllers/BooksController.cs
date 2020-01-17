using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _7;
using Newtonsoft.Json;

namespace _7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksContext _context;

        public BooksController(BooksContext context)
        {
            _context = context;
            if (context.Books.Count() == 0)
            {
                var book1 = new Book { Name = "A Study in Scarlet", Author = "Arthur Conan Doyle", Publisher = "Kamilfo" };
                var book2 = new Book { Name = "The Cuckoo's Calling", Author = "J. K. Rowling", Publisher = "Kamilfo" };
                var book3 = new Book { Name = "Then She Was Gone", Author = "Laiza Juell", Publisher = "Kamilfo" };
                var book4 = new Book { Name = "Pride and Prejudice", Author = "Jane Austen", Publisher = "Asinastra" };
                var book5 = new Book { Name = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "Asinastra" };
                var book6 = new Book { Name = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Publisher = "Penguin Books USA" };
                var book7 = new Book { Name = "A Passage to India", Author = "Gabriel García Márquez ", Publisher = "Penguin Books USA" };
                var book8 = new Book { Name = "Things Fall Apart", Author = "Chinua Achebe", Publisher = "Asinastra" };
                var book9 = new Book { Name = "Beloved", Author = "Toni Morrison", Publisher = "Kamilfo" };
                var book10 = new Book { Name = "Mrs. Dalloway", Author = "Virginia Woolf", Publisher = "Penguin Books USA" };
                context.Books.AddRange(book1, book2, book3, book4, book5, book6, book7 ,book8, book9, book10);
                //for (int i = 0; i < 10; ++i)
                //{
                //    context.Books.Add(new Book
                //    {
                //        Author = $"{i}",
                //        Name = $"{i}",
                //        Publisher = $"{i}"
                //    });
                //}
                _context.SaveChanges();
            }
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            _context.Publishers.ToList();
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }
            _context.Publishers.ToList();
            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public async Task<IActionResult> PutBook(Book book)
        {


            if (book == null)
            {
                return BadRequest();
            }
            if (!_context.Books.Any(x => x.Id == book.Id))
            {
                return NotFound();
            }

            _context.Update(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }

        // POST: api/Books
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Book>> Post(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return book;
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
