using MyProject.Data;
using MyProject.Data.Model;
using MyProject.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Pages.CreditPages
{
    public class IndexModel : GenericPageModel
    {            
        public List<Credit> Credits { get; set; } = new List<Credit>(); 

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Credits = _context.Credits.ToList();
        }
    }
}
