
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Empleado:BaseEntityPersona
    {
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario {get;set;} =null!;
        public decimal Salario { get; set; } 
        public int IdCargo {get;set;}
        [ForeignKey("IdCargo")]
        public Cargo Cargo {get; set; } =null!;
        public string TipoContratacion { get; set; } =null!;
        public int IdEps { get; set; }
        [ForeignKey("IdEps")]
        public Eps Eps { get; set; }= null!;
        public int IdArl { get; set; }
        [ForeignKey("IdArl")]
        public Arl Arl { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCumpleaños { get; set; }
        public ICollection<ContactoEmpleado> ContactosEmpleados { get; set; }
        =new List<ContactoEmpleado>();
        public ICollection<ProfesionEmpleado> ProfesionesEmpleados { get; set; }
        =new List<ProfesionEmpleado>();
        public ICollection<DiagnosticoEmpleado> DiagnosticosEmpleados { get; set;}
        =new List<DiagnosticoEmpleado>();


        
    }
}