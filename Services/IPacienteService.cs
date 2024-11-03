using SistemaMedico.Models; // Certifique-se de que isso esteja incluído

namespace SistemaMedico.Services
{
    public interface IPacienteService
    {
        List<Paciente> ObterPacientes();
        void AdicionarPaciente(Paciente paciente);
    }
}
