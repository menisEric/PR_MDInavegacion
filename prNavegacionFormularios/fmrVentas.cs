using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prNavegacionFormularios
{
    public partial class fmrVentas : Form
    {
        public fmrVentas()
        {
            InitializeComponent();
        }

        private static fmrVentas _instancia;

        public static fmrVentas getInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new fmrVentas();
            }
            return _instancia;
        }
        public void setCliente(String cliente)
        {
            txtCliente.Text = cliente;
        }

        private void fmrVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmClientes frmVista = new frmClientes();
            frmVista.ShowDialog();
        }

        private void fmrVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
