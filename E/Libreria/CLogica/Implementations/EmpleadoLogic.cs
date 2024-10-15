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
        private IPersonaLogic _personaLogic;
        private IEmpleadoRepository _empleadoRepository;

        public EmpleadoLogic(IPersonaLogic personaLogic, IEmpleadoRepository empleadoRepository)
        {
            _personaLogic = personaLogic;
            _empleadoRepository = empleadoRepository;
        }
        public void AltaEmpleado(string nombre, string apellido, string nacionalidad, string cargo, double sueldo, string telefono, string email, DateTime FechaIngreso)
        {
            try
            {
                Persona personaAgregar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Nacionalidad = nacionalidad,
                    Email = email,
                    Telefono = telefono,
                    
                    
                };
                Persona personaNueva = _personaLogic.AltaPersona(personaAgregar);
                Empleado empleadoAgregar = new Empleado()
                {
                    PersonaEmpleado = personaNueva,
                    Cargo = cargo,
                    Sueldo = sueldo,
                    Antiguedad = FechaIngreso
                };
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(empleadoAgregar.Cargo))
                {
                    camposErroneos.Add("cargo");
                }
                if(camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }
                _empleadoRepository.CreateEmpleado(empleadoAgregar);
                _empleadoRepository.Save();
            }
            catch(Exception) 
            {
                throw; 
            }
            
        }
        public void BajaEmpleado(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Ingrese un id");
            }
            Empleado empleadoEliminar = new Empleado();

            if(Int32.TryParse(id, out int idEmpleado))
            {
                empleadoEliminar = _empleadoRepository.FindByCondition(p => p.IdEmpleado == idEmpleado).FirstOrDefault();
               
                if(empleadoEliminar == null)
                {
                    throw new InvalidOperationException("El empleado que desea eliminar no existe");
                }
            }
            else
            {
                throw new InvalidOperationException("El id ingresado no es valido");
            }
            _empleadoRepository.Delete(empleadoEliminar);
            _empleadoRepository.Save();
            _personaLogic.BajaPersona(empleadoEliminar.PersonaEmpleado.IdPersona.ToString());
        }
        public void ActualizacionEmpleado(string idEmpleado, string nombre, string apellido, string nacionalidad, string cargo, double sueldo, string telefono, string email)
        {
            try
            {
                Int32.TryParse(idEmpleado, out int idEmpleadoActualizar);
                Empleado? empleadoExistente = _empleadoRepository.GetById(idEmpleadoActualizar);
                
                if (empleadoExistente == null)
                {
                    throw new ArgumentNullException("El empleado ingresado no existe");
                }

                Persona personaActualizar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Nacionalidad = nacionalidad,
                    Telefono = telefono,
                    Email = email,
                    
                };
                _personaLogic.ActualizacionPersona(personaActualizar);

                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(empleadoExistente.Cargo))
                {
                    camposErroneos.Add("Cargo");
                }
                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }
                empleadoExistente.Cargo = cargo;
                empleadoExistente.Sueldo = sueldo;
                
                _empleadoRepository.Update(empleadoExistente);
                _empleadoRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }
               

                
            
           
        }
        public List<Empleado> ObtenerEmpleados()
        {
            return _empleadoRepository.FindAll().ToList();
        }
        public Empleado? ObtenerEmpleadoPorID(string idEmpleado)
        {
            return _empleadoRepository.FindByCondition(p => p.IdEmpleado == Int32.Parse(idEmpleado)).FirstOrDefault();
        }
        public List<dynamic> ObtenerEmpleadoParaListado()
        {
            return _empleadoRepository.ObtenerEmpleados().Select(a => new {IdEmpleado = a.IdEmpleado, Nombre = a.PersonaEmpleado.Nombre, Apellido = a.PersonaEmpleado.Apellido, Nacionalidad = a.PersonaEmpleado.Nacionalidad, Documento = a.PersonaEmpleado.Documento, Cargo = a.Cargo, Sueldo = a.Sueldo}).ToList<dynamic>();
        } 
    }
}
