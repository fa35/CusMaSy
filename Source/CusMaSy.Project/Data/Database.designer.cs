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

namespace CusMaSy.Project.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CusMaSyDb")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnbieter(Anbieter instance);
    partial void UpdateAnbieter(Anbieter instance);
    partial void DeleteAnbieter(Anbieter instance);
    partial void InsertOrt(Ort instance);
    partial void UpdateOrt(Ort instance);
    partial void DeleteOrt(Ort instance);
    partial void InsertAnbieter_Zuordnung(Anbieter_Zuordnung instance);
    partial void UpdateAnbieter_Zuordnung(Anbieter_Zuordnung instance);
    partial void DeleteAnbieter_Zuordnung(Anbieter_Zuordnung instance);
    partial void InsertAnbieterTyp(AnbieterTyp instance);
    partial void UpdateAnbieterTyp(AnbieterTyp instance);
    partial void DeleteAnbieterTyp(AnbieterTyp instance);
    #endregion
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Anbieter> Anbieters
		{
			get
			{
				return this.GetTable<Anbieter>();
			}
		}
		
		public System.Data.Linq.Table<Ort> Orts
		{
			get
			{
				return this.GetTable<Ort>();
			}
		}
		
		public System.Data.Linq.Table<Anbieter_Zuordnung> Anbieter_Zuordnungs
		{
			get
			{
				return this.GetTable<Anbieter_Zuordnung>();
			}
		}
		
		public System.Data.Linq.Table<AnbieterTyp> AnbieterTyps
		{
			get
			{
				return this.GetTable<AnbieterTyp>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Anbieter")]
	public partial class Anbieter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _p_Anbieter_Nr;
		
		private string _Steuernummer;
		
		private int _f_AnbieterTyp_Nr;
		
		private string _Firma;
		
		private string _Strasse;
		
		private string _Hausnummer;
		
		private long _f_Ort_Nr;
		
		private string _Mailadresse;
		
		private string _Telefonnummer;
		
		private string _Homepage;
		
		private string _Branche;
		
		private EntityRef<Ort> _Ort;
		
		private EntityRef<AnbieterTyp> _AnbieterTyp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onp_Anbieter_NrChanging(long value);
    partial void Onp_Anbieter_NrChanged();
    partial void OnSteuernummerChanging(string value);
    partial void OnSteuernummerChanged();
    partial void Onf_AnbieterTyp_NrChanging(int value);
    partial void Onf_AnbieterTyp_NrChanged();
    partial void OnFirmaChanging(string value);
    partial void OnFirmaChanged();
    partial void OnStrasseChanging(string value);
    partial void OnStrasseChanged();
    partial void OnHausnummerChanging(string value);
    partial void OnHausnummerChanged();
    partial void Onf_Ort_NrChanging(long value);
    partial void Onf_Ort_NrChanged();
    partial void OnMailadresseChanging(string value);
    partial void OnMailadresseChanged();
    partial void OnTelefonnummerChanging(string value);
    partial void OnTelefonnummerChanged();
    partial void OnHomepageChanging(string value);
    partial void OnHomepageChanged();
    partial void OnBrancheChanging(string value);
    partial void OnBrancheChanged();
    #endregion
		
		public Anbieter()
		{
			this._Ort = default(EntityRef<Ort>);
			this._AnbieterTyp = default(EntityRef<AnbieterTyp>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_p_Anbieter_Nr", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long p_Anbieter_Nr
		{
			get
			{
				return this._p_Anbieter_Nr;
			}
			set
			{
				if ((this._p_Anbieter_Nr != value))
				{
					this.Onp_Anbieter_NrChanging(value);
					this.SendPropertyChanging();
					this._p_Anbieter_Nr = value;
					this.SendPropertyChanged("p_Anbieter_Nr");
					this.Onp_Anbieter_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Steuernummer", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Steuernummer
		{
			get
			{
				return this._Steuernummer;
			}
			set
			{
				if ((this._Steuernummer != value))
				{
					this.OnSteuernummerChanging(value);
					this.SendPropertyChanging();
					this._Steuernummer = value;
					this.SendPropertyChanged("Steuernummer");
					this.OnSteuernummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_AnbieterTyp_Nr", DbType="Int NOT NULL")]
		public int f_AnbieterTyp_Nr
		{
			get
			{
				return this._f_AnbieterTyp_Nr;
			}
			set
			{
				if ((this._f_AnbieterTyp_Nr != value))
				{
					if (this._AnbieterTyp.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onf_AnbieterTyp_NrChanging(value);
					this.SendPropertyChanging();
					this._f_AnbieterTyp_Nr = value;
					this.SendPropertyChanged("f_AnbieterTyp_Nr");
					this.Onf_AnbieterTyp_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Firma
		{
			get
			{
				return this._Firma;
			}
			set
			{
				if ((this._Firma != value))
				{
					this.OnFirmaChanging(value);
					this.SendPropertyChanging();
					this._Firma = value;
					this.SendPropertyChanged("Firma");
					this.OnFirmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Strasse", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Strasse
		{
			get
			{
				return this._Strasse;
			}
			set
			{
				if ((this._Strasse != value))
				{
					this.OnStrasseChanging(value);
					this.SendPropertyChanging();
					this._Strasse = value;
					this.SendPropertyChanged("Strasse");
					this.OnStrasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hausnummer", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Hausnummer
		{
			get
			{
				return this._Hausnummer;
			}
			set
			{
				if ((this._Hausnummer != value))
				{
					this.OnHausnummerChanging(value);
					this.SendPropertyChanging();
					this._Hausnummer = value;
					this.SendPropertyChanged("Hausnummer");
					this.OnHausnummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_Ort_Nr", DbType="BigInt NOT NULL")]
		public long f_Ort_Nr
		{
			get
			{
				return this._f_Ort_Nr;
			}
			set
			{
				if ((this._f_Ort_Nr != value))
				{
					if (this._Ort.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onf_Ort_NrChanging(value);
					this.SendPropertyChanging();
					this._f_Ort_Nr = value;
					this.SendPropertyChanged("f_Ort_Nr");
					this.Onf_Ort_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mailadresse", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Mailadresse
		{
			get
			{
				return this._Mailadresse;
			}
			set
			{
				if ((this._Mailadresse != value))
				{
					this.OnMailadresseChanging(value);
					this.SendPropertyChanging();
					this._Mailadresse = value;
					this.SendPropertyChanged("Mailadresse");
					this.OnMailadresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefonnummer", DbType="VarChar(200)")]
		public string Telefonnummer
		{
			get
			{
				return this._Telefonnummer;
			}
			set
			{
				if ((this._Telefonnummer != value))
				{
					this.OnTelefonnummerChanging(value);
					this.SendPropertyChanging();
					this._Telefonnummer = value;
					this.SendPropertyChanged("Telefonnummer");
					this.OnTelefonnummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Homepage", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Homepage
		{
			get
			{
				return this._Homepage;
			}
			set
			{
				if ((this._Homepage != value))
				{
					this.OnHomepageChanging(value);
					this.SendPropertyChanging();
					this._Homepage = value;
					this.SendPropertyChanged("Homepage");
					this.OnHomepageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Branche", DbType="VarChar(200)")]
		public string Branche
		{
			get
			{
				return this._Branche;
			}
			set
			{
				if ((this._Branche != value))
				{
					this.OnBrancheChanging(value);
					this.SendPropertyChanging();
					this._Branche = value;
					this.SendPropertyChanged("Branche");
					this.OnBrancheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ort_Anbieter", Storage="_Ort", ThisKey="f_Ort_Nr", OtherKey="p_Ort_Nr", IsForeignKey=true)]
		public Ort Ort
		{
			get
			{
				return this._Ort.Entity;
			}
			set
			{
				Ort previousValue = this._Ort.Entity;
				if (((previousValue != value) 
							|| (this._Ort.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ort.Entity = null;
						previousValue.Anbieters.Remove(this);
					}
					this._Ort.Entity = value;
					if ((value != null))
					{
						value.Anbieters.Add(this);
						this._f_Ort_Nr = value.p_Ort_Nr;
					}
					else
					{
						this._f_Ort_Nr = default(long);
					}
					this.SendPropertyChanged("Ort");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AnbieterTyp_Anbieter", Storage="_AnbieterTyp", ThisKey="f_AnbieterTyp_Nr", OtherKey="p_AnbieterTyp_Nr", IsForeignKey=true)]
		public AnbieterTyp AnbieterTyp
		{
			get
			{
				return this._AnbieterTyp.Entity;
			}
			set
			{
				AnbieterTyp previousValue = this._AnbieterTyp.Entity;
				if (((previousValue != value) 
							|| (this._AnbieterTyp.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AnbieterTyp.Entity = null;
						previousValue.Anbieters.Remove(this);
					}
					this._AnbieterTyp.Entity = value;
					if ((value != null))
					{
						value.Anbieters.Add(this);
						this._f_AnbieterTyp_Nr = value.p_AnbieterTyp_Nr;
					}
					else
					{
						this._f_AnbieterTyp_Nr = default(int);
					}
					this.SendPropertyChanged("AnbieterTyp");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ort")]
	public partial class Ort : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _p_Ort_Nr;
		
		private int _PLZ;
		
		private string _Ort1;
		
		private string _Land;
		
		private EntitySet<Anbieter> _Anbieters;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onp_Ort_NrChanging(long value);
    partial void Onp_Ort_NrChanged();
    partial void OnPLZChanging(int value);
    partial void OnPLZChanged();
    partial void OnOrt1Changing(string value);
    partial void OnOrt1Changed();
    partial void OnLandChanging(string value);
    partial void OnLandChanged();
    #endregion
		
		public Ort()
		{
			this._Anbieters = new EntitySet<Anbieter>(new Action<Anbieter>(this.attach_Anbieters), new Action<Anbieter>(this.detach_Anbieters));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_p_Ort_Nr", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long p_Ort_Nr
		{
			get
			{
				return this._p_Ort_Nr;
			}
			set
			{
				if ((this._p_Ort_Nr != value))
				{
					this.Onp_Ort_NrChanging(value);
					this.SendPropertyChanging();
					this._p_Ort_Nr = value;
					this.SendPropertyChanged("p_Ort_Nr");
					this.Onp_Ort_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLZ", DbType="Int NOT NULL")]
		public int PLZ
		{
			get
			{
				return this._PLZ;
			}
			set
			{
				if ((this._PLZ != value))
				{
					this.OnPLZChanging(value);
					this.SendPropertyChanging();
					this._PLZ = value;
					this.SendPropertyChanged("PLZ");
					this.OnPLZChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ort", Storage="_Ort1", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Ort1
		{
			get
			{
				return this._Ort1;
			}
			set
			{
				if ((this._Ort1 != value))
				{
					this.OnOrt1Changing(value);
					this.SendPropertyChanging();
					this._Ort1 = value;
					this.SendPropertyChanged("Ort1");
					this.OnOrt1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Land", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Land
		{
			get
			{
				return this._Land;
			}
			set
			{
				if ((this._Land != value))
				{
					this.OnLandChanging(value);
					this.SendPropertyChanging();
					this._Land = value;
					this.SendPropertyChanged("Land");
					this.OnLandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ort_Anbieter", Storage="_Anbieters", ThisKey="p_Ort_Nr", OtherKey="f_Ort_Nr")]
		public EntitySet<Anbieter> Anbieters
		{
			get
			{
				return this._Anbieters;
			}
			set
			{
				this._Anbieters.Assign(value);
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
		
		private void attach_Anbieters(Anbieter entity)
		{
			this.SendPropertyChanging();
			entity.Ort = this;
		}
		
		private void detach_Anbieters(Anbieter entity)
		{
			this.SendPropertyChanging();
			entity.Ort = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Anbieter_Zuordnung")]
	public partial class Anbieter_Zuordnung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _pf_HostAnbieter_Nr;
		
		private long _pf_ClientAnbieter_Nr;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpf_HostAnbieter_NrChanging(long value);
    partial void Onpf_HostAnbieter_NrChanged();
    partial void Onpf_ClientAnbieter_NrChanging(long value);
    partial void Onpf_ClientAnbieter_NrChanged();
    #endregion
		
		public Anbieter_Zuordnung()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pf_HostAnbieter_Nr", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long pf_HostAnbieter_Nr
		{
			get
			{
				return this._pf_HostAnbieter_Nr;
			}
			set
			{
				if ((this._pf_HostAnbieter_Nr != value))
				{
					this.Onpf_HostAnbieter_NrChanging(value);
					this.SendPropertyChanging();
					this._pf_HostAnbieter_Nr = value;
					this.SendPropertyChanged("pf_HostAnbieter_Nr");
					this.Onpf_HostAnbieter_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pf_ClientAnbieter_Nr", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long pf_ClientAnbieter_Nr
		{
			get
			{
				return this._pf_ClientAnbieter_Nr;
			}
			set
			{
				if ((this._pf_ClientAnbieter_Nr != value))
				{
					this.Onpf_ClientAnbieter_NrChanging(value);
					this.SendPropertyChanging();
					this._pf_ClientAnbieter_Nr = value;
					this.SendPropertyChanged("pf_ClientAnbieter_Nr");
					this.Onpf_ClientAnbieter_NrChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AnbieterTyp")]
	public partial class AnbieterTyp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _p_AnbieterTyp_Nr;
		
		private string _Bezeichnung;
		
		private EntitySet<Anbieter> _Anbieters;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onp_AnbieterTyp_NrChanging(int value);
    partial void Onp_AnbieterTyp_NrChanged();
    partial void OnBezeichnungChanging(string value);
    partial void OnBezeichnungChanged();
    #endregion
		
		public AnbieterTyp()
		{
			this._Anbieters = new EntitySet<Anbieter>(new Action<Anbieter>(this.attach_Anbieters), new Action<Anbieter>(this.detach_Anbieters));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_p_AnbieterTyp_Nr", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int p_AnbieterTyp_Nr
		{
			get
			{
				return this._p_AnbieterTyp_Nr;
			}
			set
			{
				if ((this._p_AnbieterTyp_Nr != value))
				{
					this.Onp_AnbieterTyp_NrChanging(value);
					this.SendPropertyChanging();
					this._p_AnbieterTyp_Nr = value;
					this.SendPropertyChanged("p_AnbieterTyp_Nr");
					this.Onp_AnbieterTyp_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bezeichnung", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Bezeichnung
		{
			get
			{
				return this._Bezeichnung;
			}
			set
			{
				if ((this._Bezeichnung != value))
				{
					this.OnBezeichnungChanging(value);
					this.SendPropertyChanging();
					this._Bezeichnung = value;
					this.SendPropertyChanged("Bezeichnung");
					this.OnBezeichnungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AnbieterTyp_Anbieter", Storage="_Anbieters", ThisKey="p_AnbieterTyp_Nr", OtherKey="f_AnbieterTyp_Nr")]
		public EntitySet<Anbieter> Anbieters
		{
			get
			{
				return this._Anbieters;
			}
			set
			{
				this._Anbieters.Assign(value);
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
		
		private void attach_Anbieters(Anbieter entity)
		{
			this.SendPropertyChanging();
			entity.AnbieterTyp = this;
		}
		
		private void detach_Anbieters(Anbieter entity)
		{
			this.SendPropertyChanging();
			entity.AnbieterTyp = null;
		}
	}
}
#pragma warning restore 1591
