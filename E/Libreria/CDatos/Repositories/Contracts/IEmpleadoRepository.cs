using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories.Contracts
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        public void CreateEmpleado(Empleado empleado);
        public List<Empleado> ObtenerEmpleados();
    }
}
