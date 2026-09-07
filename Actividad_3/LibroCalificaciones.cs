using System;

namespace LibroCalificacionesModificadores
{
    public class LibroCalificaciones
    {
        private string nombreCurso; // Variable de instancia (campo privado)

        // Constructor: inicializa la variable de instancia
        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre;
        }

        // Propiedad NombreCurso con descriptores get y set
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }

        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al libro de calificaciones para: \n{0}!", NombreCurso);
        }
    }
}
