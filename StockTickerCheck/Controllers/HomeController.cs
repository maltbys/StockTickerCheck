using StockTickerCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StockTickerCheck.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index(string input)
    {
      return View(StockInfoGet(input));
    }

    public ActionResult About()
    {
      ViewBag.Message = "Welcome to Simple Financial Info.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Find out about our dev team.";

      return View();
    }

    private InformationModel StockInfoGet(string input)
    {
      input = input.Trim();
      InformationModel info = new InformationModel();

      // Make sure the user has provided input
      if (string.IsNullOrEmpty(input))
      {
        info.Error = "You must input at least one symbol.";
        return info;
      }

      // Build API client information
      // Base path must be provided first and will not change between requests
      string BASE_PATH = "https://query2.finance.yahoo.com/v10/finance/quoteSummary/";
      // API path is the specific URI to be changed between requests, for each symbol provided
      string API_PATH = "{0}?modules=price%2Cearnings%2CearningsTrend";
      string[] symbols = input.Split(' ');
      if (symbols.Length > 10)
      {
        info.Error = "You can only have a maximum of 10 symbols. Please try again.";
        return info;
      }

      using (HttpClient client = new HttpClient())
      {
        try
        {
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
          client.BaseAddress = new Uri(BASE_PATH);

          // Request data for each symbol.
          // Planned development includes finding a way to look up multiple symbols in a single request, which would help with the number of symbols allowed.
          foreach (string s in symbols)
          {
            string symbolPath = string.Format(API_PATH, s);
            HttpResponseMessage response = client.GetAsync(symbolPath).GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
              var financialInfo = response.Content.ReadAsAsync<FinancialInfo>().GetAwaiter().GetResult();
              decimal earnPerShare = 0;

              // Calculate earnings numbers based on provided raw data.
              foreach (var x in financialInfo.quoteSummary.result[0].earnings.earningsChart.quarterly)
              {
                earnPerShare += (decimal)x.actual.raw;
              }
              decimal peRatio = earnPerShare != 0 ? (decimal)financialInfo.quoteSummary.result[0].price.regularMarketPrice.raw / earnPerShare : 0;

              info.Stocks.Add(new Stock
              {
                Price = (decimal)financialInfo.quoteSummary.result[0].price.regularMarketPrice.raw,
                Symbol = s.ToUpper(),
                FullName = financialInfo.quoteSummary.result[0].price.longName,
                EarnPerShare = earnPerShare,
                PERatio = peRatio
              });

            }
            else
            {
              info.Error = "There was an error processing the request:<br />" + response.StatusCode.ToString() + ", " + response.ReasonPhrase;
            }
          }
        }
        catch (Exception ex)
        {
          info.Error = "There was an error processing your request:<br />" + ex.Message;
        }
      }

      return info;
    }
  }
}