﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSOTestClientApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SSOSampleDB")]
	public partial class SSOClient1DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public SSOClient1DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SSOSampleDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SSOClient1DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SSOClient1DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SSOClient1DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SSOClient1DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Client1Credentail> Client1Credentails
		{
			get
			{
				return this.GetTable<Client1Credentail>();
			}
		}
		
		public System.Data.Linq.Table<Client1Map> Client1Maps
		{
			get
			{
				return this.GetTable<Client1Map>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client1Credentail")]
	public partial class Client1Credentail
	{
		
		private string _UserId;
		
		private string _Password;
		
		public Client1Credentail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
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
					this._Password = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client1Map")]
	public partial class Client1Map
	{
		
		private string _MainAppUserId;
		
		private string _C1AppUserId;
		
		public Client1Map()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainAppUserId", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MainAppUserId
		{
			get
			{
				return this._MainAppUserId;
			}
			set
			{
				if ((this._MainAppUserId != value))
				{
					this._MainAppUserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C1AppUserId", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string C1AppUserId
		{
			get
			{
				return this._C1AppUserId;
			}
			set
			{
				if ((this._C1AppUserId != value))
				{
					this._C1AppUserId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591