using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPlugin
{
    public partial class FindForm : Form
    {
        public string SearchText { get; set; }
        public FindForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SearchText = findTextBox.Text;
            Close();
        }
    }
}
