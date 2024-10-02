﻿using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;
        private IPersonaLogic _personaLogic;

        public AutorLogic(IAutorRepository autorRepository, IPersonaLogic personaLogic)
        {
            _autorRepository = autorRepository;
            _personaLogic = personaLogic;
        }

        public List<Autor> ObtenerAutores()
        {
            return _autorRepository.FindAll().ToList();
        }

        public Autor? ObtenerAutorPorID(string idAutor)
        {
            return _autorRepository.FindByCondition(a => a.IdAutor == Int32.Parse(idAutor)).FirstOrDefault();
        }


        public List<dynamic> ObtenerAutoresParaListado()
        {
            return _autorRepository.ObtenerAutores().Select(a => new { IdAutor = a.IdAutor, Nombre = a.PersonaAutor.Nombre, Apellido = a.PersonaAutor.Apellido, FechaNacimiento = a.FechaNacimiento, Nacionalidad = a.PersonaAutor.Nacionalidad, Telefono = a.PersonaAutor.Telefono, Email = a.PersonaAutor.Email, Biografia = a.Biografia }).ToList<dynamic>();
        }

        public void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string fechaNacimiento, string telefono, string biografia)
        {
            try
            {
                Persona personaAgregar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad
                };

                Persona personaNueva = _personaLogic.AltaPersona(personaAgregar);

                Autor autorNuevo = new Autor()
                {
                    PersonaAutor = personaNueva,
                    FechaNacimiento = ValidacionesLogic.ParsearFecha(fechaNacimiento),
                    Biografia = biografia
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(autorNuevo.Biografia))
                {
                    camposErroneos.Add("Biografia");
                }

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                _autorRepository.CreateAutor(autorNuevo);
                _autorRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaAutor(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Autor? autorEliminar = new Autor();
            
            if (Int32.TryParse(id, out  int idAutor))
            {
                autorEliminar = _autorRepository.FindByCondition(p => p.IdAutor == idAutor).FirstOrDefault();

                if (autorEliminar == null)
                {
                    throw new InvalidOperationException("La persona que se desea eliminar no existe.");
                }  
            }
            else
            {
                throw new InvalidOperationException("El ID ingresado no es valido.");

            }

            _autorRepository.Delete(autorEliminar);
            _autorRepository.Save();

            _personaLogic.BajaPersona(autorEliminar.PersonaAutor.IdPersona.ToString());
        }

        public void ActualizacionAutor(string idAutor, string nombre, string apellido, string nacionalidad, string email, string fechaNacimiento, string telefono, string biografia)
        {
            try
            {
                Int32.TryParse(idAutor, out int id);
                Autor? autorExistente = _autorRepository.GetById(id);

                if (autorExistente == null)
                {
                    throw new ArgumentNullException("No se encontro un autor con el ID ingresado.");
                }

                Persona personaActualizar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad,
                    Autor = autorExistente
                };

                _personaLogic.ActualizacionPersona(personaActualizar);

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(autorExistente.Biografia))
                {
                    camposErroneos.Add("Biografia");
                }

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                autorExistente.FechaNacimiento = ValidacionesLogic.ParsearFecha(fechaNacimiento);
                autorExistente.Biografia = biografia;

                _autorRepository.CreateAutor(autorExistente);
                _autorRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
