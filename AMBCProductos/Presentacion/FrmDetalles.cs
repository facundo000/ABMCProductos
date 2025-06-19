using AMBCProductos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMBCProductos.Presentacion
{
    public enum Modo
    { 
        VER,    //1. Ver detalles
        EDITAR,     //2. Editar
        BORRAR,     //3. Borrar
        NUEVO       //4. Nuevo
    }
    public partial class FrmDetalles : Form
    {
        ProductoServicio oServicio;
        Modo accion;
        Producto oProducto;

        public FrmDetalles(Modo modo, Producto producto)
        {
            InitializeComponent();
            oServicio = new ProductoServicio();
            accion = modo;
            oProducto = producto;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            if (accion == Modo.NUEVO)
            {
                //TENGO QUE BUSCAR OTRA FORMA
                CargarCombo(cboTipoProducto);
                CargarCombo(cboMarca);
                //CargarCombo(cboCategoria);
                oProducto = new Producto();
            }
            else
            {
                MessageBox.Show($"id_producto = {oProducto.IdProducto}");
                CargarCampos(oProducto);
            }
        }

        private void CargarCampos(Producto oProducto)
        {
            TxtCodigo.Text = oProducto.IdProducto.ToString();
            TxtNombre.Text = oProducto.Nombre.ToString();
            //txtDescripcion.Text = oProducto.Descripcion.ToString();
            //cboTipoProducto.SelectedValue = oProducto.TipoProductoId;
            cboMarca.SelectedValue = oProducto.Marca.IdMarca;
            //cboCategoria.SelectedValue = oProducto.CategoriaId;
            nudPeso.Value = oProducto.PesoKg;
            nudLimite.Value = oProducto.LimiteStock;
        }

        private void CargarCombo(ComboBox combo)
        {            
            var lista = oServicio.TraerMarcas();

            combo.DataSource = lista;
            combo.ValueMember = nameof(Marca.IdMarca);
            combo.DisplayMember = nameof(Marca.Nombre);

            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            combo.SelectedIndex = -1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //ValidarDatos

            //Cargar el objeto
            //oLibro.Titulo = TxtTitulo.Text;
            //oLibro.Autor = (Autor)CboAutor.SelectedItem;
            //if (RbtImpreso.Checked)
            //    oLibro.Formato = 1;
            //else
            //    oLibro.Formato = 2;
            //oLibro.Fecha = DtpFecha.Value;
            //oLibro.Precio = double.Parse(TxtPrecio.Text);

            //if (accion == Modo.NUEVO)
            //{
            //    //llamar al servicio nuevo
            //    if (oServicio.CrearLibro(oLibro) > 0)
            //        MessageBox.Show("Se creo nuevo libro!!!");
            //    else
            //        MessageBox.Show("Intente más tarde!");
            //}
            //if (accion == Modo.EDITAR)
            //{
            //    //update
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
