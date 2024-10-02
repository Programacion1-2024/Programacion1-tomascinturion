using CEntidades.Entidades;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IClienteLogic
    {
        void AltaCliente(string tipoDocumento, string documento, string nombre, string apellido, string nacionalidad, string email, string telefono, string esSocio, string pagaIVA);
        void BajaCliente(string id);
        void ActualizacionCliente(string tipoDocumento, string documento, string nombre, string apellido, string nacionalidad, string email, string telefono, string esSocio, string pagaIVA);
        List<Cliente> ObtenerClientes();
        Cliente? ObtenerClientePorDocumento(string documento);
        List<dynamic> ObtenerClientesParaListado();
    }
}
