using NmapXmlParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NmapTool
{
    internal class NmapReport
    {
        public static nmaprun Read(string filePath)
        {
            var xmlSerializer = new XmlSerializer(typeof(nmaprun));
            var result = default(nmaprun);

            using (var xmlStream = new StreamReader(filePath))
            {
                result = xmlSerializer.Deserialize(xmlStream) as nmaprun;
            }
            return result;
        }
    }
}
