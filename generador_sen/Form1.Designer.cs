namespace generador_sen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trBA = new System.Windows.Forms.TrackBar();
            this.Amplitud = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.trBT = new System.Windows.Forms.TrackBar();
            this.trBW = new System.Windows.Forms.TrackBar();
            this.Fase = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBW)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB1);
            this.groupBox1.Location = new System.Drawing.Point(34, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generador de Funciones";
            // 
            // cB1
            // 
            this.cB1.BackColor = System.Drawing.Color.Beige;
            this.cB1.FormattingEnabled = true;
            this.cB1.Items.AddRange(new object[] {
            "Cos",
            "Sen"});
            this.cB1.Location = new System.Drawing.Point(36, 19);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(121, 21);
            this.cB1.TabIndex = 0;
            this.cB1.Text = "Señales";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LimeGreen;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(300, 49);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(438, 331);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trBA
            // 
            this.trBA.Location = new System.Drawing.Point(131, 49);
            this.trBA.Name = "trBA";
            this.trBA.Size = new System.Drawing.Size(104, 45);
            this.trBA.TabIndex = 3;
            // 
            // Amplitud
            // 
            this.Amplitud.AutoSize = true;
            this.Amplitud.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amplitud.Location = new System.Drawing.Point(30, 49);
            this.Amplitud.Name = "Amplitud";
            this.Amplitud.Size = new System.Drawing.Size(74, 19);
            this.Amplitud.TabIndex = 6;
            this.Amplitud.Text = "Amplitud";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(40, 160);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(64, 19);
            this.tiempo.TabIndex = 8;
            this.tiempo.Text = "Tiempo";
            // 
            // trBT
            // 
            this.trBT.Location = new System.Drawing.Point(131, 160);
            this.trBT.Name = "trBT";
            this.trBT.Size = new System.Drawing.Size(104, 45);
            this.trBT.TabIndex = 9;
            // 
            // trBW
            // 
            this.trBW.Location = new System.Drawing.Point(131, 109);
            this.trBW.Name = "trBW";
            this.trBW.Size = new System.Drawing.Size(104, 45);
            this.trBW.TabIndex = 5;
            // 
            // Fase
            // 
            this.Fase.AutoSize = true;
            this.Fase.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fase.Location = new System.Drawing.Point(40, 109);
            this.Fase.Name = "Fase";
            this.Fase.Size = new System.Drawing.Size(38, 19);
            this.Fase.TabIndex = 7;
            this.Fase.Text = "Fase";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 431);
            this.Controls.Add(this.trBT);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.Fase);
            this.Controls.Add(this.Amplitud);
            this.Controls.Add(this.trBW);
            this.Controls.Add(this.trBA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBW)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trBA;
        private System.Windows.Forms.Label Amplitud;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.TrackBar trBT;
        private System.Windows.Forms.TrackBar trBW;
        private System.Windows.Forms.Label Fase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

