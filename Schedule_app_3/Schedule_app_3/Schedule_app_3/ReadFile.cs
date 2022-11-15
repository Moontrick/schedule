using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SheduleFile
{
    class ReadFile
    {
        private int _Type;
        public int Type { get { return _Type; } }

        private int _Group;
        public int Group { get { return _Group; } }

        private string _Name;
        public string Name { get { return _Name; } }

        //public List<List<string>> fullList = new List<List<string>>();

        private List<string> _PairType = new List<string>();
        private List<string> _PairName = new List<string>();
        private List<string> _TeacherName = new List<string>();
        private List<string> _Location = new List<string>();

        public List<string> PairType { get { return _PairType; } }
        public List<string> PairName { get { return _PairName; } }
        public List<string> TeacherName { get { return _TeacherName; } }
        public List<string> Location { get { return _Location; } }

        private int idPair = 0;
        private int CountPair = 0;

        private List<int> iddMergePair = new List<int>();
        private Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();

        private List<Dictionary<int, int>> _tmp_Value = new List<Dictionary<int, int>>();
        public List<Dictionary<int, int>> tmp_Value { get { return _tmp_Value; } }

        private Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        

        public ReadFile(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {

                using (StreamReader read = new StreamReader(stream))
                {
                    string[] line = read.ReadToEnd().Split('\n');
                    int DayCount = 0;

                    _Type = Convert.ToInt32(line[0]);
                    if (_Type == 0) _Group = Convert.ToInt32(line[1]);  else _Name = line[1];
                    
                    for (int i = 2; i < line.Length; i++)
                    {
                        if (line[i] == "@\r")
                        {
                            _tmp_Value.Add(keyValuePairs);
                            _tmp_Value = new List<Dictionary<int, int>>();

                            DayCount++;
                            IDCommonPair.Add(DayCount, null);
                            idPair = 0;
                        }

                        if (line[i] == "!\r") {
                            
                            idPair++;
                            i++;
                            CountPair = Convert.ToInt32(line[i]);
                            keyValuePairs.Add(idPair, CountPair);
                            
                            
                            IDCommonPair[DayCount] = tmp_Value;
                            if (CountPair != 0)
                            { 
                            i++;
                                for (int j = 0; j < CountPair; j++)
                                {
                                    _PairType.Add(line[i]);
                                    _PairName.Add(line[i++]);
                                    _TeacherName.Add(line[i++]);
                                    _Location.Add(line[i++]);
                                }
                            }
                            
                        }

                    }

                }

            }

        }
    }
}

