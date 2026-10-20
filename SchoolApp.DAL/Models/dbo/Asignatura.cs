namespace SchoolApp.DAL.Models.dbo
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int ProfesorId { get; set; }
    }
}