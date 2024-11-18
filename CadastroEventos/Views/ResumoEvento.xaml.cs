using Microsoft.Maui.Controls;
using CadastroEventos.Models;

namespace CadastroEventos.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public Evento Evento { get; set; }

        public Command VoltarCommand { get; }

        public ResumoEvento(Evento evento)
        {
            InitializeComponent();

            Evento = evento;

            VoltarCommand = new Command(Voltar);

            BindingContext = this;
        }

        private async void Voltar()
        {
            try
            {
                // Navegar para a página inicial
                await Navigation.PushAsync(new CadastroEvento());
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
