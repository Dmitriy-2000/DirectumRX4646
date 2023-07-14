
// ==================================================================
// PowerOfAttorney.g.cs
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
  public class PowerOfAttorney :
    global::Sungero.Docflow.Client.PowerOfAttorneyBase, global::Sungero.Docflow.IPowerOfAttorney
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.PowerOfAttorney.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorney, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IPowerOfAttorneyState State
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyState(this);
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.PowerOfAttorneyFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneyClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.PowerOfAttorneySharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors





















            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IPowerOfAttorneyVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IPowerOfAttorneyTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public PowerOfAttorney()
    {








    }

    #endregion

  }
}

// ==================================================================
// PowerOfAttorneyPresenter.g.cs
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
  public class PowerOfAttorneyPresenter<T> :
    global::Sungero.Docflow.Client.PowerOfAttorneyBasePresenter<T>
    where T : class, global::Sungero.Docflow.IPowerOfAttorney
  {
    #region Fields and properties




    #endregion

    #region Methods


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

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IOfficialDocument>(() => this.Entity.Id, typeof(T), "LeadingDocument");

              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

              this._IssuedToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "IssuedTo");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Docflow.IPowerOfAttorneyTracking), "ReturnTask");



    }

    public PowerOfAttorneyPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// PowerOfAttorneyCollectionPresenter.g.cs
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
  public class PowerOfAttorneyCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.PowerOfAttorneyBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IPowerOfAttorney
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public PowerOfAttorneyCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public PowerOfAttorneyCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public PowerOfAttorneyCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public PowerOfAttorneyCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// PowerOfAttorneyRepositoryImplementer.g.cs
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
  public class PowerOfAttorneyRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.PowerOfAttorneyBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IPowerOfAttorneyRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IPowerOfAttorney
    {
       public new global::Sungero.Docflow.IPowerOfAttorneyAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IPowerOfAttorneyInfo Info
       {
          get { return (global::Sungero.Docflow.IPowerOfAttorneyInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.PowerOfAttorneyTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// PowerOfAttorneyAccessRights.g.cs
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
  public class PowerOfAttorneyAccessRights : 
    Sungero.Docflow.Client.PowerOfAttorneyBaseAccessRights, Sungero.Docflow.IPowerOfAttorneyAccessRights
  {

    public PowerOfAttorneyAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class PowerOfAttorneyTypeAccessRights : 
    Sungero.Docflow.Client.PowerOfAttorneyBaseTypeAccessRights, Sungero.Docflow.IPowerOfAttorneyAccessRights
  {

    public PowerOfAttorneyTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
