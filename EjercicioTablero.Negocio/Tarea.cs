using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio
{
    public abstract class Tarea
    {
        public Tarea(int codigo, string descripcion, string estado, int orden, DateTime fechaAlta, DateTime fechaRealizacion)
        {
            _codigo = codigo;
            _descripcion = descripcion;
            _estado = estado;
            _orden = orden;
            _fechaAlta = fechaAlta;
            _fechaRealizacion = fechaRealizacion;
        }

        private int _codigo;
        private string _descripcion;
        private string _estado;
        private int _orden;
        private DateTime _fechaAlta;
        private DateTime _fechaRealizacion;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Orden { get => _orden; set => _orden = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaRealizacion { get => _fechaRealizacion; set => _fechaRealizacion = value; }

        public bool isFinalizada() {
            return false;
        }
    }
}
