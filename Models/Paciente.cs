namespace SistemaMedico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nome { get; set; } // Tornando anulável
        public int Idade { get; set; }
        public string? Diagnostico { get; set; } // Tornando anulável
    }
}
