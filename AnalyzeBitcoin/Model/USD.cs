using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeBitcoin.Model
{
    [DataContract]
    public class USD
    {
        [DataMember]
        public string code { get; set; }

        [DataMember]
        public string symbol { get; set; }
        
        [DataMember]
        public string rate { get; set; }

        [DataMember]
        public string desciption { get; set; }

        [DataMember]
        public double rate_float { get; set; }
    }
}
