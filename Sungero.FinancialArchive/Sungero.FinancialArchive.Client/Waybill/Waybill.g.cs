
// ==================================================================
// Waybill.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class Waybill :
    global::Sungero.Docflow.Client.AccountingDocumentBase, global::Sungero.FinancialArchive.IWaybill
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4e81f9ca-b95a-4fd4-bf76-ea7176c215a7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.Waybill.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IWaybill, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.FinancialArchive.IWaybillState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IWaybillState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.WaybillState(this);
    }

    public new global::Sungero.FinancialArchive.IWaybillInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IWaybillInfo)base.Info;
      }
    }

    public new global::Sungero.FinancialArchive.IWaybillAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.FinancialArchive.IWaybillAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.FinancialArchive.Client.WaybillFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.FinancialArchive.Shared.WaybillFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.FinancialArchive.WaybillClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.FinancialArchive.WaybillSharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors



























            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IWaybillVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IWaybillTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public Waybill()
    {








    }

    #endregion

  }
}

// ==================================================================
// WaybillPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class WaybillPresenter<T> :
    global::Sungero.Docflow.Client.AccountingDocumentBasePresenter<T>
    where T : class, global::Sungero.FinancialArchive.IWaybill
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
              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._OurSigningReasonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ISignatureSetting>(() => this.Entity, typeof(T), "OurSigningReason");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.ICaseFile>(() => this.Entity, typeof(T), "CaseFile");

              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

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

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._CurrencyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(T), "Currency");

              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._CorrectedCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IAccountingDocumentBase>(() => this.Entity, typeof(T), "Corrected");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IContractualDocumentBase>(() => this.Entity, typeof(T), "LeadingDocument");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IWaybillTracking), "ReturnTask");



    }

    public WaybillPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// WaybillCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class WaybillCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.FinancialArchive.IWaybill
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public WaybillCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public WaybillCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public WaybillCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public WaybillCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// WaybillRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{ 
  public class WaybillRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.FinancialArchive.IWaybillRepositoryImplementer<T>
      where T : global::Sungero.FinancialArchive.IWaybill
    {
       public new global::Sungero.FinancialArchive.IWaybillAccessRights AccessRights
       {
          get { return (global::Sungero.FinancialArchive.IWaybillAccessRights)base.AccessRights; }
       }

       public new global::Sungero.FinancialArchive.IWaybillInfo Info
       {
          get { return (global::Sungero.FinancialArchive.IWaybillInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.FinancialArchive.Client.WaybillTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// WaybillAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class WaybillAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseAccessRights, Sungero.FinancialArchive.IWaybillAccessRights
  {

    public WaybillAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class WaybillTypeAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseTypeAccessRights, Sungero.FinancialArchive.IWaybillAccessRights
  {

    public WaybillTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
