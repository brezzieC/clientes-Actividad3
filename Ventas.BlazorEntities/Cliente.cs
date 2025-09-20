using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BlazorEntities
{
    public class Cliente
    {
        [Required]
        public int CodCLiente { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NomCliente { get; set; }
        [Required(ErrorMessage = "El representante es obligatorio")]
        public int IDRepresentante { get; set; }
        [Required(ErrorMessage = "El limite de credito es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El limite de credito debe ser mayor que 0")]
        public double? LimiteCredito { get; set; } 
    }
}
