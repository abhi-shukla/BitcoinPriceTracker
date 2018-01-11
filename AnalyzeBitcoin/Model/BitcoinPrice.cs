using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AnalyzeBitcoin.Model
{
    [DataContract]
    public class BitcoinPrice
    {
        [DataMember]
        public Time time { get; set; }

        [DataMember]
        public string chartName { get; set; }

        [DataMember]
        public string disclaimer { get; set; }

        [DataMember]
        public BPI bpi { get; set; }
    }
}
