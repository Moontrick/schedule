using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schedule_app_3
{
    internal class WriteFile
    {

        public WriteFile() { }

        public WriteFile(Dictionary<int, List<Dictionary<int, int>>> IDCommonPair, List<string> _PairType, List<string> _PairName
                        , List<string> _TeacherName, List<string> _Location, List<string> _Podgroup)
        {



            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "Shedule.txt");

            using (FileStream fileStream = System.IO.File.Create(targetFile))
            {

                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    string group = "311";
                    string userType = "0"; // 0 - student 1 - teacher
                    string new_day = "@";
                    string new_pair = "!";
                    writer.WriteLine(group);
                    writer.WriteLine(userType);
                    int id = 0;
                    foreach (var DAY in IDCommonPair)
                    {
                        writer.WriteLine(new_day);
                        foreach (var PAIR_IN_DAY in DAY.Value)
                        {
                            foreach (var PAIR_ID in PAIR_IN_DAY)
                            {
                                writer.WriteLine(new_pair);
                                writer.WriteLine(PAIR_ID.Value);
                                for (int i = 0; i < PAIR_ID.Value; i++)
                                {
                                    writer.WriteLine(_PairType[id]);
                                    writer.WriteLine(_PairName[id]);
                                    writer.WriteLine(_Podgroup[id]);
                                    writer.WriteLine(_TeacherName[id]);
                                    writer.WriteLine(_Location[id]);
                                    id++;
                                }


                            }
                        }
                    }
                }

            }



        }
    }
}