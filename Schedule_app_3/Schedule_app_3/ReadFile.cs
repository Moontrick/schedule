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
        private List<string> _Podgroup = new List<string>();
        public List<string> PairType { get { return _PairType; } }
        public List<string> PairName { get { return _PairName; } }
        public List<string> TeacherName { get { return _TeacherName; } }
        public List<string> Location { get { return _Location; } }
        public List<string> Podgroup { get { return _Podgroup; } }
<<<<<<< HEAD
        
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4

        private int idPair = 0;
        private int CountPair = 0;

        private List<int> iddMergePair = new List<int>();
        private Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();
        public Dictionary<int, List<Dictionary<int, int>>> _IDCommonPair { get { return IDCommonPair; } }

        private List<Dictionary<int, int>> _tmp_Value = new List<Dictionary<int, int>>();
        public List<Dictionary<int, int>> tmp_Value { get { return _tmp_Value; } }

        private Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
<<<<<<< HEAD
        
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4

        public ReadFile(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {

                using (StreamReader read = new StreamReader(stream))
                {
                    string[] line = read.ReadToEnd().Split('\n');
                    int DayCount = 0;

                    _Type = Convert.ToInt32(line[0]);
<<<<<<< HEAD
                    if (_Type == 0) _Group = Convert.ToInt32(line[1]);  else _Name = line[1];
                    
                    for (int i = 2; i < line.Length - 1;)
                    {
                        if (line[i] == "@\r")
=======
                    if (_Type == 0) _Group = Convert.ToInt32(line[1]); else _Name = line[1];

                    for (int i = 2; i < line.Length - 1;)
                    {
                        if (line[i] == "@\r" || line[i] == "@")
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
                        {
                            //_tmp_Value.Add(keyValuePairs);
                            //_tmp_Value = new List<Dictionary<int, int>>();
                            //keyValuePairs.Clear();
                            //DayCount++;
                            //IDCommonPair.Add(DayCount, null);

                            _tmp_Value.Add(keyValuePairs);
                            //IDCommonPair.Add(DayCount, tmp_Value);
                            if (DayCount == 0 && i != 2)
                            {
                                IDCommonPair[DayCount] = tmp_Value;
                                DayCount++;

<<<<<<< HEAD
                            } else if (DayCount != 0)
=======
                            }
                            else if (DayCount != 0)
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
                            {
                                IDCommonPair[DayCount] = tmp_Value;
                                DayCount++;

                            }

                            if (DayCount != 5)
                            {
                                _tmp_Value = new List<Dictionary<int, int>>();

                            }


                            keyValuePairs = new Dictionary<int, int>();
                            idPair = 0;
                            i++;
                        }

<<<<<<< HEAD
                        if (line[i] == "!\r") {
                            
=======
                        if (line[i] == "!\r" || line[i] == "!")
                        {

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
                            i++;
                            CountPair = Convert.ToInt32(line[i]);
                            keyValuePairs.Add(idPair, CountPair);
                            idPair++;


<<<<<<< HEAD
                           
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
                            if (CountPair != 0)
                            {
                                i++;
                                for (int j = 0; j < CountPair; j++)
                                {
                                    _PairType.Add(line[i++]);
                                    _PairName.Add(line[i++]);
                                    _Podgroup.Add(line[i++]);
                                    _TeacherName.Add(line[i++]);
                                    _Location.Add(line[i++]);
                                }
                            }
                            else i++;
<<<<<<< HEAD
                            
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
                        }

                    }
                    //_tmp_Value.Add(keyValuePairs);
                    //tmp_Value.Clear();
                    //tmp_Value.Add(keyValuePairs);
                    //IDCommonPair[DayCount] = tmp_Value;

                    _tmp_Value = new List<Dictionary<int, int>>();
                    _tmp_Value.Add(keyValuePairs);
                    IDCommonPair[DayCount] = _tmp_Value;



                }

            }

        }
    }
<<<<<<< HEAD
}

=======
}
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
