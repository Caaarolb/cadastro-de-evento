using System;

namespace CadastroDeEventosApp.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada para duração do evento
        public int Duracao => (DataTermino - DataInicio).Days;

        // Propriedade calculada para o custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
