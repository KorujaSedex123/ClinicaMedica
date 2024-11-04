using SistemaMedico.Models; // Certifique-se de que isso esteja inclu�do
using SistemaMedico.Services;

namespace SistemaMedico.Views
{
    public partial class MedicoListPage : ContentPage
    {
        private readonly IMedicoService _medicoService;

        public MedicoListPage(IMedicoService medicoService)
        {
            InitializeComponent();
            _medicoService = medicoService;
            CarregarMedicos();
        }

        private void CarregarMedicos()
        {
            MedicosList.ItemsSource = _medicoService.ObterMedicos();
        }

        private async void OnAdicionarMedicoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroMedicoPage(_medicoService));
        }

    }
}
