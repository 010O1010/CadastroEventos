using Microsoft.Maui.Controls;
using CadastroEventos.Models;

namespace CadastroEventos.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public Evento Evento { get; set; }
        public Command SalvarEventoCommand { get; }

        public CadastroEvento()
        {
            InitializeComponent();

            Evento = new Evento
            {
                    // Definindo a data de início e término para o dia de hoje
                    DataInicio = DateTime.Now,
                    DataTermino = DateTime.Now,
            };

            SalvarEventoCommand = new Command(SalvarEvento);

            BindingContext = this;
        }

            private async void SalvarEvento()
        {
            try
            {
                // Navegar para a página de resumo com os dados do evento
                await Navigation.PushAsync(new ResumoEvento(Evento));
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
