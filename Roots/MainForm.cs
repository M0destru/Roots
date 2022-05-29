using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Roots
{
    public partial class MainForm : Form
    {
        private static int precision = 3;
        string msg;
        string caption;
        string invite;
        string helpHeader;

        public MainForm()
        {
            InitializeComponent();
            numUpDownPrecision.Maximum = 15;

            msg =
                "О программе: Программа для вычисления корней v1.0.0\n\nВозможности программы:\n" +
                "   - Поддерживаются целые, вещественные (разделитель - точка), комплексные (в виде a + bi или a + b * i) и длинные числа\n" +
                "   - Корень может быть получен в арифметическом и аналитическом (только для целых чисел) видах\n" +
                "   - Можно выбрать, с какой точностью вычислить корень\n" +
                "   - Программа доступна на двух языках: русский и английский\n" +
                "   - Программа поддерживает подключение новых языков\n\n" +
                "Инструкция:\n" +
                "   *Вы можете изменить язык интерфейса во вкладке \"Настройки\"\n" +
                "   1. Введите значение в поле \"Ввод числа\"\n" +
                "   2. Выберите, с какой точностью Вы хотите вычислить корень, в поле \"Точность\"\n" +
                "   3. Выберите вид, в котором будет выведен корень\n" +
                "   4. Нажмите кнопку \"Извлечь\"\n" +
                "   5. Найденный корень будет выведен в поле \"Результат\"";
            caption = "Справка";
            invite = "Посетите наш сервер в Discord, если вам нужна помощь";
            helpHeader = "Контакты";
        }

        private void tsMenuSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this);
            sf.ShowDialog();
        }

        public void ChangeLoc(List<string> text)
        {
            if (text != null)
            {
                menuStrip1.Items[0].Text = text[0];
                caption = menuStrip1.Items[1].Text = text[1];
                gbInput.Text = text[2];
                lbAccuracy.Text = text[3];
                label1.Text = text[4];
                tbNum.PlaceholderText = text[5]; 
                btnGetRoot.Text = text[6];
                btnClearNum.Text = text[7];
                rbArithmetic.Text = text[8];
                rbAnalytical.Text = text[9];
                gbResult.Text = text[10];
                invite = text[35];
                menuStrip1.Items[2].Text = helpHeader = text[34];
                msg = "";
                for (int i = 16; i <= 28; i++)
                    msg += text[i];
            }
        }

        private void btnClearNum_Click(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbResult.Clear();
        }

        private void btnGetRoot_Click(object sender, EventArgs e)
        {
            try { tbResult.Text = Parser.calc(tbNum.Text, rbAnalytical.Checked, Convert.ToInt32(numUpDownPrecision.Value)); }
            catch (Exception ex) { tbResult.Text = ex.Message; }
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbAnalytical_CheckedChanged(object sender, EventArgs e)
        {
            numUpDownPrecision.Enabled = !rbAnalytical.Checked;
        }

        private void numUpDownPrecision_ValueChanged(object sender, EventArgs e)
        {
            precision = (int) numUpDownPrecision.Value;
        }

        private void tsMenuReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsMenuContacts_Click(object sender, EventArgs e)
        {
            Help form = new Help(invite);
            form.Text = helpHeader;
            form.ShowDialog();
        }
    }
}
