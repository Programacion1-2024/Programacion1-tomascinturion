using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _clienteRepository;
        private IPersonaLogic _personaLogic;

        public ClienteLogic(IClienteRepository clienteRepository, IPersonaLogic personaLogic)
        {
            _clienteRepository = clienteRepository;
            _personaLogic = personaLogic;
        }

        public List<Cliente> ObtenerClientes()
        {
            return _clienteRepository.FindAll().ToList();
        }

        public Cliente? ObtenerClientePorDocumento(string documento)
        {
            return _clienteRepository.FindByCondition(a => a.PersonaCliente.Documento == documento).FirstOrDefault();
        }

        public List<dynamic> ObtenerClientesParaListado()
        {
            return _clienteRepository.ObtenerClientes().Select(a => new { IdCliente = a.IdCliente, TipoDocumento = a.PersonaCliente.TipoDocumento, NumeroDocumento = a.PersonaCliente.Documento, Nombre = a.PersonaCliente.Nombre, Apellido = a.PersonaCliente.Apellido, Nacionalidad = a.PersonaCliente.Nacionalidad, Telefono = a.PersonaCliente.Telefono, Email = a.PersonaCliente.Email }).ToList<dynamic>();
        }

        public void AltaCliente(string tipoDocumento, string documento, string nombre, string apellido, string nacionalidad, string email, string telefono, string esSocio, string pagaIVA)
        {
            try
            {
                Persona personaAgregar = new Persona()
                {
                    TipoDocumento = tipoDocumento,
                    Documento = documento,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad
                };

                Persona personaNueva = _personaLogic.AltaPersona(personaAgregar);

                bool esSocioBool;
                if (esSocio == "Si")
                {
                    esSocioBool = true;
                }
                else if (esSocio == "No")
                {
                    esSocioBool = false;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para EsSocio. Debe ser 'Sí' o 'No'.");
                }

                bool pagaIVABool;
                if (pagaIVA == "Si")
                {
                    pagaIVABool = true;
                }
                else if (pagaIVA == "No")
                {
                    pagaIVABool = false;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para PagaIVA. Debe ser 'Sí' o 'No'.");
                }

                Cliente clienteNuevo = new Cliente()
                {
                    PersonaCliente = personaNueva,
                    EsSocio = esSocioBool,
                    PagaIVA = pagaIVABool
                };

                _clienteRepository.CreateCliente(clienteNuevo);
                _clienteRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaCliente(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Cliente? clienteEliminar = new Cliente();

            if (Int32.TryParse(id, out int idCliente))
            {
                clienteEliminar = _clienteRepository.FindByCondition(p => p.IdCliente == idCliente).FirstOrDefault();

                if (clienteEliminar == null)
                {
                    throw new InvalidOperationException("La persona que se desea eliminar no existe.");
                }
            }
            else
            {
                throw new InvalidOperationException("El ID ingresado no es valido.");

            }

            _clienteRepository.Delete(clienteEliminar);
            _clienteRepository.Save();

            _personaLogic.BajaPersona(clienteEliminar.PersonaCliente.IdPersona.ToString());
        }

        public void ActualizacionCliente(string tipoDocumento, string documento, string nombre, string apellido, string nacionalidad, string email, string telefono, string esSocio, string pagaIVA)
        {
            try
            {
                Cliente? clienteExistente = _clienteRepository.FindByCondition(c => c.PersonaCliente.Documento == documento).FirstOrDefault();

                if (clienteExistente == null)
                {
                    throw new ArgumentNullException("No se encontro un cliente con el documento ingresado.");
                }

                Persona personaActualizar = new Persona()
                {
                    TipoDocumento = tipoDocumento,
                    Documento = documento,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad,
                    Cliente = clienteExistente
                };

                _personaLogic.ActualizacionPersona(personaActualizar);

                bool esSocioBool;
                if (esSocio == "Si")
                {
                    esSocioBool = true;
                }
                else if (esSocio == "No")
                {
                    esSocioBool = false;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para EsSocio. Debe ser 'Sí' o 'No'.");
                }

                bool pagaIVABool;
                if (pagaIVA == "Si")
                {
                    pagaIVABool = true;
                }
                else if (pagaIVA == "No")
                {
                    pagaIVABool = false;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para PagaIVA. Debe ser 'Sí' o 'No'.");
                }

                clienteExistente.EsSocio = esSocioBool;
                clienteExistente.PagaIVA = pagaIVABool;

                _clienteRepository.CreateCliente(clienteExistente);
                _clienteRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}