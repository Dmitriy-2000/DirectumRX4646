
// ==================================================================
// ContractStatement.g.cs
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
  public class ContractStatement :
    global::Sungero.Docflow.Client.AccountingDocumentBase, global::Sungero.FinancialArchive.IContractStatement
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f2f5774d-5ca3-4725-b31d-ac618f6b8850");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.ContractStatement.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IContractStatement, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.FinancialArchive.IContractStatementState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IContractStatementState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.ContractStatementState(this);
    }

    public new global::Sungero.FinancialArchive.IContractStatementInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IContractStatementInfo)base.Info;
      }
    }

    public new global::Sungero.FinancialArchive.IContractStatementAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.FinancialArchive.IContractStatementAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.FinancialArchive.Client.ContractStatementFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.FinancialArchive.Shared.ContractStatementFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.FinancialArchive.ContractStatementClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.FinancialArchive.ContractStatementSharedHandlers(this);
    }

    #endregion

    #region Framework events







    #endregion

    #region Constructors



























            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IContractStatementVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }


            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.FinancialArchive.IContractStatementTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }


    public ContractStatement()
    {








    }

    #endregion

  }
}

// ==================================================================
// ContractStatementPresenter.g.cs
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
  public class ContractStatementPresenter<T> :
    global::Sungero.Docflow.Client.AccountingDocumentBasePresenter<T>
    where T : class, global::Sungero.FinancialArchive.IContractStatement
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
          private global::System.Windows.Input.ICommand _CreateCoverLetterCommand;

          public global::System.Windows.Input.ICommand CreateCoverLetterCommand
          {
            get
            {
              if (this._CreateCoverLetterCommand == null)
                  this._CreateCoverLetterCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateCoverLetter", this, this.CreateCoverLetter, this.CanCreateCoverLetter) { IsEmptyParameterAllowed = true };
              return this._CreateCoverLetterCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.FinancialArchive.Client.ContractStatementActions)(entity as Sungero.FinancialArchive.Client.ContractStatement).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.FinancialArchive.Client.ContractStatementActions)(entity as Sungero.FinancialArchive.Client.ContractStatement).ActionsHandlers).ShowDuplicates(args);
              }
              private bool CanCreateCoverLetter(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.FinancialArchive.Client.ContractStatementActions)(entity as Sungero.FinancialArchive.Client.ContractStatement).ActionsHandlers).CanCreateCoverLetter(args);
              }

              private void CreateCoverLetter(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateCoverLetter);
                ((Sungero.FinancialArchive.Client.ContractStatementActions)(entity as Sungero.FinancialArchive.Client.ContractStatement).ActionsHandlers).CreateCoverLetter(args);
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

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._CurrencyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(T), "Currency");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._BusinessUnitBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "BusinessUnitBox");

              this._CorrectedCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IAccountingDocumentBase>(() => this.Entity, typeof(T), "Corrected");

              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IContractualDocumentBase>(() => this.Entity, typeof(T), "LeadingDocument");

              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

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

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.FinancialArchive.IContractStatementTracking), "ReturnTask");



    }

    public ContractStatementPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ContractStatementCollectionPresenter.g.cs
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
  public class ContractStatementCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionPresenter<T>
    where T: class, global::Sungero.FinancialArchive.IContractStatement
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ContractStatementCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ContractStatementCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ContractStatementCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ContractStatementCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ContractStatementRepositoryImplementer.g.cs
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
  public class ContractStatementRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.FinancialArchive.IContractStatementRepositoryImplementer<T>
      where T : global::Sungero.FinancialArchive.IContractStatement
    {
       public new global::Sungero.FinancialArchive.IContractStatementAccessRights AccessRights
       {
          get { return (global::Sungero.FinancialArchive.IContractStatementAccessRights)base.AccessRights; }
       }

       public new global::Sungero.FinancialArchive.IContractStatementInfo Info
       {
          get { return (global::Sungero.FinancialArchive.IContractStatementInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.FinancialArchive.Client.ContractStatementTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractStatementAccessRights.g.cs
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
  public class ContractStatementAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseAccessRights, Sungero.FinancialArchive.IContractStatementAccessRights
  {

    public ContractStatementAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractStatementTypeAccessRights : 
    Sungero.Docflow.Client.AccountingDocumentBaseTypeAccessRights, Sungero.FinancialArchive.IContractStatementAccessRights
  {

    public ContractStatementTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
