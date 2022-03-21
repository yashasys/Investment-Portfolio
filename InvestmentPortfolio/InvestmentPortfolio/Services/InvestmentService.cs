using InvestmentPortfolio.IServices;
using InvestmentPortfolio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentPortfolio.Services
{
    public class InvestmentService : IInvestmentService
    {
        Investment_PortfolioContext dbContext;
        public InvestmentService(Investment_PortfolioContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Investment> GetInvestment()
        {
            var Investement = dbContext.Investment.ToList();
            return Investement;
        }

        public Investment AddInvestment(Investment investment)
        {
            if (investment != null)
            {
                dbContext.Investment.Add(investment);
                dbContext.SaveChanges();
                return investment;
            }
            return null;
        }

        public Investment UpdateInvestment(Investment investment)
        {
            dbContext.Entry(investment).State = EntityState.Modified;
            dbContext.SaveChanges();
            return investment;
        }

        public Investment DeleteInvestment(int id)
        {
            var investment = dbContext.Investment.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(investment).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return investment;
        }

        public Investment GetInvestmentById(int id)
        {
            var investment = dbContext.Investment.FirstOrDefault(x => x.Id == id);
            return investment;
        }




    }
}
