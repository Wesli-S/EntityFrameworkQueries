# EntityFrameworkQueries

## Getting Started
- VS 2022
- .NET 6 or higher
- [AP Database](create_ap.sql) installed
  
You may need to change the DB connection string located in the APContext class.
This code points to mssqllocaldb by default. If your AP script isn't installed on this, update the string. 
```csharp
 optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AP");
```
