using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                bd.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(bd.Lector["Id"]);
                    categoria.Descripcion = bd.Lector["Descripcion"].ToString();
                    listaCategorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }

            return listaCategorias;
        }
    }
}