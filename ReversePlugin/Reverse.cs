using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlugins;

namespace ReversePlugin
{
    public class Reverse : IPlugin
    {
        public string PluginName
        {
            get { return "Reverse"; }
        }

        public void Execute(System.Windows.Forms.RichTextBox textBox)
        {
            textBox.Text = new string(textBox.Text.ToCharArray().Reverse().ToArray());
        }
    }
}
