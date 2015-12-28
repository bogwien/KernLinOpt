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
        }

        private void buttonInitCalc_Click(object sender, EventArgs e)
        {
            int InitRes = objKL.calcInitItems();
            labelInitCalc.Text = "Результат: " + InitRes + " мешков";
        }

        private void buttonOptimizator_Click(object sender, EventArgs e)
        {
            int result = objKL.doKernLin();
            labelOptimizator.Text = "Ответ: "+ result + " мешков";
            
        }
    }
}
