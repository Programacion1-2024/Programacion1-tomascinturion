using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        Task<List<Autor>> GetAll();
        void AltaAutor(Autor autorNuevo);
        void ActualizarAutor(string documento, Autor autorActualizado);
        void EliminarAutor(string documento);
    }
}
