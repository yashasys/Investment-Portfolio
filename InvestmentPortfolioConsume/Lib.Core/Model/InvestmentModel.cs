using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core.Model
{
    public class InvestmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal? Contact { get; set; }
        public string ProfilePicURL { get; set; }
        public decimal? TotalInvestment { get; set; } 
        public string Gender { get; set; }
        
    }
}
