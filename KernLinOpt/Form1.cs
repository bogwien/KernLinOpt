﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
            
            //1. Очищаем график
            this.chart.Series["SeriesInit"].Points.Clear();
            this.chart.Series["SeriesCurrent"].Points.Clear();

            //2. Выключаем возможность менять параметры конструктора(для юзабилити)
            domainUpDownTry.Enabled     = false;
            domainUpDownSize.Enabled    = false;
            comboBoxCapacity.Enabled    = false;
            comboBoxMin.Enabled         = false;
            comboBoxMax.Enabled         = false;

            //3. Вызываем конструктор
            int trying      = Convert.ToInt32(domainUpDownTry.Text);
            int size        = Convert.ToInt32(domainUpDownSize.Text);
            int capacity    = Convert.ToInt32(comboBoxCapacity.Text);
            int min         = Convert.ToInt32(comboBoxMin.Text);
            int max         = Convert.ToInt32(comboBoxMax.Text);

            if ((capacity < max) || (min > max))
            {
                showError();
                domainUpDownTry.Enabled = true;
                domainUpDownSize.Enabled = true;
                comboBoxCapacity.Enabled = true;
                comboBoxMin.Enabled = true;
                comboBoxMax.Enabled = true;
            }
            else {
                objKL = new KernLin(size, trying, capacity, min, max);

                //4. Заполняем массив случайными данными
                objKL.RandArr();

                //5. Отображаем результат в label
                labelGenerator.Text = "Массив из " + size + " элементов - готов!";

                //6. Включаем кнопки оценки и reset
                buttonInitCalc.Enabled = true;
                buttonReset.Enabled = true;
                checkBoxFFD.Enabled = true;

                //7. Выбираем в фокус кнопку оценки
                buttonInitCalc.Select();
            }
        }

        private async void buttonInitCalc_Click(object sender, EventArgs e)
        {
            //0. Выключаем кнопки
            buttonInitCalc.Enabled = false;
            buttonGenerator.Enabled = false;
            buttonReset.Enabled = false;
            checkBoxFFD.Enabled = false;
            toolStripStatusLabel.Text = "Выполнение...";
            panel.UseWaitCursor = true;

            //1. Выполняем оценку массива и выводим результат в label
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] InitRes = objKL.calcInitItems();
            int InitResLength = InitRes.Length;
            labelInitCalc.Text = "Результат: " + InitResLength + " мешков";

            //2. Если включен чекбокс выполняем и отрисовываем First-Fit Decreasing (рабочий массив array)
            if (checkBoxFFD.Checked)
            {
                if (await objKL.FirstFitDecreasing())
                {
                    this.chart.Series["SeriesCurrent"].Points.DataBindY(objKL.calcArrItems());
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            //3. Включаем кнопки
            buttonOptimizator.Enabled = true;
            buttonGenerator.Enabled = true;
            buttonReset.Enabled = true;
            toolStripStatusLabel.Text = "Готово за " + elapsedTime;
            panel.UseWaitCursor = false;

            //4. Выбираем в фокус кнопку оптимизации
            buttonOptimizator.Select();
            this.chart.Series["SeriesInit"].Points.DataBindY(InitRes);
        }

        private async void buttonOptimizator_Click(object sender, EventArgs e)
        {
            //0. Выключаем кнопки
            buttonGenerator.Enabled     = false;
            buttonReset.Enabled         = false;
            buttonOptimizator.Enabled   = false;
            buttonOpenF.Enabled         = false;
            toolStripStatusLabel.Text   = "Выполнение...";
            panel.UseWaitCursor         = true;

            //1. Делаем асинхронно оптимизацию и выводим результат
            Stopwatch stopWatch         = new Stopwatch();
            stopWatch.Start();

            int[] result                = await objKL.DoKernLinAsync();
            int resultLength            = result.Length;
            labelOptimizator.Text       = "Ответ: " + resultLength + " мешков";
            this.chart.Series["SeriesCurrent"].Points.DataBindY(result);

            stopWatch.Stop();
            TimeSpan ts                 = stopWatch.Elapsed;
            string elapsedTime          = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            
            //2. Включаем кнопки
            buttonOptimizator.Enabled   = true;
            buttonGenerator.Enabled     = true;
            buttonReset.Enabled         = true;
            buttonOptimizator.Enabled   = true;
            buttonOpenF.Enabled         = true;
            toolStripStatusLabel.Text   = "Готово за " + elapsedTime;
            panel.UseWaitCursor         = false;

            //3. Выбираем в фокус кнопку оптимизации
            buttonOptimizator.Select();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //0. Выключаем кнопки reset, оптимизации и оценки
            buttonReset.Enabled = false;
            buttonInitCalc.Enabled = false;
            buttonOptimizator.Enabled = false;

            //1. Разблокируем элементы ввода параметров конструктора и выбор FFD
            domainUpDownTry.Enabled = true;
            domainUpDownSize.Enabled = true;
            comboBoxCapacity.Enabled = true;
            comboBoxMin.Enabled = true;
            comboBoxMax.Enabled = true;
            checkBoxFFD.Enabled = true;

            //2. Восстанавливаем исходные label
            labelGenerator.Text = "Сгенерируйте массив";
            labelInitCalc.Text = "Оцените начальную последовательность";
            labelOptimizator.Text = "Оптимизируйте!";

            //3. Выбираем в фокус кнопку генерации
            buttonGenerator.Select();

            //4. Очищаем график
            this.chart.Series["SeriesInit"].Points.Clear();
            this.chart.Series["SeriesCurrent"].Points.Clear();
        }

        private void showError()
        {
            formError error = new formError();
            error.ShowDialog();
        }
        
        private async void buttonOpenF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Select a Text File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
                sr.Close();

                buttonGenerator.Enabled     = false;
                buttonOptimizator.Enabled   = false;
                buttonInitCalc.Enabled      = false;
                domainUpDownTry.Enabled     = false;
                domainUpDownSize.Enabled    = false;
                comboBoxCapacity.Enabled    = false;
                comboBoxMin.Enabled         = false;
                comboBoxMax.Enabled         = false;
                labelInitCalc.Text          = "Оцените начальную последовательность";
                labelOptimizator.Text       = "Оптимизируйте!";
                labelGenerator.Text         = "Массив открыт!";

                this.chart.Series["SeriesInit"].Points.Clear();
                this.chart.Series["SeriesCurrent"].Points.Clear();
                
                
                int trying                  = Convert.ToInt32(domainUpDownTry.Text);
                int capacity                = Convert.ToInt32(comboBoxCapacity.Text);

                objKL                       = new KernLin(lines,trying,capacity);
                
                buttonInitCalc.Enabled      = true;
                buttonReset.Enabled         = true;
                checkBoxFFD.Enabled         = true;
                
                buttonInitCalc.Select();
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
