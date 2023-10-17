using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionProduit.Models;


    public class ProduitDBContext : DbContext
    {
        public ProduitDBContext(DbContextOptions<ProduitDBContext> options)
            : base(options)
        {
        }

        public DbSet<GestionProduit.Models.Product> Product { get; set; } = default!;

    }

