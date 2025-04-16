using System;

namespace TPWinForm_equipo_6
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Marca() { }

        public Marca(int idMarca, string desc) {
            Id = idMarca;
            Descripcion = desc;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}