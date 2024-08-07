using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Contexts;
using CEntidades.Entidades;


namespace CDatos.Repositories.Contracts
{
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        public PersonaRepository(LibreriaContext context): base(context)
        {

        }
    }
}
