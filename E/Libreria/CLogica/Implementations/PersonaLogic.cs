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
        public void AltaPersona(Persona persona)
        {
            //aca van los metodos de persona (los que estan en crudpersin
        }
        public void ActualizacionPersona(string documento, Persona personaActualizada)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException( "El documento ingresado es invalido.");
            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if(persona == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento");
                persona.Nombre = personaActualizada.Nombre;
                persona.Apellido = personaActualizada.Apellido;
                persona.Telefono = personaActualizada.Telefono;
                persona.Documento = personaActualizada.Documento;
                persona.Email = personaActualizada.Documento;
                _personaRepository.Save()//por terminar
            }
        }
    }
}
