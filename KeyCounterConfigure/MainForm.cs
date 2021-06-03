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
        private int polling_rate;
        private double counter_opacity;
        private string filename;
        public bool changed;
        private Size tabPage_size;

        public MainForm()
        {
            configControls = new List<ConfigControl>();
            filename = null;
            changed = false;
            InitializeComponent();
            InitialiseLocaleComponents();
            tabPage_size = exampleTabPage.Size;
            debugToolStripMenuItem.Visible = Debugger.IsAttached;
            newToolStripMenuItem_Click(null, null);
        }

        public void InitialiseLocaleComponents()
        {
            Text = LocaleDialogue.Get("maintitle");
            fileToolStripMenuItem.Text = LocaleDialogue.Get("menufile");
            editToolStripMenuItem.Text = LocaleDialogue.Get("menuedit");
            aboutToolStripMenuItem.Text = LocaleDialogue.Get("menuabout");
            newToolStripMenuItem.Text = LocaleDialogue.Get("newconfig");
            openToolStripMenuItem.Text = LocaleDialogue.Get("openconfig");
            saveToolStripMenuItem.Text = LocaleDialogue.Get("saveconfig");
            saveAsToolStripMenuItem.Text = LocaleDialogue.Get("saveconfigas");
            quitToolStripMenuItem.Text = LocaleDialogue.Get("quit");
            createNewCounterToolStripMenuItem.Text = LocaleDialogue.Get("newcounter");
            removeCurrentCounterToolStripMenuItem.Text = LocaleDialogue.Get("removecounter");
            editCounterOpacityToolStripMenuItem.Text = LocaleDialogue.Get("opacity");
            editPollingRateToolStripMenuItem.Text = LocaleDialogue.Get("pollingrate");
            testToolStripMenuItem.Text = LocaleDialogue.Get("testconfig");
            creditsToolStripMenuItem.Text = LocaleDialogue.Get("credits");
            changelogToolStripMenuItem.Text = LocaleDialogue.Get("changelog");
        }

        private void load_config(Config config)
        {
            configControls.Clear();
            for (int i = 0; i < config.configs.Length; i++)
            {
                make_ConfigControl((KeyCounterConfig)config.configs[i]);
            }
            polling_rate = config.polling_rate;
            counter_opacity = config.counter_opacity;
            refresh_configsTabControl();
            changed = false;
        }

        private void make_ConfigControl(KeyCounterConfig config)
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
            Config saved_config = new Config();
            saved_config.configs = new KeyCounterConfig[configControls.Count];
            for (int i = 0; i < configControls.Count; i++)
            {
                saved_config.configs[i] = configControls[i].config;
            }
            saved_config.polling_rate = polling_rate;
            saved_config.counter_opacity = counter_opacity;
            string config_xml = ConfigLoader.Save(saved_config);
            File.WriteAllText(path, config_xml);
            changed = false;
            filename = path;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!check_unsaved_changes())
            {
                load_config(new Config());
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
                DialogResult dialogResult = MessageBox.Show(LocaleDialogue.Get("unsavedchanges"), LocaleDialogue.Get("unsavedchangestitle"), MessageBoxButtons.YesNoCancel);
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
            make_ConfigControl(new KeyCounterConfig());
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
            if (MessageBox.Show($"Are you sure you want to delete counter \"{configsTabControl.SelectedTab.Text}\"?", "Delete counter?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreditsForm().ShowDialog();
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
v3: - Added counter colour and position customisation
- Added multiple trigger types
- Added increment/decrement rates for those key roles
- Added the ability to change a counter's colour and position
- Added counter opacity (applies to all counters)
- Added a warning when running a config that has no exit role usage
- Setting a key to an action now no longer accepts keys KeyCounter can't use
- Added tooltips
- Added text file that stores most text (used for translating)
", "KeyCounter changelog");
        }

        private void editPollingRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurePollingRateForm configureForm = new ConfigurePollingRateForm(polling_rate);
            if (configureForm.ShowDialog() == DialogResult.OK)
            {
                polling_rate = configureForm.polling_rate;
                changed = true;
            }
        }

        private void editCounterOpacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureCounterOpacityForm configureForm = new ConfigureCounterOpacityForm(counter_opacity);
            if (configureForm.ShowDialog() == DialogResult.OK)
            {
                counter_opacity = configureForm.Opacity;
                changed = true;
            }
        }
    }
}