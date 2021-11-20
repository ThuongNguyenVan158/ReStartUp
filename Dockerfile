FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ReStartUp/ReStartUp.csproj", "ReStartUp/"]
RUN dotnet restore "ReStartUp/ReStartUp.csproj"
COPY . .
WORKDIR "/src/ReStartUp"
RUN dotnet build "ReStartUp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReStartUp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ReStartUp.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet REStartUp.dll