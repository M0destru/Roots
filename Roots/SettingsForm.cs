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
            Lang.LoadLoc(btnLoadLanguageFile.Text);
        }

        void UpdateList()
        {
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
            /* TODO: заготовка для Артема */
            var dlg = new OpenFileDialog();
            dlg.Filter = "JSON|*.json";

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var path = Path.GetFullPath(dlg.FileName);

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                
            }

            tbFile.Text = path;
        }
    }
}
