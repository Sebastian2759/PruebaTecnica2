# PruebaTecnica2

PruebaTecnica2 es un proyecto desarrollado en .NET Core 8.0 que sigue una arquitectura hexagonal. Está diseñado para proporcionar una solución escalable y mantenible para la gestión de ventas de automóviles.

## Versiones

- .NET Core: 8.0
- Biblioteca de Clases .NET Standard: 8.0
- Entity Framework Core: [Versión específica aquí]
- AutoMapper: [Versión específica aquí]

## Estructura del Proyecto

El proyecto sigue una estructura de carpetas organizada para separar claramente las diferentes capas y componentes:

- **Aplication**: Contiene la capa de aplicación, donde se definen los casos de uso y se gestionan las interacciones con los usuarios.
  - **Dto**: Data Transfer Objects utilizados en la capa de aplicación.
  - **Mapper**: Configuración e implementaciones de mapeo entre entidades y DTOs.
  - **Servicios**: Implementaciones de servicios de aplicación.
- **Dominio**: Lógica del negocio y entidades del dominio.
  - **Entidades**: Entidades del dominio.
  - **Interfaces**: Definiciones de interfaces de repositorios.
- **Infraestructura**: Implementaciones concretas de los puertos definidos en la capa de aplicación.
  - **Data**: Implementaciones de acceso a datos.
  - **Repositorio**: Implementaciones de repositorios.
- **Infraestructure.Api**: Proyecto de API web.
  - **Controllers**: Controladores de la API.
  - **Properties**: Configuraciones de propiedades del proyecto.
## Instalación y Uso

Para instalar y utilizar el proyecto, sigue estos pasos:

1. Clona el repositorio desde GitHub.
2. Abre el proyecto en tu entorno de desarrollo.
3. Asegúrate de tener las versiones requeridas de .NET Core y las demás dependencias instaladas.
4. Compila el proyecto y asegúrate de que no haya errores.
5. Ejecuta el proyecto y prueba su funcionalidad.

