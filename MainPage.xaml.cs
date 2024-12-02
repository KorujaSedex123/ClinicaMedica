using ClinicManager.Views;
namespace ClinicaMedica;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCadastrarMedicoClicked(object sender, EventArgs e)
    {
        // Lógica para cadastro de médico
        await Navigation.PushAsync(new CadastroMedico());
    }
}
