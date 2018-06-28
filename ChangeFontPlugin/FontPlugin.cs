using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPlugins;

namespace ChangeFontPlugin
{
    public class FontPlugin : IPlugin
    {
        public string PluginName
        {
            get { return "Fonts"; }
        }

        public void Execute(System.Windows.Forms.RichTextBox textBox)
        {
            FontDialog fonts = new FontDialog();
            fonts.ShowDialog();

            textBox.Font = fonts.Font;
        }
    }
}
