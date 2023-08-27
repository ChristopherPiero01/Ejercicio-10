namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(this.txtCon.Text);
            if (monto <= 100)
            {
                double dscto = 0.10 * monto;
                txtDes.Text = dscto.ToString();
                double subtotal = monto - dscto;
                txtSt.Text = subtotal.ToString();
                double imp = 0.18 * subtotal;
                txtImp.Text = imp.ToString();
                double total = subtotal + imp;
                txtTotal.Text = total.ToString();
            }
            else if (monto >= 100)
            {
                double dscto = 0.20 * monto;
                txtDes.Text = dscto.ToString();
                double subtotal = monto - dscto;
                txtSt.Text = subtotal.ToString();
                double imp = 0.18 * subtotal;
                txtImp.Text = imp.ToString();
                double total = subtotal + imp;
                txtTotal.Text = total.ToString();
            }
        }
    }
}