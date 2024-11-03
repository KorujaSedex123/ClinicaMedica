using SistemaMedico.Models;
using SistemaMedico.Services;
using System;

namespace SistemaMedico.Views
{
    public partial class CadastroPacientePage : ContentPage
    {
        private readonly IPacienteService _pacienteService;

        public CadastroPacientePage(IPacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService ?? throw new ArgumentNullException(nameof(pacienteService));
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var nome = NomeEntry.Text;
            var idade = int.TryParse(IdadeEntry.Text, out int parsedIdade) ? parsedIdade : (int?)null;
            var diagnostico = DiagnosticoEntry.Text;

            if (string.IsNullOrWhiteSpace(nome) || !idade.HasValue || string.IsNullOrWhiteSpace(diagnostico))
            {
                await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
                return;
            }

            var novoPaciente = new Paciente
            {
                Id = _pacienteService.ObterPacientes().Count + 1,
                Nome = nome,
                Idade = idade.Value,
                Diagnostico = diagnostico
            };

            _pacienteService.AdicionarPaciente(novoPaciente);
            await Navigation.PopAsync();
        }
    }
}
