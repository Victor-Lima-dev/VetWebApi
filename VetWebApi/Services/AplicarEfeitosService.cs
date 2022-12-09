using VetWebApi.Context;
using VetWebApi.Models;

namespace VetWebApi.Services
{
    public class AplicarEfeitosService
    {
        //acesso banco de dados
        private readonly AppDbContext _context;

        public AplicarEfeitosService(AppDbContext context)
        {
            _context = context;
        }

        public void AplicarEfeitos(int remedioId, int animalId)
        {
            //selecionar remedio com id
            Remedio remedio = _context.Remedios.FirstOrDefault(c => c.RemedioId == remedioId);
            //selecionar animal com id
            Animal animal = _context.Animais.FirstOrDefault(c => c.AnimalId == animalId);

            ConfereFrequenciaCardiaca(animal, remedio);
            ConfereFrequenciaRespiratoria(animal, remedio);
            ConferePressaoArterial(animal, remedio);
            ConfereHematocritos(animal, remedio);
            ConfereLeucocitos(animal, remedio);
          


        }

        public void ConfereFrequenciaCardiaca(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarFrequenciaCardiaca == true)
            {
                parametros.FrequenciaCardiaca = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirFrequenciaCardiaca == true)
            {
                parametros.FrequenciaCardiaca = "DIMINUIU";
            }

            else { return; }
        }
        public void ConfereFrequenciaRespiratoria(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarFrequenciaRespiratoria == true)
            {
                parametros.FrequenciaRespiratoria = "AUMENTOU";
            }
            else if (efeitoSistemico.PodeDiminuirFrequenciaRespiratoria == true)
            {
                parametros.FrequenciaRespiratoria = "DIMINUIU";
            }

            else { return; }
        }

        public void ConferePressaoArterial(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "AUMENTOU";
            }
            else if (efeitoSistemico.PodeDiminuirPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereHematocritos(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarHematocritos == true)
            {
                parametros.Hematocrito = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirHematocritos == true)
            {
                parametros.Hematocrito = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereLeucocitos(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarLeucocitos == true)
            {
                parametros.Leucocitos = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirLeucocitos == true)
            {
                parametros.Leucocitos = "DIMINUIU";
            }
            else { return; }
        }
    }
}
