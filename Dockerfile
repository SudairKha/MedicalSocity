# ===== BUILD STAGE =====
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Restore & publish
RUN dotnet publish MedicalSocity.sln -c Release -o /app/publish

# ===== RUNTIME STAGE =====
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

# Render uses dynamic port
ENV ASPNETCORE_URLS=http://0.0.0.0:10000

EXPOSE 10000

# IMPORTANT: change this if your DLL name is different
ENTRYPOINT ["dotnet", "MedicalSocity.dll"]