using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoanManagementWebAPI.Model;

namespace LoanManagementWebAPI.Data
{
    public class LoanManagementWebAPIContext : DbContext
    {
        public LoanManagementWebAPIContext (DbContextOptions<LoanManagementWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LoanManagementWebAPI.Model.Loan> Loan { get; set; } = default!;
    }
}
