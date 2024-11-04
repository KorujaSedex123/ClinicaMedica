using SistemaMedico.Models; // Certifique-se de que isso esteja inclu�do

namespace SistemaMedico.Views
{
    public partial class MedicoDetailPage : ContentPage
    {
        private Medico _medico;

        public MedicoDetailPage(Medico medico)
        {
            InitializeComponent();
            _medico = medico;
            BindingContext = _medico;
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Bot�o Adicionar Paciente clicado");
            // Salvar as altera��es (implementar de acordo com a sua l�gica)
            Navigation.PopAsync();
        }
    }
}
