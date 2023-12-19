using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Data;

namespace MyProject.Generic
{
    public class GenericPageModel:PageModel
    {

        internal ApplicationDbContext _context;

        public string Message { get; set; } = String.Empty;
    }
}
