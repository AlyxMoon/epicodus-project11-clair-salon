FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY ./HairSalon /app
COPY ./HairSalon/appsettings.docker.json /app/appsettings.json