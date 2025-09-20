using System.ComponentModel.DataAnnotations;
using Ventas.BlazorEntities;
namespace Ventas.Test
{
    public class VentasTest
    {
          
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }
        [Fact]
        public void ValidacionDebeFallarCuandoCamposEstanVacios()
        {
            var Venta = new oVentas();
            var errores = ValidarModelo(Venta);
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El Numero del empleado no es valido") ||
            e.ErrorMessage!.Contains("El Numero del empleado debe ser mayor que 0")
            );
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El Nombre del empleado es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad debe estar entre 18 y 100 años") ||
            e.ErrorMessage!.Contains("La edad del empleado es requerida"));            

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo del empleado es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota del empleado es requerida") ||
            e.ErrorMessage!.Contains("La cuota debe ser mayor que 0"));
  
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Las ventas del empleado son requeridas") ||
            e.ErrorMessage!.Contains("Las ventas deben ser un número positivo"));


        }
        [Fact]
        public void ValidacionDebePasarDatosCorrectos()
        {
            var Venta = new oVentas()
            {
                IdEmpleado= 1,
                Nombre = "Juan Perez",
                Edad = 30,
                Cargo = "Vendedor",
                FechaContrato = DateTime.Now.AddYears(-1),
                Cuota = 5000.00,
                Ventas = 150
            };
            var errores = ValidarModelo(Venta);
            Assert.Empty(errores);
        }

    }
}