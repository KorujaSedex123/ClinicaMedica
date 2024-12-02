using System;
using ClinicManager.Models.Patients;
using ClinicManager.Models.Doctors;

namespace ClinicManager.Models.Consultations
{
    public class Consulta
    {
        public int Id { get; set; } // Identificador único da consulta.
        public Paciente Paciente { get; set; } // Paciente atendido na consulta.
        public Medico Medico { get; set; } // Médico responsável pela consulta.
        public DateTime DataHora { get; set; } // Data e hora da consulta.
        public StatusConsulta Status { get; set; } // Status da consulta.
        public string Observacoes { get; set; } // Observações feitas pelo médico durante a consulta.

        public enum StatusConsulta
        {
            Agendada, // Consulta agendada.
            Realizada, // Consulta realizada.
            Cancelada // Consulta cancelada.
        }
    }
}
