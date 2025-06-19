using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMBCProductos.Negocio
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private string descripcion;
        private int tipoProductoId; // cambiar esto a TipoProducto
        private Marca marca;
        private int categoriaId; //cambiar esto a Categoria
        private decimal pesoKg;
        private int limiteStock;
        private string rutaImg;



        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int TipoProductoId
        {
            get { return tipoProductoId; }
            set { tipoProductoId = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int CategoriaId
        {
            get { return categoriaId; }
            set { categoriaId = value; }
        }

        public decimal PesoKg
        {
            get { return pesoKg; }
            set { pesoKg = value; }
        }

        public int LimiteStock
        {
            get { return limiteStock; }
            set { limiteStock = value; }
        }

        public string RutaImg
        {
            get { return rutaImg; }
            set { rutaImg = value; }
        }
    }
}
