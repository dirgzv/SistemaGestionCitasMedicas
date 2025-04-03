using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SignosVitales
    {
        public int IdSignosVitales { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public decimal TensionArterialSistolica { get; set; }
        public decimal TensionArterialDiastolica { get; set; }
        public decimal FrecuenciaCardiaca { get; set; }
        public decimal FrecuenciaRespiratoria { get; set; }
        public decimal Temperatura { get; set; }
        public SignosVitales() { }
        public SignosVitales(int idSignosVitales, decimal peso, decimal talla, decimal tensionArterialSistolica, decimal tensionArterialDiastolica, decimal frecuenciaCardiaca, decimal frecuenciaRespiratoria, decimal temperatura)
        {
            IdSignosVitales = idSignosVitales;
            Peso = peso;
            Talla = talla;
            TensionArterialSistolica = tensionArterialSistolica;
            TensionArterialDiastolica = tensionArterialDiastolica;
            FrecuenciaCardiaca = frecuenciaCardiaca;
            FrecuenciaRespiratoria = frecuenciaRespiratoria;
            Temperatura = temperatura;
        }
    }
}

