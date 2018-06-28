using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TestPlugins;

namespace PluginNotepadTest
{
    public partial class MainForm : Form
    {
        readonly List<IPlugin> _plugins;
        public MainForm()
        {
            InitializeComponent();

            
            _plugins = GenericPluginLoader<IPlugin>.LoadPlugins("Plugins")?.ToList();
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            if (_plugins != null)
            {
                foreach (IPlugin plugin in _plugins)
                {
                    pluginsToolStripMenuItem.DropDownItems.Add(plugin.PluginName);
                }
                pluginsToolStripMenuItem.DropDownItemClicked += PluginsToolStripMenuItem_DropDownItemClicked;
            }
        }

        private void PluginsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var plugin = _plugins.First(t => t.PluginName == e.ClickedItem.Text);
            plugin.Execute(textBox1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = "";
                var file = openFileDialog.FileName;

                using (FileStream fs = File.Open(file, FileMode.Open))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        textBox1.Text += temp.GetString(b);
                    }
                }
            }
        }
    }
}
