using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_AbnerValeriano
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }
        Pedidos pedidos = new Pedidos();
        PedidosDA pedidosDA = new PedidosDA();
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            pedidos.Identidad = IdentidadMaskedTextBox.Text;
            pedidos.Nombre = NombreTextBox.Text;
            pedidos.Codigo = CodigoProductoTextBox.Text;
            pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.Descripcion = DescripcionProductoTextBox.Text;
            pedidos.Fecha = FechaDateTimePicker.Value;

            int idPedido = 0;

            idPedido = pedidosDA.InsertarPedidos(pedidos);

            ListarPedidos();
            LimpiarControles();


        }
        private void ListarPedidos()
        {
            DetalleDataGridView.DataSource = pedidosDA.ListarPedidos();
        }

        private void LimpiarControles()
        {
            IdentidadMaskedTextBox.Clear();
            NombreTextBox.Clear();
            CodigoProductoTextBox.Clear();
            CantidadTextBox.Clear();
            DescripcionProductoTextBox.Clear();
        }
    }
}
