Write-Host "update dotnet ef..."
dotnet tool update -g dotnet-ef
Write-Host "generate migrations script..."
dotnet ef migrations script --idempotent -p "..\src\Util.Platform.Data.SqlServer" -o ../output/deploy/sql/sqlserver/migrations.sql
dotnet ef migrations script --idempotent -p "..\src\Util.Platform.Data.PgSql" -o ../output/deploy/sql/pgsql/migrations.sql