using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_Lab8.Models;

namespace Barbu_Nicoleta_Lab8.Data
{
    public class Barbu_Nicoleta_Lab8Context : DbContext
    {
        public Barbu_Nicoleta_Lab8Context (DbContextOptions<Barbu_Nicoleta_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Barbu_Nicoleta_Lab8.Models.Book> Book { get; set; }
    }
}
