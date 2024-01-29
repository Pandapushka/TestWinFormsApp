using System;
using System.Collections.Generic;
using System.IO;

namespace Dll
{
    public static class CsvReader
    {
        public static List<CsvItem> Read(string path)
        {
            List<CsvItem> list = new List<CsvItem>();
            try
            {
                var V = File.ReadLines(path);
                
                foreach (var i in V)
                {

                    string[] line = i.Split(';');
                    if (line[0] == "UserId")
                        continue;
                    CsvItem item = new CsvItem();
                    item.Id = Convert.ToInt32(line[0]);
                    item.Name = line[1];
                    item.SecondName = line[2];
                    item.Number = line[3];
                    list.Add(item);
                }

            }
            catch
            {

            }            
            return list;
        }
    }
}
