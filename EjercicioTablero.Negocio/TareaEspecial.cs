using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio
{
    public class TareaEspecial : Tarea
    {
        public TareaEspecial(int codigo, string descripcion, string estado, int orden, DateTime fechaAlta, DateTime fechaRealizacion, string descripcionEspecial) : base(codigo, descripcion, estado, orden, fechaAlta, fechaRealizacion)
        {
            _descripcionEspecial = descripcionEspecial;
        }

        private string _descripcionEspecial;

        public string DescripcionEspecial { get => _descripcionEspecial; set => _descripcionEspecial = value; }
    }
}
