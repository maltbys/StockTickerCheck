using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTickerCheck.Models
{
  public class InformationModel
  {
    public InformationModel()
    {
      Stocks = new List<Stock>();
      Error = null;
    }

    public string Input { get; set; }
    public List<Stock> Stocks { get; set; }
    public string Error { get; set; }
  }

  public class Stock
  {
    public string Symbol { get; set; }
    public string FullName { get; set; }
    public decimal Price { get; set; }
    public decimal PERatio { get; set; }
    public decimal EarnPerShare { get; set; }
  }

}