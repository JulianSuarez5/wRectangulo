using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wRectangulo
{
    public partial class Form1 : Form
    {
        public const int ancho = 20;
        public const int largo = 20;
        Graphics grafico;

        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btnDibujar_Click_1(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                clsRectangulo rec = new clsRectangulo(x, y);

                grafico.FillRectangle(Brushes.Black, rec.obtenX(), rec.obtenY(), ancho, largo);
                txtCantidad.Text = Convert.ToString(clsRectangulo.obtenCuenta());
            }
            catch (Exception)
            {

                MessageBox.Show("Digite valores de tipo numerico");
            }
        }
    }
}
