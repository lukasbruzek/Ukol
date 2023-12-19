using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Data;
using MyProject.Generic;
using MyProject.Data.Model;

namespace MyProject.Pages
{
    public class IndexModel : GenericPageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Credit Credit { get; set; } = new Credit();

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Credit.Created = DateTime.Now;

            _context.Credits.Add(Credit);
            _context.SaveChanges();
            string message = "";
            if(Credit.Success)
            {
                message = "uspěl";
            }
            else
            {
                message = "neuspěl";
            }

            Message = $"Děkujeme za vyplnění dotazníku, Vaše hodnocení je: {Credit.Value} a proto jste {message}. Hodnoceno {Credit.Created.ToString("dd.MM.yyyy H:m")}";

            Credit = new Credit();

            ModelState.Clear();

            return Page();
        }

        public void OnGet()
        {

        }
    }
}
