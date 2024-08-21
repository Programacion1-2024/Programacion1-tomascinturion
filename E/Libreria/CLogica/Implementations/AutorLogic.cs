using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        public AutorLogic(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<List<Autor>> GetAll()
        {
            return await _autorRepository.GetAll();
        }

        public void AltaAutor(Autor autorNuevo) 
        {
            if (string.IsNullOrEmpty(autorNuevo.Biografia))
            {
                throw new ArgumentException("La biografia no es valida");
            }
            Autor autor = new Autor();
            autor.PersonaAutor = autorNuevo.PersonaAutor;
            autor.Biografia = autorNuevo.Biografia;
            autor.FechaNacimiento = autorNuevo.FechaNacimiento;
            autor.Libros = autorNuevo.Libros;  

            _autorRepository.Create(autor);
            _autorRepository.Save();
        }
        public void ActualizarAutor(string documento, Autor autorActualizado)
        {
            if (string.IsNullOrEmpty(autorActualizado.Biografia))
            {
                throw new ArgumentException("La biografia no es valida");
            }
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
            {
                throw new ArgumentException("El documento ingresado es invalido.");
            }

            Autor? autor = _autorRepository.FindByCondition(p => p.PersonaAutor.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento");
            }

            autor.Biografia = autorActualizado.Biografia;
            autor.Libros = autorActualizado.Libros;
            _autorRepository.Update(autor);
            _autorRepository.Save();

        }
        public void EliminarAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es invalido.");

            Autor? autor = _autorRepository.FindByCondition(p => p.PersonaAutor.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento");
            }

            _autorRepository.Delete(autor);
            _autorRepository.Save();
        }
        #region Validaciones
        public bool ContieneCaracter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }
        #endregion
    }
}
