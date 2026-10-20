namespace SchoolApp.DAL.Models.dbo
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        public string Correo { get; set; }
    }
}