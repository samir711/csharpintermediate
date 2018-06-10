using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class HttpCookie
    {

        // Indexer example;
        private readonly Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        //var cookie = new HttpCookie();
        //    cookie["firstname"] = "Mosh";
        //    cookie["lastname"] = "test";
        //    Console.WriteLine(cookie["firstname"]);
        //    Console.WriteLine(cookie["lastname"]);

    }
}
