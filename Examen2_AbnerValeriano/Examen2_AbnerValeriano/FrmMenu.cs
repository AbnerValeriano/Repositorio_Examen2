using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2_AbnerValeriano
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        FrmProducto frmProducto = null;
        FrmPedidos frmPedidos = null;
        private void ProductostoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
        }

        private void PedidostoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }
    }
}
