#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ArtistPage/ArtistPage.APILayer/ArtistPage.APILayer.csproj", "ArtistPage/ArtistPage.APILayer/"]
RUN dotnet restore "ArtistPage/ArtistPage.APILayer/ArtistPage.APILayer.csproj"
COPY . .
WORKDIR "/src/ArtistPage/ArtistPage.APILayer"
RUN dotnet build "ArtistPage.APILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArtistPage.APILayer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArtistPage.APILayer.dll"]