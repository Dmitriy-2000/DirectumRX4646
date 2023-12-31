
// ==================================================================
// Country.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class Country :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Commons.ICountry
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1f612925-95fc-4662-807d-c92c810a62b1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Client.Country.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.ICountry, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Commons.ICountryState State
    {
      get
      {
        return (global::Sungero.Commons.ICountryState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.CountryState(this);
    }

    public new global::Sungero.Commons.ICountryInfo Info
    {
      get
      {
        return (global::Sungero.Commons.ICountryInfo)base.Info;
      }
    }

    public new global::Sungero.Commons.ICountryAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Commons.ICountryAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Commons.Client.CountryAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Code;

        public virtual global::System.String Code
        {
          get { return this._Code.Value; }
          set { this._Code.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Commons.Client.CountryActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Commons.Client.CountryCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Commons.Client.CountryAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Commons.Client.CountryAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Commons.Client.CountryFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Commons.Shared.CountryFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Commons.CountryClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.CountrySharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Commons.ICountrySharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void CodeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Code, this.Code, this);
     ((global::Sungero.Commons.ICountrySharedHandlers)this.SharedHandlers).CodeChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Commons.CountryClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CodeValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Code, value, this, this.Info.Properties.Code);
    ((global::Sungero.Commons.CountryClientHandlers)this.Handlers).CodeValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public Country()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._Code = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Code", this);
            this._Code.ValueChanged += (sender, e) => { this.CodeChangedHandler(); };
            this.AddProperty(this._Code);








    }

    #endregion

  }
}

// ==================================================================
// CountryPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class CountryPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Commons.ICountry
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _ShowDuplicatesCommand;

          public global::System.Windows.Input.ICommand ShowDuplicatesCommand
          {
            get
            {
              if (this._ShowDuplicatesCommand == null)
                  this._ShowDuplicatesCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowDuplicates", this, this.ShowDuplicates, this.CanShowDuplicates) { IsEmptyParameterAllowed = true };
              return this._ShowDuplicatesCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Commons.Client.CountryActions)(entity as Sungero.Commons.Client.Country).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.Commons.Client.CountryActions)(entity as Sungero.Commons.Client.Country).ActionsHandlers).ShowDuplicates(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



    #region Constructors

    private void Init()
    {

    }

    public CountryPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// CountryCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class CountryCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Commons.ICountry
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public CountryCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public CountryCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public CountryCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public CountryCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// CountryRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{ 
  public class CountryRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.Commons.ICountryRepositoryImplementer<T>
      where T : global::Sungero.Commons.ICountry
    {
       public new global::Sungero.Commons.ICountryAccessRights AccessRights
       {
          get { return (global::Sungero.Commons.ICountryAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Commons.ICountryInfo Info
       {
          get { return (global::Sungero.Commons.ICountryInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Commons.Client.CountryTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CountryAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class CountryAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Commons.ICountryAccessRights
  {

    public CountryAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CountryTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Commons.ICountryAccessRights
  {

    public CountryTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
