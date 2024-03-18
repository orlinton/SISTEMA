using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto cdProducto = new CD_Producto(); // Instancia de la capa de datos para productos

        public void InsertarProducto(CE_Producto producto)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de insertar el producto en la base de datos
            cdProducto.InsertarProductos(producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad, producto.Proveedor, producto.Categoria, producto.FechaIngreso, producto.FechaCaducidad, producto.UnidadMedida, producto.Nota, producto.Codigo , producto.Ubicacion);
        }

        public void EliminarProducto(int IdProducto)
        {
            // Llamada al método de la capa de datos para eliminar el producto
            cdProducto.EliminarProducto(IdProducto);
        }

        public void Actualizar_Producto(CE_Producto producto)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de actualizar el producto en la base de datos
            cdProducto.Actualizar_Producto(
                producto.IdProducto,
                producto.Nombre,
                producto.Descripcion,
                producto.Precio,
                producto.Cantidad,
                producto.Proveedor,
                producto.Categoria,
                producto.FechaIngreso,
                producto.FechaCaducidad,
                producto.UnidadMedida,
                producto.Nota,
                producto.Codigo,
                producto.Ubicacion 
            );
        }

    }
}

