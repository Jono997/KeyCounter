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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string file = args.Length == 0 ? "Configuration.xml" : args[0];
            if (File.Exists(file))
            {
                Config[] configs = ConfigLoader.Load(File.ReadAllText(file));
                Application.Run(new CountForm(configs));
            }
            else
                MessageBox.Show("No configuration found. Please create one via the configuration tool.");
        }
    }
}
