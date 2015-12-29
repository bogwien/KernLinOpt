namespace KernLinOpt
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOptimizator = new System.Windows.Forms.Button();
            this.labelGenerator = new System.Windows.Forms.Label();
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.labelOptimizator = new System.Windows.Forms.Label();
            this.buttonInitCalc = new System.Windows.Forms.Button();
            this.labelInitCalc = new System.Windows.Forms.Label();
            this.domainUpDownSize = new System.Windows.Forms.DomainUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDownTry = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOptimizator
            // 
            this.buttonOptimizator.Enabled = false;
            this.buttonOptimizator.Location = new System.Drawing.Point(216, 114);
            this.buttonOptimizator.Name = "buttonOptimizator";
            this.buttonOptimizator.Size = new System.Drawing.Size(107, 23);
            this.buttonOptimizator.TabIndex = 0;
            this.buttonOptimizator.Text = "Оптимизировать";
            this.buttonOptimizator.UseVisualStyleBackColor = true;
            this.buttonOptimizator.Click += new System.EventHandler(this.buttonOptimizator_Click);
            // 
            // labelGenerator
            // 
            this.labelGenerator.AutoSize = true;
            this.labelGenerator.Location = new System.Drawing.Point(329, 61);
            this.labelGenerator.Name = "labelGenerator";
            this.labelGenerator.Size = new System.Drawing.Size(118, 13);
            this.labelGenerator.TabIndex = 1;
            this.labelGenerator.Text = "Сгенерируйте массив";
            this.labelGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.Location = new System.Drawing.Point(216, 56);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(107, 23);
            this.buttonGenerator.TabIndex = 3;
            this.buttonGenerator.Text = "Сгенерировать";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // labelOptimizator
            // 
            this.labelOptimizator.AutoSize = true;
            this.labelOptimizator.Location = new System.Drawing.Point(329, 119);
            this.labelOptimizator.Name = "labelOptimizator";
            this.labelOptimizator.Size = new System.Drawing.Size(89, 13);
            this.labelOptimizator.TabIndex = 4;
            this.labelOptimizator.Text = "Оптимизируйте!";
            // 
            // buttonInitCalc
            // 
            this.buttonInitCalc.Enabled = false;
            this.buttonInitCalc.Location = new System.Drawing.Point(216, 85);
            this.buttonInitCalc.Name = "buttonInitCalc";
            this.buttonInitCalc.Size = new System.Drawing.Size(107, 23);
            this.buttonInitCalc.TabIndex = 5;
            this.buttonInitCalc.Text = "Оценить";
            this.buttonInitCalc.UseVisualStyleBackColor = true;
            this.buttonInitCalc.Click += new System.EventHandler(this.buttonInitCalc_Click);
            // 
            // labelInitCalc
            // 
            this.labelInitCalc.AutoSize = true;
            this.labelInitCalc.Location = new System.Drawing.Point(329, 90);
            this.labelInitCalc.Name = "labelInitCalc";
            this.labelInitCalc.Size = new System.Drawing.Size(216, 13);
            this.labelInitCalc.TabIndex = 6;
            this.labelInitCalc.Text = "Оцените начальную последовательность";
            // 
            // domainUpDownSize
            // 
            this.domainUpDownSize.BackColor = System.Drawing.SystemColors.Info;
            this.domainUpDownSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.domainUpDownSize.Items.Add("10");
            this.domainUpDownSize.Items.Add("50");
            this.domainUpDownSize.Items.Add("100");
            this.domainUpDownSize.Items.Add("150");
            this.domainUpDownSize.Items.Add("200");
            this.domainUpDownSize.Items.Add("250");
            this.domainUpDownSize.Items.Add("300");
            this.domainUpDownSize.Items.Add("350");
            this.domainUpDownSize.Items.Add("400");
            this.domainUpDownSize.Items.Add("450");
            this.domainUpDownSize.Items.Add("500");
            this.domainUpDownSize.Items.Add("600");
            this.domainUpDownSize.Items.Add("700");
            this.domainUpDownSize.Items.Add("800");
            this.domainUpDownSize.Items.Add("900");
            this.domainUpDownSize.Items.Add("1000");
            this.domainUpDownSize.Items.Add("1250");
            this.domainUpDownSize.Items.Add("1500");
            this.domainUpDownSize.Items.Add("1750");
            this.domainUpDownSize.Items.Add("2000");
            this.domainUpDownSize.Items.Add("2500");
            this.domainUpDownSize.Items.Add("3000");
            this.domainUpDownSize.Items.Add("3500");
            this.domainUpDownSize.Items.Add("4000");
            this.domainUpDownSize.Items.Add("4500");
            this.domainUpDownSize.Items.Add("5000");
            this.domainUpDownSize.Items.Add("6000");
            this.domainUpDownSize.Items.Add("7000");
            this.domainUpDownSize.Items.Add("8000");
            this.domainUpDownSize.Items.Add("9000");
            this.domainUpDownSize.Items.Add("10000");
            this.domainUpDownSize.Location = new System.Drawing.Point(16, 70);
            this.domainUpDownSize.Name = "domainUpDownSize";
            this.domainUpDownSize.Size = new System.Drawing.Size(120, 20);
            this.domainUpDownSize.TabIndex = 7;
            this.domainUpDownSize.Text = "50";
            this.domainUpDownSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(26, 54);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(97, 13);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Число элементов";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Допустимых попыток";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainUpDownTry
            // 
            this.domainUpDownTry.BackColor = System.Drawing.SystemColors.Info;
            this.domainUpDownTry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.domainUpDownTry.Items.Add("1");
            this.domainUpDownTry.Items.Add("2");
            this.domainUpDownTry.Items.Add("3");
            this.domainUpDownTry.Items.Add("4");
            this.domainUpDownTry.Items.Add("5");
            this.domainUpDownTry.Items.Add("6");
            this.domainUpDownTry.Items.Add("7");
            this.domainUpDownTry.Items.Add("8");
            this.domainUpDownTry.Items.Add("9");
            this.domainUpDownTry.Items.Add("10");
            this.domainUpDownTry.Items.Add("12");
            this.domainUpDownTry.Items.Add("14");
            this.domainUpDownTry.Items.Add("16");
            this.domainUpDownTry.Items.Add("18");
            this.domainUpDownTry.Items.Add("20");
            this.domainUpDownTry.Items.Add("24");
            this.domainUpDownTry.Items.Add("28");
            this.domainUpDownTry.Items.Add("32");
            this.domainUpDownTry.Items.Add("36");
            this.domainUpDownTry.Items.Add("40");
            this.domainUpDownTry.Items.Add("45");
            this.domainUpDownTry.Items.Add("50");
            this.domainUpDownTry.Items.Add("55");
            this.domainUpDownTry.Items.Add("60");
            this.domainUpDownTry.Items.Add("65");
            this.domainUpDownTry.Items.Add("70");
            this.domainUpDownTry.Items.Add("75");
            this.domainUpDownTry.Items.Add("80");
            this.domainUpDownTry.Items.Add("85");
            this.domainUpDownTry.Items.Add("90");
            this.domainUpDownTry.Items.Add("95");
            this.domainUpDownTry.Items.Add("100");
            this.domainUpDownTry.Items.Add("110");
            this.domainUpDownTry.Items.Add("120");
            this.domainUpDownTry.Items.Add("130");
            this.domainUpDownTry.Items.Add("140");
            this.domainUpDownTry.Items.Add("150");
            this.domainUpDownTry.Items.Add("160");
            this.domainUpDownTry.Items.Add("170");
            this.domainUpDownTry.Items.Add("180");
            this.domainUpDownTry.Items.Add("190");
            this.domainUpDownTry.Items.Add("200");
            this.domainUpDownTry.Items.Add("220");
            this.domainUpDownTry.Items.Add("240");
            this.domainUpDownTry.Items.Add("260");
            this.domainUpDownTry.Items.Add("280");
            this.domainUpDownTry.Items.Add("300");
            this.domainUpDownTry.Items.Add("330");
            this.domainUpDownTry.Items.Add("360");
            this.domainUpDownTry.Items.Add("390");
            this.domainUpDownTry.Items.Add("420");
            this.domainUpDownTry.Items.Add("450");
            this.domainUpDownTry.Items.Add("480");
            this.domainUpDownTry.Items.Add("510");
            this.domainUpDownTry.Items.Add("540");
            this.domainUpDownTry.Items.Add("570");
            this.domainUpDownTry.Items.Add("600");
            this.domainUpDownTry.Items.Add("650");
            this.domainUpDownTry.Items.Add("700");
            this.domainUpDownTry.Items.Add("750");
            this.domainUpDownTry.Items.Add("800");
            this.domainUpDownTry.Items.Add("850");
            this.domainUpDownTry.Items.Add("900");
            this.domainUpDownTry.Items.Add("1000");
            this.domainUpDownTry.Items.Add("1100");
            this.domainUpDownTry.Items.Add("1250");
            this.domainUpDownTry.Items.Add("1500");
            this.domainUpDownTry.Items.Add("1750");
            this.domainUpDownTry.Items.Add("2000");
            this.domainUpDownTry.Items.Add("2500");
            this.domainUpDownTry.Items.Add("3000");
            this.domainUpDownTry.Items.Add("3500");
            this.domainUpDownTry.Items.Add("4000");
            this.domainUpDownTry.Items.Add("4500");
            this.domainUpDownTry.Items.Add("5000");
            this.domainUpDownTry.Location = new System.Drawing.Point(16, 111);
            this.domainUpDownTry.Name = "domainUpDownTry";
            this.domainUpDownTry.Size = new System.Drawing.Size(120, 20);
            this.domainUpDownTry.TabIndex = 10;
            this.domainUpDownTry.Text = "100";
            this.domainUpDownTry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "1. Начальные параметры";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "2. Действия с данными";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(142, 79);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(41, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 151);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainUpDownTry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.domainUpDownSize);
            this.Controls.Add(this.labelInitCalc);
            this.Controls.Add(this.buttonInitCalc);
            this.Controls.Add(this.labelOptimizator);
            this.Controls.Add(this.buttonGenerator);
            this.Controls.Add(this.labelGenerator);
            this.Controls.Add(this.buttonOptimizator);
            this.Name = "FormMain";
            this.Text = "Задача bin packing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOptimizator;
        private System.Windows.Forms.Label labelGenerator;
        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.Label labelOptimizator;
        private System.Windows.Forms.Button buttonInitCalc;
        private System.Windows.Forms.Label labelInitCalc;
        private System.Windows.Forms.DomainUpDown domainUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDownTry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
    }
}

