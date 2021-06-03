using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeyCounter
{
    public partial class MainForm : Form
    {
        private List<ConfigControl> configControls;
        private string filename;
        public bool changed;
        private Size tabPage_size;

        public MainForm()
        {
            configControls = new List<ConfigControl>();
            filename = null;
            changed = false;
            InitializeComponent();
            tabPage_size = exampleTabPage.Size;
            debugToolStripMenuItem.Visible = Debugger.IsAttached;
            newToolStripMenuItem_Click(null, null);
        }

        private void load_config(Config[] configs)
        {
            configControls.Clear();
            for (int i = 0; i < configs.Length; i++)
            {
                make_ConfigControl(configs[i]);
            }
            refresh_configsTabControl();
            changed = false;
        }

        private void make_ConfigControl(Config config)
        {
            configControls.Add(new ConfigControl()
            {
                Dock = DockStyle.Fill
            });
            configControls.Last().Setup(this, config);
        }

        private void refresh_configsTabControl()
        {
            configsTabControl.TabPages.Clear();
            for (int i = 0; i < configControls.Count; i++)
            {
                configsTabControl.TabPages.Add(new TabPage()
                {
                    Text = configControls[i].config.name,
                    Size = tabPage_size
                });
                configsTabControl.TabPages[i].Controls.Add(configControls[i]);
            }
        }

        private void save_config(string path)
        {
            Config[] saved_config = new Config[configControls.Count];
            for (int i = 0; i < configControls.Count; i++)
            {
                saved_config[i] = configControls[i].config;
            }
            string config_xml = ConfigLoader.Save(saved_config);
            File.WriteAllText(path, config_xml);
            changed = false;
            filename = path;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!check_unsaved_changes())
            {
                load_config(new Config[] { new Config() });
                filename = null;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                save_config(saveFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == null)
                saveAsToolStripMenuItem_Click(null, null);
            else
                save_config(filename);
        }

        /// <summary>
        /// Checks for unsaved changes. Returns true if the current function should be aborted.
        /// </summary>
        private bool check_unsaved_changes()
        {
            if (changed)
            {
                DialogResult dialogResult = MessageBox.Show("Save the current configuration?", "You have unsaved changes!", MessageBoxButtons.YesNoCancel);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(null, null);
                        return changed;
                    case DialogResult.No:
                        return false;
                    case DialogResult.Cancel:
                        return true;
                }
            }
            return false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = check_unsaved_changes();
        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changed = true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changed = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!check_unsaved_changes())
                {
                    filename = openFileDialog.FileName;
                    load_config(ConfigLoader.Load(File.ReadAllText(filename)));
                }
            }
        }

        private void createNewCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            make_ConfigControl(new Config());
            refresh_configsTabControl();
            changed = true;
        }

        public void refresh_tabPage_name(string name)
        {
            configsTabControl.SelectedTab.Text = name;
        }

        private void removeCurrentCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = configsTabControl.SelectedIndex;
            if (MessageBox.Show("Are you sure you want to delete counter \"" + configsTabControl.SelectedTab.Text + "\"?", "Delete counter?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                configControls.RemoveAt(i);
                refresh_configsTabControl();
                changed = true;
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool changed = this.changed;
            string filename = this.filename;
            string temp_path = Path.GetTempFileName();
            save_config(temp_path);
            Process test_process = new Process()
            {
                StartInfo = new ProcessStartInfo(Path.Combine(Environment.GetCommandLineArgs()[0], "..", "KeyCounter.exe"), temp_path)
            };
            test_process.Start();
            test_process.WaitForExit();
            File.Delete(temp_path);
            this.changed = changed;
            this.filename = filename;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KeyCounter by Jono99\nPlease send any and all customer support inquiries to your nearest rubbish bin. Seriously, this program literally just counts keystrokes, what issues could you have?\nIn all seriousness, you can send support inquiries to Discord user Jono99#9105.", "KeyCounter v2");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"v1: Initial release
v2: - Separated editing and running configurations into separate executables
- Added multiple counter support
- Added counter position adjustment
- Added counter names
- Added GlobalCheckpoint and GlobalReset key roles
", "KeyCounter changelog");
        }
    }
}