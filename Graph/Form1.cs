using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    public partial class Form1 : Form
    {
        double y1 = 0;
        double x1 = 0;
        double x2 = 0;
        double x3 = 0;
        double x = 0;
        double y = 0;
        double y2 = 0;
        double r1 = 0;
        double r2 = 0;
        double y3 = 0;
        double y4 = 0;
        public Form1()
        {
            InitializeComponent();         
        }

        public void Asignar()
        {
            switch (txtx1.Text)
            {
                case "-":
                    x2 = -1;
                    break;
                case "":
                    x2 = 1;
                    break;
                default:
                    x2 = Convert.ToDouble(txtx1.Text);
                    break;
            }
            switch (txty1.Text)
            {
                case "-":
                    y3 = -1;
                    break;
                case "":
                    y3 = 1;
                    break;
                default:
                    y3 = Convert.ToDouble(txty1.Text);
                    break;
            }
            switch (txtx2.Text)
            {
                case "-":
                    x3 = -1;
                    break;
                case "":
                    x3 = 1;
                    break;
                default:
                    x3 = Convert.ToDouble(txtx2.Text);
                    break;
            }
            switch (txty2.Text)
            {
                case "-":
                    y4 = -1;
                    break;
                case "":
                    y4 = 1;
                    break;
                default:
                    y4 = Convert.ToDouble(txty2.Text);
                    break;
            }
            switch (txtr1.Text)
            {
                case "":
                    r1 = 0;
                    break;
                default:
                    r1 = Convert.ToDouble(txtr1.Text);
                    break;
            }
            switch (txtr2.Text)
            {
                case "":
                    r2 = 0;
                    break;
                default:
                    r2 = Convert.ToDouble(txtr2.Text);
                    break;
            }  
        }
        public void DespejarY1()
        {
           Asignar();
           switch (Convert.ToInt32(y3))
            {
                case 0:
                    x = r1 / x2;
                    y = (r2 - (x3 * x)) / y4;
                    break;
                case 1:
                    y1 = r1 - (x2 * x1);
                    break;
                default:
                    if (y3 < 0 && y3 == -1)
                    {
                        y1 = ((r1 - (x2 * x1)) / y3) * -1;
                        break;
                    }
                    else
                        y1 = (r1 - (x2 * x1)) / y3;
                    break;
            }

        }

        public void DespejarY2()
        {
            Asignar();
            switch (Convert.ToInt32(y4))
            {
                case 0:
                    x = r2 / x3;
                    y = (r1 - (x2 * x)) / y3;
                    break;
                case 1:
                    y2 = r2 - (x3 * x1);
                    break;
                default:
                    if (y4 < 0 && y4 == -1)
                    {
                        y2 = ((r2 - (x3 * x1)) / y4) * -1;
                        break;
                    }
                    else
                        y2 = (r2 - (x3 * x1)) / y4;
                    break;
            }
        }

        public void Graficar()
        {
            for (int i = -5; i <= 5 ; i++)
            {
                x1 = i;
                DespejarY1();
                DespejarY2();

                if (x == 0 && y == 0)
                {
                    if (y1 == y2 && i != -5)
                    {
                        y = y1;
                        x = x1;
                    }
                    else if (y1 == y2 && i == -5)
                    {
                        y = 1;
                        x = 1;
                    }
                }

 

                dgv1.Rows.Add(i, y1, y2);
                ch1.Series["Series1"].Points.AddXY(x1,y1);
                ch1.Series["Series2"].Points.AddXY(x1, y2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
            btnResultado.Hide();
            btnProcedimiento.Hide();
            CrearSeries();
            lblGrafica.Hide();
            txtx1.Enabled = true;
            txty1.Enabled = true;
            txtx2.Enabled = true;
            txty2.Enabled = true;
            txtr1.Enabled = true;
            txtr2.Enabled = true;
        }
        public void Inicio()
        {
            lbl1.Show();
            dgv1.Hide();
            lblx.Hide();
            lbly.Hide();
            lblp1.Hide();
            lblp2.Hide();
            lblPaso1.Hide();
            lblPaso2.Hide();
            lblTabla.Hide();
            lbly1.Hide();
            lbly2.Hide();
            btnLimpiar.Enabled = false;
            ch1.Hide();
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                btnProcedimiento.Show();
                Graficar();
                lblx.Text = "x = " + x;
                lbly.Text = "y = " + y;
                lblx.Show();
                lbly.Show();
                lblGrafica.Show();
                btnLimpiar.Enabled = true;
                ch1.Show();
                btnLimpiar.Enabled = true;
                txtx1.Enabled = false;
                txty1.Enabled = false;
                txtx2.Enabled = false;
                txty2.Enabled = false;
                txtr1.Enabled = false;
                txtr2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("El sistema de ecuaciones no tiene solución");
                Limpiar();
                btnProcedimiento.Hide();
                btnLimpiar.Enabled = false;
            }
        }

        public void CrearSeries()
        {
            ch1.Series.Add("Series1");
            ch1.Series["Series1"].ChartType = SeriesChartType.Line;
            ch1.Series["Series1"].BorderWidth = 5;
            ch1.Series["Series1"].Color = Color.Blue;
            ch1.Series["Series1"].LegendText = "(X,Y1)";

            ch1.Series.Add("Series2");
            ch1.Series["Series2"].ChartType = SeriesChartType.Line;
            ch1.Series["Series2"].BorderWidth = 5;
            ch1.Series["Series2"].Color = Color.Orange;
            ch1.Series["Series2"].LegendText = "(X,Y2)";
        }
        private void txtx1_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = true;
            button1.Enabled = true;
        }

        private void Limpiar()
        {
            txtx1.Text = "";
            txty1.Text = "";
            txtr1.Text = "";
            txtx2.Text = "";
            txty2.Text = "";
            txtr2.Text = "";
            y1 = 0;
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x = 0;
            y = 0;
            y2 = 0;
            r1 = 0;
            r2 = 0;
            y3 = 0;
            y4 = 0;
            dgv1.Rows.Clear();
            ch1.Series.Clear();
            ch1.Hide();
            button1.Enabled = false;
            CrearSeries();
            txtx1.Enabled = true;
            txty1.Enabled = true;
            txtx2.Enabled = true;
            txty2.Enabled = true;
            txtr1.Enabled = true;
            txtr2.Enabled = true;
            lblGrafica.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnLimpiar.Enabled = false;
            lblx.Hide();
            lbly.Hide();
            btnResultado.Hide();
            btnProcedimiento.Hide();
        }

        private void txty1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void txtr1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void txtx2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void txty2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void txtr2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnProcedimiento_Click(object sender, EventArgs e)
        {
            lbl1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Text = "Solución paso a paso";
            lbly.Hide();
            lblx.Hide();
            txtx1.Hide();
            txty1.Hide();
            txtr1.Hide();
            txtx2.Hide();
            txty2.Hide();
            txtr2.Hide();
            button1.Hide();
            btnLimpiar.Hide();
            btnProcedimiento.Hide();
            btnResultado.Show();
            lblp1.Show();
            lblp2.Show();
            lblPaso1.Show();
            lblPaso2.Show();
            lblTabla.Show();
            Despeje();
            dgv1.Show();
            ch1.Hide();
            lblGrafica.Hide();
        }
        public void Despeje()
        {
            Y1();
            Y2();
        }
        public void Y1()
        {
            if (x2 < 0 && y3 == 1)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + r1 + " + " + x2 * -1 + "x";
            }
            if (x2 > 0 && y3 == 1)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + r1 + " - " + x2 + "x";
            }
            if (y3 == -1 && x2 > 0)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + r1 + " - " + x2 + "x";
            }
            if (y3 == -1 && x2 < 0)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + r1 + " + " + x2 * -1 + "x";
            }
            if (y3 > 1 || y3 < 0 && x2 < 0)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + "(" + r1 + " + " + x2 * -1 + "x" + ")" + "/" + y3;
            }
            if (y3 > 1 || y3 < 0 && x2 > 0)
            {
                lbly1.Show();
                lbly1.Text = "Y1 = " + "(" + r1 + " - " + x2 + "x" + ")" + "/" + y3;
            }
            if (y3 == 0)
                lbly1.Hide();
        }
        public void Y2()
        {
            if (x3 < 0 && y4 == 1)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + r2 + " + " + x3 * -1 + "x";
            }
            if (x3 > 0 && y4 == 1)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + r2 + " - " + x3 + "x";
            }
            if (y4 == -1 && x3 > 0)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + r2 + " - " + x3 + "x";
            }
            if (y4 == -1 && x3 < 0)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + r2 + " + " + x3 * -1 + "x";
            }
            if (y4 > 1 || y4 < 0 && x3 < 0)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + "(" + r2 + " + " + x3 * -1 + "x" + ")" + "/" + y4;
            }
            if (y4 > 1 || y4 < 0 && x3 > 0)
            {
                lbly2.Show();
                lbly2.Text = "Y2 = " + "(" + r2 + " - " + x3 + "x" + ")" + "/" + y4;
            }
            if (y4 == 0)
                lbly2.Hide();
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            Inicio();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Text = "Ingrese su sistema de ecuaciones lineales de 2x2";
            lbly.Show();
            lblx.Show();
            txtx1.Show();
            txty1.Show();
            txtr1.Show();
            txtx2.Show();
            txty2.Show();
            txtr2.Show();
            button1.Show();
            btnLimpiar.Show();
            btnLimpiar.Enabled = true;
            btnResultado.Hide();
            btnProcedimiento.Show();
            ch1.Show();
            lblGrafica.Show();
        }

        private void txtx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (seleccion != DialogResult.Yes)
            {
                e.Cancel = true;
                Focus();
            }
        }
    }
}
