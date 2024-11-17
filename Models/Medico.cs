using System.Collections.Generic;

namespace GerenciamentoHospitais.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public string Contato { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
        public ICollection<Internacao> Internacoes { get; set; }
    }
}
