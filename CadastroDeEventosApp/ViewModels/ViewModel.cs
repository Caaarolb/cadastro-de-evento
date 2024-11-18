using CadastroDeEventosApp.Models;
using CadastroDeEventosApp.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CadastroDeEventosApp.ViewModels
{
    public class EventoViewModel : INotifyPropertyChanged
    {
        public Evento Evento { get; set; } = new Evento();

        // Command para cadastrar o evento e navegar para a tela de resumo
        public ICommand CadastrarCommand => new Command(async () =>
        {
            // Validação simples para garantir que as datas estão corretas
            if (Evento.DataInicio > Evento.DataTermino)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "A data de início deve ser anterior à data de término.",
                    "OK"
                );
                return;
            }

            // Navegar para a página de resumo passando o objeto Evento
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoEventoPage(Evento));
        });

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

