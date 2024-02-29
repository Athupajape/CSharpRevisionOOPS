using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class DictionaryClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> d1 = new Dictionary<string, string>();
            d1.Add("India", "Delhi,Mumbai,Pune");
            d1.Add("USA", "LosAngeles,NewYork");

            foreach(KeyValuePair<string,string> keyValuePair in d1)
            {
                Console.WriteLine("The State is : {0} and the cities are : {1}", keyValuePair.Key, keyValuePair.Value);
            }

            foreach (string k1 in d1.Keys)
            {
                Console.WriteLine("The State is : {0} ",k1);
            }

            foreach (string k2 in d1.Values)
            {
                Console.WriteLine("The cities are : {0}", k2);
            }
        }
        
        
    }
}
