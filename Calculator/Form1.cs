using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string avaibaleSymbols = "0123456789,.i+-"; //последние 3 символа только для COMPLEX
        private enum states { START, INT, DOUBLE, COMPLEX, ERROR }; // длинная арифметика?

        public Calculator()
        {
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            helpToolStripMenuItem.Text = "Help";
            langToolStripMenuItem.Text = "Language";
            aboutToolStripMenuItem.Text = "About";
            exitToolStripMenuItem.Text = "Exit";

            groupBox1.Text = "Input";
            groupBox2.Text = "Root degree";

            bt_calc.Text = "Calculate";
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Файл";
            helpToolStripMenuItem.Text = "Помощь";
            langToolStripMenuItem.Text = "Язык";
            aboutToolStripMenuItem.Text = "О программе";
            exitToolStripMenuItem.Text = "Выход";

            groupBox1.Text = "Ввод";
            groupBox2.Text = "Степень корня";

            bt_calc.Text = "Вычислить";
        }
    }
}
