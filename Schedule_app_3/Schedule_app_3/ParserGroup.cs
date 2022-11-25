using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_app_3
{
    internal class ParserGroup
    {
        List<string> GroupType = new List<string>();  
        private List<string> _GroupList = new List<string>();

        public List<string> GroupList { get {return _GroupList; } }


        public ParserGroup(string faculty)
        {
            try
            {
                using (HttpClientHandler hdl = new HttpClientHandler { AllowAutoRedirect = false, AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.None })
                {
                    using (var client = new HttpClient(hdl))
                    {
                        using (HttpResponseMessage resp = client.GetAsync("https://www.sgu.ru/schedule/" + $"{faculty}").Result)
                        {
                            if (resp.IsSuccessStatusCode)
                            {
                                var html = resp.Content.ReadAsStringAsync().Result;
                                if (!string.IsNullOrEmpty(html))
                                {
                                    HtmlDocument doc = new HtmlDocument();
                                    doc.LoadHtml(html);
                                    string type = "";
                                    string groupNum = "";
                                    string stri = "//*[@id=\"schedule_page\"]/fieldset[1]/div"; //заранее сохраняем строку индекса
                                    int l = 1;
                                    while (doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]") != null) // пока есть что парсить
                                    {
                                        var table1 = doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]");//чисто по приколу
                                        var table5 = doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]/legend/span");//тип группы 
                                        type = table5.InnerText;
                                        //Console.WriteLine(groupNum);
                                        GroupType.Add(type);

                                        int h = 1;
                                        while (doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]/div/fieldset[" + System.Convert.ToString(h) + "]/div/a[1]") != null)//столбец
                                        {
                                            int k = 1;
                                            var table = doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]/div/fieldset[" + System.Convert.ToString(h) + "]/div/a[1]");//строка
                                            while (table != null)
                                            {
                                                table = doc.DocumentNode.SelectSingleNode(stri + "/fieldset[" + System.Convert.ToString(l) + "]/div/fieldset[" + System.Convert.ToString(h) + "]/div/a[" + System.Convert.ToString(k) + "]");
                                                if (table == null)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    groupNum = table.InnerText;
                                                    //Console.WriteLine(type);
                                                    GroupList.Add(groupNum);
                                                    k++;
                                                }
                                            }
                                            h++;
                                        }
                                        l++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }




        }

    }
}
