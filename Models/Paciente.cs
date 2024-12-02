using System;
using System.Collections.Generic;
using ClinicManager.Models.Records;

namespace ClinicManager.Models.Patients
{    public class Paciente
    {
        public int Id { get; set; } // Identificador único do paciente.
        public string Nome { get; set; } // Nome completo do paciente.
        public string CPF { get; set; } // CPF do paciente.
        public DateTime DataNascimento { get; set; } // Data de nascimento do paciente.
        public string Telefone { get; set; } // Telefone de contato do paciente.
        public string Endereco { get; set; } // Endereço do paciente.
        public ICollection<Prontuario> Prontuarios { get; set; } // Lista de prontuários médicos do paciente.
    }
}