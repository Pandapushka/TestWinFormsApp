using System;
using System.Collections.Generic;
using System.Xml;

namespace Dll
{
    public static class XmlReader
    {
        public static List<XmlItem> Read(string path)
        {
            List<XmlItem> list = new List<XmlItem>();
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(path);
                XmlElement root = xmlDocument.DocumentElement;
                if (root != null)
                {
                    foreach (var i in root)
                    {
                        var Xml = i as XmlElement;
                        var id = Xml.GetAttribute("UserId");
                        string Pan = "";
                        string ExpDate = "";
                        foreach (XmlNode child in Xml.ChildNodes)
                        {
                            if (child.Name == "Pan")
                            {
                                Pan = child.InnerText;
                            }
                            else if (child.Name == "ExpDate")
                            {
                                ExpDate = child.InnerText;
                            }
                        }
                        XmlItem xmlItem = new XmlItem();
                        xmlItem.Id = Convert.ToInt32(id);
                        xmlItem.Pan = Pan;
                        xmlItem.ExpDate = ExpDate;
                        list.Add(xmlItem);
                    }
                }
            }
            catch
            {
                
            }
            return list;
        }
    }
}
