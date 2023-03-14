using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Models;

namespace RazorPagesFilmes.Data
{
    public class RazorPagesFilmesContext : DbContext
    {
        public RazorPagesFilmesContext (DbContextOptions<RazorPagesFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilmes.Models.Filme> Filme { get; set; } = default!;
    }
}
