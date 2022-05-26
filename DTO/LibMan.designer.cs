﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibMan")]
	public partial class LibManDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertAccountType(AccountType instance);
    partial void UpdateAccountType(AccountType instance);
    partial void DeleteAccountType(AccountType instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBookType(BookType instance);
    partial void UpdateBookType(BookType instance);
    partial void DeleteBookType(BookType instance);
    #endregion
		
		public LibManDataContext() : 
				base(global::DTO.Properties.Settings.Default.LibManConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibManDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibManDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibManDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibManDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<AccountType> AccountTypes
		{
			get
			{
				return this.GetTable<AccountType>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BookType> BookTypes
		{
			get
			{
				return this.GetTable<BookType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private int _AccountTypeID;
		
		private string _Fullname;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private System.Nullable<bool> _Gender;
		
		private string _UserID;
		
		private string _Address;
		
		private EntityRef<AccountType> _AccountType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAccountTypeIDChanging(int value);
    partial void OnAccountTypeIDChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Account()
		{
			this._AccountType = default(EntityRef<AccountType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeID", DbType="Int NOT NULL")]
		public int AccountTypeID
		{
			get
			{
				return this._AccountTypeID;
			}
			set
			{
				if ((this._AccountTypeID != value))
				{
					if (this._AccountType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountTypeIDChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeID = value;
					this.SendPropertyChanged("AccountTypeID");
					this.OnAccountTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(60)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Char(12)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(200)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_AccountType", ThisKey="AccountTypeID", OtherKey="AccountTypeID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AccountType AccountType
		{
			get
			{
				return this._AccountType.Entity;
			}
			set
			{
				AccountType previousValue = this._AccountType.Entity;
				if (((previousValue != value) 
							|| (this._AccountType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AccountType.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._AccountType.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._AccountTypeID = value.AccountTypeID;
					}
					else
					{
						this._AccountTypeID = default(int);
					}
					this.SendPropertyChanged("AccountType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountType")]
	public partial class AccountType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccountTypeID;
		
		private string _AccountTypeName;
		
		private EntitySet<Account> _Accounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccountTypeIDChanging(int value);
    partial void OnAccountTypeIDChanged();
    partial void OnAccountTypeNameChanging(string value);
    partial void OnAccountTypeNameChanged();
    #endregion
		
		public AccountType()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AccountTypeID
		{
			get
			{
				return this._AccountTypeID;
			}
			set
			{
				if ((this._AccountTypeID != value))
				{
					this.OnAccountTypeIDChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeID = value;
					this.SendPropertyChanged("AccountTypeID");
					this.OnAccountTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeName", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string AccountTypeName
		{
			get
			{
				return this._AccountTypeName;
			}
			set
			{
				if ((this._AccountTypeName != value))
				{
					this.OnAccountTypeNameChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeName = value;
					this.SendPropertyChanged("AccountTypeName");
					this.OnAccountTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_Accounts", ThisKey="AccountTypeID", OtherKey="AccountTypeID")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookID;
		
		private string _BookName;
		
		private System.Nullable<int> _BookTypeID;
		
		private string _Authors;
		
		private string _Publisher;
		
		private System.Nullable<double> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private EntityRef<BookType> _BookType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnBookTypeIDChanging(System.Nullable<int> value);
    partial void OnBookTypeIDChanged();
    partial void OnAuthorsChanging(string value);
    partial void OnAuthorsChanged();
    partial void OnPublisherChanging(string value);
    partial void OnPublisherChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    #endregion
		
		public Book()
		{
			this._BookType = default(EntityRef<BookType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(150)")]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookTypeID", DbType="Int")]
		public System.Nullable<int> BookTypeID
		{
			get
			{
				return this._BookTypeID;
			}
			set
			{
				if ((this._BookTypeID != value))
				{
					if (this._BookType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookTypeIDChanging(value);
					this.SendPropertyChanging();
					this._BookTypeID = value;
					this.SendPropertyChanged("BookTypeID");
					this.OnBookTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Authors", DbType="NVarChar(150)")]
		public string Authors
		{
			get
			{
				return this._Authors;
			}
			set
			{
				if ((this._Authors != value))
				{
					this.OnAuthorsChanging(value);
					this.SendPropertyChanging();
					this._Authors = value;
					this.SendPropertyChanged("Authors");
					this.OnAuthorsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher", DbType="NVarChar(150)")]
		public string Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookType_Book", Storage="_BookType", ThisKey="BookTypeID", OtherKey="BookTypeID", IsForeignKey=true, DeleteRule="SET NULL")]
		public BookType BookType
		{
			get
			{
				return this._BookType.Entity;
			}
			set
			{
				BookType previousValue = this._BookType.Entity;
				if (((previousValue != value) 
							|| (this._BookType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookType.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._BookType.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._BookTypeID = value.BookTypeID;
					}
					else
					{
						this._BookTypeID = default(Nullable<int>);
					}
					this.SendPropertyChanged("BookType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookType")]
	public partial class BookType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookTypeID;
		
		private string _BookTypeName;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookTypeIDChanging(int value);
    partial void OnBookTypeIDChanged();
    partial void OnBookTypeNameChanging(string value);
    partial void OnBookTypeNameChanged();
    #endregion
		
		public BookType()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookTypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BookTypeID
		{
			get
			{
				return this._BookTypeID;
			}
			set
			{
				if ((this._BookTypeID != value))
				{
					this.OnBookTypeIDChanging(value);
					this.SendPropertyChanging();
					this._BookTypeID = value;
					this.SendPropertyChanged("BookTypeID");
					this.OnBookTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookTypeName", DbType="NVarChar(100)")]
		public string BookTypeName
		{
			get
			{
				return this._BookTypeName;
			}
			set
			{
				if ((this._BookTypeName != value))
				{
					this.OnBookTypeNameChanging(value);
					this.SendPropertyChanging();
					this._BookTypeName = value;
					this.SendPropertyChanged("BookTypeName");
					this.OnBookTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookType_Book", Storage="_Books", ThisKey="BookTypeID", OtherKey="BookTypeID")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BookType = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BookType = null;
		}
	}
}
#pragma warning restore 1591
