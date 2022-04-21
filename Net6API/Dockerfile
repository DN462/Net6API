#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Net6API/Net6API.csproj", "Net6API/"]
RUN dotnet restore "Net6API/Net6API.csproj"
COPY . .
WORKDIR "/src/Net6API"
RUN dotnet build "Net6API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Net6API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Net6API.dll"]
