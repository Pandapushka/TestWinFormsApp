using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Dll
{
    public static class FileProvider
    {
        public static List<XmlItem> GlobalXmlList = new List<XmlItem>();
        public static List<CsvItem> GlobalCsvList = new List<CsvItem>();
        public static List<ResultItem> GlobalResultList = new List<ResultItem>();
        public static void Result(List<XmlItem> xml, List<CsvItem> csv, bool left)
        {
            for (int x = 0; x < xml.Count; x++)
            {
                for (int c = 0; c < csv.Count; c++)
                {
                    var m1 = xml[x];
                    var m2 = csv[c];
                    if (m1.Id == m2.Id)
                    {
                        GlobalResultList.Add(new ResultItem { UserId = m1.Id, FirstName = m2.Name, LastName = m2.SecondName, Pan = m1.Pan, Phone = m2.Number, ExpDate = m1.ExpDate });
                        //Console.WriteLine("Совпадение найдено " + m2.Id);
                        xml.RemoveAt(x);
                        csv.RemoveAt(c);
                        if (x > 0)
                        {
                            x--;
                        }
                        c--;
                    }
                }
            }
            if (left)
            {
                GlobalXmlList.AddRange(xml);
            }
            else
            {
                GlobalCsvList.AddRange(csv);
            }
        }
        public static string GetResult()
        {
            var options1 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(GlobalResultList, options1);
            GlobalResultList.Clear();
            return jsonString;
        }
    }
}
