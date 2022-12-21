FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy everything.
COPY ./ ./

# Restore as distinct layer.
RUN dotnet restore ./TenisApp.Canchas.Application/TenisApp.Canchas.Application.csproj

# Build and publish release.
RUN dotnet publish ./TenisApp.Canchas.Application/TenisApp.Canchas.Application.csproj -c Release -o out

# Build runtime image.
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "TenisApp.Canchas.Application.dll"]