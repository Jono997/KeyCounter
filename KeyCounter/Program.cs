using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KeyCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            LocaleDialogue.Initialise();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string file = args.Length == 0 ? "Configuration.xml" : args[0];
            if (File.Exists(file))
            {
                Config config = ConfigLoader.Load(File.ReadAllText(file));
                if (config.hasExit() || MessageBox.Show(LocaleDialogue.Get("noexit"), LocaleDialogue.Get("noexittitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Application.Run(new CountForm(config));
            }
            else
                MessageBox.Show(LocaleDialogue.Get("noconfig"));
        }
    }
}
