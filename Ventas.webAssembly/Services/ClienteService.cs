using Ventas.BlazorEntities;

namespace Ventas.webAssembly.Services
{
    public class ClienteService
    {
        List<Cliente> Lista; 
        public ClienteService()
        {
            Lista = new List<Cliente>
            {
                new Cliente{CodCLiente= 1, NomCliente = "Elba Zurita" , IDRepresentante = 1, LimiteCredito= 2000},
                new Cliente{CodCLiente= 2, NomCliente = "Maria Pacajes" , IDRepresentante = 2, LimiteCredito= 1230},
                new Cliente{CodCLiente= 3, NomCliente = "Adita Choque" , IDRepresentante = 2, LimiteCredito= 3205}
            };

        }
        public List<Cliente> ListaClientes()
        {
            return Lista;
        }
        public List<Cliente> filtrarClientes(string nombreTitulo)
        {
            List<Cliente> l = ListaClientes();
            
            if (nombreTitulo.Equals(string.Empty))
                return l;
            else
            {
                List<Cliente> listaFiltrada = l.Where(x => x.NomCliente.ToLower().Contains(nombreTitulo.ToLower())).ToList();
                return listaFiltrada;
            }

        }
        public Cliente ObtenerCLiente(int id)
        {
            var representante = Lista.FirstOrDefault(r => r.CodCLiente == id);
            if (representante != null)
            {
                return representante;
            }
            else
            {
                return new Cliente();
            }
        }
        public void EliminarCLiente(int id)
        {
            var Cliente = Lista.FirstOrDefault(r => r.CodCLiente== id);
            if (Cliente != null)
            {
                Lista.Remove(Cliente);
            }
        }
        public void AgregarCliente(Cliente nuevoCliente)
        {
            try
            {
                var numMax = Lista.Select(r => r.CodCLiente).Max() + 1;
                nuevoCliente.CodCLiente = numMax;
                Lista.Add(nuevoCliente);
            }
            catch (Exception ex) {
                var numMax = 1;
                nuevoCliente.CodCLiente = numMax;
                Lista.Add(nuevoCliente);
            }
            
        }
        public void ActualizarCliente(Cliente actualizarCliente, int id)
        {
            var actualizar = Lista.FirstOrDefault(r => r.CodCLiente == id);
            if (actualizar != null)
            {
                actualizar.NomCliente = actualizarCliente.NomCliente;
                actualizar.IDRepresentante = actualizarCliente.IDRepresentante;
                actualizar.LimiteCredito = actualizarCliente.LimiteCredito;
            }
        }
    }
}
