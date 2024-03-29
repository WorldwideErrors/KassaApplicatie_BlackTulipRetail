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

namespace KassaApplicatie
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbBlackTulip")]
	public partial class DatabaseBTRDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertproducttype(producttype instance);
    partial void Updateproducttype(producttype instance);
    partial void Deleteproducttype(producttype instance);
    partial void Insertitemsinorder(itemsinorder instance);
    partial void Updateitemsinorder(itemsinorder instance);
    partial void Deleteitemsinorder(itemsinorder instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    partial void Insertpricehistory(pricehistory instance);
    partial void Updatepricehistory(pricehistory instance);
    partial void Deletepricehistory(pricehistory instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    #endregion
		
		public DatabaseBTRDataContext() : 
				base(global::KassaApplicatie.Properties.Settings.Default.dbBlackTulipConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseBTRDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseBTRDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseBTRDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseBTRDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<producttype> producttypes
		{
			get
			{
				return this.GetTable<producttype>();
			}
		}
		
		public System.Data.Linq.Table<itemsinorder> itemsinorders
		{
			get
			{
				return this.GetTable<itemsinorder>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
		
		public System.Data.Linq.Table<pricehistory> pricehistories
		{
			get
			{
				return this.GetTable<pricehistory>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customers")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _firstname;
		
		private string _lastname;
		
		private string _city;
		
		private string _phonenumber;
		
		private string _email;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnphonenumberChanging(string value);
    partial void OnphonenumberChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public customer()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phonenumber", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if ((this._phonenumber != value))
				{
					this.OnphonenumberChanging(value);
					this.SendPropertyChanging();
					this._phonenumber = value;
					this.SendPropertyChanged("phonenumber");
					this.OnphonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_order", Storage="_orders", ThisKey="id", OtherKey="customerId")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
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
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.producttypes")]
	public partial class producttype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _type;
		
		private EntitySet<product> _products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    #endregion
		
		public producttype()
		{
			this._products = new EntitySet<product>(new Action<product>(this.attach_products), new Action<product>(this.detach_products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttype_product", Storage="_products", ThisKey="id", OtherKey="producttypeId")]
		public EntitySet<product> products
		{
			get
			{
				return this._products;
			}
			set
			{
				this._products.Assign(value);
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
		
		private void attach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttype = this;
		}
		
		private void detach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttype = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.itemsinorder")]
	public partial class itemsinorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _amount;
		
		private int _orderId;
		
		private int _productId;
		
		private EntityRef<order> _order;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    partial void OnorderIdChanging(int value);
    partial void OnorderIdChanged();
    partial void OnproductIdChanging(int value);
    partial void OnproductIdChanged();
    #endregion
		
		public itemsinorder()
		{
			this._order = default(EntityRef<order>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderId", DbType="Int NOT NULL")]
		public int orderId
		{
			get
			{
				return this._orderId;
			}
			set
			{
				if ((this._orderId != value))
				{
					if (this._order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderIdChanging(value);
					this.SendPropertyChanging();
					this._orderId = value;
					this.SendPropertyChanged("orderId");
					this.OnorderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", DbType="Int NOT NULL")]
		public int productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_itemsinorder", Storage="_order", ThisKey="orderId", OtherKey="id", IsForeignKey=true)]
		public order order
		{
			get
			{
				return this._order.Entity;
			}
			set
			{
				order previousValue = this._order.Entity;
				if (((previousValue != value) 
							|| (this._order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._order.Entity = null;
						previousValue.itemsinorders.Remove(this);
					}
					this._order.Entity = value;
					if ((value != null))
					{
						value.itemsinorders.Add(this);
						this._orderId = value.id;
					}
					else
					{
						this._orderId = default(int);
					}
					this.SendPropertyChanged("order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_itemsinorder", Storage="_product", ThisKey="productId", OtherKey="id", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.itemsinorders.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.itemsinorders.Add(this);
						this._productId = value.id;
					}
					else
					{
						this._productId = default(int);
					}
					this.SendPropertyChanged("product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _date;
		
		private int _customerId;
		
		private EntitySet<itemsinorder> _itemsinorders;
		
		private EntityRef<customer> _customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OncustomerIdChanging(int value);
    partial void OncustomerIdChanged();
    #endregion
		
		public order()
		{
			this._itemsinorders = new EntitySet<itemsinorder>(new Action<itemsinorder>(this.attach_itemsinorders), new Action<itemsinorder>(this.detach_itemsinorders));
			this._customer = default(EntityRef<customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerId", DbType="Int NOT NULL")]
		public int customerId
		{
			get
			{
				return this._customerId;
			}
			set
			{
				if ((this._customerId != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncustomerIdChanging(value);
					this.SendPropertyChanging();
					this._customerId = value;
					this.SendPropertyChanged("customerId");
					this.OncustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_itemsinorder", Storage="_itemsinorders", ThisKey="id", OtherKey="orderId")]
		public EntitySet<itemsinorder> itemsinorders
		{
			get
			{
				return this._itemsinorders;
			}
			set
			{
				this._itemsinorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_order", Storage="_customer", ThisKey="customerId", OtherKey="id", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._customerId = value.id;
					}
					else
					{
						this._customerId = default(int);
					}
					this.SendPropertyChanged("customer");
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
		
		private void attach_itemsinorders(itemsinorder entity)
		{
			this.SendPropertyChanging();
			entity.order = this;
		}
		
		private void detach_itemsinorders(itemsinorder entity)
		{
			this.SendPropertyChanging();
			entity.order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pricehistories")]
	public partial class pricehistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _startdate;
		
		private System.Nullable<System.DateTime> _enddate;
		
		private decimal _price;
		
		private int _productId;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnstartdateChanging(System.DateTime value);
    partial void OnstartdateChanged();
    partial void OnenddateChanging(System.Nullable<System.DateTime> value);
    partial void OnenddateChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnproductIdChanging(int value);
    partial void OnproductIdChanged();
    #endregion
		
		public pricehistory()
		{
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startdate", DbType="Date NOT NULL")]
		public System.DateTime startdate
		{
			get
			{
				return this._startdate;
			}
			set
			{
				if ((this._startdate != value))
				{
					this.OnstartdateChanging(value);
					this.SendPropertyChanging();
					this._startdate = value;
					this.SendPropertyChanged("startdate");
					this.OnstartdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enddate", DbType="Date")]
		public System.Nullable<System.DateTime> enddate
		{
			get
			{
				return this._enddate;
			}
			set
			{
				if ((this._enddate != value))
				{
					this.OnenddateChanging(value);
					this.SendPropertyChanging();
					this._enddate = value;
					this.SendPropertyChanged("enddate");
					this.OnenddateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", DbType="Int NOT NULL")]
		public int productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_pricehistory", Storage="_product", ThisKey="productId", OtherKey="id", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.pricehistories.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.pricehistories.Add(this);
						this._productId = value.id;
					}
					else
					{
						this._productId = default(int);
					}
					this.SendPropertyChanged("product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.products")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private int _producttypeId;
		
		private EntitySet<itemsinorder> _itemsinorders;
		
		private EntitySet<pricehistory> _pricehistories;
		
		private EntityRef<producttype> _producttype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnproducttypeIdChanging(int value);
    partial void OnproducttypeIdChanged();
    #endregion
		
		public product()
		{
			this._itemsinorders = new EntitySet<itemsinorder>(new Action<itemsinorder>(this.attach_itemsinorders), new Action<itemsinorder>(this.detach_itemsinorders));
			this._pricehistories = new EntitySet<pricehistory>(new Action<pricehistory>(this.attach_pricehistories), new Action<pricehistory>(this.detach_pricehistories));
			this._producttype = default(EntityRef<producttype>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producttypeId", DbType="Int NOT NULL")]
		public int producttypeId
		{
			get
			{
				return this._producttypeId;
			}
			set
			{
				if ((this._producttypeId != value))
				{
					if (this._producttype.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproducttypeIdChanging(value);
					this.SendPropertyChanging();
					this._producttypeId = value;
					this.SendPropertyChanged("producttypeId");
					this.OnproducttypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_itemsinorder", Storage="_itemsinorders", ThisKey="id", OtherKey="productId")]
		public EntitySet<itemsinorder> itemsinorders
		{
			get
			{
				return this._itemsinorders;
			}
			set
			{
				this._itemsinorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_pricehistory", Storage="_pricehistories", ThisKey="id", OtherKey="productId")]
		public EntitySet<pricehistory> pricehistories
		{
			get
			{
				return this._pricehistories;
			}
			set
			{
				this._pricehistories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttype_product", Storage="_producttype", ThisKey="producttypeId", OtherKey="id", IsForeignKey=true)]
		public producttype producttype
		{
			get
			{
				return this._producttype.Entity;
			}
			set
			{
				producttype previousValue = this._producttype.Entity;
				if (((previousValue != value) 
							|| (this._producttype.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._producttype.Entity = null;
						previousValue.products.Remove(this);
					}
					this._producttype.Entity = value;
					if ((value != null))
					{
						value.products.Add(this);
						this._producttypeId = value.id;
					}
					else
					{
						this._producttypeId = default(int);
					}
					this.SendPropertyChanged("producttype");
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
		
		private void attach_itemsinorders(itemsinorder entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_itemsinorders(itemsinorder entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
		
		private void attach_pricehistories(pricehistory entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_pricehistories(pricehistory entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
}
#pragma warning restore 1591
