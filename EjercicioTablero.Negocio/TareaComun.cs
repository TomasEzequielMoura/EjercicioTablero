using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio
{
    public sealed class TareaComun : Tarea
    {
        public TareaComun(int codigo, string descripcion, string estado, int orden, DateTime fechaAlta, DateTime fechaRealizacion, int impacto) : base (codigo, descripcion, estado, orden, fechaAlta, fechaRealizacion)
        {
            _impacto = impacto;
        }

        private int _impacto;

        public int Impacto { get => _impacto; set => _impacto = value; }
    }
}
