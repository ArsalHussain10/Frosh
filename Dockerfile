FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Frosh/Frosh.csproj", "Frosh/"]
RUN dotnet restore "Frosh/Frosh.csproj"
COPY . .
WORKDIR "/src/Frosh"
RUN dotnet build "Frosh.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Frosh.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Frosh.dll"]
