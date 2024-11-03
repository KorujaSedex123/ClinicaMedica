using SistemaMedico.Models; // Certifique-se de que isso esteja incluído
using System.Collections.Generic;

namespace SistemaMedico.Services
{
    public class PacienteService : IPacienteService
    {
        private List<Paciente> pacientes = new List<Paciente>();

        public List<Paciente> ObterPacientes()
        {
            return pacientes;
        }

        public void AdicionarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
    }
}
