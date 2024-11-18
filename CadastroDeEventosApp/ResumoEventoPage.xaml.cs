using CadastroDeEventosApp.Models;

namespace CadastroDeEventosApp.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
