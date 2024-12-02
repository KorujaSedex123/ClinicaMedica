namespace ClinicManager.Models.Doctors
{
    public class Medico
    {
        public int Id { get; set; } // Identificador único do médico.
        public string Nome { get; set; } // Nome completo do médico.
        public string CRM { get; set; } // Número do CRM do médico.
        public string Especialidade { get; set; } // Especialidade médica do profissional.
        public decimal ValorConsulta { get; set; } // Valor da consulta cobrada pelo médico.
    }
}