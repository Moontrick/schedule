using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace Schedule_app_3
{
    internal class Parser
    {

        private List<string> _PairType = new List<string>();
        private List<string> _PairName = new List<string>();
        private List<string> _TeacherName = new List<string>();
        private List<string> _Location = new List<string>();

        public List<string> PairType { get { return _PairType; } }
        public List<string> PairName { get { return _PairName; } }
        public List<string> TeacherName { get { return _TeacherName; } }
        public List<string> Location { get { return _Location; } }


        private Dictionary<int, int> IDCommonPair = new Dictionary<int, int>();

        public Dictionary<int, int> _IDCommonPair { get { return IDCommonPair; } }


        //string[] mas_type_par = new string[20];

        string[] mas_podroup = new string[20];
        //string[] mas_mesto = new string[20];
        //string[] name_prep = new string[20];
        //string[] mas_str = new string[20];
        int[] prov = new int[20];


        private string week_now = "";
        private string date_name = "";
        private string type_par = "";
        private string group = "";
        private string name_par = "";
        private string Prepod = "";
        private string mesto = "";
        //private int h = 1;
        int col = 0;

        private int IDPair = 0;
        private int CountPair = 0;
        public Parser(int h, string faculty, string group)
        {
            for (int i = 0; i < 20; i++)
            {
                prov[i] = 0;
                mas_podroup[i] = null;
            }

            using (HttpClientHandler hdl = new HttpClientHandler { AllowAutoRedirect = false, AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.None })
            {
                using (var client = new HttpClient(hdl))
                {
                    string url = "https://www.sgu.ru/schedule/" + $"{faculty}" + "/do/" + $"{group}";
                    using (HttpResponseMessage resp = client.GetAsync(url).Result)
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            var html = resp.Content.ReadAsStringAsync().Result;
                            if (!string.IsNullOrEmpty(html))
                            {


                                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                doc.LoadHtml(html);
                                int chil = 1;
                                for (int i = 1; i < 20; i++)
                                {
                                    string stri = "//td[@id = '" + System.Convert.ToString(chil) + "_" + System.Convert.ToString(h) + "";
                                    var table1 = doc.DocumentNode.SelectSingleNode(stri + "']//div[@class = 'l-pr-t']");
                                    if (table1 != null)
                                    {
                                        type_par = table1.InnerText;
                                        if (type_par == "лек.")
                                        {
                                            type_par = "Лекция";
                                        }
                                        else if (type_par == "пр.")
                                        {
                                            type_par = "Практика";
                                        }
                                        _PairType.Add(type_par);
                                        var table = doc.DocumentNode.SelectSingleNode(stri + "']//div[@class = 'l-dn']");
                                        var table5 = doc.DocumentNode.SelectSingleNode(stri + "']/div[1]/div[1]/div[3]");
                                        name_par = table.InnerText + table5.InnerText;
                                        _PairName.Add(name_par);

                                        var table2 = doc.DocumentNode.SelectSingleNode(stri + "']//div[@class = 'l-tn']");
                                        Prepod = table2.InnerText;
                                        _TeacherName.Add(Prepod);
                                        var table3 = doc.DocumentNode.SelectSingleNode(stri + "']//div[@class = 'l-p']");
                                        mesto = table3.InnerText;
                                        _Location.Add(mesto);

                                        col++;
                                        var flag = doc.DocumentNode.SelectSingleNode(stri + "']/div[2]/div[2]");

                                        if (flag != null)
                                        {
                                            prov[i]++;
                                            int j = i + 1;
                                            int stri_prov = 2;
                                            while (flag != null)
                                            {
                                                prov[i]++;
                                                table1 = doc.DocumentNode.SelectSingleNode(stri + "']/div[" + System.Convert.ToString(stri_prov) + "]/div[1]/div[2]");
                                                type_par = table1.InnerText;
                                                if (type_par == "лек.")
                                                {
                                                    type_par = "Лекция";
                                                }
                                                else if (type_par == "пр.")
                                                {
                                                    type_par = "Практика";
                                                }
                                                _PairType.Add(type_par);
                                                table = doc.DocumentNode.SelectSingleNode(stri + "']//div[@class = 'l-dn']");
                                                table5 = doc.DocumentNode.SelectSingleNode(stri + "']/div[1]/div[1]/div[3]");
                                                name_par = table.InnerText + table5.InnerText;
                                                _PairName.Add(name_par);
                                                //var table2 = doc.DocumentNode.SelectSingleNode("//td[@id = '4_1']");
                                                table2 = doc.DocumentNode.SelectSingleNode(stri + "']/div[" + System.Convert.ToString(stri_prov) + "]/div[3]");
                                                Prepod = table2.InnerText;
                                                _TeacherName.Add(Prepod);
                                                table3 = doc.DocumentNode.SelectSingleNode(stri + "']/div[" + System.Convert.ToString(stri_prov) + "]/div[4]");
                                                mesto = table3.InnerText;
                                                _Location.Add(mesto);
                                                stri_prov++;
                                                flag = doc.DocumentNode.SelectSingleNode(stri + "']/div[" + System.Convert.ToString(stri_prov) + "]/div[2]");
                                                j++;
                                            }
                                            IDCommonPair.Add(IDPair++, j - i);

                                            i = j;
                                        }
                                        else
                                        {
                                            IDCommonPair.Add(IDPair++, 1);
                                            prov[i] = 0;
                                        }
                                    }
                                    else
                                    {
                                        IDCommonPair.Add(IDPair++, 0);
                                    }
                                    chil++;
                                }
                            }
                        }
                    }
                }
            }

        }

    }
}
