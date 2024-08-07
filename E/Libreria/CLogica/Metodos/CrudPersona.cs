using CDatos.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;

namespace CLogica.Metodos
{
    public class CrudPersona
    {
       LibreriaContext context = new LibreriaContext();

        public void AgregarPersona(Persona persona)
        {
            Persona nuevoPersona = new Persona();
            if (persona != null)
            {
                if(persona.TipoDocumento == "DNI")
                {
                    if (persona.Documento.Length > 11)
                    {
                        if(persona.Apellido.Length > 2 && persona.Apellido.Length < 20)
                        {
                            if(persona.Nombre.Length > 2 && persona.Nombre.Length < 20)
                            {
                                if(persona.Nacionalidad != null)
                                {
                                    if(persona.Telefono != null)
                                    {
                                        if(persona.Email != null)
                                        {

                                        }
                                        else
                                        {

                                        }
                                    }
                                            
                                }

                            }
                        }
                    }

                }

            }
        }
    }
}


