using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WealthTrackProtfolio.Models;
using WealthTrackProtfolio.Models.VIewModel;

namespace WealthTrackProtfolio.Data
{
    public class WealthTrackProtfolioContext : DbContext
    {
        public WealthTrackProtfolioContext (DbContextOptions<WealthTrackProtfolioContext> options)
            : base(options)
        {
        }

        public DbSet<WealthTrackProtfolio.Models.Investment> Investment { get; set; } = default!;
        public DbSet<WealthTrackProtfolio.Models.VIewModel.InvestmentCreateViewModel> InvestmentCreateViewModel { get; set; } = default!;
    }
}
