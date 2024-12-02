using ClinicManager.Models.Doctors;
using ClinicManager.Services;
using System;

namespace ClinicManager.Views
{
    public partial class CadastroMedico : ContentPage
    {
        private readonly MedicoService _medicoService;

        public CadastroMedico()
        {
            InitializeComponent();
            _medicoService = new MedicoService();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            var novoMedico = new Medico
            {
                Nome = NomeEntry.Text,
                CRM = CrmEntry.Text,
                Especialidade = EspecialidadeEntry.Text,
                ValorConsulta = decimal.TryParse(ValorConsultaEntry.Text, out var valor) ? valor : 0
            };

            _medicoService.Adicionar(novoMedico);
            DisplayAlert("Sucesso", "Médico cadastrado com sucesso!", "OK");

            // Limpa os campos
            NomeEntry.Text = string.Empty;
            CrmEntry.Text = string.Empty;
            EspecialidadeEntry.Text = string.Empty;
            ValorConsultaEntry.Text = string.Empty;
        }
    }
}
