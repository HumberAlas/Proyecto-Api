# API de Inventario con Swagger

## Descripción

Esta API permite gestionar un inventario de productos mediante operaciones CRUD (Crear, Leer, Actualizar y Eliminar). Se ha desarrollado con .NET 8.0 y está documentada con Swagger.

Requisitos

.NET 8.0 SDK instalado.

SQL Server configurado.

Visual Studio o cualquier otro IDE compatible con .NET.


## Instalación

Clonar el repositorio o extraer los archivos del proyecto.

Aplicar las migraciones de la base de datos (si se usa Entity Framework):

dotnet ef database update

Ejecutar la API:

dotnet run


## Uso

Acceder a Swagger


## Endpoints principales

GET /api/inventario → Obtiene todos los productos del inventario.

GET /api/inventario/{id} → Obtiene un producto por su ID.

POST /api/inventario → Crea un nuevo producto.

PUT /api/inventario/{id} → Actualiza un producto existente.

DELETE /api/inventario/{id} → Elimina un producto del inventario.


## Configuración

Si es necesario cambiar la configuración de la base de datos, editar el archivo appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=MI_SERVIDOR;Database=InventarioDB;User Id=usuario;Password=contraseña;"
  }
}
