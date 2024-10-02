using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using CDatos.Repositories.Contracts;
using System.Text.RegularExpressions;

namespace CLogica.Implementations
{
    public class LibroLogic : ILibroLogic
    {
        private ILibroRepository _libroRepository;
        public LibroLogic(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        public void AltaLibro(Libro libroAgregar)
        {
            List<string> camposInvalidos = new List<string>();
            if (libroAgregar == null)
            {
                throw new ArgumentException("Ingrese los datos");
            }    
            if (string.IsNullOrEmpty(libroAgregar.Titulo))
            {
                camposInvalidos.Add("Titulo");
            }
            if (string.IsNullOrEmpty(libroAgregar.ISBN) || !ISBNValid(libroAgregar.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroAgregar.ISBN).Count() != 0)
            {
                camposInvalidos.Add("ISBN");
            }
            if (string.IsNullOrEmpty(libroAgregar.Descripcion))
            {
                camposInvalidos.Add("Descripcion");
            }
            if (libroAgregar.Precio <= 0)
            {
                camposInvalidos.Add("Precio");
            }
            if (libroAgregar.FechaPublicacion == null)
            {
                camposInvalidos.Add("Fecha Publicacion");
            }


        }

        private bool ISBNValid(string ISBN)
        {
            if (string.IsNullOrEmpty(ISBN))
            {
                return true;
            }
            var regex = new Regex(@"^(?:\d{1,5}-\d{1,7}-\d{1,7}-[\dX]|\d{3}-\d{1,5}-\d{1,7}-\d{1,7}-\d{1})$");
            return regex.IsMatch(ISBN);
        }
    }
}
