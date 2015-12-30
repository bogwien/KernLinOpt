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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.checkBoxFFD = new System.Windows.Forms.CheckBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOptimizator
            // 
            resources.ApplyResources(this.buttonOptimizator, "buttonOptimizator");
            this.buttonOptimizator.Name = "buttonOptimizator";
            this.buttonOptimizator.UseVisualStyleBackColor = true;
            this.buttonOptimizator.Click += new System.EventHandler(this.buttonOptimizator_Click);
            // 
            // labelGenerator
            // 
            resources.ApplyResources(this.labelGenerator, "labelGenerator");
            this.labelGenerator.Name = "labelGenerator";
            // 
            // buttonGenerator
            // 
            resources.ApplyResources(this.buttonGenerator, "buttonGenerator");
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // labelOptimizator
            // 
            resources.ApplyResources(this.labelOptimizator, "labelOptimizator");
            this.labelOptimizator.Name = "labelOptimizator";
            // 
            // buttonInitCalc
            // 
            resources.ApplyResources(this.buttonInitCalc, "buttonInitCalc");
            this.buttonInitCalc.Name = "buttonInitCalc";
            this.buttonInitCalc.UseVisualStyleBackColor = true;
            this.buttonInitCalc.Click += new System.EventHandler(this.buttonInitCalc_Click);
            // 
            // labelInitCalc
            // 
            resources.ApplyResources(this.labelInitCalc, "labelInitCalc");
            this.labelInitCalc.Name = "labelInitCalc";
            // 
            // domainUpDownSize
            // 
            this.domainUpDownSize.BackColor = System.Drawing.SystemColors.Info;
            this.domainUpDownSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items1"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items2"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items3"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items4"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items5"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items6"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items7"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items8"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items9"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items10"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items11"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items12"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items13"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items14"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items15"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items16"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items17"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items18"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items19"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items20"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items21"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items22"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items23"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items24"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items25"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items26"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items27"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items28"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items29"));
            this.domainUpDownSize.Items.Add(resources.GetString("domainUpDownSize.Items30"));
            resources.ApplyResources(this.domainUpDownSize, "domainUpDownSize");
            this.domainUpDownSize.Name = "domainUpDownSize";
            // 
            // labelSize
            // 
            resources.ApplyResources(this.labelSize, "labelSize");
            this.labelSize.Name = "labelSize";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // domainUpDownTry
            // 
            this.domainUpDownTry.BackColor = System.Drawing.SystemColors.Info;
            this.domainUpDownTry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items1"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items2"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items3"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items4"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items5"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items6"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items7"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items8"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items9"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items10"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items11"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items12"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items13"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items14"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items15"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items16"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items17"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items18"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items19"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items20"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items21"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items22"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items23"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items24"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items25"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items26"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items27"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items28"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items29"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items30"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items31"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items32"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items33"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items34"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items35"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items36"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items37"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items38"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items39"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items40"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items41"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items42"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items43"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items44"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items45"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items46"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items47"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items48"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items49"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items50"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items51"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items52"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items53"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items54"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items55"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items56"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items57"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items58"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items59"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items60"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items61"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items62"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items63"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items64"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items65"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items66"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items67"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items68"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items69"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items70"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items71"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items72"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items73"));
            this.domainUpDownTry.Items.Add(resources.GetString("domainUpDownTry.Items74"));
            resources.ApplyResources(this.domainUpDownTry, "domainUpDownTry");
            this.domainUpDownTry.Name = "domainUpDownTry";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkBoxFFD);
            this.panel.Controls.Add(this.chart);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // checkBoxFFD
            // 
            resources.ApplyResources(this.checkBoxFFD, "checkBoxFFD");
            this.checkBoxFFD.Checked = true;
            this.checkBoxFFD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFFD.Name = "checkBoxFFD";
            this.checkBoxFFD.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 5;
            chartArea1.Area3DStyle.PointDepth = 50;
            chartArea1.Area3DStyle.PointGapDepth = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY.MaximumAutoSize = 80F;
            chartArea1.AxisY2.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY2.MaximumAutoSize = 80F;
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.chart, "chart");
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Name = "SeriesInit";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "SeriesCurrent";
            series2.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
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
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.CheckBox checkBoxFFD;
    }
}

