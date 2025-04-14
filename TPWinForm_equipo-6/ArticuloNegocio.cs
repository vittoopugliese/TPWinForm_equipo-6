using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPWinForm_equipo_6
{
    internal class ArticuloNegocio
    {
        private BaseDeDatos bd;

        public ArticuloNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                List<Marca> listaMarcas = marcaNegocio.Listar();
                List<Categoria> listaCategorias = categoriaNegocio.Listar();

                // diccionarios para acceder rapidamente a su descripcion mediante id
                Dictionary<int, Marca> diccionarioMarcas = new Dictionary<int, Marca>();
                Dictionary<int, Categoria> diccionarioCategorias = new Dictionary<int, Categoria>();

                foreach (Marca marca in listaMarcas) diccionarioMarcas.Add(marca.Id, marca);
                foreach (Categoria categoria in listaCategorias) diccionarioCategorias.Add(categoria.Id, categoria);

                bd.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria FROM ARTICULOS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = Convert.ToInt32(bd.Lector["Id"]);
                    articulo.Codigo = bd.Lector["Codigo"].ToString();
                    articulo.Nombre = bd.Lector["Nombre"].ToString();
                    articulo.Descripcion = bd.Lector["Descripcion"].ToString();
                    articulo.IdMarca = Convert.ToInt32(bd.Lector["IdMarca"]);
                    articulo.IdCategoria = Convert.ToInt32(bd.Lector["IdCategoria"]);
                    articulo.Precio = Convert.ToDecimal(bd.Lector["Precio"]);

                    if (diccionarioMarcas.ContainsKey(articulo.IdMarca)) {
                        articulo.Marca = diccionarioMarcas[articulo.IdMarca];
                    } else {
                        articulo.Marca = new Marca { Id = 0, Descripcion = "-- Sin Marca --" };
                    }

                    if (diccionarioCategorias.ContainsKey(articulo.IdCategoria)) {
                        articulo.Categoria = diccionarioCategorias[articulo.IdCategoria];
                    } else {
                        articulo.Categoria = new Categoria { Id = 0, Descripcion = "-- Sin Categoría --" };
                    }

                    listaArticulos.Add(articulo);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                bd.cerrarConexion();
            }

            return listaArticulos;
        }

        public void CrearNuevoArticulo(Articulo nuevoArticulo)
            // por el momento hay un error que hace que al crear un nuevo articulo, se cree dos veces
            // luego investigare xq pasa .
        {
            try
            {
                bd.setearConsulta(  "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria); " +
                                    "SELECT SCOPE_IDENTITY();");

                bd.setearParametro("@Codigo", nuevoArticulo.Codigo);
                bd.setearParametro("@Nombre", nuevoArticulo.Nombre);
                bd.setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                bd.setearParametro("@Precio", nuevoArticulo.Precio);
                bd.setearParametro("@IdMarca", nuevoArticulo.IdMarca);
                bd.setearParametro("@IdCategoria", nuevoArticulo.IdCategoria);

                bd.ejecutarLectura();

                if (bd.Lector.Read())
                {
                    nuevoArticulo.Id = Convert.ToInt32(bd.Lector[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void EditarArticuloExistente(Articulo articuloEditado)
        {
            try
            {
                bd.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id");

                bd.setearParametro("@Codigo", articuloEditado.Codigo);
                bd.setearParametro("@Nombre", articuloEditado.Nombre);
                bd.setearParametro("@Descripcion", articuloEditado.Descripcion);
                bd.setearParametro("@Precio", articuloEditado.Precio);
                bd.setearParametro("@IdMarca", articuloEditado.IdMarca);
                bd.setearParametro("@IdCategoria", articuloEditado.IdCategoria);
                bd.setearParametro("@Id", articuloEditado.Id);

                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public bool EliminarArticuloSeleccionado(int idArticulo)
        {
            try
            {
                bd.setearConsulta("SELECT Id FROM ARTICULOS WHERE Id = @Id");
                bd.setearParametro("@Id", idArticulo);
                bd.ejecutarLectura();

                if (!bd.Lector.Read())
                {
                    MessageBox.Show("El articulo a eliminar no existe o ya fue eliminado...");
                    bd.cerrarConexion();
                    return false;
                }

                bd.cerrarConexion();

                bd.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                bd.setearParametro("@Id", idArticulo);
                bd.ejecutarAccion();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

    }
}