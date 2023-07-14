
// ==================================================================
// StampSetting.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class StampSetting :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Docflow.IStampSetting
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("06e3a0a6-5e8c-463e-bbfd-578227389d3f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.StampSetting.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IStampSetting, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IStampSettingState State
    {
      get
      {
        return (global::Sungero.Docflow.IStampSettingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.StampSettingState(this);
    }

    public new global::Sungero.Docflow.IStampSettingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IStampSettingInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IStampSettingAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IStampSettingAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.StampSettingAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _NeedShowDateTime;

        public virtual global::System.Boolean? NeedShowDateTime
        {
          get { return this._NeedShowDateTime.Value; }
          set { this._NeedShowDateTime.Value = value; }
        }







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.Docflow.IStampSettingBusinessUnits> _BusinessUnits;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IStampSettingBusinessUnits> BusinessUnits
          {
            get { return this._BusinessUnits.Value; }
          }




      protected global::Sungero.Domain.Client.TextProperty _Title;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Title
      {
        get { return this._Title.Value; }
        set { this._Title.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _Note;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Note
      {
        get { return this._Note.Value; }
        set { this._Note.Value = value; }
      }
      protected global::Sungero.Domain.Client.TextProperty _LogoAsBase64;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String LogoAsBase64
      {
        get { return this._LogoAsBase64.Value; }
        set { this._LogoAsBase64.Value = value; }
      }


      protected global::Sungero.Domain.Client.ImageProperty _Logo;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual global::System.Byte[] Logo
      {
        get { return this._Logo.Value; }
        set { this._Logo.Value = value; }
      }



    private object _BusinessUnitsActionsHandlers;

    public object BusinessUnitsActionsHandlers
    {
      get
      {
        if (this._BusinessUnitsActionsHandlers == null)
          this._BusinessUnitsActionsHandlers = this.CreateBusinessUnitsActionsHandlers();
        return this._BusinessUnitsActionsHandlers;
      }
    }

    private object _BusinessUnitsCollectionActionsHandlers;

    public object BusinessUnitsCollectionActionsHandlers
    {
      get
      {
        if (this._BusinessUnitsCollectionActionsHandlers == null)
          this._BusinessUnitsCollectionActionsHandlers = this.CreateBusinessUnitsCollectionActionsHandlers();
        return this._BusinessUnitsCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.StampSettingActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.StampSettingCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.StampSettingAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.StampSettingAnyChildEntityCollectionActions();
    }

    protected virtual object CreateBusinessUnitsActionsHandlers()
    {
      return null;
    }

    protected virtual object CreateBusinessUnitsCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.StampSettingFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.StampSettingFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.StampSettingClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.StampSettingSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void BusinessUnitsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).BusinessUnitsChanged(args);
    }

    protected void LogoChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.ImagePropertyChangedEventArgs(this.State.Properties.Logo, this.Logo, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).LogoChanged(args);
    }

    protected void TitleChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Title, this.Title, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).TitleChanged(args);
    }

    protected void NeedShowDateTimeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.NeedShowDateTime, this.NeedShowDateTime, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).NeedShowDateTimeChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void LogoAsBase64ChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.LogoAsBase64, this.LogoAsBase64, this);
     ((global::Sungero.Docflow.IStampSettingSharedHandlers)this.SharedHandlers).LogoAsBase64Changed(args);
    }



    protected virtual global::Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers CreateBusinessUnitsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers CreateBusinessUnitsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void BusinessUnitsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("BusinessUnitsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateBusinessUnitsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.BusinessUnitsAdded(args);
        }
      }
    }

    protected virtual void BusinessUnitsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.StampSettingBusinessUnitsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("BusinessUnitsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateBusinessUnitsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.BusinessUnitsDeleted(args);
        }
      }
    }


  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Docflow.StampSettingClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }



  protected global::System.String TitleValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Title, value, this, this.Info.Properties.Title);
    ((global::Sungero.Docflow.StampSettingClientHandlers)this.Handlers).TitleValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? NeedShowDateTimeValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.NeedShowDateTime, value, this, this.Info.Properties.NeedShowDateTime);
    ((global::Sungero.Docflow.StampSettingClientHandlers)this.Handlers).NeedShowDateTimeValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Docflow.StampSettingClientHandlers)this.Handlers).NoteValueInput(args);
    return args.NewValue;
  }

  protected global::System.String LogoAsBase64ValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.LogoAsBase64, value, this, this.Info.Properties.LogoAsBase64);
    ((global::Sungero.Docflow.StampSettingClientHandlers)this.Handlers).LogoAsBase64ValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors


            protected virtual void InitBusinessUnitsCollectionProperty()
            {
              this._BusinessUnits = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IStampSettingBusinessUnits>("BusinessUnits", this);
              this._BusinessUnits.ValueChanged += (sender, e) => { this.BusinessUnitsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._BusinessUnits);
              this.SetBusinessUnitsEventHandlers();
            }

            protected void SetBusinessUnitsEventHandlers()
            {
              this._BusinessUnits.ChildEntityAdded += this.BusinessUnitsAddedHandler;
              this._BusinessUnits.ChildEntityDeleted += this.BusinessUnitsDeletedHandler;
            }


    public StampSetting()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._NeedShowDateTime = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("NeedShowDateTime", this);
            this._NeedShowDateTime.ValueChanged += (sender, e) => { this.NeedShowDateTimeChangedHandler(); };
            this.AddProperty(this._NeedShowDateTime);


            this.InitBusinessUnitsCollectionProperty();


            this._Title = new global::Sungero.Domain.Client.TextProperty("Title", this);
            this._Title.ValueChanged += (sender, e) => { this.TitleChangedHandler(); };
            this.AddProperty(this._Title);

            this._Note = new global::Sungero.Domain.Client.TextProperty("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);

            this._LogoAsBase64 = new global::Sungero.Domain.Client.TextProperty("LogoAsBase64", this);
            this._LogoAsBase64.ValueChanged += (sender, e) => { this.LogoAsBase64ChangedHandler(); };
            this.AddProperty(this._LogoAsBase64);



            this._Logo = new global::Sungero.Domain.Client.ImageProperty("Logo", this);
            this._Logo.ValueChanged += (sender, e) => { this.LogoChangedHandler(); };
            this.AddProperty(this._Logo);




    }

    #endregion

  }
}

// ==================================================================
// StampSettingPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class StampSettingPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Docflow.IStampSetting
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _UploadLogoCommand;

          public global::System.Windows.Input.ICommand UploadLogoCommand
          {
            get
            {
              if (this._UploadLogoCommand == null)
                  this._UploadLogoCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("UploadLogo", this, this.UploadLogo, this.CanUploadLogo) { IsEmptyParameterAllowed = true };
              return this._UploadLogoCommand;
            }
          }
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
          private global::System.Windows.Input.ICommand _DeleteLogoCommand;

          public global::System.Windows.Input.ICommand DeleteLogoCommand
          {
            get
            {
              if (this._DeleteLogoCommand == null)
                  this._DeleteLogoCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("DeleteLogo", this, this.DeleteLogo, this.CanDeleteLogo) { IsEmptyParameterAllowed = true };
              return this._DeleteLogoCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanUploadLogo(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).CanUploadLogo(args);
              }

              private void UploadLogo(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.UploadLogo);
                ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).UploadLogo(args);
              }
              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).ShowDuplicates(args);
              }
              private bool CanDeleteLogo(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).CanDeleteLogo(args);
              }

              private void DeleteLogo(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.DeleteLogo);
                ((Sungero.Docflow.Client.StampSettingActions)(entity as Sungero.Docflow.Client.StampSetting).ActionsHandlers).DeleteLogo(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _BusinessUnitsBusinessUnitCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter BusinessUnitsBusinessUnitCollectionPresenter
                          {
                  get { return this._BusinessUnitsBusinessUnitCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {

                          this._BusinessUnitsBusinessUnitCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IBusinessUnit>(global::System.Guid.Parse("8d05138f-8d6c-4a85-9a1b-47e840321ba0"));
                        this._BusinessUnitsBusinessUnitCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(Sungero.Docflow.IStampSettingBusinessUnits), "BusinessUnit");


    }

    public StampSettingPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// StampSettingCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class StampSettingCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IStampSetting
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public StampSettingCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public StampSettingCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public StampSettingCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public StampSettingCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// StampSettingRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class StampSettingRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
      global::Sungero.Docflow.IStampSettingRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IStampSetting
    {
       public new global::Sungero.Docflow.IStampSettingAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IStampSettingAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IStampSettingInfo Info
       {
          get { return (global::Sungero.Docflow.IStampSettingInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.StampSettingTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// StampSettingAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class StampSettingAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Docflow.IStampSettingAccessRights
  {

    public StampSettingAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class StampSettingTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Docflow.IStampSettingAccessRights
  {

    public StampSettingTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
