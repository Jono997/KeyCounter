using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace KeyCounter
{
    public static class ConfigLoader
    {
        public static string Save(Config[] configs)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config[]));
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, configs);
            stringWriter.Flush();
            stringWriter.Close();
            return stringWriter.ToString();
        }

        public static Config[] Load(string xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config[]));
            StringReader stringReader = new StringReader(xml);
            Config[] config = (Config[])xmlSerializer.Deserialize(stringReader);
            stringReader.Close();
            return config;
        }
    }
}
