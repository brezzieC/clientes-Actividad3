using Ventas.BlazorEntities;

namespace Ventas.webAssembly.Services
{
    public class JefesService
    {
        private RepresentantesService representantesService ;
        private List<oVentas> vendedores;
        private List<Jefes> JefesLista;
        private List<oVentas> JefesEmp;
        public JefesService()
        {
            representantesService = new RepresentantesService();
            vendedores = representantesService.GetRepresentantes();
            JefesEmp =vendedores.Where(x => x.Cargo == "Jefe").ToList();
            JefesLista = new List<Jefes>();
            foreach (var item in JefesEmp)
            {
                Jefes jefe = new Jefes();
                jefe.idJefe = item.IdEmpleado;
                jefe.NomJefe = item.Nombre;
                JefesLista.Add(jefe);
            }
            
        }
        public List<Jefes> GetJefes() { 
            return JefesLista;
        }
        public string getNombre(int id)
        {
            var obj = JefesLista.FirstOrDefault(x => x.idJefe == id);
            if (obj != null)
                return obj.NomJefe;
            else
                return "";
        }

    }
}
