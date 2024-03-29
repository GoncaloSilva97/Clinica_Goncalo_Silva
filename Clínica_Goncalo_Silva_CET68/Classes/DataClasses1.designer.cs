﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clínica_Goncalo_Silva_CET68.Classes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ClinicaVeterinaria")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnimais(Animais instance);
    partial void UpdateAnimais(Animais instance);
    partial void DeleteAnimais(Animais instance);
    partial void InsertConsultas(Consultas instance);
    partial void UpdateConsultas(Consultas instance);
    partial void DeleteConsultas(Consultas instance);
    partial void InsertDonos(Donos instance);
    partial void UpdateDonos(Donos instance);
    partial void DeleteDonos(Donos instance);
    partial void InsertMedicos(Medicos instance);
    partial void UpdateMedicos(Medicos instance);
    partial void DeleteMedicos(Medicos instance);
    partial void InsertSalas(Salas instance);
    partial void UpdateSalas(Salas instance);
    partial void DeleteSalas(Salas instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Clínica_Goncalo_Silva_CET68.Properties.Settings.Default.ClinicaVeterinariaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Animais> Animais
		{
			get
			{
				return this.GetTable<Animais>();
			}
		}
		
		public System.Data.Linq.Table<Consultas> Consultas
		{
			get
			{
				return this.GetTable<Consultas>();
			}
		}
		
		public System.Data.Linq.Table<Donos> Donos
		{
			get
			{
				return this.GetTable<Donos>();
			}
		}
		
		public System.Data.Linq.Table<Medicos> Medicos
		{
			get
			{
				return this.GetTable<Medicos>();
			}
		}
		
		public System.Data.Linq.Table<Salas> Salas
		{
			get
			{
				return this.GetTable<Salas>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animais")]
	public partial class Animais : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NomeAnimal;
		
		private string _EspecieRaça;
		
		private int _IDChip;
		
		private System.DateTime _DataNascimento;
		
		private int _IDdono;
		
		private EntitySet<Consultas> _Consultas;
		
		private EntityRef<Donos> _Donos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNomeAnimalChanging(string value);
    partial void OnNomeAnimalChanged();
    partial void OnEspecieRaçaChanging(string value);
    partial void OnEspecieRaçaChanged();
    partial void OnIDChipChanging(int value);
    partial void OnIDChipChanged();
    partial void OnDataNascimentoChanging(System.DateTime value);
    partial void OnDataNascimentoChanged();
    partial void OnIDdonoChanging(int value);
    partial void OnIDdonoChanged();
    #endregion
		
		public Animais()
		{
			this._Consultas = new EntitySet<Consultas>(new Action<Consultas>(this.attach_Consultas), new Action<Consultas>(this.detach_Consultas));
			this._Donos = default(EntityRef<Donos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomeAnimal", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string NomeAnimal
		{
			get
			{
				return this._NomeAnimal;
			}
			set
			{
				if ((this._NomeAnimal != value))
				{
					this.OnNomeAnimalChanging(value);
					this.SendPropertyChanging();
					this._NomeAnimal = value;
					this.SendPropertyChanged("NomeAnimal");
					this.OnNomeAnimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EspecieRaça", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string EspecieRaça
		{
			get
			{
				return this._EspecieRaça;
			}
			set
			{
				if ((this._EspecieRaça != value))
				{
					this.OnEspecieRaçaChanging(value);
					this.SendPropertyChanging();
					this._EspecieRaça = value;
					this.SendPropertyChanged("EspecieRaça");
					this.OnEspecieRaçaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChip", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDChip
		{
			get
			{
				return this._IDChip;
			}
			set
			{
				if ((this._IDChip != value))
				{
					this.OnIDChipChanging(value);
					this.SendPropertyChanging();
					this._IDChip = value;
					this.SendPropertyChanged("IDChip");
					this.OnIDChipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataNascimento", DbType="Date NOT NULL")]
		public System.DateTime DataNascimento
		{
			get
			{
				return this._DataNascimento;
			}
			set
			{
				if ((this._DataNascimento != value))
				{
					this.OnDataNascimentoChanging(value);
					this.SendPropertyChanging();
					this._DataNascimento = value;
					this.SendPropertyChanged("DataNascimento");
					this.OnDataNascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDdono", DbType="Int NOT NULL")]
		public int IDdono
		{
			get
			{
				return this._IDdono;
			}
			set
			{
				if ((this._IDdono != value))
				{
					if (this._Donos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDdonoChanging(value);
					this.SendPropertyChanging();
					this._IDdono = value;
					this.SendPropertyChanged("IDdono");
					this.OnIDdonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animais_Consultas", Storage="_Consultas", ThisKey="IDChip", OtherKey="Chip")]
		public EntitySet<Consultas> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Donos_Animais", Storage="_Donos", ThisKey="IDdono", OtherKey="IDCliente", IsForeignKey=true)]
		public Donos Donos
		{
			get
			{
				return this._Donos.Entity;
			}
			set
			{
				Donos previousValue = this._Donos.Entity;
				if (((previousValue != value) 
							|| (this._Donos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Donos.Entity = null;
						previousValue.Animais.Remove(this);
					}
					this._Donos.Entity = value;
					if ((value != null))
					{
						value.Animais.Add(this);
						this._IDdono = value.IDCliente;
					}
					else
					{
						this._IDdono = default(int);
					}
					this.SendPropertyChanged("Donos");
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
		
		private void attach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Animais = this;
		}
		
		private void detach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Animais = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Consultas")]
	public partial class Consultas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Medico;
		
		private int _Sala;
		
		private int _Chip;
		
		private int _IDConsulta;
		
		private System.DateTime _DataHora;
		
		private EntityRef<Animais> _Animais;
		
		private EntityRef<Medicos> _Medicos;
		
		private EntityRef<Salas> _Salas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedicoChanging(int value);
    partial void OnMedicoChanged();
    partial void OnSalaChanging(int value);
    partial void OnSalaChanged();
    partial void OnChipChanging(int value);
    partial void OnChipChanged();
    partial void OnIDConsultaChanging(int value);
    partial void OnIDConsultaChanged();
    partial void OnDataHoraChanging(System.DateTime value);
    partial void OnDataHoraChanged();
    #endregion
		
		public Consultas()
		{
			this._Animais = default(EntityRef<Animais>);
			this._Medicos = default(EntityRef<Medicos>);
			this._Salas = default(EntityRef<Salas>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medico", DbType="Int NOT NULL")]
		public int Medico
		{
			get
			{
				return this._Medico;
			}
			set
			{
				if ((this._Medico != value))
				{
					if (this._Medicos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMedicoChanging(value);
					this.SendPropertyChanging();
					this._Medico = value;
					this.SendPropertyChanged("Medico");
					this.OnMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sala", DbType="Int NOT NULL")]
		public int Sala
		{
			get
			{
				return this._Sala;
			}
			set
			{
				if ((this._Sala != value))
				{
					if (this._Salas.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSalaChanging(value);
					this.SendPropertyChanging();
					this._Sala = value;
					this.SendPropertyChanged("Sala");
					this.OnSalaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chip", DbType="Int NOT NULL")]
		public int Chip
		{
			get
			{
				return this._Chip;
			}
			set
			{
				if ((this._Chip != value))
				{
					if (this._Animais.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChipChanging(value);
					this.SendPropertyChanging();
					this._Chip = value;
					this.SendPropertyChanged("Chip");
					this.OnChipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDConsulta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDConsulta
		{
			get
			{
				return this._IDConsulta;
			}
			set
			{
				if ((this._IDConsulta != value))
				{
					this.OnIDConsultaChanging(value);
					this.SendPropertyChanging();
					this._IDConsulta = value;
					this.SendPropertyChanged("IDConsulta");
					this.OnIDConsultaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataHora", DbType="DateTime NOT NULL")]
		public System.DateTime DataHora
		{
			get
			{
				return this._DataHora;
			}
			set
			{
				if ((this._DataHora != value))
				{
					this.OnDataHoraChanging(value);
					this.SendPropertyChanging();
					this._DataHora = value;
					this.SendPropertyChanged("DataHora");
					this.OnDataHoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animais_Consultas", Storage="_Animais", ThisKey="Chip", OtherKey="IDChip", IsForeignKey=true)]
		public Animais Animais
		{
			get
			{
				return this._Animais.Entity;
			}
			set
			{
				Animais previousValue = this._Animais.Entity;
				if (((previousValue != value) 
							|| (this._Animais.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animais.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Animais.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Chip = value.IDChip;
					}
					else
					{
						this._Chip = default(int);
					}
					this.SendPropertyChanged("Animais");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medicos_Consultas", Storage="_Medicos", ThisKey="Medico", OtherKey="IDMedico", IsForeignKey=true)]
		public Medicos Medicos
		{
			get
			{
				return this._Medicos.Entity;
			}
			set
			{
				Medicos previousValue = this._Medicos.Entity;
				if (((previousValue != value) 
							|| (this._Medicos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Medicos.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Medicos.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Medico = value.IDMedico;
					}
					else
					{
						this._Medico = default(int);
					}
					this.SendPropertyChanged("Medicos");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salas_Consultas", Storage="_Salas", ThisKey="Sala", OtherKey="NumeroSala", IsForeignKey=true)]
		public Salas Salas
		{
			get
			{
				return this._Salas.Entity;
			}
			set
			{
				Salas previousValue = this._Salas.Entity;
				if (((previousValue != value) 
							|| (this._Salas.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Salas.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Salas.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Sala = value.NumeroSala;
					}
					else
					{
						this._Sala = default(int);
					}
					this.SendPropertyChanged("Salas");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Donos")]
	public partial class Donos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Nome;
		
		private string _Email;
		
		private int _IDCliente;
		
		private EntitySet<Animais> _Animais;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnIDClienteChanging(int value);
    partial void OnIDClienteChanged();
    #endregion
		
		public Donos()
		{
			this._Animais = new EntitySet<Animais>(new Action<Animais>(this.attach_Animais), new Action<Animais>(this.detach_Animais));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCliente", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDCliente
		{
			get
			{
				return this._IDCliente;
			}
			set
			{
				if ((this._IDCliente != value))
				{
					this.OnIDClienteChanging(value);
					this.SendPropertyChanging();
					this._IDCliente = value;
					this.SendPropertyChanged("IDCliente");
					this.OnIDClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Donos_Animais", Storage="_Animais", ThisKey="IDCliente", OtherKey="IDdono")]
		public EntitySet<Animais> Animais
		{
			get
			{
				return this._Animais;
			}
			set
			{
				this._Animais.Assign(value);
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
		
		private void attach_Animais(Animais entity)
		{
			this.SendPropertyChanging();
			entity.Donos = this;
		}
		
		private void detach_Animais(Animais entity)
		{
			this.SendPropertyChanging();
			entity.Donos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medicos")]
	public partial class Medicos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NomeMedico;
		
		private int _IDMedico;
		
		private string _FuncaoMedico;
		
		private EntitySet<Consultas> _Consultas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNomeMedicoChanging(string value);
    partial void OnNomeMedicoChanged();
    partial void OnIDMedicoChanging(int value);
    partial void OnIDMedicoChanged();
    partial void OnFuncaoMedicoChanging(string value);
    partial void OnFuncaoMedicoChanged();
    #endregion
		
		public Medicos()
		{
			this._Consultas = new EntitySet<Consultas>(new Action<Consultas>(this.attach_Consultas), new Action<Consultas>(this.detach_Consultas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomeMedico", DbType="VarChar(100)")]
		public string NomeMedico
		{
			get
			{
				return this._NomeMedico;
			}
			set
			{
				if ((this._NomeMedico != value))
				{
					this.OnNomeMedicoChanging(value);
					this.SendPropertyChanging();
					this._NomeMedico = value;
					this.SendPropertyChanged("NomeMedico");
					this.OnNomeMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMedico", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDMedico
		{
			get
			{
				return this._IDMedico;
			}
			set
			{
				if ((this._IDMedico != value))
				{
					this.OnIDMedicoChanging(value);
					this.SendPropertyChanging();
					this._IDMedico = value;
					this.SendPropertyChanged("IDMedico");
					this.OnIDMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FuncaoMedico", DbType="VarChar(300)")]
		public string FuncaoMedico
		{
			get
			{
				return this._FuncaoMedico;
			}
			set
			{
				if ((this._FuncaoMedico != value))
				{
					this.OnFuncaoMedicoChanging(value);
					this.SendPropertyChanging();
					this._FuncaoMedico = value;
					this.SendPropertyChanged("FuncaoMedico");
					this.OnFuncaoMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medicos_Consultas", Storage="_Consultas", ThisKey="IDMedico", OtherKey="Medico")]
		public EntitySet<Consultas> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
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
		
		private void attach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Medicos = this;
		}
		
		private void detach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Medicos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salas")]
	public partial class Salas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NumeroSala;
		
		private string _FuncaoSala;
		
		private EntitySet<Consultas> _Consultas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumeroSalaChanging(int value);
    partial void OnNumeroSalaChanged();
    partial void OnFuncaoSalaChanging(string value);
    partial void OnFuncaoSalaChanged();
    #endregion
		
		public Salas()
		{
			this._Consultas = new EntitySet<Consultas>(new Action<Consultas>(this.attach_Consultas), new Action<Consultas>(this.detach_Consultas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroSala", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NumeroSala
		{
			get
			{
				return this._NumeroSala;
			}
			set
			{
				if ((this._NumeroSala != value))
				{
					this.OnNumeroSalaChanging(value);
					this.SendPropertyChanging();
					this._NumeroSala = value;
					this.SendPropertyChanged("NumeroSala");
					this.OnNumeroSalaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FuncaoSala", DbType="VarChar(300)")]
		public string FuncaoSala
		{
			get
			{
				return this._FuncaoSala;
			}
			set
			{
				if ((this._FuncaoSala != value))
				{
					this.OnFuncaoSalaChanging(value);
					this.SendPropertyChanging();
					this._FuncaoSala = value;
					this.SendPropertyChanged("FuncaoSala");
					this.OnFuncaoSalaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salas_Consultas", Storage="_Consultas", ThisKey="NumeroSala", OtherKey="Sala")]
		public EntitySet<Consultas> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
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
		
		private void attach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Salas = this;
		}
		
		private void detach_Consultas(Consultas entity)
		{
			this.SendPropertyChanging();
			entity.Salas = null;
		}
	}
}
#pragma warning restore 1591
