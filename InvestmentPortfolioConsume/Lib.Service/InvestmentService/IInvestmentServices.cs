using Lib.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service.InvestmentService
{
    public interface IInvestmentServices
    {

        Task<List<InvestmentModel>> GetInvestmentList();
    }
}
