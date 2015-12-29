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
            //0. Если кнопка нажата без reset, то блокируем кнопку оптимизации и возвращаем исходные label
            buttonOptimizator.Enabled = false;
            labelInitCalc.Text = "Оцените начальную последовательность";
            labelOptimizator.Text = "Оптимизируйте!";

            //1. Выключаем возможность менять параметры конструктора(для юзабилити)
            domainUpDownTry.Enabled = false;
            domainUpDownSize.Enabled = false;

            //2. Вызываем конструктор
            int trying  = Convert.ToInt32(domainUpDownTry.Text);
            int size    = Convert.ToInt32(domainUpDownSize.Text);
            objKL       = new KernLin(size,trying);

            //3. Заполняем массив случайными данными
            objKL.RandArr();

            //4. Отображаем результат в label
            labelGenerator.Text = "Массив из " + size + " элементов - готов!";
            
            //5. Включаем кнопки оценки и reset
            buttonInitCalc.Enabled = true;
            buttonReset.Enabled = true;
            //6. Выбираем в фокус кнопку оценки
            buttonInitCalc.Select();
        }

        private void buttonInitCalc_Click(object sender, EventArgs e)
        {
            //0. Блокируем повторное нажатие(до резета или новой генерации массива)
            buttonInitCalc.Enabled = false;

            //1. Выполняем оценку массива и выводим результат в label
            int InitRes = objKL.calcInitItems();
            labelInitCalc.Text = "Результат: " + InitRes + " мешков";

            //2. Включаем возможность вызвать оптимизацию
            buttonOptimizator.Enabled = true;
            
            //3. Выбираем в фокус кнопку оптимизации
            buttonOptimizator.Select();
        }

        private async void buttonOptimizator_Click(object sender, EventArgs e)
        {
            //0. Выключаем кнопки
            buttonGenerator.Enabled = false;
            buttonReset.Enabled = false;
            
            //1. Делаем асинхронно оптимизацию и выводим результат
            int result = await objKL.DoKernLinAsync();
            labelOptimizator.Text = "Ответ: "+ result + " мешков";
            
            //2. Включаем кнопки
            buttonOptimizator.Enabled = true;
            buttonGenerator.Enabled = true;
            buttonReset.Enabled = true;

            //3. Выбираем в фокус кнопку оптимизации
            buttonOptimizator.Select();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //0. Выключаем кнопки reset, оптимизации и оценки
            buttonReset.Enabled = false;
            buttonInitCalc.Enabled = false;
            buttonOptimizator.Enabled = false;
            
            //1. Разблокируем элементы ввода параметров конструктора
            domainUpDownTry.Enabled = true;
            domainUpDownSize.Enabled = true;

            //2. Восстанавливаем исходные label
            labelGenerator.Text = "Сгенерируйте массив";
            labelInitCalc.Text = "Оцените начальную последовательность";
            labelOptimizator.Text = "Оптимизируйте!";

            //3. Выбираем в фокус кнопку генерации
            buttonGenerator.Select();
        }
    }
}
