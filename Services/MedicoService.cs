using SistemaMedico.Models; // Certifique-se de que isso esteja incluído
using System.Collections.Generic;

namespace SistemaMedico.Services
{
    public class MedicoService : IMedicoService
    {
        private List<Medico> medicos = new List<Medico>();

        public List<Medico> ObterMedico()
        {
            return medicos;
        }

        public void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }
    }
}
