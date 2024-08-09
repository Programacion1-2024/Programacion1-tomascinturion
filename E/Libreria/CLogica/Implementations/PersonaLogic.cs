using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;
        public PersonaLogic(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public void AltaPersona(Persona personaNueva)
        {
            List<String> camposinvalidos = new List<string>();

            if (string.IsNullOrEmpty(personaNueva.Nombre) || !IsValidName(personaNueva.Nombre))
                throw new ArgumentException("Nombre inválido");

            if (string.IsNullOrEmpty(personaNueva.Apellido) || !IsValidName(personaNueva.Apellido))
                throw new ArgumentException("Apellido inválido");

            if (string.IsNullOrEmpty(personaNueva.Documento) || !IsValidDocumento(personaNueva.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaNueva.Documento).Count() != 0)
                throw new ArgumentException("Documento inválido");

            if (string.IsNullOrEmpty(personaNueva.Telefono) || !IsValidTelefono(personaNueva.Telefono))
                throw new ArgumentException("Teléfono inválido");

            if (string.IsNullOrEmpty(personaNueva.Email) || !IsValidEmail(personaNueva.Email))
                throw new ArgumentException("Email inválido");

            if (camposinvalidos.Count > 0)
            {
                throw new ArgumentException();
            }

            Persona persona = new Persona();
            persona.Nombre = personaNueva.Nombre;
            persona.Apellido = personaNueva.Apellido;
            persona.Nacionalidad = personaNueva.Nacionalidad;
            persona.Documento = personaNueva.Documento;
            persona.TipoDocumento = personaNueva.TipoDocumento;
            persona.Telefono = personaNueva.Telefono;
            persona.Email = personaNueva.Email;
            if (personaNueva.Autor != null)
            {
                persona.Autor = personaNueva.Autor;
            }
            if (personaNueva.Empleado != null)
            {
                persona.Empleado = personaNueva.Empleado;
            }
            if (personaNueva.Cliente != null)
            {
                persona.Cliente = personaNueva.Cliente;
            }
            _personaRepository.Create(persona);
            _personaRepository.Save();
        }
        public void ActualizacionPersona(string documento, Persona personaActualizada)
        {
            List<String> camposinvalidos = new List<string>();

            if (string.IsNullOrEmpty(personaActualizada.Nombre) || !IsValidName(personaActualizada.Nombre))
                throw new ArgumentException("Nombre inválido");

            if (string.IsNullOrEmpty(personaActualizada.Apellido) || !IsValidName(personaActualizada.Apellido))
                throw new ArgumentException("Apellido inválido");

            if (string.IsNullOrEmpty(personaActualizada.Telefono) || !IsValidTelefono(personaActualizada.Telefono))
                throw new ArgumentException("Teléfono inválido");

            if (string.IsNullOrEmpty(personaActualizada.Email) || !IsValidEmail(personaActualizada.Email))
                throw new ArgumentException("Email inválido");

            if (camposinvalidos.Count > 0)
            {
                throw new ArgumentException();
            }

            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es invalido.");

            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if(persona == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento");
            }
            persona.Nombre = personaActualizada.Nombre;
            persona.Apellido = personaActualizada.Apellido;
            persona.Telefono = personaActualizada.Telefono;
            persona.Documento = personaActualizada.Documento;
            persona.Email = personaActualizada.Documento;
            _personaRepository.Update(persona);
            _personaRepository.Save();
        }
        public void EliminarPersona(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es invalido.");

            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (persona == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento");
            }

            _personaRepository.Delete(persona);
            _personaRepository.Save();
        }
        #region validaciones
        public bool ContieneCaracter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidName(string nombre)
        {
            return ContieneCaracter(nombre) && nombre.Length == 15;
        }

        private bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }

        private bool IsValidTelefono(string telefono)
        {
            return telefono.Length != 10 && ContieneCaracter(telefono);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && ContieneCaracter(email);
        }
        #endregion validaciones
    }
}
