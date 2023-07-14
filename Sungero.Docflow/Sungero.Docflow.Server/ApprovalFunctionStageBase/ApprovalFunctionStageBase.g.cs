
// ==================================================================
// ApprovalFunctionStageBase.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalFunctionStageBaseFilter<T> :
      global::Sungero.Docflow.Server.ApprovalStageBaseFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalFunctionStageBase
    {
      private global::Sungero.Docflow.IApprovalFunctionStageBaseFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IApprovalFunctionStageBaseFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalFunctionStageBaseFilter(global::Sungero.Docflow.IApprovalFunctionStageBaseFilterState filter)
      : base(filter)
      {
      }

      protected ApprovalFunctionStageBaseFilter()
      {
      }
    }
      public class ApprovalFunctionStageBaseUiFilter<T> :
        global::Sungero.Docflow.Server.ApprovalStageBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IApprovalFunctionStageBase
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalFunctionStageBaseSearchDialogModel : global::Sungero.Docflow.Server.ApprovalStageBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.Int32? DeadlineInDays { get; protected set; }
                  public override global::System.Int32? DeadlineInHours { get; protected set; }
                  public override global::System.String Name { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }



                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> TimeoutAction { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFilter<global::Sungero.Docflow.IApprovalFunctionStageBase>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ApprovalFunctionStageBaseUiFilter<global::Sungero.Docflow.IApprovalFunctionStageBase>))]

  public class ApprovalFunctionStageBase :
    global::Sungero.Docflow.Server.ApprovalStageBase, global::Sungero.Docflow.IApprovalFunctionStageBase
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6831f842-3ea6-412e-9637-c6315a4e6686");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalFunctionStageBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalFunctionStageBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalFunctionStageBaseState State
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionStageBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalFunctionStageBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalFunctionStageBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalFunctionStageBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionStageBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalFunctionStageBaseSharedHandlers(this);
    }

    private global::System.Int32? _TimeoutInDays;
    public virtual global::System.Int32? TimeoutInDays
    {
      get
      {
        return this._TimeoutInDays;
      }

      set
      {
        this.SetPropertyValue("TimeoutInDays", this._TimeoutInDays, value, (propertyValue) => { this._TimeoutInDays = propertyValue; }, this.TimeoutInDaysChangedHandler);
      }
    }
    private global::System.Int32? _TimeoutInHours;
    public virtual global::System.Int32? TimeoutInHours
    {
      get
      {
        return this._TimeoutInHours;
      }

      set
      {
        this.SetPropertyValue("TimeoutInHours", this._TimeoutInHours, value, (propertyValue) => { this._TimeoutInHours = propertyValue; }, this.TimeoutInHoursChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _TimeoutActionItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.ApprovalFunctionStageBase.TimeoutAction),
      typeof(global::Sungero.Docflow.Server.ApprovalFunctionStageBase),
      "TimeoutAction");

    public static global::Sungero.Domain.Shared.EnumerationItems TimeoutActionItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalFunctionStageBase._TimeoutActionItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems TimeoutActionAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalFunctionStageBase.TimeoutActionItems; }
    }

    private global::Sungero.Core.Enumeration? _TimeoutAction;

    public virtual global::Sungero.Core.Enumeration? TimeoutAction
    {
      get { return this._TimeoutAction; }
      set { this.SetEnumPropertyValue("TimeoutAction", this._TimeoutAction, value, (propertyValue) => { this._TimeoutAction = propertyValue; }, this.TimeoutActionChangedHandler, this.TimeoutActionAllowedItems); }
    }





    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalFunctionStageBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalFunctionStageBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalFunctionStageBaseCreatingFromServerHandler((global::Sungero.Docflow.IApprovalFunctionStageBase)entitySource, this.Info);
    }

    #region Framework events

    protected void TimeoutInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.TimeoutInDays, this.TimeoutInDays, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutInDaysChanged(args);
    }

    protected void TimeoutInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.TimeoutInHours, this.TimeoutInHours, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutInHoursChanged(args);
    }

    protected void TimeoutActionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.TimeoutAction, this.TimeoutAction, this);
     ((global::Sungero.Docflow.IApprovalFunctionStageBaseSharedHandlers)this.SharedHandlers).TimeoutActionChanged(args);
    }



    #endregion


    public ApprovalFunctionStageBase()
    {
    }

  }
}

// ==================================================================
// ApprovalFunctionStageBaseHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

  public partial class ApprovalFunctionStageBaseFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalStageBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalFunctionStageBase
  {
    private global::Sungero.Docflow.IApprovalFunctionStageBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IApprovalFunctionStageBaseFilterState)this.Filter;
      }
    }

    public ApprovalFunctionStageBaseFilteringServerHandler(global::Sungero.Docflow.IApprovalFunctionStageBaseFilterState filter)
    : base(filter)
    {
    }

    protected ApprovalFunctionStageBaseFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ApprovalFunctionStageBaseUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalStageBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IApprovalFunctionStageBase
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalFunctionStageBaseSearchDialogServerHandler : global::Sungero.Docflow.ApprovalStageBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalFunctionStageBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalFunctionStageBaseSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalFunctionStageBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalFunctionStageBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalFunctionStageBaseServerHandlers : global::Sungero.Docflow.ApprovalStageBaseServerHandlers
  {
    private global::Sungero.Docflow.IApprovalFunctionStageBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBase)this.Entity; }
    }

    public ApprovalFunctionStageBaseServerHandlers(global::Sungero.Docflow.IApprovalFunctionStageBase entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalFunctionStageBaseCreatingFromServerHandler : global::Sungero.Docflow.ApprovalStageBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalFunctionStageBase _source
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBase)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalFunctionStageBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseInfo)this._Info; }
    }

    public ApprovalFunctionStageBaseCreatingFromServerHandler(global::Sungero.Docflow.IApprovalFunctionStageBase source, global::Sungero.Docflow.IApprovalFunctionStageBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalFunctionStageBaseEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalFunctionStageBaseAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalFunctionStageBaseAccessRights : 
    Sungero.Docflow.Server.ApprovalStageBaseAccessRights, Sungero.Docflow.IApprovalFunctionStageBaseAccessRights
  {

    public ApprovalFunctionStageBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalFunctionStageBaseTypeAccessRights : 
    Sungero.Docflow.Server.ApprovalStageBaseTypeAccessRights, Sungero.Docflow.IApprovalFunctionStageBaseAccessRights
  {

    public ApprovalFunctionStageBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalFunctionStageBaseRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class ApprovalFunctionStageBaseRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ApprovalStageBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalFunctionStageBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalFunctionStageBase 
    {
       public new global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalFunctionStageBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalFunctionStageBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalFunctionStageBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalFunctionStageBasePanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// ApprovalFunctionStageBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalFunctionStageBaseFunctions : global::Sungero.Docflow.Server.ApprovalStageBaseFunctions
  {
    private global::Sungero.Docflow.IApprovalFunctionStageBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalFunctionStageBase)this.Entity; }
    }

    public ApprovalFunctionStageBaseFunctions(global::Sungero.Docflow.IApprovalFunctionStageBase entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalFunctionStageBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class ApprovalFunctionStageBase
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult Execute(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Execute", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult CheckCompletionState(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckCompletionState", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  void Abort(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask task, global::System.Int32 stageNumber)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Abort", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, stageNumber });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  void Rework(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask task, global::System.Int32 stageNumber)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Rework", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, stageNumber });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult GetSuccessResult(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSuccessResult", new System.Type[] {  });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult GetErrorResult(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::System.String errorMessage)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetErrorResult", new System.Type[] { typeof(global::System.String) });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { errorMessage });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult GetRetryResult(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::System.String errorMessage)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRetryResult", new System.Type[] { typeof(global::System.String) });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { errorMessage });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  void AddStageToRoute(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleCardReport.ConditionTableLine> linedRoute, global::System.String prefix, global::System.Int32 level)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddStageToRoute", new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ApprovalRuleCardReport.ConditionTableLine>), typeof(global::System.String), typeof(global::System.Int32) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { linedRoute, prefix, level });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.String GetStateViewBlockName(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask task, global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo statusInfo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStateViewBlockName", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, statusInfo });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  void AddStateViewBlockPerformers(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask task, Sungero.Core.StateBlock block, global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo statusInfo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddStateViewBlockPerformers", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(Sungero.Core.StateBlock), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, block, statusInfo });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.String GetStateViewBlockDeadline(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask task, global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo statusInfo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStateViewBlockDeadline", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::Sungero.Docflow.Structures.ApprovalRuleBase.StageStatusInfo) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { task, statusInfo });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  void SendTimeoutSubtask(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask approvalTask, global::System.String errorMessage)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SendTimeoutSubtask", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask), typeof(global::System.String) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask, errorMessage });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.CoreEntities.IUser> GetTimeoutSubtaskPerformers(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTimeoutSubtaskPerformers", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::System.Collections.Generic.List<global::Sungero.CoreEntities.IUser>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.String GetTimeoutSubtaskThreadSubject(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTimeoutSubtaskThreadSubject", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.String GetTimeoutSubtaskSubject(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::System.String prefix, global::System.String additionalInfo)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTimeoutSubtaskSubject", new System.Type[] { typeof(global::System.String), typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { prefix, additionalInfo });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.String GetTimeoutSubtaskActiveText(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase, global::System.String errorMessage)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTimeoutSubtaskActiveText", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { errorMessage });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalFunctionStageBaseFunctions" />
    internal static  global::System.Nullable<global::Sungero.Core.Enumeration> GetStageType(global::Sungero.Docflow.IApprovalFunctionStageBase approvalFunctionStageBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalFunctionStageBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetStageType", new System.Type[] {  });
      return (global::System.Nullable<global::Sungero.Core.Enumeration>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ApprovalFunctionStageBaseServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalFunctionStageBaseServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalFunctionStageBaseServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalFunctionStageBaseQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class ApprovalFunctionStageBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalFunctionStageBase.ApprovalFunctionStageBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
