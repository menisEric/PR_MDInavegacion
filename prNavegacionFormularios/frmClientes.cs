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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            fmrVentas frm = fmrVentas.getInstancia();
            String par1 = cboClientes.Text;
            frm.setCliente(par1);
            this.Hide();
        }
    }
}
