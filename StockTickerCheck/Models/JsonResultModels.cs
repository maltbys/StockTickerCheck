using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTickerCheck.Models
{
  /*
   * Model classes were auto-generated by pasting JSON result from API call, and allowing VS to deserialize.
   * */
  public class FinancialInfo
  {
    public Quotesummary quoteSummary { get; set; }
  }

  public class Quotesummary
  {
    public Result[] result { get; set; }
    public object error { get; set; }
  }

  public class Result
  {
    public Earnings earnings { get; set; }
    public Price price { get; set; }
  }

  public class Earnings
  {
    public int maxAge { get; set; }
    public Earningschart earningsChart { get; set; }
    public Financialschart financialsChart { get; set; }
    public string financialCurrency { get; set; }
  }

  public class Earningschart
  {
    public Quarterly[] quarterly { get; set; }
    public Currentquarterestimate currentQuarterEstimate { get; set; }
    public string currentQuarterEstimateDate { get; set; }
    public int currentQuarterEstimateYear { get; set; }
    public Earningsdate[] earningsDate { get; set; }
  }

  public class Currentquarterestimate
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Quarterly
  {
    public string date { get; set; }
    public Actual actual { get; set; }
    public Estimate estimate { get; set; }
  }

  public class Actual
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Estimate
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Earningsdate
  {
    public int raw { get; set; }
    public string fmt { get; set; }
  }

  public class Financialschart
  {
    public Yearly[] yearly { get; set; }
    public Quarterly1[] quarterly { get; set; }
  }

  public class Yearly
  {
    public int date { get; set; }
    public Revenue revenue { get; set; }
    public Earnings1 earnings { get; set; }
  }

  public class Revenue
  {
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Earnings1
  {
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Quarterly1
  {
    public string date { get; set; }
    public Revenue1 revenue { get; set; }
    public Earnings2 earnings { get; set; }
  }

  public class Revenue1
  {
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Earnings2
  {
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Price
  {
    public int maxAge { get; set; }
    public Premarketchangepercent preMarketChangePercent { get; set; }
    public Premarketchange preMarketChange { get; set; }
    public int preMarketTime { get; set; }
    public Premarketprice preMarketPrice { get; set; }
    public string preMarketSource { get; set; }
    public Postmarketchangepercent postMarketChangePercent { get; set; }
    public Postmarketchange postMarketChange { get; set; }
    public int postMarketTime { get; set; }
    public Postmarketprice postMarketPrice { get; set; }
    public string postMarketSource { get; set; }
    public Regularmarketchangepercent regularMarketChangePercent { get; set; }
    public Regularmarketchange regularMarketChange { get; set; }
    public int regularMarketTime { get; set; }
    public Pricehint priceHint { get; set; }
    public Regularmarketprice regularMarketPrice { get; set; }
    public Regularmarketdayhigh regularMarketDayHigh { get; set; }
    public Regularmarketdaylow regularMarketDayLow { get; set; }
    public Regularmarketvolume regularMarketVolume { get; set; }
    public Averagedailyvolume10day averageDailyVolume10Day { get; set; }
    public Averagedailyvolume3month averageDailyVolume3Month { get; set; }
    public Regularmarketpreviousclose regularMarketPreviousClose { get; set; }
    public string regularMarketSource { get; set; }
    public Regularmarketopen regularMarketOpen { get; set; }
    public Strikeprice strikePrice { get; set; }
    public Openinterest openInterest { get; set; }
    public string exchange { get; set; }
    public string exchangeName { get; set; }
    public int exchangeDataDelayedBy { get; set; }
    public string marketState { get; set; }
    public string quoteType { get; set; }
    public string symbol { get; set; }
    public object underlyingSymbol { get; set; }
    public string shortName { get; set; }
    public string longName { get; set; }
    public string currency { get; set; }
    public string quoteSourceName { get; set; }
    public string currencySymbol { get; set; }
    public object fromCurrency { get; set; }
    public object toCurrency { get; set; }
    public object lastMarket { get; set; }
    public Volume24hr volume24Hr { get; set; }
    public Volumeallcurrencies volumeAllCurrencies { get; set; }
    public Circulatingsupply circulatingSupply { get; set; }
    public Marketcap marketCap { get; set; }
  }

  public class Premarketchangepercent
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Premarketchange
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Premarketprice
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Postmarketchangepercent
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Postmarketchange
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Postmarketprice
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketchangepercent
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketchange
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Pricehint
  {
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Regularmarketprice
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketdayhigh
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketdaylow
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketvolume
  {
    public int raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

  public class Averagedailyvolume10day
  {
  }

  public class Averagedailyvolume3month
  {
  }

  public class Regularmarketpreviousclose
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Regularmarketopen
  {
    public float raw { get; set; }
    public string fmt { get; set; }
  }

  public class Strikeprice
  {
  }

  public class Openinterest
  {
  }

  public class Volume24hr
  {
  }

  public class Volumeallcurrencies
  {
  }

  public class Circulatingsupply
  {
  }

  public class Marketcap
  {
    public long raw { get; set; }
    public string fmt { get; set; }
    public string longFmt { get; set; }
  }

}