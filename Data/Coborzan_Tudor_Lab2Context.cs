﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coborzan_Tudor_Lab2.Models;

namespace Coborzan_Tudor_Lab2.Data
{
    public class Coborzan_Tudor_Lab2Context : DbContext
    {
        public Coborzan_Tudor_Lab2Context (DbContextOptions<Coborzan_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coborzan_Tudor_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Coborzan_Tudor_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Coborzan_Tudor_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Coborzan_Tudor_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
