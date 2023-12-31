# This docker file uses multi-stage build strategy
# to ensure optimal image build times and sizes
# End result container image requires .NET runtime,
# however creating it requires .NET SDK.
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS base
WORKDIR /src

FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src
COPY . .
RUN dotnet restore StreamHub.Web.csproj
RUN dotnet build "./StreamHub.Web.csproj" -c Debug -o /out

FROM build AS publish
RUN dotnet publish StreamHub.Web.csproj -c Debug -o /out

# Building final image used in running container
FROM base AS final
RUN apk update \
    && apk add unzip procps
WORKDIR /src
COPY --from=publish /out .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet StreamHub.Web.dll
