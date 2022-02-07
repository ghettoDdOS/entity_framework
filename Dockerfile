FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine

WORKDIR /app

COPY . .

RUN dotnet restore