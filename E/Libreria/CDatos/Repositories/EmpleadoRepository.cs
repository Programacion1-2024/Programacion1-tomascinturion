using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(LibreriaContext context) : base(context) 
        {
        }
        public void CreateEmpleado(Empleado empleado)
        {
            _context.Empleado.Attach(empleado);
        }
        public List<Empleado> ObtenerEmpleados()
        {
            return _context.Empleado.Include(a => a.PersonaEmpleado).ToList();
        }
    }
}
