using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente : Persona
    {
        public int IdPaciente { get; set; }
        public int IdClinica { get; set; }
        public int IdEps { get; set; }
        public List<HistoriaClinica> HistoriasClinicas { get; set; } = new List<HistoriaClinica>();
        public List<FormulaMedica> FormulasMedicas { get; set; } = new List<FormulaMedica>();
        public List<CitaMedica> CitasMedicas { get; set; } = new List<CitaMedica>();
        public Paciente() { }
        public Paciente(int idPersona, string nombre, string apellido, char sexo, int edad, string telefono, string correo, string direccion, DateTime fechaNacimiento, int idPaciente, int idEps, List<HistoriaClinica> historiasClinicas, List<FormulaMedica> formulasMedicas, List<CitaMedica> citasMedicas, int idClinica)
            : base(idPersona, nombre, apellido, sexo, edad, telefono, correo, direccion, fechaNacimiento)
        {
            IdPaciente = idPaciente;
            IdEps = idEps;
            HistoriasClinicas = historiasClinicas;
            FormulasMedicas = formulasMedicas;
            CitasMedicas = citasMedicas;
            IdClinica = idClinica;
        }
    }
}
