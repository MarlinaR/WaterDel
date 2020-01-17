using System;
using System.Collections.Generic;

namespace task6_3
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreationDate { get; set; }
        public int TypeId { get; set; }

        public virtual BookKinds Type { get; set; }
    }
}
