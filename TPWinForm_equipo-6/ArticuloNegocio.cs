using System;
using System.Collections.Generic;

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

                bd.setearConsulta("SELECT * FROM ARTICULOS");
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

                return listaArticulos;
            } catch (Exception ex) {
                throw ex;
            } finally {
                bd.cerrarConexion();
            }
        }
    }
}