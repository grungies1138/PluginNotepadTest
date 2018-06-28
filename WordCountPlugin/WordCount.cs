using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPlugins;

namespace WordCountPlugin
{
    public class WordCount : IPlugin
    {
        public string PluginName
        {
            get { return "Word Count"; }
        }

        public void Execute(RichTextBox textBox)
        {
            var words = textBox.Text.Split(' ');
            MessageBox.Show($"Current word count: {words.Length}", PluginName);
        }
    }
}
