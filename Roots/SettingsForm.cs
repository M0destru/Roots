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
    public partial class SettingsForm : Form
    {
        MainForm basic;

        public SettingsForm(MainForm mf)
        {
            InitializeComponent();
            basic = mf;

            bool loaded = Lang.LoadLoc();
            if (loaded)
                UpdateList();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLoc(cbLanguage.Text);
        }

        void ChangeLoc(string lang)
        {
            var text = Lang.GetLoc(lang);

            if (text != null)
            {
                gbLanguage.Text = text[6];
                gbLanguageFile.Text = text[7];
                btnLoadLanguageFile.Text = text[8];

                Update();
            }
            basic.ChangeLoc(lang, text);
        }

        private void btnLoadLanguageFile_Click(object sender, EventArgs e)
        {
            Lang.LoadLoc(tbFile.Text);
            UpdateList();
        }

        public void UpdateList()
        {
            cbLanguage.Items.Clear();

            var dict = Lang.GetDict();
            int count = dict.Keys.Count;
            var key = dict.Keys.ToList<string>();

            for (int i = 0; i < count; i++)
            {
                cbLanguage.Items.Add(key[i]);
            }
        }

        private void btnGetPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    tbFile.Text = fd.FileName;
                }
            }
        }
    }
}
