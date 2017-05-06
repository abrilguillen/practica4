using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Formulario
{
    public partial class frmInventario : Form
    {
        Inventario inventario = new Inventario();

        public frmInventario()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);

            inventario.agregarProducto(new Producto(codigo, nombre, cantidad, precio));

            txtCodigo.Clear();
            txtCantidad.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtBuscarXNombre.Text);
            inventario.eliminar(codigo);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            int posicion = int.Parse(txtPosicion.Text);

            inventario.insertar(new Producto(codigo, nombre, cantidad, precio), posicion);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            
            Producto producto = inventario.buscar(int.Parse(txtBuscarXNombre.Text));

            if (producto != null)
            {
                txtReporte.Text = producto.ToString();
            }
            else
            {
                MessageBox.Show("El producto quee indica no se encontro");
            }
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.reporte();
        }

        private void cmdAgregarInicio_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            //se pasan los parametros
            inventario.agregarProductoInicio(new Producto(codigo, nombre, cantidad, precio));

            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void cmdEliminarInicio_Click(object sender, EventArgs e)
        {
            //int codigo = int.Parse(txtBuscarXNombre.Text);
            inventario.eliminarInicio();
        }

        private void cmdEliminarUltimo_Click(object sender, EventArgs e)
        {
            inventario.eliminarUltimo();
        }

        private void cmdReporteInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.reporteInverso();
        }
    }
}
