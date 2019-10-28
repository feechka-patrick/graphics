namespace graphics
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cosx = new System.Windows.Forms.CheckBox();
            this.sinx = new System.Windows.Forms.CheckBox();
            this.textMax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.repeat = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(24, 176);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart.Size = new System.Drawing.Size(790, 448);
            this.chart.TabIndex = 2;
            this.chart.Tag = "chart";
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // cosx
            // 
            this.cosx.Appearance = System.Windows.Forms.Appearance.Button;
            this.cosx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosx.Location = new System.Drawing.Point(24, 28);
            this.cosx.Margin = new System.Windows.Forms.Padding(4);
            this.cosx.Name = "cosx";
            this.cosx.Size = new System.Drawing.Size(117, 57);
            this.cosx.TabIndex = 3;
            this.cosx.Text = "cos x";
            this.cosx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cosx.UseVisualStyleBackColor = true;
            this.cosx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sinx
            // 
            this.sinx.Appearance = System.Windows.Forms.Appearance.Button;
            this.sinx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinx.Location = new System.Drawing.Point(24, 105);
            this.sinx.Margin = new System.Windows.Forms.Padding(4);
            this.sinx.Name = "sinx";
            this.sinx.Size = new System.Drawing.Size(117, 52);
            this.sinx.TabIndex = 4;
            this.sinx.Text = "sin x";
            this.sinx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sinx.UseVisualStyleBackColor = true;
            this.sinx.CheckedChanged += new System.EventHandler(this.sinx_CheckedChanged);
            // 
            // textMax
            // 
            this.textMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textMax.AutoSize = true;
            this.textMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMax.Location = new System.Drawing.Point(8, 77);
            this.textMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(306, 29);
            this.textMax.TabIndex = 5;
            this.textMax.Text = "Максимальное значение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minBox);
            this.groupBox1.Controls.Add(this.textMin);
            this.groupBox1.Controls.Add(this.maxBox);
            this.groupBox1.Controls.Add(this.textMax);
            this.groupBox1.Location = new System.Drawing.Point(177, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(482, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minBox
            // 
            this.minBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minBox.Location = new System.Drawing.Point(322, 28);
            this.minBox.Margin = new System.Windows.Forms.Padding(4);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(136, 34);
            this.minBox.TabIndex = 10;
            // 
            // textMin
            // 
            this.textMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textMin.AutoSize = true;
            this.textMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMin.Location = new System.Drawing.Point(8, 28);
            this.textMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(299, 29);
            this.textMin.TabIndex = 9;
            this.textMin.Text = "Минимальное значение";
            // 
            // maxBox
            // 
            this.maxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxBox.Location = new System.Drawing.Point(322, 77);
            this.maxBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(136, 34);
            this.maxBox.TabIndex = 7;
            this.maxBox.TextChanged += new System.EventHandler(this.max_TextChanged);
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go.Location = new System.Drawing.Point(667, 32);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(147, 53);
            this.go.TabIndex = 8;
            this.go.Tag = "go";
            this.go.Text = "ПОСТРОИТЬ";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // repeat
            // 
            this.repeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeat.Location = new System.Drawing.Point(667, 100);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(147, 53);
            this.repeat.TabIndex = 9;
            this.repeat.Text = "ОЧИСТИТЬ";
            this.repeat.UseVisualStyleBackColor = true;
            this.repeat.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorP
            // 
            this.errorP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP.ContainerControl = this;
            this.errorP.RightToLeft = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 637);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.go);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sinx);
            this.Controls.Add(this.cosx);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 859);
            this.MinimumSize = new System.Drawing.Size(861, 659);
            this.Name = "MainForm";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.CheckBox cosx;
        private System.Windows.Forms.CheckBox sinx;
        private System.Windows.Forms.Label textMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button repeat;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label textMin;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}

