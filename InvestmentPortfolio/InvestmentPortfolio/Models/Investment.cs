using System;
using System.Collections.Generic;

namespace InvestmentPortfolio.Models
{
    public partial class Investment
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal? Contact { get; set; }
        public string ProfilePicUrl { get; set; }
        public decimal? TotalInvestment { get; set; }
        public string Gender { get; set; }
    }
}
