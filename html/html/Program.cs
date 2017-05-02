using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
namespace HttpGet
{
    class Class1
    {
        [STAThread]
        /*
        static void Main(string[] args)
        {
            System.Net.WebClient client = new WebClient();
            byte[] page = client.DownloadData("http://www.baidu.com");
            string content = System.Text.Encoding.UTF8.GetString(page);
            string regex = "百度*";//"href=[\\\"\\\'](http:\\/\\/|\\.\\/|\\/)?\\w+(\\.\\w+)*(\\/\\w+(\\.\\w+)?)*(\\/|\\?\\w*=\\w*(&\\w*=\\w*)*)?[\\\"\\\']";
            Regex re = new Regex(regex);
            MatchCollection matches = re.Matches(content);

            System.Collections.IEnumerator enu = matches.GetEnumerator();
            while (enu.MoveNext() && enu.Current != null)
            {
                Match match = (Match)(enu.Current);
                Console.Write(match.Value + "\r\n");
            }
        }*/
        static void Main()
        {
            HtmlWeb webClient = new HtmlWeb();
            HtmlDocument doc = webClient.Load("http://www.985z.com/?post=19");

            HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//p");

            if (hrefList != null)
            {
                foreach (HtmlNode href in hrefList)
                {
                    //HtmlAttribute att = href.Attributes["href"];
                    Console.WriteLine(href.InnerText);

                }

            }  

        }
    }
}

