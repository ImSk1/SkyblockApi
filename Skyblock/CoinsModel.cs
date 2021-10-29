using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skyblock
{
    public class CoinsModel
    {
        public string profile_id { get; set; }
        public string cute_name { get; set; }
        public double purse { get; set; }
        public double bank { get; set; }
    }
    
}