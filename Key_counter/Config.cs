using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Key_counter
{
    public class Config
    {
        public Key[] keys { get; set; }
        public int counter_start { get; set; }

        public Config()
        {
            keys = new Key[] { new Key(System.Windows.Forms.Keys.K, Key.KeyAction.Increment),
                               new Key(System.Windows.Forms.Keys.F, Key.KeyAction.Increment),
                               new Key(System.Windows.Forms.Keys.R, Key.KeyAction.Reset),
                               new Key(System.Windows.Forms.Keys.Pause, Key.KeyAction.Exit)
                             };
            counter_start = 0;
        }

        public Config(Key[] keys, int counter_start)
        {
            this.keys = keys;
            this.counter_start = counter_start;
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
            StreamWriter streamWriter = new StreamWriter("Configuration.xml");
            xmlSerializer.Serialize(streamWriter, this);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public static Config Load()
        {
            if (File.Exists("Configuration.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                StreamReader streamReader = new StreamReader("Configuration.xml");
                Config config = (Config)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
                return config;
            }
            else
                return new Config();
        }
    }
}
