# Proyecto Survey

El proyecto Survey es una aplicación de encuestas desarrollada en .NET 6 con características de versionamiento, generación de informes gráficos y capacidad de generar cálculos mediante No-Code. Utiliza Entity Framework Core, LINQ y MSSQL 2022 como gestor de base de datos.

## Requisitos previos

Antes de comenzar, asegúrate de tener instalados los siguientes elementos:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) o cualquier otro editor de código de tu preferencia
- SQL Server Management Studio (SSMS) u otra herramienta de gestión de bases de datos compatible con MSSQL 2022

## Configuración

Sigue estos pasos para configurar el proyecto:

1. Clona el repositorio del proyecto o descarga los archivos en tu máquina local.
2. Abre el proyecto en tu editor de código preferido.
3. Modifica el archivo `AppSettings.json` con la cadena de conexión (`connectionString`) para conectar con la base de datos deseada. Por ejemplo:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SurveyDB;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```

4. Abre una ventana de línea de comandos en la raíz del proyecto.
5. Ejecuta el siguiente comando para aplicar las migraciones y actualizar la base de datos:

   ```shell
   dotnet ef database update
   ```

   Esto asegurará que la estructura de la base de datos esté actualizada con las últimas migraciones.

## Ejecución de la API

Para ejecutar la API, sigue estos pasos:

1. Abre el proyecto en Visual Studio o desde la línea de comandos en la raíz del proyecto.
2. Compila el proyecto para asegurarte de que no hay errores.
3. Ejecuta la aplicación presionando F5 en Visual Studio o ejecutando el siguiente comando en la línea de comandos:

   ```shell
   dotnet run
   ```

   La API se ejecutará y estará lista para recibir solicitudes.

## Back Up 

se deja un back up en el siguiente directorio 



   ```json
   Aprehende.Survey.Database
   ```
   
   el arhivo tiene como nombre 
   [surveyBackup.bak]
 


## Recursos adicionales

Aquí tienes algunos recursos adicionales que pueden ser útiles para trabajar con .NET:

- [Documentación oficial de .NET](https://docs.microsoft.com/dotnet/)
- [Documentación de Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [Foros de .NET](https://forums.dotnetfoundation.org/)
