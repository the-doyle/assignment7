using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment5.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; } //total items in db
        public int ItemsPerPage { get; set; } //items on each page
        public int CurrentPage { get; set; } //page we are on 
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
