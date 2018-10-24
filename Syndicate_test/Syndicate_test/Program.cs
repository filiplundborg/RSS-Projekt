using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;

namespace Syndicate_test
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string url = "https://api.sr.se/api/rss/pod/3966";
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);

            Console.WriteLine(feed.Title.Text + "\n");
            foreach (var items in feed.Items)
            {


                Console.WriteLine(items.Title.Text + "\n");
                Console.WriteLine(items.Summary.Text + "\n");
                
            }

        



            Console.ReadKey();
        }
    }
}
