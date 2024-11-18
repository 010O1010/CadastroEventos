using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }
        public string Requisitos { get; set; }

        // Propriedade calculada: duração do evento em dias
        public int DuracaoEmDias => DataTermino.Subtract(DataInicio).Days;

        // Propriedade calculada: custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }

}
