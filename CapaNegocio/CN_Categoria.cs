using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria cdCategoria = new CD_Categoria();

        public void InsertarCategoria(CE_Categoria categoria)
        {
            // Lógica adicional de validación si es necesario
            cdCategoria.InsertarCategoria(categoria.NombreCategoria);
        }

        public void ActualizarCategoria(CE_Categoria categoria)
        {
            // Lógica adicional de validación si es necesario
            cdCategoria.ActualizarCategoria(categoria.IdCategoria , categoria.NombreCategoria);
        }

        public void EliminarCategoria(int idCategoria)
        {
            // Lógica adicional de validación si es necesario
            cdCategoria.EliminarCategoria(idCategoria);
        }
    }
}