using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTickerData.Models
{
    public class StockDataModels
    {
      
        public Links links { get; set; }
        public Meta meta { get; set; }
        public Datum[] data { get; set; }
        public object error { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Meta
    {
        public DateTime executionDate { get; set; }
        public int count { get; set; }
    }

    public class Datum
    {
        public string symbol { get; set; }
        public string exchange { get; set; }
        public string exchangeShortCode { get; set; }
        public float lastTrade { get; set; }
        public DateTime? date { get; set; }
        public float changeNumber { get; set; }
        public int changePercent { get; set; }
        public float? bid { get; set; }
        public int? bidSize { get; set; }
        public int? askSize { get; set; }
        public float dayHigh { get; set; }
        public float dayLow { get; set; }
        public int? volume { get; set; }
        public float open { get; set; }
        public float previousClose { get; set; }
        public float _52WeekHigh { get; set; }
        public DateTime? _52WeekHighDate { get; set; }
        public float _52WeekLow { get; set; }
        public DateTime? _52WeekLowDate { get; set; }
        public float? peRatio { get; set; }
        public long? marketCap { get; set; }
        public int? sharesOutstanding { get; set; }
        public float? rollingEPS { get; set; }
        public string isDefault { get; set; }
        public string isIndex { get; set; }
        public string _class { get; set; }
        public int securityId { get; set; }
        public int? yield { get; set; }
        public DateTime? firstTradeDate { get; set; }
    }
}

