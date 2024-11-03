using SistemaMedico.Models; // Certifique-se de que isso esteja incluído

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
            Console.WriteLine("Botão Adicionar Paciente clicado");
            // Salvar as alterações (implementar de acordo com a sua lógica)
            Navigation.PopAsync();
        }
    }
}
