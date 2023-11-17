# NCQ Todo App API

## Requerimientos

- [.Net Core version 6]("https://dotnet.microsoft.com/en-us/download")
- [Visual studio 22 o dotnet CLI]("https://visualstudio.microsoft.com/vs/community/")
- [SQL Server]("https://www.microsoft.com/en-us/sql-server/sql-server-downloads")

## Sobre el projecto

Este projecto fue creado basado en los principios de [The Clean Architecture]("https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html"), separado en 4 capas principales, las cuales son las siguentes:

- **Domain**: Representa las entidades y la logica de negocio de la aplicacion.

- **Application**: Es el encargado de actúa como puente entre la capa de dominio y las interfaces externas de una aplicación, como la capa de presentación o la capa de acceso a datos.

- **Infrastructure**: Se encarga de implementa los detalles técnicos de la aplicación, como el acceso a datos, el registro, el correo electrónico y otros mecanismos de comunicación. La capa de infraestructura interactúa con sistemas y tecnologías externos, como bases de datos, API o servicios en la nube.

- **Presentation**: La capa de presentación es un componente de Arquitectura Limpia responsable de enviar respuestas y recibir solicitudes de los usuarios.

## Configuración

### Cadena de conexión

En el directorio `Presentation` se encuentra el projecto `NCQ.Todo.App.Api` en el se encuentra el archivo `appsettings.json` ahi debe replazar el valor correcto de conexion `ConnectionStrings.TodoDB`

```json
{
	"ConnectionStrings": {
		"TodoDB": "yourConnetionString"
	}
}
```

### Datos datos

La base de datos fue desarrollado con la tecnologia [Code-First]("https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx"), que permite construir la base de datos a nivel de codigo.

**La base de Datos sera creada si no existe cuando se ejecute el proyecto por primera vez**

### Datos predeterminados

No se requiere un script SQL externo, en las migraciones, permite crear datos predefinidos.

**Cuando se ejecuta el proyecto por primera vez creara los datos predeterminados**

### Ejcutar el proyecto

- Visual studio: Solo requiere abrir la solucion en Visual studio y ejecutaralo.

- dotnet cli: `dotnet run --project NCQ.Todo.App.Api/`
