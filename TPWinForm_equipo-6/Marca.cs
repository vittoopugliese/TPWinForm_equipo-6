using System;

namespace TPWinForm_equipo_6
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}