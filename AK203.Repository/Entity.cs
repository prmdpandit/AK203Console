using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace AK203.Repository
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Is_Active { get; set; } = 1;
        public string Role { get; set; } = "admin";
        public int Comp_Id { get; set; } = 1;
        public string AuthKey { get; set; }
        public string AccessToken { get; set; }
        public int Active { get; set; } = 1;
        public int Created_By { get; set; } = 0;
        public DateTime? Created_At { get; set; }
        public int Updated_By { get; set; } = 0;
        public DateTime Updated_At { get; set; }

        //public ICollection<Stock_In> StockIns { get; set; }
        //public ICollection<Equipment> Equipments { get; set; }
    }
    public class Locations
    {
        public int Id { get; set; }
        public string Location_Name { get; set; }
        public int Is_Active { get; set; } = 1;
    }


    public class Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; } = 1;

        public ICollection<Sub_Category> SubCategories { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
    }

    public class Sub_Category
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Sub_CategoryName { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; } = 1;

        public Category Category { get; set; }
    }

    public class Packaging
    {
        public int Id { get; set; }
        public string Package_Name { get; set; }
        public string Package_Size { get; set; }
        public int Package_Qty { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; } = 1;

        public ICollection<Stock_In> StockIns { get; set; }
    }

    public class Equipment
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public int SubCategory_Id { get; set; }
        public string Part_No { get; set; }
        public string Material_No { get; set; }
        public string Nomenclature { get; set; }
        public string Specification { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; } = 1;
        public int Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_At { get; set; }

        public Category Category { get; set; }
        public Sub_Category SubCategory { get; set; }
       // public ICollection<Stock_In_Items> StockInItems { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Supplier_Type { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Contact_No { get; set; }
        public string Supplier_Address { get; set; }
        public int Is_Active { get; set; } = 1;

        public ICollection<Stock_In> StockIns { get; set; }
    }

    public class Stock_In
    {
        public int Id { get; set; }
        public int Supplier_Id { get; set; }
        public int Packaging_Id { get; set; }
        public int Package_Nos { get; set; }
        public string Invoice_No { get; set; }
        public int Total_Qty { get; set; }
        public decimal Rate { get; set; }
        public int Year_Of_Mfr { get; set; }
        public DateTime Receive_Date { get; set; }
        public string Description { get; set; }
        public string Receiver_Name { get; set; }
        public string Receiver_Phone_No { get; set; }
        public DateTime Invoice_Dt { get; set; }
        public int Is_Stock_Added { get; set; } = 0;
        public int Is_Active { get; set; } = 1;
        public int Created_By { get; set; } = 0;
        public DateTime? Created_At { get; set; }
        public int Updated_By { get; set; } = 0;
        public DateTime Updated_At { get; set; }

        [ForeignKey("Supplier_Id")]
        public Supplier Supplier { get; set; }
        [ForeignKey("Packaging_Id")]
        public virtual Packaging Packaging { get; set; }
    //    public ICollection<Stock_Packaging> StockPackagings { get; set; }
        public ICollection<Stock_In_Items> StockInItems { get; set; }
    }

    public class Stock_Packaging
    {
        public int Id { get; set; }
        public int Stock_In_Id { get; set; }
        public string Box_No { get; set; }
        public int Box_Qty { get; set; }
        public string Box_Qr { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; } = 1;
        //[ForeignKey("Stock_In_Id")]
        //public virtual Stock_In StockIn { get; set; }
    }

    public class Stock_In_Items
    {
        public int Id { get; set; }
        public int Stock_In_Id { get; set; }
        public int Stock_Packaging_Id { get; set; }
    
        public string Equipment_Reg_No { get; set; }
        public string Equipment_Rfid { get; set; }
        public string Description { get; set; }
        public int Is_Stock_Transferred { get; set; } = 0;
        public int Is_Active { get; set; } = 1;
        public int Created_By { get; set; } = 0;
        public DateTime? Created_At { get; set; }
        public int Updated_By { get; set; } = 0;
        public DateTime Updated_At { get; set; }

        [ForeignKey("Stock_In_Id")]
        public Stock_In StockIn { get; set; }
        [ForeignKey("Stock_Packaging_Id")]
        public Stock_Packaging StockPackaging { get; set; }
      
    }


public class Stock_Issue
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Challan_No { get; set; }

        public DateTime? Challan_Dt { get; set; }

        public DateTime? Issue_Dt { get; set; }

        public int? Equipment_Id { get; set; }

        [MaxLength(20)]
        public string Issue_To_Army_No { get; set; }

        [MaxLength(100)]
        public string Issue_To_Name { get; set; }

        [MaxLength(50)]
        public string Issue_To_Rank { get; set; }

        [MaxLength(50)]
        public string Issue_To_Designation { get; set; }

        [MaxLength(50)]
        public string Issue_To_Unit_Name { get; set; }

        public int? Total_Qty { get; set; }

        public int? Punched_By { get; set; }

        [MaxLength(100)]
        public string Issue_By_Officer { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int Created_By { get; set; } = 0;

        public DateTime? Created_At { get; set; }
    }

    public class Stock_Issue_Packaging
    {
        [Key]
        public int Id { get; set; }

        public int? Stock_Issue_Id { get; set; }

        public int? Stock_Packaging_Id { get; set; }

        [MaxLength(100)]
        public string Box_No { get; set; }

        public int? Box_Qty { get; set; }

        // Optional: Define foreign key relationships if needed
        [ForeignKey("Stock_Issue_Id")]
        public virtual Stock_Issue Stock_Issue { get; set; }

        [ForeignKey("Stock_Packaging_Id")]
        public virtual Stock_Packaging Stock_Packaging { get; set; }
    }

    [Table("stock_issue_items_rfid")]
    public class StockIssueItemRfid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("stock_issue_id")]
        public int Stock_Issue_Id { get; set; }

        [Column("equipment_rfid")]
        [StringLength(150)]
        public string EquipmentRfid { get; set; }

        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }

        // Navigation property
        //[ForeignKey("Stock_Issue_Id")]
        //public virtual Stock_Issue StockIssue { get; set; }
    }

}
