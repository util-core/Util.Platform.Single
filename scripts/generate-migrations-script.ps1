Write-Host "update dotnet ef..."
dotnet tool update -g dotnet-ef
Write-Host "generate migrations script..."
dotnet ef migrations script --idempotent -p "..\src\Util.Platform.Data.SqlServer" -o ../deploy/sql/sqlserver/migrations.sql
dotnet ef migrations script --idempotent -p "..\src\Util.Platform.Data.PgSql" -o ../deploy/sql/pgsql/migrations.sql
dotnet ef migrations script --idempotent -p "..\src\Util.Platform.Data.MySql" -o ../deploy/sql/mysql/migrations.sql