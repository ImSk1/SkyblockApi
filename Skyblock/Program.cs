using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skyblock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string coinsUrl = "https://sky.shiiyu.moe/api/v2/coins/uwuSk1/Lime";
            string talismansUrl = "https://sky.shiiyu.moe/api/v2/talismans/uwuSk1/Lime";
            
            var coinsObj = GetCoins(coinsUrl);
            var bank = coinsObj.bank;
            if (talismansUrl != null && coinsUrl != null)
            {
                var talismansObj = GetTalismans(talismansUrl);
                var talismanCount = talismansObj.talismans.Count;
                var talismans = talismansObj.talismans;
                int activeTalismanCount = 0;
                Console.WriteLine($"uwuSk1 {bank:F2} coins in the bank.");
                Console.WriteLine($"uwuSk1 has {talismanCount} talismans.");
                Console.WriteLine("Here are the active ones:");
                List<string> inactiveTalismans = new List<string>();
                for (int i = 0; i < talismans.Count; i++)
                {
                    if (talismans[i].isInactive)
                    {
                        inactiveTalismans.Add(talismans[i].base_name);
                        continue;
                    }
                    else
                    {
                        Console.Write(talismans[i].base_name + ", ");
                        activeTalismanCount++;
                    }

                }
                Console.WriteLine($"Active talisman count: {activeTalismanCount}");
                Console.WriteLine("Here are the inactive ones");
                Console.WriteLine(string.Join(", ", inactiveTalismans));
            }
           

           
            
        }
        static CoinsModel GetCoins(string coinsUrl)
        {
            var jsonObj = new WebClient().DownloadString(coinsUrl);
            var skyblockObj = JsonConvert.DeserializeObject<CoinsModel>(jsonObj);
            return skyblockObj;
        }
        static TalismansModel GetTalismans(string talismansUrl)
        {
            var jsonObj = new WebClient().DownloadString(talismansUrl);
            var skyblockObj = JsonConvert.DeserializeObject<TalismansModel>(jsonObj);
            return skyblockObj;
        }
    }
}
