FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Album.Api/Album.Api.csproj", "Album.Api/"]
RUN dotnet restore "Album.Api/Album.Api.csproj"
COPY . .
WORKDIR "/src/Album.Api"
RUN dotnet build "Album.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Album.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Album.Api.dll"]
