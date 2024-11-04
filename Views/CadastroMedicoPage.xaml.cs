using SistemaMedico.Models;
using SistemaMedico.Services;
using System;

namespace SistemaMedico.Views
{
    public partial class CadastroMedicoPage : ContentPage
    {
        private readonly IMedicoService _medicoService;

        public CadastroMedicoPage(IMedicoService pacienteService)
        {
            InitializeComponent();
            _medicoService = medicoService ?? throw new ArgumentNullException(nameof(medicoService));
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var nome = NomeEntry.Text;
            var cmr = int.TryParse(CMREntry.Text, out int parsedCRM) ? parsedCRM : (int?)null;
            var especialidade = EspecialidadeEntry.Text;
             var contato = int.TryParse(ContatoEntry.Text, out int parsedcontato) ? parsedcontato : (int?)null;

            if (string.IsNullOrWhiteSpace(nome) || !cmr.HasValue || string.IsNullOrWhiteSpace(especialidade))
            {
                await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
                return;
            }

            var novoPaciente = new Paciente
            {
                Id = _medicoService.ObterMedico().Count + 1,
                Nome = nome,
                CMR = cmr.Value,
                Especialidade = especialidade,
                Contato = contato.Value
            };

            _medicoService.AdicionarMedico(novoMedico);
            await Navigation.PopAsync();
        }
    }
}
