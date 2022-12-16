using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_app_3
{
    internal class Csv
    {

        private List<string> _Name = new List<string>();
        private List<string> _SurName = new List<string>();
        private List<string> _Otchestvo = new List<string>();
        private List<string> _Id = new List<string>();

        public List<string> Name { get { return _Name; } }
        public List<string> SurName { get { return _SurName; } }
        public List<string> Otchestvo { get { return _Otchestvo; } }
        public List<string> Id { get { return _Id; } }
        public Csv(string str)
        {
            using (var reader = FileSystem.OpenAppPackageFileAsync(str).Result)
            {
                using (StreamReader streamReader = new StreamReader(reader))
                {

                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        var Stringvalues = line.Split(';');
                        var values = line.Split(',');

                        _SurName.Add(values[0]);
                        _Name.Add(values[1]);
                        _Otchestvo.Add(values[2]);
                        _Id.Add(values[3]);
                    }
                }
            }
        }
    }
}