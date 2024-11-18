using CadastroDeEventosApp.Views;

namespace CadastroDeEventosApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}
