using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPWinForm_equipo_6
{
    internal class ImagenNegocio
    {
        private BaseDeDatos bd;

        public ImagenNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Imagen> ListarPorArticulo(int idArticulo)
        {
            List<Imagen> listaImagenes = new List<Imagen>();

            try
            {
                bd.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                bd.setearParametro("@IdArticulo", idArticulo);
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Id = Convert.ToInt32(bd.Lector["Id"]);
                    imagen.IdArticulo = Convert.ToInt32(bd.Lector["IdArticulo"]);
                    imagen.imagenUrl = bd.Lector["imagenUrl"].ToString();
                    listaImagenes.Add(imagen);
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

            return listaImagenes;
        }
    }
}