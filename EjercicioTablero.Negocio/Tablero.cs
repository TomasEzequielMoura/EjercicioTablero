using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio
{
    public class Tablero
    {
        public Tablero(string titulo, string descripcion, List<Tarea> tareas, DateTime fechaInicioProyecto)
        {
            _titulo = titulo;
            _descripcion = descripcion;
            _tareas = tareas;
            _fechaInicioProyecto = fechaInicioProyecto;
        }

        private string _titulo;
        private string _descripcion;
        private List<Tarea> _tareas;
        private DateTime _fechaInicioProyecto;

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public List<Tarea> Tareas { get => _tareas; set => _tareas = value; }
        public DateTime FechaInicioProyecto { get => _fechaInicioProyecto; set => _fechaInicioProyecto = value; }

        public void AgregarTarea(Tarea tarea)
        {

        }
        public void CambiarEstado(int codigo, string estado)
        {

        }
        public List<Tarea> TraerTareas(string estado) {
            List<Tarea> listTarea = new List<Tarea>();
            return listTarea;
        }
        public Tarea TraerTareaMasAntigua()
        {

            TareaComun tareaMasAntiguaComun = new TareaComun(1, "tarea asd", "En Proceso", 25, new DateTime(2012, 12, 31, 16, 45, 0), new DateTime(2012, 12, 31, 16, 45, 0), 20);
            TareaEspecial tareaMasAntiguaEspecial = new TareaEspecial(1, "tarea asd", "En Proceso", 25, new DateTime(2012, 12, 31, 16, 45, 0), new DateTime(2012, 12, 31, 16, 45, 0), "Velez");

            Tarea tareaMasAntigua = tareaMasAntiguaComun;

            return tareaMasAntigua;
        }
    }
}
