using AnalyzeBitcoin.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;

namespace AnalyzeBitcoin.Service
{
    public class PriceRetriver
    {
        public static BitcoinPrice GetCurrentBitcoinPrice()
        {
            RestClient client = new RestClient("https://api.coindesk.com/v1/bpi/currentprice.json");

            RestRequest request = new RestRequest(Method.GET);

            RestResponse<BitcoinPrice> response = null;

            response = (RestResponse<BitcoinPrice>)client.Execute<BitcoinPrice>(request);

            if (response.ResponseStatus == ResponseStatus.Error && response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<BitcoinPrice>(response.Content);
        }
    }
}
