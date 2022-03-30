# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
ARG src="Plugins.DataStore/"
COPY Ecommerce.sln ./
COPY CoreBusiness/*.csproj ./CoreBusiness/
COPY DataStore/*.csproj ./DataStore/
COPY Library/*.csproj ./Library/
COPY ${src}*.csproj ./${src}
COPY WebApp/*.csproj ./WebApp/
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build-env /app/out .

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet WebApp.dll