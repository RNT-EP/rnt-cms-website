# Ensure we have the version specific Umbraco templates
dotnet new install Umbraco.Templates::13.5.3 --force

# Create solution/project
dotnet new sln --name "RNTWebsite"
dotnet new umbraco --force -n "RNTWebsite" --friendly-name "Administrador" --email "admin@example.com" --password "1234567890" --development-database-type SQLite
dotnet sln add "RNTWebsite"

dotnet run --project "RNTWebsite"
#Running
