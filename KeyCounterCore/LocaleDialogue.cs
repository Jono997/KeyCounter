using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using ATEM;

namespace KeyCounter
{
    public static class LocaleDialogue
    {
        private static Dictionary<string, string> strings;
        private static string lf_name = "Locale.txt";
        private static string lf_path = Path.Combine(Environment.GetCommandLineArgs()[0], "..", lf_name);

        public static void Initialise()
        {
            if (File.Exists(lf_path))
            {
                string[] locale_file = File.ReadAllLines(lf_path, Encoding.UTF8);
                Regex file_to_dict_regex = new Regex(@"^(.+?)\s*:\s*(.+)$");
                strings = new Dictionary<string, string>();
                foreach (string line in locale_file)
                {
                    Match m = file_to_dict_regex.Match(line);
                    if (m.Success)
                    {
                        GroupCollection g = m.Groups;
                        if (g.Count > 2)
                            strings.Add(g[1].Value, g[2].Value.Replace(@"\n", "\r\n"));
                    }
                }
            }
        }

        public static string Get(string key, params object[] substitutes)
        {
            if (strings.ContainsKey(key))
            {
                string line_raw = strings[key];
                string line = line_raw;
                for (int i = 0; i < substitutes.Length; i++)
                {
                    string[] line_split = line.Split(new string[] { $"{{{i}}}" }, StringSplitOptions.None);
                    line = line_split.Stitch(substitutes[i].ToString());
                }
                return line;
            }
            else
                return key;
        }

        public static string GetFallback(string key, string fallback)
        {
            return strings.ContainsKey(key) ? strings[key] : fallback;
        }
    }
}
