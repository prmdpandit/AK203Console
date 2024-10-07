using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK203.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Users> Users { get; }
        IRepository<Locations> Locations { get; }
        IRepository<Category> Categories { get; }
        IRepository<Packaging> Packagings { get; }
        IRepository<Sub_Category> SubCategories { get; }
        IRepository<Equipment> Equipments { get; }
        IRepository<Supplier> Suppliers { get; }
        IRepository<Stock_In> StockIns { get; }
        IRepository<Stock_Packaging> StockPackagings { get; }
        IRepository<Stock_In_Items> StockInItems { get; }
        IRepository<Stock_Issue> StockIssues { get; }
        IRepository<Stock_Issue_Packaging> StockIssuePackages { get; }

        IRepository<StockIssueItemRfid> StockIssueItemRfids { get; }
        void Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly Ak203DbContext _context;

        public UnitOfWork(Ak203DbContext context)
        {
            _context = context;
            Users = new Repository<Users>(_context);
            Locations = new Repository<Locations>(_context);
            Categories = new Repository<Category>(_context);
            Packagings = new Repository<Packaging>(_context);
            SubCategories = new Repository<Sub_Category>(_context);
            Equipments = new Repository<Equipment>(_context);
            Suppliers = new Repository<Supplier>(_context);
            StockIns = new Repository<Stock_In>(_context);
            StockPackagings = new Repository<Stock_Packaging>(_context);
            StockInItems = new Repository<Stock_In_Items>(_context);
            StockIssues = new Repository<Stock_Issue>(_context);
            StockIssuePackages = new Repository<Stock_Issue_Packaging>(_context);
            StockIssueItemRfids = new Repository<StockIssueItemRfid>(_context);
        }

        public IRepository<Users> Users { get; }
        public IRepository<Locations> Locations { get; }
        public IRepository<Category> Categories { get; }
        public IRepository<Packaging> Packagings { get; }
        public IRepository<Sub_Category> SubCategories { get; }
        public IRepository<Equipment> Equipments { get; }
        public IRepository<Supplier> Suppliers { get; }
        public IRepository<Stock_In> StockIns { get; }
        public IRepository<Stock_Packaging> StockPackagings { get; }
        public IRepository<Stock_In_Items> StockInItems { get; }
        public IRepository<Stock_Issue> StockIssues { get; }
        public IRepository<Stock_Issue_Packaging> StockIssuePackages { get; }

        public IRepository<StockIssueItemRfid> StockIssueItemRfids { get; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
