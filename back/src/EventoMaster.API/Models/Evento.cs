namespace EventoMaster.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string lote { get; set; }
        public string ImagemURL { get; set; }
    };
}