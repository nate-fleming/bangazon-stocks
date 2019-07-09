using System;
using System.Collections.Generic;
using System.Linq;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("GOOGL", "Google");
            // Add a few more of your favorite stocks

            // Dictionary<string, int> portfolio = new Dictionary<string, int>()
            // {
            //     {"AAPL", 400},
            //     {"AAPL", 600},
            //     {"GM", 200},
            //     {"GM", 100},
            //     {"CAT", 400},
            //     {"CAT", 800},
            //     {"GOOGL", 600},
            //     {"GOOGL", 200}
            // };

            Dictionary<string, List<int>> portfolio = new Dictionary<string, List<int>>();

            portfolio.Add("AAPL", new List<int>() { 600, 200 });
            portfolio.Add("CAT", new List<int>() { 800, 200 });
            portfolio.Add("GM", new List<int>() { 100, 300 });
            portfolio.Add("GOOGL", new List<int>() { 400, 200 });

            foreach (KeyValuePair<string, List<int>> stock in portfolio)
            {
                int total = stock.Value.Sum();

                Console.WriteLine($"Investor has spent a total of {total} on the stock for {stocks[stock.Key]}");
            }


        }
    }
}
