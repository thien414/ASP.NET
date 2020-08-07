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

namespace DA_ASP.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBanDienThoai")]
	public partial class dbBanDTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDONHANG(DONHANG instance);
    partial void UpdateDONHANG(DONHANG instance);
    partial void DeleteDONHANG(DONHANG instance);
    partial void InsertTKKHACHHANG(TKKHACHHANG instance);
    partial void UpdateTKKHACHHANG(TKKHACHHANG instance);
    partial void DeleteTKKHACHHANG(TKKHACHHANG instance);
    partial void InsertNHASX(NHASX instance);
    partial void UpdateNHASX(NHASX instance);
    partial void DeleteNHASX(NHASX instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertTKADMIN(TKADMIN instance);
    partial void UpdateTKADMIN(TKADMIN instance);
    partial void DeleteTKADMIN(TKADMIN instance);
    #endregion
		
		public dbBanDTDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBanDienThoaiConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbBanDTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbBanDTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbBanDTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbBanDTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DONHANG> DONHANGs
		{
			get
			{
				return this.GetTable<DONHANG>();
			}
		}
		
		public System.Data.Linq.Table<TKKHACHHANG> TKKHACHHANGs
		{
			get
			{
				return this.GetTable<TKKHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<NHASX> NHASXes
		{
			get
			{
				return this.GetTable<NHASX>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<TKADMIN> TKADMINs
		{
			get
			{
				return this.GetTable<TKADMIN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONHANG")]
	public partial class DONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDH;
		
		private string _NgayGiao;
		
		private string _NgayDat;
		
		private string _ThanhToan;
		
		private System.Nullable<int> _MaUser;
		
		private System.Nullable<int> _MaSP;
		
		private System.Nullable<int> _MaTK;
		
		private EntityRef<TKKHACHHANG> _TKKHACHHANG;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
		private EntityRef<TKADMIN> _TKADMIN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(string value);
    partial void OnMaDHChanged();
    partial void OnNgayGiaoChanging(string value);
    partial void OnNgayGiaoChanged();
    partial void OnNgayDatChanging(string value);
    partial void OnNgayDatChanged();
    partial void OnThanhToanChanging(string value);
    partial void OnThanhToanChanged();
    partial void OnMaUserChanging(System.Nullable<int> value);
    partial void OnMaUserChanged();
    partial void OnMaSPChanging(System.Nullable<int> value);
    partial void OnMaSPChanged();
    partial void OnMaTKChanging(System.Nullable<int> value);
    partial void OnMaTKChanged();
    #endregion
		
		public DONHANG()
		{
			this._TKKHACHHANG = default(EntityRef<TKKHACHHANG>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			this._TKADMIN = default(EntityRef<TKADMIN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhToan", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ThanhToan
		{
			get
			{
				return this._ThanhToan;
			}
			set
			{
				if ((this._ThanhToan != value))
				{
					this.OnThanhToanChanging(value);
					this.SendPropertyChanging();
					this._ThanhToan = value;
					this.SendPropertyChanged("ThanhToan");
					this.OnThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaUser", DbType="Int")]
		public System.Nullable<int> MaUser
		{
			get
			{
				return this._MaUser;
			}
			set
			{
				if ((this._MaUser != value))
				{
					if (this._TKKHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaUserChanging(value);
					this.SendPropertyChanging();
					this._MaUser = value;
					this.SendPropertyChanged("MaUser");
					this.OnMaUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int")]
		public System.Nullable<int> MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTK", DbType="Int")]
		public System.Nullable<int> MaTK
		{
			get
			{
				return this._MaTK;
			}
			set
			{
				if ((this._MaTK != value))
				{
					if (this._TKADMIN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTKChanging(value);
					this.SendPropertyChanging();
					this._MaTK = value;
					this.SendPropertyChanged("MaTK");
					this.OnMaTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TKKHACHHANG_DONHANG", Storage="_TKKHACHHANG", ThisKey="MaUser", OtherKey="MaUser", IsForeignKey=true)]
		public TKKHACHHANG TKKHACHHANG
		{
			get
			{
				return this._TKKHACHHANG.Entity;
			}
			set
			{
				TKKHACHHANG previousValue = this._TKKHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._TKKHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TKKHACHHANG.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._TKKHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._MaUser = value.MaUser;
					}
					else
					{
						this._MaUser = default(Nullable<int>);
					}
					this.SendPropertyChanged("TKKHACHHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_DONHANG", Storage="_SANPHAM", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TKADMIN_DONHANG", Storage="_TKADMIN", ThisKey="MaTK", OtherKey="MaTK", IsForeignKey=true)]
		public TKADMIN TKADMIN
		{
			get
			{
				return this._TKADMIN.Entity;
			}
			set
			{
				TKADMIN previousValue = this._TKADMIN.Entity;
				if (((previousValue != value) 
							|| (this._TKADMIN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TKADMIN.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._TKADMIN.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._MaTK = value.MaTK;
					}
					else
					{
						this._MaTK = default(Nullable<int>);
					}
					this.SendPropertyChanged("TKADMIN");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TKKHACHHANG")]
	public partial class TKKHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaUser;
		
		private string _TenUser;
		
		private string _SDTUser;
		
		private string _NgaySinh;
		
		private string _MKUser;
		
		private string _Email;
		
		private string _DiaChi;
		
		private EntitySet<DONHANG> _DONHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaUserChanging(int value);
    partial void OnMaUserChanged();
    partial void OnTenUserChanging(string value);
    partial void OnTenUserChanged();
    partial void OnSDTUserChanging(string value);
    partial void OnSDTUserChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnMKUserChanging(string value);
    partial void OnMKUserChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public TKKHACHHANG()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaUser", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaUser
		{
			get
			{
				return this._MaUser;
			}
			set
			{
				if ((this._MaUser != value))
				{
					this.OnMaUserChanging(value);
					this.SendPropertyChanging();
					this._MaUser = value;
					this.SendPropertyChanged("MaUser");
					this.OnMaUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenUser", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string TenUser
		{
			get
			{
				return this._TenUser;
			}
			set
			{
				if ((this._TenUser != value))
				{
					this.OnTenUserChanging(value);
					this.SendPropertyChanging();
					this._TenUser = value;
					this.SendPropertyChanged("TenUser");
					this.OnTenUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTUser", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string SDTUser
		{
			get
			{
				return this._SDTUser;
			}
			set
			{
				if ((this._SDTUser != value))
				{
					this.OnSDTUserChanging(value);
					this.SendPropertyChanging();
					this._SDTUser = value;
					this.SendPropertyChanged("SDTUser");
					this.OnSDTUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MKUser", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MKUser
		{
			get
			{
				return this._MKUser;
			}
			set
			{
				if ((this._MKUser != value))
				{
					this.OnMKUserChanging(value);
					this.SendPropertyChanging();
					this._MKUser = value;
					this.SendPropertyChanged("MKUser");
					this.OnMKUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TKKHACHHANG_DONHANG", Storage="_DONHANGs", ThisKey="MaUser", OtherKey="MaUser")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
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
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TKKHACHHANG = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TKKHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHASX")]
	public partial class NHASX : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSX;
		
		private string _TenSX;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSXChanging(string value);
    partial void OnMaSXChanged();
    partial void OnTenSXChanging(string value);
    partial void OnTenSXChanged();
    #endregion
		
		public NHASX()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSX", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSX
		{
			get
			{
				return this._MaSX;
			}
			set
			{
				if ((this._MaSX != value))
				{
					this.OnMaSXChanging(value);
					this.SendPropertyChanging();
					this._MaSX = value;
					this.SendPropertyChanged("MaSX");
					this.OnMaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSX", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSX
		{
			get
			{
				return this._TenSX;
			}
			set
			{
				if ((this._TenSX != value))
				{
					this.OnTenSXChanging(value);
					this.SendPropertyChanging();
					this._TenSX = value;
					this.SendPropertyChanged("TenSX");
					this.OnTenSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHASX_SANPHAM", Storage="_SANPHAMs", ThisKey="MaSX", OtherKey="MaSX")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHASX = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHASX = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<decimal> _GiaCu;
		
		private System.Nullable<decimal> _GiaMoi;
		
		private string _ThongSoSP;
		
		private string _ChiTietSP;
		
		private string _ImgSP;
		
		private string _ImgSP1;
		
		private string _ImgSP2;
		
		private string _ImgSP3;
		
		private string _MaSX;
		
		private EntitySet<DONHANG> _DONHANGs;
		
		private EntityRef<NHASX> _NHASX;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiaCuChanging(System.Nullable<decimal> value);
    partial void OnGiaCuChanged();
    partial void OnGiaMoiChanging(System.Nullable<decimal> value);
    partial void OnGiaMoiChanged();
    partial void OnThongSoSPChanging(string value);
    partial void OnThongSoSPChanged();
    partial void OnChiTietSPChanging(string value);
    partial void OnChiTietSPChanged();
    partial void OnImgSPChanging(string value);
    partial void OnImgSPChanged();
    partial void OnImgSP1Changing(string value);
    partial void OnImgSP1Changed();
    partial void OnImgSP2Changing(string value);
    partial void OnImgSP2Changed();
    partial void OnImgSP3Changing(string value);
    partial void OnImgSP3Changed();
    partial void OnMaSXChanging(string value);
    partial void OnMaSXChanged();
    #endregion
		
		public SANPHAM()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			this._NHASX = default(EntityRef<NHASX>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaCu", DbType="Money")]
		public System.Nullable<decimal> GiaCu
		{
			get
			{
				return this._GiaCu;
			}
			set
			{
				if ((this._GiaCu != value))
				{
					this.OnGiaCuChanging(value);
					this.SendPropertyChanging();
					this._GiaCu = value;
					this.SendPropertyChanged("GiaCu");
					this.OnGiaCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaMoi", DbType="Money")]
		public System.Nullable<decimal> GiaMoi
		{
			get
			{
				return this._GiaMoi;
			}
			set
			{
				if ((this._GiaMoi != value))
				{
					this.OnGiaMoiChanging(value);
					this.SendPropertyChanging();
					this._GiaMoi = value;
					this.SendPropertyChanged("GiaMoi");
					this.OnGiaMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThongSoSP", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ThongSoSP
		{
			get
			{
				return this._ThongSoSP;
			}
			set
			{
				if ((this._ThongSoSP != value))
				{
					this.OnThongSoSPChanging(value);
					this.SendPropertyChanging();
					this._ThongSoSP = value;
					this.SendPropertyChanged("ThongSoSP");
					this.OnThongSoSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiTietSP", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ChiTietSP
		{
			get
			{
				return this._ChiTietSP;
			}
			set
			{
				if ((this._ChiTietSP != value))
				{
					this.OnChiTietSPChanging(value);
					this.SendPropertyChanging();
					this._ChiTietSP = value;
					this.SendPropertyChanged("ChiTietSP");
					this.OnChiTietSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgSP", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImgSP
		{
			get
			{
				return this._ImgSP;
			}
			set
			{
				if ((this._ImgSP != value))
				{
					this.OnImgSPChanging(value);
					this.SendPropertyChanging();
					this._ImgSP = value;
					this.SendPropertyChanged("ImgSP");
					this.OnImgSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgSP1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImgSP1
		{
			get
			{
				return this._ImgSP1;
			}
			set
			{
				if ((this._ImgSP1 != value))
				{
					this.OnImgSP1Changing(value);
					this.SendPropertyChanging();
					this._ImgSP1 = value;
					this.SendPropertyChanged("ImgSP1");
					this.OnImgSP1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgSP2", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImgSP2
		{
			get
			{
				return this._ImgSP2;
			}
			set
			{
				if ((this._ImgSP2 != value))
				{
					this.OnImgSP2Changing(value);
					this.SendPropertyChanging();
					this._ImgSP2 = value;
					this.SendPropertyChanged("ImgSP2");
					this.OnImgSP2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgSP3", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImgSP3
		{
			get
			{
				return this._ImgSP3;
			}
			set
			{
				if ((this._ImgSP3 != value))
				{
					this.OnImgSP3Changing(value);
					this.SendPropertyChanging();
					this._ImgSP3 = value;
					this.SendPropertyChanged("ImgSP3");
					this.OnImgSP3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSX", DbType="VarChar(10)")]
		public string MaSX
		{
			get
			{
				return this._MaSX;
			}
			set
			{
				if ((this._MaSX != value))
				{
					if (this._NHASX.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSXChanging(value);
					this.SendPropertyChanging();
					this._MaSX = value;
					this.SendPropertyChanged("MaSX");
					this.OnMaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_DONHANG", Storage="_DONHANGs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHASX_SANPHAM", Storage="_NHASX", ThisKey="MaSX", OtherKey="MaSX", IsForeignKey=true)]
		public NHASX NHASX
		{
			get
			{
				return this._NHASX.Entity;
			}
			set
			{
				NHASX previousValue = this._NHASX.Entity;
				if (((previousValue != value) 
							|| (this._NHASX.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHASX.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NHASX.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaSX = value.MaSX;
					}
					else
					{
						this._MaSX = default(string);
					}
					this.SendPropertyChanged("NHASX");
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
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TKADMIN")]
	public partial class TKADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTK;
		
		private string _TenTK;
		
		private string _MatKhau;
		
		private System.Nullable<bool> _IsDelete;
		
		private EntitySet<DONHANG> _DONHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTKChanging(int value);
    partial void OnMaTKChanged();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnIsDeleteChanging(System.Nullable<bool> value);
    partial void OnIsDeleteChanged();
    #endregion
		
		public TKADMIN()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTK
		{
			get
			{
				return this._MaTK;
			}
			set
			{
				if ((this._MaTK != value))
				{
					this.OnMaTKChanging(value);
					this.SendPropertyChanging();
					this._MaTK = value;
					this.SendPropertyChanged("MaTK");
					this.OnMaTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDelete", DbType="Bit")]
		public System.Nullable<bool> IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TKADMIN_DONHANG", Storage="_DONHANGs", ThisKey="MaTK", OtherKey="MaTK")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
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
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TKADMIN = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TKADMIN = null;
		}
	}
}
#pragma warning restore 1591
