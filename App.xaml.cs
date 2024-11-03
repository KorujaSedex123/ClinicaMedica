using Microsoft.Extensions.DependencyInjection;
using SistemaMedico.Services;
using SistemaMedico.Views;

namespace SistemaMedico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddSingleton<IPacienteService, PacienteService>();

            var serviceProvider = services.BuildServiceProvider();
            var pacienteService = serviceProvider.GetService<IPacienteService>();

            if (pacienteService != null)
            {
                MainPage = new NavigationPage(new PacienteListPage(pacienteService));
            }
            else
            {
                throw new InvalidOperationException("O serviço de paciente não pôde ser resolvido.");
            }
        }
    }
}
