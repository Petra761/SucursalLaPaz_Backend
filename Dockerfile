# Dockerfile (colocado en la raíz del repo)

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# copiar el .csproj usando la sintaxis JSON para manejar espacios en la ruta
COPY ["Sucursal La Paz microservicio/SucursalLaPaz_Backend.csproj", "./"]
RUN dotnet restore "./SucursalLaPaz_Backend.csproj"

# copiar el resto del contenido del proyecto (la carpeta)
COPY ./Sucursal\ La\ Paz\ microservicio/ ./
RUN dotnet build "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SucursalLaPaz_Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish ./

EXPOSE 8080

ENTRYPOINT ["sh", "-c", "dotnet SucursalLaPaz_Backend.dll --urls http://*:${PORT:-8080}"]
