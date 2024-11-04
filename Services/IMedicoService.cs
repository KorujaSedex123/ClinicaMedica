using SistemaMedico.Models; // Certifique-se de que isso esteja incluído

namespace SistemaMedico.Services
{
    public interface IMedicoService
    {
        List<Medico> ObterMedico();
        void AdicionarMedico(Medico medico);
    }
}
