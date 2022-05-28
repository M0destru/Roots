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

        private void btnGetRoot_Click(object sender, EventArgs e)
        {
            string valType;
            try
            {
                valType = Parser.calc(tbNum.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (rbAnalytical.Checked && (valType == "double" || valType == "complex"))
            {
                MessageBox.Show("Вещественные и комплексные числа нельзя представить в аналитическом виде!");
                return;
            }

            switch (valType)
            {
                case "integer":
                case "biginteger":
                    if (rbAnalytical.Checked)
                        tbResult.Text = SquareRootCalculator.AnalyticalSQRT(BigInteger.Parse(tbNum.Text)); 
                    else
                        tbResult.Text = Math.Round(SquareRootCalculator.SQRT(double.Parse(tbNum.Text), precision).Real, precision).ToString(); 
                    break; 
                    
                case "double":
                    tbResult.Text = SquareRootCalculator.SQRT(double.Parse(tbNum.Text), precision).Real.ToString();
                    break;
                case "complex":
                    Complex compNum = SquareRootCalculator.SQRT(ComplexParser.parse(tbNum.Text), precision);
                    double im = Math.Round(compNum.Imaginary, precision);
                    double re = Math.Round(compNum.Real, precision);
                    string sign = im >= 0 ? "+" : "-";
                    tbResult.Text = $"{re}{sign}{im}i";
                    break;
            }
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
            string msg =
                "О программе: Программа для вычисления корней v1.0.0\n\nВозможности программы:\n" +
                "   - Поддерживаются целые, вещественные, комплексные и длинные числа\n" +
                "   - Корень может быть получен в арифмитическом и аналитическом видах\n" +
                "   - Можно выбрать с какой точностью вычислить корень\n" +
                "   - Программа доступна на двух языках: русский и английский\n" +
                "   - Программа поддерживает подключение новых языков\n\n" +
                "Инструкция:\n" +
                "   *Вы можете изменить язык интерфейса во вкладке \"Настройки\"*\n" +
                "   1. Введите значение в поле \"Ввод числа\"\n" +
                "   2. Выберить с какой точностью Вы хотите вычислить корень в поле \"Точность\"\n" +
                "   3. Выберите вид, в котором будет выведен корень\n" +
                "   4. Нажмите кнопку \"Извлечь\"\n" +
                "   5. Найденный корень будет выведен в поле \"Результат\"";
            string caption = "Справка";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
