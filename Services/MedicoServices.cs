using ClinicManager.Models.Doctors;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManager.Services
{
    public class MedicoService
    {
        private readonly List<Medico> _medicos;

        public MedicoService()
        {
            _medicos = new List<Medico>(); // Simula um banco de dados na memória
        }

        public IEnumerable<Medico> ObterTodos()
        {
            return _medicos;
        }

        public Medico ObterPorId(int id)
        {
            return _medicos.FirstOrDefault(m => m.Id == id);
        }

        public void Adicionar(Medico medico)
        {
            medico.Id = _medicos.Count > 0 ? _medicos.Max(m => m.Id) + 1 : 1;
            _medicos.Add(medico);
        }

        public void Atualizar(Medico medico)
        {
            var existente = ObterPorId(medico.Id);
            if (existente != null)
            {
                existente.Nome = medico.Nome;
                existente.CRM = medico.CRM;
                existente.Especialidade = medico.Especialidade;
                existente.ValorConsulta = medico.ValorConsulta;
            }
        }

        public void Remover(int id)
        {
            var medico = ObterPorId(id);
            if (medico != null)
            {
                _medicos.Remove(medico);
            }
        }
    }
}
