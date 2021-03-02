namespace Cur
{
    partial class MemeStock
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSell100 = new System.Windows.Forms.Button();
            this.btSell10 = new System.Windows.Forms.Button();
            this.btSell1 = new System.Windows.Forms.Button();
            this.btBuy100 = new System.Windows.Forms.Button();
            this.btBuy10 = new System.Windows.Forms.Button();
            this.btBuy1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUSD = new System.Windows.Forms.Label();
            this.lbRUB = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btSell100);
            this.panel1.Controls.Add(this.btSell10);
            this.panel1.Controls.Add(this.btSell1);
            this.panel1.Controls.Add(this.btBuy100);
            this.panel1.Controls.Add(this.btBuy10);
            this.panel1.Controls.Add(this.btBuy1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbUSD);
            this.panel1.Controls.Add(this.lbRUB);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 82);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buy/Sell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Profit:";
            // 
            // btSell100
            // 
            this.btSell100.Location = new System.Drawing.Point(445, 56);
            this.btSell100.Name = "btSell100";
            this.btSell100.Size = new System.Drawing.Size(39, 23);
            this.btSell100.TabIndex = 14;
            this.btSell100.Text = "-100";
            this.btSell100.UseVisualStyleBackColor = true;
            this.btSell100.Visible = false;
            this.btSell100.Click += new System.EventHandler(this.btSell100_Click);
            // 
            // btSell10
            // 
            this.btSell10.Location = new System.Drawing.Point(406, 56);
            this.btSell10.Name = "btSell10";
            this.btSell10.Size = new System.Drawing.Size(33, 23);
            this.btSell10.TabIndex = 13;
            this.btSell10.Text = "-10";
            this.btSell10.UseVisualStyleBackColor = true;
            this.btSell10.Visible = false;
            this.btSell10.Click += new System.EventHandler(this.btSell10_Click);
            // 
            // btSell1
            // 
            this.btSell1.Location = new System.Drawing.Point(373, 56);
            this.btSell1.Name = "btSell1";
            this.btSell1.Size = new System.Drawing.Size(27, 23);
            this.btSell1.TabIndex = 12;
            this.btSell1.Text = "-1";
            this.btSell1.UseVisualStyleBackColor = true;
            this.btSell1.Visible = false;
            this.btSell1.Click += new System.EventHandler(this.btSell1_Click);
            // 
            // btBuy100
            // 
            this.btBuy100.Location = new System.Drawing.Point(201, 56);
            this.btBuy100.Name = "btBuy100";
            this.btBuy100.Size = new System.Drawing.Size(39, 23);
            this.btBuy100.TabIndex = 11;
            this.btBuy100.Text = "+100";
            this.btBuy100.UseVisualStyleBackColor = true;
            this.btBuy100.Visible = false;
            this.btBuy100.Click += new System.EventHandler(this.btBuy100_Click);
            // 
            // btBuy10
            // 
            this.btBuy10.Location = new System.Drawing.Point(246, 56);
            this.btBuy10.Name = "btBuy10";
            this.btBuy10.Size = new System.Drawing.Size(33, 23);
            this.btBuy10.TabIndex = 10;
            this.btBuy10.Text = "+10";
            this.btBuy10.UseVisualStyleBackColor = true;
            this.btBuy10.Visible = false;
            this.btBuy10.Click += new System.EventHandler(this.btBuy10_Click);
            // 
            // btBuy1
            // 
            this.btBuy1.Location = new System.Drawing.Point(285, 56);
            this.btBuy1.Name = "btBuy1";
            this.btBuy1.Size = new System.Drawing.Size(27, 23);
            this.btBuy1.TabIndex = 9;
            this.btBuy1.Text = "+1";
            this.btBuy1.UseVisualStyleBackColor = true;
            this.btBuy1.Visible = false;
            this.btBuy1.Click += new System.EventHandler(this.btBuy1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "1000";
            // 
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUSD.Location = new System.Drawing.Point(559, 36);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(37, 14);
            this.lbUSD.TabIndex = 6;
            this.lbUSD.Text = "USD:";
            // 
            // lbRUB
            // 
            this.lbRUB.AutoSize = true;
            this.lbRUB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRUB.Location = new System.Drawing.Point(558, 16);
            this.lbRUB.Name = "lbRUB";
            this.lbRUB.Size = new System.Drawing.Size(38, 14);
            this.lbRUB.TabIndex = 5;
            this.lbRUB.Text = "RUB:";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(294, 7);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 43);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Do it!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edRate.Location = new System.Drawing.Point(93, 29);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(55, 21);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting rate:";
            // 
            // chart1
            // 
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 82);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Crimson;
            series5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "F2";
            series5.Name = "USD";
            series5.YValuesPerPoint = 4;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(717, 368);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // MemeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "MemeStock";
            this.Text = "MemeStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbUSD;
        private System.Windows.Forms.Label lbRUB;
        private System.Windows.Forms.Button btSell100;
        private System.Windows.Forms.Button btSell10;
        private System.Windows.Forms.Button btSell1;
        private System.Windows.Forms.Button btBuy100;
        private System.Windows.Forms.Button btBuy10;
        private System.Windows.Forms.Button btBuy1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

