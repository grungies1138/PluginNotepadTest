using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlugins;

namespace FindPlugin
{
    public class FindPlugin : IPlugin
    {
        public string PluginName
        {
            get { return "Find"; }
        }

        public void Execute(System.Windows.Forms.RichTextBox textBox)
        {
           // Todo: Implement execution
        }
    }
}
