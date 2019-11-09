FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["BaiTap.csproj", ""]
RUN dotnet restore "./BaiTap.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BaiTap.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BaiTap.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BaiTap.dll"]