using System;
using System.Collections.Generic;

namespace TPWinForm_equipo_6
{
    internal class CategoriaNegocio
    {
        private BaseDeDatos bd;

        public CategoriaNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Categoria> Listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            try
            {
                bd.setearConsulta("SELECT * FROM CATEGORIAS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(bd.Lector["Id"]);
                    categoria.Descripcion = bd.Lector["Descripcion"].ToString();

                    listaCategorias.Add(categoria);
                }

                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
    }
}