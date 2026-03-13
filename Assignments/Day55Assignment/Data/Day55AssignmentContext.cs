using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day55Assignment.Models;

namespace Day55Assignment.Data
{
    public class Day55AssignmentContext : DbContext
    {
        public Day55AssignmentContext (DbContextOptions<Day55AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Day55Assignment.Models.Employees> Employees { get; set; } = default!;
    }
}
