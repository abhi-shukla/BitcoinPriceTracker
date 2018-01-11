using AnalyzeBitcoin.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeBitcoin.Service
{
    public class PriceRetriver
    {
        public static BitcoinPrice GetCurrentBitcoinPrice()
        {
            RestClient client = new RestClient("https://api.coindesk.com/v1/bpi/currentprice.json");

            RestRequest request = new RestRequest(Method.GET);

            RestResponse<BitcoinPrice> response = (RestResponse<BitcoinPrice>) client.Execute<BitcoinPrice>(request);

            var price = JsonConvert.DeserializeObject<BitcoinPrice>(response.Content);

            return price;
        }
    }
}
