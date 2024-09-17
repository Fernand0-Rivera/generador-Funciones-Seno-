using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generador_sen{
    public partial class Form1 : Form{
        double ti, tf, g, t, T, w, A, Tr;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Firma_2.exe");
        }


        int n;
        private void Form1_Load(object sender, EventArgs e) { 
        }
    
        public Form1(){
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e){
            double h;
            w = trBW.Value + 1.0;
            A = trBA.Value - 0.1;
            ti = 0;
            tf = 10;
            n = chart1.Width;
            Tr = DateTime.Now.Second;
            T = trBT.Value + Tr;
            h = (tf - ti) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++){
                t = ti + k * h;
                g = fu(t);
                chart1.Series["Series1"].Points.AddXY(t, g);
            }
        }
        double fu(double t){
            double r = 0;
            if (cB1.Text == "Cos") {
                r = Math.Cos(t - T);
            }
            if (cB1.Text == "Sen") {
                r = A * Math.Cos(w * t - T);
            }
            return r;
        }
    }
}
