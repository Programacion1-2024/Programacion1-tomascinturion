using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEmpleadoLogic
    {
        public void AltaEmpleado(string nombre, string apellido, string nacionalidad, string cargo, double sueldo, string telefono, string email, DateTime FechaIngreso);
        public void BajaEmpleado(string id);
        public void ActualizacionEmpleado(string idEmpleado, string nombre, string apellido, string nacionalidad, string cargo, double sueldo, string telefono, string email);
        public List<Empleado> ObtenerEmpleados();
        public Empleado? ObtenerEmpleadoPorID(string idEmpleado);
        public List<dynamic> ObtenerEmpleadoParaListado();
    }
}
