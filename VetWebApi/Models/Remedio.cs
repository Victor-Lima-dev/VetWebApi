namespace VetWebApi.Models
{
    public class Remedio
    {
        public string? Nome { get; set; }
        public int RemedioId { get; set; }
        public string? PrincipioAtivo { get; set; }
        public string? MecanismoAcao { get; set; }
        public string? ViaAdministracao { get; set; }
        public string? EfeitoAdverso { get; set; }

        //Efeitos Sistemicos
        public Boolean PodeAumentarFrequenciaCardiaca { get; set; }
        public Boolean PodeDiminuirFrequenciaCardiaca { get; set; }

        public Boolean PodeAumentarFrequenciaRespiratoria { get; set; }
        public Boolean PodeDiminuirFrequenciaRespiratoria { get; set; }

        public Boolean PodeAumentarPressaoArterial { get; set; }
        public Boolean PodeDiminuirPressaoArterial { get; set; }

        public Boolean PodeAumentarHematocritos { get; set; }
        public Boolean PodeDiminuirHematocritos { get; set; }

        public Boolean PodeAumentarLeucocitos { get; set; }
        public Boolean PodeDiminuirLeucocitos { get; set; }

    }
}
