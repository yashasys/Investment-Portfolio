using Lib.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace Lib.Service.InvestmentService
{
    public class InvestmentServices : IInvestmentServices
    {
        public InvestmentServices()
        {



        }



        public async Task<List<InvestmentModel>> GetInvestmentList()
        {
            var investmentList = new List<InvestmentModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44338/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("/api/Investment/GetInvestment");

                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;

                    investmentList = JsonConvert.DeserializeObject<List<InvestmentModel>>(readTask);

                    return investmentList;
                }
            }
            return investmentList;

        }
    }
}