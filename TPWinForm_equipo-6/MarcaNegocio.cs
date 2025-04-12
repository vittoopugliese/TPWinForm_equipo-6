using System;
using System.Collections.Generic;

namespace TPWinForm_equipo_6
{
    internal class MarcaNegocio
    {
        private BaseDeDatos bd;

        public MarcaNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                bd.setearConsulta("SELECT * FROM MARCAS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = Convert.ToInt32(bd.Lector["Id"]);
                    marca.Descripcion = bd.Lector["Descripcion"].ToString();
                    listaMarcas.Add(marca);
                }

                return listaMarcas;
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