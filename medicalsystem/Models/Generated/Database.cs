



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `constrng`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.;Initial Catalog=mms;Integrated Security=True;User ID=sa;Password=***********`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace constrng
{

	public partial class constrngDB : Database
	{
		public constrngDB() 
			: base("constrng")
		{
			CommonConstruct();
		}

		public constrngDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			constrngDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static constrngDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new constrngDB();
        }

		[ThreadStatic] static constrngDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static constrngDB repo { get { return constrngDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : constrngDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    

	[TableName("dbo.tblCompay")]



	[PrimaryKey("CompanyId")]




	[ExplicitColumns]

    public partial class tblCompay : constrngDB.Record<tblCompay>  
    {



		[Column] public int CompanyId { get; set; }





		[Column] public string CompanyName { get; set; }





		[Column] public string CompanyAddress { get; set; }





		[Column] public string CompanyEmail { get; set; }



	}

    

	[TableName("dbo.tblDealer")]



	[PrimaryKey("DealId")]




	[ExplicitColumns]

    public partial class tblDealer : constrngDB.Record<tblDealer>  
    {



		[Column] public int DealId { get; set; }





		[Column] public string DealerName { get; set; }





		[Column] public string DealerAddres { get; set; }





		[Column] public string DealerEmail { get; set; }





		[Column] public int CompanyId { get; set; }



	}

    

	[TableName("dbo.tblProduct")]



	[PrimaryKey("ProductId")]




	[ExplicitColumns]

    public partial class tblProduct : constrngDB.Record<tblProduct>  
    {



		[Column] public int ProductId { get; set; }





		[Column] public string ProductName { get; set; }





		[Column] public int TypeId { get; set; }



	}

    

	[TableName("dbo.tblProductReceivedDetails")]



	[PrimaryKey("PRDId")]




	[ExplicitColumns]

    public partial class tblProductReceivedDetail : constrngDB.Record<tblProductReceivedDetail>  
    {



		[Column] public int PRDId { get; set; }





		[Column] public int PRMId { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public int Quantity { get; set; }





		[Column] public DateTime PurchaseDate { get; set; }





		[Column] public DateTime SaleDate { get; set; }





		[Column] public DateTime MfgDate { get; set; }





		[Column] public DateTime ExpDate { get; set; }





		[Column] public string BatchNo { get; set; }



	}

    

	[TableName("dbo.tblProductReceivedMaster")]



	[PrimaryKey("PRMId")]




	[ExplicitColumns]

    public partial class tblProductReceivedMaster : constrngDB.Record<tblProductReceivedMaster>  
    {



		[Column] public int PRMId { get; set; }





		[Column] public int DealerId { get; set; }





		[Column] public DateTime Date { get; set; }





		[Column] public int Amount { get; set; }





		[Column] public string Remarks { get; set; }



	}

    

	[TableName("dbo.tblSaleDetails")]



	[PrimaryKey("SDId")]




	[ExplicitColumns]

    public partial class tblSaleDetail : constrngDB.Record<tblSaleDetail>  
    {



		[Column] public int SDId { get; set; }





		[Column] public int SMId { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public int Quantity { get; set; }





		[Column] public int Rate { get; set; }



	}

    

	[TableName("dbo.tblSaleMaster")]



	[PrimaryKey("SMId")]




	[ExplicitColumns]

    public partial class tblSaleMaster : constrngDB.Record<tblSaleMaster>  
    {



		[Column] public int SMId { get; set; }





		[Column] public string CustomerName { get; set; }





		[Column] public DateTime Date { get; set; }





		[Column] public int Amount { get; set; }





		[Column] public int Discount { get; set; }





		[Column] public string Remarks { get; set; }



	}

    

	[TableName("dbo.tblSaleReturnDetails")]



	[PrimaryKey("SRDId")]




	[ExplicitColumns]

    public partial class tblSaleReturnDetail : constrngDB.Record<tblSaleReturnDetail>  
    {



		[Column] public int SRDId { get; set; }





		[Column] public int SRMId { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public int Rate { get; set; }



	}

    

	[TableName("dbo.tblSaleReturnMaster")]



	[PrimaryKey("SRMId")]




	[ExplicitColumns]

    public partial class tblSaleReturnMaster : constrngDB.Record<tblSaleReturnMaster>  
    {



		[Column] public int SRMId { get; set; }





		[Column] public int SMId { get; set; }





		[Column] public DateTime Date { get; set; }



	}

    

	[TableName("dbo.tblStockInHand")]



	[PrimaryKey("SIHId")]




	[ExplicitColumns]

    public partial class tblStockInHand : constrngDB.Record<tblStockInHand>  
    {



		[Column] public int SIHId { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public int Quantity { get; set; }





		[Column] public int PRMId { get; set; }



	}

    

	[TableName("dbo.tblType")]



	[PrimaryKey("TypeId")]




	[ExplicitColumns]

    public partial class tblType : constrngDB.Record<tblType>  
    {



		[Column] public int TypeId { get; set; }





		[Column] public string TypeName { get; set; }



	}

    

	[TableName("dbo.tblUser")]



	[PrimaryKey("UserId")]




	[ExplicitColumns]

    public partial class tblUser : constrngDB.Record<tblUser>  
    {



		[Column] public int UserId { get; set; }





		[Column] public string FirstName { get; set; }





		[Column] public string LastName { get; set; }





		[Column] public string UserName { get; set; }





		[Column] public string EmailId { get; set; }





		[Column] public string MobileNumber { get; set; }





		[Column] public string Password { get; set; }





		[Column] public int Designation { get; set; }





		[Column] public int? SecurityQuestionOne { get; set; }





		[Column] public string SecurityAnswerOne { get; set; }





		[Column] public int? SecurityQuestionTwo { get; set; }





		[Column] public string SecurityAnswerTwo { get; set; }





		[Column] public bool IsActive { get; set; }





		[Column] public bool IsReset { get; set; }





		[Column] public string CreatedBy { get; set; }





		[Column] public DateTime CreatedDate { get; set; }





		[Column] public string Modifiedby { get; set; }





		[Column] public DateTime ModifiedDate { get; set; }





		[Column] public DateTime? LastLogin { get; set; }





		[Column] public string UserImg { get; set; }



	}


}
