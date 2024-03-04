FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ConsoleCalculator.csproj", ""]
RUN dotnet restore "ConsoleCalculator.csproj"
COPY . .
WORKDIR ""
RUN dotnet build "ConsoleCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleCalculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleCalculator.dll"]