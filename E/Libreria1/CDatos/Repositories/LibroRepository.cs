using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class LibroRepository : Repository<Libro>
    {
        public LibroRepository(LibreriaContext context) : base(context)
        {

        }
    }
}
