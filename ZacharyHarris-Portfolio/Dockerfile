#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ZacharyHarris-Portfolio/ZacharyHarris-Portfolio.csproj", "ZacharyHarris-Portfolio/"]
COPY ["ZacharyHarris-PortfolioML.Model/ZacharyHarris-PortfolioML.Model.csproj", "ZacharyHarris-PortfolioML.Model/"]
RUN dotnet restore "ZacharyHarris-Portfolio/ZacharyHarris-Portfolio.csproj"
COPY . .
WORKDIR "/src/ZacharyHarris-Portfolio"
RUN dotnet build "ZacharyHarris-Portfolio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZacharyHarris-Portfolio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZacharyHarris-Portfolio.dll"]