using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SignosVitales
    {
        public int IdSignosVitales { get; set; }
        public double Peso { get; set; }
        public double Talla { get; set; }
        public double IndiceMasaCorporal { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public double Temperatura { get; set; }
        public int PresionArterialDiastolica { get; set; }
        public int PresionArterialSistolica { get; set; }
        public int PresionArterialMedia { get; set; }
        public int SaturacionOxigeno { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int IdHistoriaClinica { get; set; }
        public SignosVitales() { }
        public SignosVitales(int idSignosVitales, double peso, double talla, double indiceMasaCorporal, int frecuenciaCardiaca, double temperatura, int presionArterialDiastolica, int presionArterialSistolica, int presionArterialMedia, int saturacionOxigeno, int frecuenciaRespiratoria, int idHistoriaClinica)
        {
            IdSignosVitales = idSignosVitales;
            Peso = peso;
            Talla = talla;
            IndiceMasaCorporal = indiceMasaCorporal;
            FrecuenciaCardiaca = frecuenciaCardiaca;
            Temperatura = temperatura;
            PresionArterialDiastolica = presionArterialDiastolica;
            PresionArterialSistolica = presionArterialSistolica;
            PresionArterialMedia = presionArterialMedia;
            SaturacionOxigeno = saturacionOxigeno;
            FrecuenciaRespiratoria = frecuenciaRespiratoria;
            IdHistoriaClinica = idHistoriaClinica;
        }
    }

}
