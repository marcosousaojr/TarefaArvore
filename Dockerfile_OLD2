# Etapa 1: Construir a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar csproj e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar o restante dos arquivos e construir a aplicação
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa 2: Criar a imagem final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expor a porta que a aplicação usará
EXPOSE 80

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "TarefaArvore.dll"]