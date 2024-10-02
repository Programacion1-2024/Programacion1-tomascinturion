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
        public void AltaEmpleado(string nombre, string apellido, string nacionalidad, string documento, string cargo, double sueldo);
        public void BajaEmpleado(string id);
        public void ActualizacionEmpleado(string idEmpleado, string nombre, string apellido, string nacionalidad, string cargo, double sueldo);
        public List<Empleado> ObtenerEmpleados();
        public Empleado? ObtenerEmpleadoPorDNI(string idEmpleado);
    }
}
