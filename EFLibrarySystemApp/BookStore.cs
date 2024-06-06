using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrarySystemApp
{
    public class BookStore
    {
        public Book Book { get; set; } = null!;
        public Room Room { get; set; } = null!;

        public int BookId { get; set; }
        public int RoomId { get; set; }

        public int? Quantity { get; set; }
        public int? Shelf { get; set; }
    }
}
