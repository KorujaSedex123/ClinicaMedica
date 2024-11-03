using SistemaMedico.Models; // Certifique-se de que isso esteja inclu�do

namespace SistemaMedico.Views
{
    public partial class PacienteDetailPage : ContentPage
    {
        private Paciente _paciente;

        public PacienteDetailPage(Paciente paciente)
        {
            InitializeComponent();
            _paciente = paciente;
            BindingContext = _paciente;
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Bot�o Adicionar Paciente clicado");
            // Salvar as altera��es (implementar de acordo com a sua l�gica)
            Navigation.PopAsync();
        }
    }
}
