# Util Platform Api镜像配置

# 变量定义
ARG runtime_version=8.0.1
ARG sdk_version=8.0.101

# 基础阶段
FROM mcr.microsoft.com/dotnet/aspnet:${runtime_version} AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# 发布阶段
FROM mcr.microsoft.com/dotnet/sdk:${sdk_version} AS publish
WORKDIR /src
COPY ["Directory.Build.props", "."]
COPY ["build/*", "./build/"]
COPY ["src/Util.Platform.Api/Util.Platform.Api.csproj", "src/Util.Platform.Api/"]
COPY ["src/Util.Platform.Application/Util.Platform.Application.csproj", "src/Util.Platform.Application/"]
COPY ["src/Util.Platform.Domain.Identity/Util.Platform.Domain.Identity.csproj", "src/Util.Platform.Domain.Identity/"]
COPY ["src/Util.Platform.Data/Util.Platform.Data.csproj", "src/Util.Platform.Data/"]
COPY ["src/Util.Platform.Data.PgSql/Util.Platform.Data.PgSql.csproj", "src/Util.Platform.Data.PgSql/"]
COPY ["src/Util.Platform.Data.MySql/Util.Platform.Data.MySql.csproj", "src/Util.Platform.Data.MySql/"]
COPY ["src/Util.Platform.Data.SqlServer/Util.Platform.Data.SqlServer.csproj", "src/Util.Platform.Data.SqlServer/"]
RUN dotnet restore "src/Util.Platform.Api/Util.Platform.Api.csproj"
COPY . .
WORKDIR "/src/src/Util.Platform.Api"
RUN dotnet publish "Util.Platform.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 最终阶段
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV TZ=Asia/Shanghai
ENTRYPOINT ["dotnet", "Util.Platform.Api.dll"]