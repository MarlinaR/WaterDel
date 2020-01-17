using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _7;

namespace _7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly BooksContext _context;

        public PublishersController(BooksContext context)
        {
            _context = context;
            if (context.Publishers.Count() == 0)
            {
                var publisher1 = new Publisher { Name = "Penguin Books USA" };
                var publisher2 = new Publisher { Name = "Kamilfo" };
                var publisher3 = new Publisher { Name = "Asinastra" };

                //for (int i = 0; i < 10; ++i)
                //{
                //    context.Publishers.Add(new Publisher
                //    {
                //        Name = $"{i}",C:\Users\Arina\Desktop\Web-Third-Semestr-master\7\Controllers\PublishersController.cs
                //    });
                //}
                context.Publishers.AddRange(publisher1, publisher2, publisher3);
                _context.SaveChanges();
            }
        }

        // GET: api/Publishers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publisher>>> GetPublishers()
        {
            _context.Books.ToList();
            return await _context.Publishers.ToListAsync();
        }

        // GET: api/Publishers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);

            if (publisher == null)
            {
                return NotFound();
            }
            _context.Books.ToList();
            return publisher;
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            if (id != publisher.Id)
            {
                return BadRequest();
            }

            _context.Entry(publisher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Publishers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublisher", new { id = publisher.Id }, publisher);
        }

        // DELETE: api/Publishers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Publisher>> DeletePublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();

            return publisher;
        }

        private bool PublisherExists(int id)
        {
            return _context.Publishers.Any(e => e.Id == id);
        }
    }
}
