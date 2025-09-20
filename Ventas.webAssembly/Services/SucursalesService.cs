using Ventas.BlazorEntities;

namespace Ventas.webAssembly.Services
{
    public class SucursalesService
    {
        private List<Sucursales> listaSucurasales;
        public SucursalesService()
        {
            listaSucurasales = new List<Sucursales>
            {
                new Sucursales { Id = 1, Nombre = "La Paz" },
                new Sucursales { Id = 2, Nombre = "Santa Cruz" },
                new Sucursales { Id = 3, Nombre = "Cochabamba" },
            };
        }
        public List<Sucursales> getSucursales()
        {
            return listaSucurasales;
        }

        public string getNombre(int id) { 
            var obj = listaSucurasales.FirstOrDefault(x=>x.Id==id);
            if (obj != null)
                return obj.Nombre;
            else
                return "";
        }
        
    }
}
