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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsMenuSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this);
            sf.ShowDialog();
        }

        public void ChangeLoc(string lang, List<string> text)
        {
            if (text != null)
            {
                menuStrip1.Items[0].Text = text[0];
                gbInput.Text = text[1];
                btnClearNum.Text = text[2];
                btnGetRoot.Text = text[3];
                gbResult.Text = text[4];
                lbAccuracy.Text = text[5];
            }
        }

        private void btnClearNum_Click(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbResult.Clear();
        }
    }
}
