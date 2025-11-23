# Dockerfile

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# CORRECCIÓN 1: Quitar la carpeta de la ruta, ya que estamos en la raíz del repo
COPY ["SucursalLaPaz_Backend.csproj", "./"]
RUN dotnet restore "./SucursalLaPaz_Backend.csproj"

# CORRECCIÓN 2: Copiar todo el contenido del directorio actual (el repo)
COPY . .
RUN dotnet build "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish ./

EXPOSE 8080

# Simplifiqué el Entrypoint, ya que tu Program.cs ya maneja el puerto correctamente
ENTRYPOINT ["dotnet", "SucursalLaPaz_Backend.dll"]