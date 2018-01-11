using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeBitcoin.Model
{
    [DataContract]
    public class Time
    {
        [DataMember]
        public string updated { get; set; }

        [DataMember]
        public string updatedISO { get; set; }

        [DataMember]
        public string updatedUK { get; set; }
    }
}
