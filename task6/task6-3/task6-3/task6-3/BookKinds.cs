using System;
using System.Collections.Generic;

namespace task6_3
{
    public partial class BookKinds
    {
        public BookKinds()
        {
            Books = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
