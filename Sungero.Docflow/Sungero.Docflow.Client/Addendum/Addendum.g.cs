
// ==================================================================
// Addendum.g.cs
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
  public class Addendum :
    global::Sungero.Docflow.Client.InternalDocumentBase, global::Sungero.Docflow.IAddendum
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("58b9ed35-9c84-46cd-aa79-9b5ef5a82f5d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.Addendum.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAddendum, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IAddendumState State
    {
      get
      {
        return (global::Sungero.Docflow.IAddendumState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AddendumState(this);
    }

    public new global::Sungero.Docflow.IAddendumInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IAddendumInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IAddendumAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IAddendumAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.AddendumAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.AddendumActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.AddendumCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.AddendumAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.AddendumAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.AddendumFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.AddendumFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.AddendumClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AddendumSharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors




















            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IAddendumVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IAddendumTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public Addendum()
    {








    }

    #endregion

  }
}

// ==================================================================
// AddendumPresenter.g.cs
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
  public class AddendumPresenter<T> :
    global::Sungero.Docflow.Client.InternalDocumentBasePresenter<T>
    where T : class, global::Sungero.Docflow.IAddendum
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _UnbindAddendumCommand;

          public global::System.Windows.Input.ICommand UnbindAddendumCommand
          {
            get
            {
              if (this._UnbindAddendumCommand == null)
                  this._UnbindAddendumCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("UnbindAddendum", this, this.UnbindAddendum, this.CanUnbindAddendum) { IsEmptyParameterAllowed = true };
              return this._UnbindAddendumCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanUnbindAddendum(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.AddendumActions)(entity as Sungero.Docflow.Client.Addendum).ActionsHandlers).CanUnbindAddendum(args);
              }

              private void UnbindAddendum(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.UnbindAddendum);
                ((Sungero.Docflow.Client.AddendumActions)(entity as Sungero.Docflow.Client.Addendum).ActionsHandlers).UnbindAddendum(args);
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
              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IOfficialDocument>(() => this.Entity, typeof(T), "LeadingDocument");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ICaseFile>(() => this.Entity, typeof(T), "CaseFile");

              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Docflow.IAddendumTracking), "ReturnTask");



    }

    public AddendumPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// AddendumCollectionPresenter.g.cs
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
  public class AddendumCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.InternalDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IAddendum
  {
    #region Actions

          private global::System.Windows.Input.ICommand _UnbindAddendumCommand;  

          public global::System.Windows.Input.ICommand UnbindAddendumCommand 
          { 
            get
            { 
              if (this._UnbindAddendumCommand == null)
                this._UnbindAddendumCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("UnbindAddendum", this, this.UnbindAddendum, this.CanUnbindAddendum) { IsEmptyParameterAllowed = true };
              return this._UnbindAddendumCommand; 
            }
          }



    #endregion

    #region Methods

        private bool CanUnbindAddendum(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Docflow.Client.AddendumActions)(entity as Sungero.Docflow.Client.Addendum).ActionsHandlers).CanUnbindAddendum(args);
        }

        private void UnbindAddendum(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.UnbindAddendum);
          ((Sungero.Docflow.Client.AddendumActions)(entity as Sungero.Docflow.Client.Addendum).ActionsHandlers).UnbindAddendum(args);
        }



    #endregion

    public AddendumCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public AddendumCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public AddendumCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public AddendumCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// AddendumRepositoryImplementer.g.cs
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
  public class AddendumRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.InternalDocumentBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IAddendumRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IAddendum
    {
       public new global::Sungero.Docflow.IAddendumAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IAddendumAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IAddendumInfo Info
       {
          get { return (global::Sungero.Docflow.IAddendumInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.AddendumTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// AddendumAccessRights.g.cs
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
  public class AddendumAccessRights : 
    Sungero.Docflow.Client.InternalDocumentBaseAccessRights, Sungero.Docflow.IAddendumAccessRights
  {

    public AddendumAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class AddendumTypeAccessRights : 
    Sungero.Docflow.Client.InternalDocumentBaseTypeAccessRights, Sungero.Docflow.IAddendumAccessRights
  {

    public AddendumTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}