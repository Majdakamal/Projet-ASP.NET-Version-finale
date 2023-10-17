using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionProduit.Models;

namespace GestionProduit.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProduitDBContext _context;

        public IndexModel(ProduitDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string Des { get; set; }

        public async Task OnGetAsync()

        {
            var prods = from m in _context.Product select m;
            if(!string.IsNullOrEmpty(Des))
            {
                prods = prods.Where(s => s.Name.Contains(Des));
            }
           
                Product = await prods.ToListAsync();
            
        }
    }
}
