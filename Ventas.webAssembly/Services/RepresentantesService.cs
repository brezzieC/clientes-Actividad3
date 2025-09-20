using Ventas.BlazorEntities;

namespace Ventas.webAssembly.Services
{
    public class RepresentantesService
    {
        public List<oVentas> listaRep;
        public RepresentantesService()
        {
            listaRep = new List<oVentas>
            {
                new oVentas { IdEmpleado = 1, Nombre = "Armando Casas", Edad = 30, Cargo = "Jefe", FechaContrato = new DateTime(2020, 1, 15), Cuota = 5000, Ventas = 10, idJefe= 1, idSucursales=1 },
                new oVentas { IdEmpleado = 2, Nombre = "Jacinto Escobar", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2019, 3, 22), Cuota = 7000, Ventas = 15, idJefe= 1, idSucursales=2 },
                new oVentas { IdEmpleado = 3, Nombre = "Josimar Paredes", Edad = 28, Cargo = "Vendedor", FechaContrato = new DateTime(2021, 6, 10), Cuota = 6000, Ventas = 8,idJefe=1, idSucursales=3},
            };
        }
        public List<oVentas> GetRepresentantes()
        {
            return listaRep;
        }
        public string getNombre(int id)
        {
            var Objeto = listaRep.FirstOrDefault(x=>x.IdEmpleado == id);
            if (Objeto == null)
                return "";
            else
                return Objeto.Nombre;
        }
        public List<oVentas> filtrarVendedores(string nombreTitulo)
        {
            List<oVentas> l = GetRepresentantes();
            if (nombreTitulo.Equals(string.Empty))
                return l;
            else
            {
                List<oVentas> listaFiltrada = l.Where(x => x.Nombre.ToLower().Contains(nombreTitulo.ToLower())).ToList();
                return listaFiltrada;
            }
            
        }
        public oVentas ObtenerRepresentante(int id)
        {
            var representante = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (representante != null)
            {
                return representante;
            }
            else
            {
                return new oVentas();
            }
        }
        public void EliminarRepresentante(int id)
        {
            var representante = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (representante != null)
            {
                listaRep.Remove(representante);
            }
        }
        public void AgregarRepresentante(oVentas nuevoRepresentante)
        {
            var numMax = listaRep.Select(r => r.IdEmpleado).Max() + 1;
            nuevoRepresentante.IdEmpleado = numMax;
            listaRep.Add(nuevoRepresentante);
        }
        public void ActualizarRepresentante(oVentas actualizarRep, int id)
        {
            var actualizar = listaRep.FirstOrDefault(r => r.IdEmpleado == id);
            if (actualizar != null)
            {
                actualizar.Nombre = actualizarRep.Nombre;
                actualizar.Edad = actualizarRep.Edad;
                actualizar.Cargo = actualizarRep.Cargo;
                actualizar.FechaContrato = actualizarRep.FechaContrato;
                actualizar.Cuota = actualizarRep.Cuota;
                actualizar.Ventas = actualizarRep.Ventas;
            }
        }
    }
}
