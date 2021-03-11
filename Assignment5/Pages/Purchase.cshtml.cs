using System;
using System.Linq;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages

{
    public class PurchaseModel : PageModel //this class is for purchases. 
    {
        private IBookRepository repository;

        public PurchaseModel (IBookRepository repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); 
        }

        public IActionResult OnPost(string ISBN, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.ISBN == ISBN);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(string ISBN, string returnUrl)
        {

            Book book = repository.Books.FirstOrDefault(b => b.ISBN == ISBN);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(book);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
