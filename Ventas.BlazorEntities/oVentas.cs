using System;
using System.ComponentModel.DataAnnotations;

namespace Ventas.BlazorEntities
{
    public class oVentas
    {
        [Required(ErrorMessage = "El Numero del empleado no es valido")]
        [Range(0, int.MaxValue, ErrorMessage = "El Numero del empleado debe ser mayor que 0")]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "El Nombre del empleado es requerido")]
        [StringLength(50, ErrorMessage = "El Nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La edad del empleado es requerida")]
        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100 años")]
        public int Edad { get; set; } 

        [Required(ErrorMessage = "El cargo del empleado es requerido")]
        [StringLength(50, ErrorMessage = "El cargo no puede exceder los 50 caracteres")]
        public string Cargo { get; set; } = null!;

        [Required(ErrorMessage = "La fecha del contrato es requerida")]
        [DataType(DataType.Date, ErrorMessage = "La fecha del contrato debe ser una fecha válida")]
        public DateTime FechaContrato { get; set; } 

        [Required(ErrorMessage = "La cuota del empleado es requerida")]
        [Range(1, double.MaxValue, ErrorMessage = "La cuota debe ser mayor que 0")]
        public double Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas del empleado son requeridas")]
        [Range(0, int.MaxValue, ErrorMessage = "Las ventas deben ser un número positivo")]
        public int Ventas { get; set; } = -1;
        public int idSucursales { get; set; }
        public int idJefe { get; set; }
    }
}
