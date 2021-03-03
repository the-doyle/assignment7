using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;

        //constructor 
        public EFBookRepository(BookDBContext context)
        {
            _context = context;
        }


        public IQueryable<Book> Books => _context.Books;

    }
}
