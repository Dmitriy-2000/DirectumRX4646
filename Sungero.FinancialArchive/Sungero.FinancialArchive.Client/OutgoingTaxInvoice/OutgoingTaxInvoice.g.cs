
// ==================================================================
// OutgoingTaxInvoice.g.cs
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
  public class OutgoingTaxInvoice :
    global::Sungero.Docflow.Client.AccountingDocumentBase, global::Sungero.FinancialArchive.IOutgoingTaxInvoice
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f50c4d8a-56bc-43ef-bac3-856f57ca70be");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.OutgoingTaxInvoice.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IOutgoingTaxInvoice, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceState(this);
    }

    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo)base.Info;
      }
    }

    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.FinancialArchive.OutgoingTaxInvoiceClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.FinancialArchive.OutgoingTaxInvoiceSharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors



























            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }

            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public OutgoingTaxInvoice()
    {








    }

    #endregion

  }
}

// ==================================================================
// OutgoingTaxInvoicePresenter.g.cs
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
  public class OutgoingTaxInvoicePresenter<T> :
    global::Sungero.Docflow.Client.AccountingDocumentBasePresenter<T>
    where T : class, global::Sungero.FinancialArchive.IOutgoingTaxInvoice
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

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

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

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");

              this._CorrectedCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IAccountingDocumentBase>(() => this.Entity, typeof(T), "Corrected");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IContractualDocumentBase>(() => this.Entity, typeof(T), "LeadingDocument");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IOutgoingTaxInvoiceTracking), "ReturnTask");



    }

    public OutgoingTaxInvoicePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// OutgoingTaxInvoiceCollectionPresenter.g.cs
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
  public class OutgoingTaxInvoiceCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.FinancialArchive.IOutgoingTaxInvoice
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public OutgoingTaxInvoiceCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public OutgoingTaxInvoiceCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public OutgoingTaxInvoiceCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public OutgoingTaxInvoiceCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// OutgoingTaxInvoiceRepositoryImplementer.g.cs
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
  public class OutgoingTaxInvoiceRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.FinancialArchive.IOutgoingTaxInvoiceRepositoryImplementer<T>
      where T : global::Sungero.FinancialArchive.IOutgoingTaxInvoice
    {
       public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights AccessRights
       {
          get { return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights)base.AccessRights; }
       }

       public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo Info
       {
          get { return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.FinancialArchive.Client.OutgoingTaxInvoiceTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// OutgoingTaxInvoiceAccessRights.g.cs
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
  public class OutgoingTaxInvoiceAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseAccessRights, Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights
  {

    public OutgoingTaxInvoiceAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class OutgoingTaxInvoiceTypeAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseTypeAccessRights, Sungero.FinancialArchive.IOutgoingTaxInvoiceAccessRights
  {

    public OutgoingTaxInvoiceTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
