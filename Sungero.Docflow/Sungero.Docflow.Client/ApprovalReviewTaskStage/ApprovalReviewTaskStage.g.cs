
// ==================================================================
// ApprovalReviewTaskStage.g.cs
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
  public class ApprovalReviewTaskStage :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBase, global::Sungero.Docflow.IApprovalReviewTaskStage
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9bc1a190-7ede-40e0-9895-397f2433d587");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalReviewTaskStage.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReviewTaskStage, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalReviewTaskStageState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReviewTaskStageState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReviewTaskStageState(this);
    }

    public new global::Sungero.Docflow.IApprovalReviewTaskStageInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReviewTaskStageInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalReviewTaskStageAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalReviewTaskStageAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _WaitReviewTaskCompletion;

        public virtual global::System.Boolean? WaitReviewTaskCompletion
        {
          get { return this._WaitReviewTaskCompletion.Value; }
          set { this._WaitReviewTaskCompletion.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReviewTaskStageFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalReviewTaskStageClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReviewTaskStageSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void WaitReviewTaskCompletionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.WaitReviewTaskCompletion, this.WaitReviewTaskCompletion, this);
     ((global::Sungero.Docflow.IApprovalReviewTaskStageSharedHandlers)this.SharedHandlers).WaitReviewTaskCompletionChanged(args);
    }



  protected global::System.Boolean? WaitReviewTaskCompletionValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.WaitReviewTaskCompletion, value, this, this.Info.Properties.WaitReviewTaskCompletion);
    ((global::Sungero.Docflow.ApprovalReviewTaskStageClientHandlers)this.Handlers).WaitReviewTaskCompletionValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public ApprovalReviewTaskStage()
    {
            this._WaitReviewTaskCompletion = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("WaitReviewTaskCompletion", this);
            this._WaitReviewTaskCompletion.ValueChanged += (sender, e) => { this.WaitReviewTaskCompletionChangedHandler(); };
            this.AddProperty(this._WaitReviewTaskCompletion);








    }

    #endregion

  }
}

// ==================================================================
// ApprovalReviewTaskStagePresenter.g.cs
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
  public class ApprovalReviewTaskStagePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalFunctionStageBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalReviewTaskStage
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

    }

    public ApprovalReviewTaskStagePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalReviewTaskStageCollectionPresenter.g.cs
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
  public class ApprovalReviewTaskStageCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalFunctionStageBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalReviewTaskStage
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalReviewTaskStageCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalReviewTaskStageCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalReviewTaskStageCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalReviewTaskStageCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalReviewTaskStageRepositoryImplementer.g.cs
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
  public class ApprovalReviewTaskStageRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalFunctionStageBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalReviewTaskStageRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalReviewTaskStage
    {
       public new global::Sungero.Docflow.IApprovalReviewTaskStageAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalReviewTaskStageAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalReviewTaskStageInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalReviewTaskStageInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalReviewTaskStageTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalReviewTaskStageAccessRights.g.cs
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
  public class ApprovalReviewTaskStageAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseAccessRights, Sungero.Docflow.IApprovalReviewTaskStageAccessRights
  {

    public ApprovalReviewTaskStageAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalReviewTaskStageTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalFunctionStageBaseTypeAccessRights, Sungero.Docflow.IApprovalReviewTaskStageAccessRights
  {

    public ApprovalReviewTaskStageTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
