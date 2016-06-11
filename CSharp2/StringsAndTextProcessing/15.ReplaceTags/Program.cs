using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();
            var parsedHtml = new StringBuilder();
            var url = new StringBuilder();
            var link = new StringBuilder();

            bool inText = true;
            bool inTag = false;
            bool inUrl = false;
            bool inLink = false;

            for (int i = 0; i < html.Length; i++)
            {
                
                char currentSymbol = html[i];

                //if (i == 35)
                //{
                //    Console.WriteLine(currentSymbol);
                //}

                //Entering in tag state
                if (currentSymbol == '<' && inText)
                {
                    if (html[i + 1] == 'a')
                    {
                        inText = false;
                        inTag = true;
                        continue;
                    }
                }

                //Entering in URL state
                if (currentSymbol == '"' && inTag && !inUrl)
                {
                    inUrl = true;
                    continue;
                }

                //Entering in Link state
                if (currentSymbol == '>' && html[i - 1] == '"' && inTag)
                {
                    inLink = true;
                    continue;
                }

                //Exit URL state
                if (currentSymbol == '"' && inUrl)
                {
                    inUrl = false;
                    continue;
                }

                //Exint Link state
                if (inLink)
                {
                    if (currentSymbol == '<')
                    {
                        inLink = false;
                    }
                }
                //Exit Tag state
                if (inTag && currentSymbol == '<')
                {
                    if (html[i + 1] == '/')
                    {
                        inTag = false;
                        inText = true;
                        parsedHtml.Append(string.Format("[{0}]({1})", link, url));
                        url.Clear();
                        link.Clear();
                        i += 3;
                    }
                    continue;
                }

                if (inText)
                {
                    parsedHtml.Append(currentSymbol);
                    continue;
                }
                if (inLink)
                {
                    link.Append(currentSymbol);
                    continue;
                }
                if (inUrl)
                {
                    url.Append(currentSymbol);
                    continue;
                }
            }

            Console.WriteLine(parsedHtml);






            //THE SLOW WAY

            //    string html = Console.ReadLine();
            //    var parsedHtml = new StringBuilder();
            //    var hrefs = new List<string>();
            //
            //    //
            //    int openingBracketPossition = html.IndexOf("<a");
            //    int closingBracketPossition = html.IndexOf("</a>");
            //    while (openingBracketPossition > -1)
            //    {
            //        string aTag = html.Substring(openingBracketPossition + 2, closingBracketPossition - (openingBracketPossition + 2));
            //        hrefs.Add(aTag);
            //        openingBracketPossition = html.IndexOf("<a", openingBracketPossition + 1);
            //        closingBracketPossition = html.IndexOf("</a>", closingBracketPossition + 1);
            //    }
            //
            //    for (int i = 0; i < hrefs.Count; i++)
            //    {
            //        string curentATag = hrefs[i];
            //        string url, linkTo;
            //        string[] splited = curentATag.Split('"');
            //        url = splited[1];
            //        linkTo = splited[2].Substring(1);
            //
            //        html = html.Replace("<a" + curentATag + "</a>", String.Format("[{0}]({1})", linkTo, url));
            //    }
            //
            //    Console.WriteLine(html);
        }
    }
}
