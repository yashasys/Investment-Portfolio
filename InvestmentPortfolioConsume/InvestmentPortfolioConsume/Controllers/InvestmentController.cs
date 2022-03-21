using Lib.Service.InvestmentService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentPortfolioConsume.Controllers
{
    public class InvestmentController : Controller
    {
        private readonly IInvestmentServices _investmentServices;

        public InvestmentController(IInvestmentServices investmentServices)
        {
            _investmentServices = investmentServices;

        }
        public async Task<IActionResult> List()
        {
            var list = await _investmentServices.GetInvestmentList();
            return View(list);
        }
    }
}
