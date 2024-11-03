using SistemaMedico.Models; // Certifique-se de que isso esteja incluído
using SistemaMedico.Services;

namespace SistemaMedico.Views
{
    public partial class PacienteListPage : ContentPage
    {
        private readonly IPacienteService _pacienteService;

        public PacienteListPage(IPacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            CarregarPacientes();
        }

        private void CarregarPacientes()
        {
            PacientesList.ItemsSource = _pacienteService.ObterPacientes();
        }

        private async void OnAdicionarPacienteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPacientePage(_pacienteService));
        }

    }
}
