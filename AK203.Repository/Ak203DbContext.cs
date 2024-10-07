using System.Data.Entity;
using AK203.Repository;

using MySql.Data.EntityFramework;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

[DbConfigurationType(typeof(MySqlEFConfiguration))]
public class Ak203DbContext : DbContext
{
    public Ak203DbContext() : base("name=Ak203DbContext")
    {
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<AK203.Repository.Locations> Locations { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Packaging> Packagings { get; set; }
    public DbSet<Sub_Category> SubCategories { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Stock_In> StockIns { get; set; }
    public DbSet<Stock_Packaging> StockPackagings { get; set; }
    public DbSet<Stock_In_Items> StockInItems { get; set; }
    public DbSet<Stock_Issue> StockIssues { get; set; }
    public DbSet<Stock_Issue_Packaging> StockIssuePackagings { get;set; }
    public DbSet<StockIssueItemRfid> StockIssueItemRfids { get; set; }
}
