using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; } //pulls in the books from the model
        public PagingInfo PagingInfo { get; set; } //pulls in the paging info
        public string CurrentCategory { get; set; } //property of the view model 

    }
}
