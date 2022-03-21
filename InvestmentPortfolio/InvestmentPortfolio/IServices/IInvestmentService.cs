using InvestmentPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentPortfolio.IServices
{
    public interface IInvestmentService 
    {
        IEnumerable<Investment> GetInvestment();
        Investment GetInvestmentById(int id);
        Investment AddInvestment(Investment investment);
        Investment UpdateInvestment(Investment investment);
        Investment DeleteInvestment(int id);
    }
}
