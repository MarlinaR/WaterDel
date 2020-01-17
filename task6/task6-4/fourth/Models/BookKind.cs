using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fourth.Models
{
    public class BookKind
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
