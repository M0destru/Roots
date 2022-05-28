using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //example:
            var text = Lang.GetLoc("en");
            if (text != null)
            {
                label1.Text = text[0];
                button1.Text = text[1];
            }
        }
    }
}
