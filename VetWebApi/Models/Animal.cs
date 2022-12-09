namespace VetWebApi.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string? Nome { get; set; }
        public string? Especie { get; set; }
        public string? Sexo { get; set; }
        public string? Comorbidade { get; set; }
        public string? Condicao { get; set; }

        
        public string FrequenciaCardiaca { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string PressaoArterialSistemica { get; set; }
        public string Hematocrito { get; set; }
        public string Leucocitos { get; set; }
    }
}
