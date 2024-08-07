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
    }
}
