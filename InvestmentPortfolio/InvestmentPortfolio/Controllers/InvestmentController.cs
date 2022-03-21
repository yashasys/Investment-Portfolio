using InvestmentPortfolio.IServices;
using InvestmentPortfolio.Models;
using InvestmentPortfolio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        private readonly IInvestmentService investmentService;
        public InvestmentController(IInvestmentService Investment)
        {
            investmentService = Investment;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Investment/GetInvestment")]
        public IEnumerable<Investment> GetInvestment()
        {
            return investmentService.GetInvestment();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Investment/AddInvestment")]
        public Investment AddInvestment(Investment investment)
        {
            return investmentService.AddInvestment(investment);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Investment/EditInvestment")]
        public Investment EditInvestment(Investment investment)
        {
            return investmentService.UpdateInvestment(investment);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Investment/DeleteInvestment")]
        public Investment DeleteInvestmente(int id)
        {
            return investmentService.DeleteInvestment(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Investment/GetInvestmentId")]
        public Investment GetInvestmentId(int id)
        {
            return investmentService.GetInvestmentById(id);
        }

    }
}
