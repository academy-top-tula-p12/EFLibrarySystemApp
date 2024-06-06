using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrarySystemApp
{
    public class IssueCard
    {
        public int Id { get; set; }
        public Book Book { get; set; } = null!;
        public Reader Reader { get; set; } = null!;
        public Librarian Librarian { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public int Period { get; set; } // period at days
    }
}
