using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _PersonaRepository;

        public AutorLogic(IAutorRepository PersonaRepository)
        {
            _PersonaRepository = PersonaRepository;
        }

        public async Task<List<Autor>> GetAll()
        {
            return await _PersonaRepository.GetAll();
        }

        public void AltaAutor(Autor autorNuevo) 
        {
            if (string.IsNullOrEmpty(autorNuevo.Biografia))
            {
                throw new ArgumentException("La biografia no es valida");
            }
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

            Autor? autor = _PersonaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento");
            }

            autor.Biografia = autorActualizado.Biografia;
            _PersonaRepository.Update(autor);
            _PersonaRepository.Save();

        }
        public void EliminarAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es invalido.");

            Autor? autor = _PersonaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento");
            }

            _PersonaRepository.Delete(autor);
            _PersonaRepository.Save();
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
