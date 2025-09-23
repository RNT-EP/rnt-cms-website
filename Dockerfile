
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src


COPY ["RNT/RNT.csproj", "RNT/"]
RUN dotnet restore "RNT/RNT.csproj"


COPY . .
WORKDIR "/src/RNT"
RUN dotnet publish -c Release -o /app/publish


FROM base AS final
WORKDIR /app


COPY --from=build /app/publish .


RUN mkdir -p /app/wwwroot/media
RUN mkdir -p /app/App_Data


ENTRYPOINT ["dotnet", "RNT.dll"]
