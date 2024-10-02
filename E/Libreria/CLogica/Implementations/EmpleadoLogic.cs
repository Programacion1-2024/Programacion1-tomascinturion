using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EmpleadoLogic : IEmpleadoLogic
    {
        private PersonaLogic _personaLogic;
        private IEmpleadoRepository _empleadoRepository;

        public EmpleadoLogic(PersonaLogic personaLogic, IEmpleadoRepository empleadoRepository)
        {
            _personaLogic = personaLogic;
            _empleadoRepository = empleadoRepository;
        }
        public void AltaEmpleado(string nombre, string apellido, string nacionalidad, string documento, string cargo, double sueldo)
        {
            try
            {
                Persona personaAgregar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Nacionalidad = nacionalidad,
                    Documento = documento,
                };
                Persona personaNueva = _personaLogic.AltaPersona(personaAgregar);
                Empleado empleadoAgregar = new Empleado()
                {
                    Cargo = cargo,
                    Sueldo = sueldo,
                };
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(empleadoAgregar.Cargo))
                {
                    camposErroneos.Add("cargo");
                }
                _empleadoRepository.CreateEmpleado(empleadoAgregar);
            }
            
        }
    }
}
