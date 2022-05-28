using System;
using System.Drawing;
using System.IO;
using System.Linq;
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

            string curLoc = Lang.CheckLoc();
            if (curLoc != null)
                ChangeLoc(curLoc);
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void ChangeLoc(string lang)
        {
            var text = Lang.GetLoc(lang);

            if (text != null)
            {
                this.Text = text[0];
                gbLanguage.Text = text[11];
                gbLanguageFile.Text = text[12];
                tbFile.PlaceholderText = text[13];
                btnLoadLanguageFile.Text = text[14];
                btnOk.Text = text[15];

                Update();
            }

            basic.ChangeLoc(text);
            Lang.ChangeLoc(text);
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
                fd.Filter = "JSON|*.json";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    tbFile.Text = fd.FileName;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ChangeLoc(cbLanguage.Text);
        }
    }
}
