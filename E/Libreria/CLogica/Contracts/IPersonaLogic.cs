using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    internal interface IPersonaLogic
    {
        void AltaPersona(Persona persona);
        void ActualizacionPersona(string documento, Persona personaActualuzada);
    }
}
