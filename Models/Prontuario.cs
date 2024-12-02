using System;
using ClinicManager.Models.Patients;

namespace ClinicManager.Models.Records
{
    public class Prontuario
    {
        public int Id { get; set; } // Identificador único do prontuário.
        public Paciente Paciente { get; set; } // Paciente ao qual o prontuário pertence.
        public DateTime Data { get; set; } // Data de registro do prontuário.
        public string Diagnostico { get; set; } // Diagnóstico médico do paciente.
        public string Prescricoes { get; set; } // Prescrições ou medicamentos recomendados.
    }
}
