#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["0-Service/FRN.WebApi/FRN.WebApi.csproj", "0-Service/FRN.WebApi/"]
COPY ["3-Infra/FRN.Infra/FRN.Infra.csproj", "3-Infra/FRN.Infra/"]
COPY ["2-Domain/FRN.Domain/FRN.Domain.csproj", "2-Domain/FRN.Domain/"]
RUN dotnet restore "0-Service/FRN.WebApi/FRN.WebApi.csproj"
COPY . .
WORKDIR "/src/0-Service/FRN.WebApi"
RUN dotnet build "FRN.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FRN.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FRN.WebApi.dll"]