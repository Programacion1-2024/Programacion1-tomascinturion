using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class NuevasTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copia",
                columns: table => new
                {
                    IdCopia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_COPIA", x => x.IdCopia);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EDITORIAL", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_FORMAPAGO", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNIPersona = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PERSONA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaLimite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PRESTAMO", x => x.IdPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_VENTA", x => x.IdVenta);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    IdEditorial1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_LIBRO", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Editorial_IdEditorial1",
                        column: x => x.IdEditorial1,
                        principalTable: "Editorial",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaAutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTOR", x => x.IdAutor);
                    table.ForeignKey(
                        name: "FK_Autor_Persona_PersonaAutorId",
                        column: x => x.PersonaAutorId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsSocio = table.Column<bool>(type: "bit", nullable: false),
                    PagaIVA = table.Column<bool>(type: "bit", nullable: false),
                    PersonaClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona_PersonaClienteId",
                        column: x => x.PersonaClienteId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antiguedad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<double>(type: "float", nullable: false),
                    PersonaEmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EMPLEADO", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona_PersonaEmpleadoId",
                        column: x => x.PersonaEmpleadoId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroLibro",
                columns: table => new
                {
                    IdGenereoLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro1 = table.Column<int>(type: "int", nullable: false),
                    IdGenero1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENEROLIBRO", x => x.IdGenereoLibro);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Genero_IdGenero1",
                        column: x => x.IdGenero1,
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Libro_IdLibro1",
                        column: x => x.IdLibro1,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    IdAutorLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAutor1 = table.Column<int>(type: "int", nullable: false),
                    IdLibro1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTORLIBRO", x => x.IdAutorLibro);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autor_IdAutor1",
                        column: x => x.IdAutor1,
                        principalTable: "Autor",
                        principalColumn: "IdAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libro_IdLibro1",
                        column: x => x.IdLibro1,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_PersonaAutorId",
                table: "Autor",
                column: "PersonaAutorId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdAutor1",
                table: "AutorLibro",
                column: "IdAutor1");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdLibro1",
                table: "AutorLibro",
                column: "IdLibro1");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonaClienteId",
                table: "Cliente",
                column: "PersonaClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PersonaEmpleadoId",
                table: "Empleado",
                column: "PersonaEmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_IdGenero1",
                table: "GeneroLibro",
                column: "IdGenero1");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_IdLibro1",
                table: "GeneroLibro",
                column: "IdLibro1");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_IdEditorial1",
                table: "Libro",
                column: "IdEditorial1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Copia");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "GeneroLibro");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Editorial");
        }
    }
}
