# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar el proyecto y restaurar
COPY ["Sucursal_La_Paz_microservicio/SucursalLaPaz_Backend.csproj", "./"]
RUN dotnet restore "./SucursalLaPaz_Backend.csproj"

# Copiar todo y build
COPY ./Sucursal_La_Paz_microservicio/ ./
RUN dotnet build "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish ./

# Exponer puerto (documentativo)
EXPOSE 8080

# ENTRYPOINT usando puerto dinámico de Railway
ENTRYPOINT ["sh", "-c", "dotnet SucursalLaPaz_Backend.dll --urls http://*:${PORT:-8080}"]
