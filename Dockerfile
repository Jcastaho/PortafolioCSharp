# --- Etapa de compilación (Build Stage) ---
# Usamos la imagen oficial del SDK de .NET 8.0 para compilar el proyecto
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copiamos primero el archivo .csproj para aprovechar el caché de Docker
# Esto hace que las compilaciones futuras sean más rápidas si no has cambiado las dependencias
COPY ["Portafolio/Portafolio.csproj", "Portafolio/"]

# Restauramos las dependencias del proyecto
RUN dotnet restore "Portafolio/Portafolio.csproj"

# Copiamos el resto de los archivos del proyecto
COPY . .

# Publicamos la aplicación en modo Release, lista para producción
WORKDIR "/app/Portafolio"
RUN dotnet publish "Portafolio.csproj" -c Release -o /app/publish

# --- Etapa final (Final Stage) ---
# Usamos una imagen mucho más ligera que solo contiene lo necesario para ejecutar la app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

# Copiamos la aplicación compilada desde la etapa de 'build'
COPY --from=build /app/publish .

# El comando para iniciar la aplicación cuando el contenedor se ejecute
ENTRYPOINT ["dotnet", "Portafolio.dll"]
