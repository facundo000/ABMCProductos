using AMBCProductos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMBCProductos.Negocio
{
    public class ProductoServicio
    {
        ProductoDao oDao;
        public ProductoServicio()
        {
            oDao = new ProductoDao();
        }

        public List<Producto> TraerProductos(Filtro filtro)
        {
            return oDao.RecuperarProductos(filtro);
        }

        public int ModificarProducto(Producto producto)
        {
            return oDao.ActualizarProducto(producto);
        }

        public List<Marca> TraerMarcas()
        {
            return oDao.RecuperarMarcas();
        }

        public List<TipoProducto> TraerTiposProductos()
        {
            return oDao.RecuperarTiposProductos();
        }
    }
}
