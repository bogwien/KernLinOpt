using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KernLinOpt
{
    public partial class FormMain : Form
    {
        KernLin objKL;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGenerator_Click(object sender, EventArgs e)
        {
            int trying  = Convert.ToInt32(domainUpDownTry.Text);
            int size    = Convert.ToInt32(domainUpDownSize.Text);
            objKL       = new KernLin(size,trying);
            objKL.RandArr();
            labelGenerator.Text = "Массив из " + size + " элементов - готов!";
            buttonInitCalc.Enabled = true;
            buttonReset.Enabled = true;
            domainUpDownTry.Enabled = false;
            domainUpDownSize.Enabled = false;
        }

        private void buttonInitCalc_Click(object sender, EventArgs e)
        {
            int InitRes = objKL.calcInitItems();
            labelInitCalc.Text = "Результат: " + InitRes + " мешков";
            buttonOptimizator.Enabled = true;
        }

        private void buttonOptimizator_Click(object sender, EventArgs e)
        {
            buttonOptimizator.Enabled = false;
            int result = objKL.doKernLin();
            labelOptimizator.Text = "Ответ: "+ result + " мешков";
            buttonOptimizator.Enabled = true;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            domainUpDownTry.Enabled = true;
            domainUpDownSize.Enabled = true;
            buttonOptimizator.Enabled = false;
            buttonInitCalc.Enabled = false;
            labelGenerator.Text = "Сгенерируйте массив";
            labelInitCalc.Text = "Оцените начальную последовательность";
            labelOptimizator.Text = "Оптимизируйте!";
        }
    }
}
