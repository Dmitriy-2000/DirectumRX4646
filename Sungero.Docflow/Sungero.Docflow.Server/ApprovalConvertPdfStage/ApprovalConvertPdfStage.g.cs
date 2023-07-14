
// ==================================================================
// ApprovalConvertPdfStage.g.cs
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
    public class ApprovalConvertPdfStageFilter<T> :
      global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFilter<T>
      where T : class, global::Sungero.Docflow.IApprovalConvertPdfStage
    {
      private global::Sungero.Docflow.IApprovalConvertPdfStageFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IApprovalConvertPdfStageFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ApprovalConvertPdfStageFilter(global::Sungero.Docflow.IApprovalConvertPdfStageFilterState filter)
      : base(filter)
      {
      }

      protected ApprovalConvertPdfStageFilter()
      {
      }
    }
      public class ApprovalConvertPdfStageUiFilter<T> :
        global::Sungero.Docflow.Server.ApprovalFunctionStageBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IApprovalConvertPdfStage
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ApprovalConvertPdfStageSearchDialogModel : global::Sungero.Docflow.Server.ApprovalFunctionStageBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.Int32? DeadlineInDays { get; protected set; }
                  public override global::System.Int32? DeadlineInHours { get; protected set; }
                  public override global::System.String Name { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> TimeoutAction { get; protected set; }




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ApprovalConvertPdfStageFilter<global::Sungero.Docflow.IApprovalConvertPdfStage>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ApprovalConvertPdfStageUiFilter<global::Sungero.Docflow.IApprovalConvertPdfStage>))]

  public class ApprovalConvertPdfStage :
    global::Sungero.Docflow.Server.ApprovalFunctionStageBase, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("77fe4545-9220-4cde-9cf7-a254d28b3ba5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalConvertPdfStage.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalConvertPdfStage, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IApprovalConvertPdfStageState State
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStageState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalConvertPdfStageState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalConvertPdfStageInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStageInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ApprovalConvertPdfStageAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ApprovalConvertPdfStageFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalConvertPdfStageFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalConvertPdfStageServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalConvertPdfStageSharedHandlers(this);
    }

    private global::System.Boolean? _ConvertWithAddenda;
    public virtual global::System.Boolean? ConvertWithAddenda
    {
      get
      {
        return this._ConvertWithAddenda;
      }

      set
      {
        this.SetPropertyValue("ConvertWithAddenda", this._ConvertWithAddenda, value, (propertyValue) => { this._ConvertWithAddenda = propertyValue; }, this.ConvertWithAddendaChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ApprovalConvertPdfStageCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IApprovalConvertPdfStage)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ApprovalConvertPdfStageCreatingFromServerHandler((global::Sungero.Docflow.IApprovalConvertPdfStage)entitySource, this.Info);
    }

    #region Framework events

    protected void ConvertWithAddendaChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.ConvertWithAddenda, this.ConvertWithAddenda, this);
     ((global::Sungero.Docflow.IApprovalConvertPdfStageSharedHandlers)this.SharedHandlers).ConvertWithAddendaChanged(args);
    }



    #endregion


    public ApprovalConvertPdfStage()
    {
    }

  }
}

// ==================================================================
// ApprovalConvertPdfStageHandlers.g.cs
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

  public partial class ApprovalConvertPdfStageFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalFunctionStageBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    private global::Sungero.Docflow.IApprovalConvertPdfStageFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IApprovalConvertPdfStageFilterState)this.Filter;
      }
    }

    public ApprovalConvertPdfStageFilteringServerHandler(global::Sungero.Docflow.IApprovalConvertPdfStageFilterState filter)
    : base(filter)
    {
    }

    protected ApprovalConvertPdfStageFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ApprovalConvertPdfStageUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ApprovalFunctionStageBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IApprovalConvertPdfStage
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ApprovalConvertPdfStageSearchDialogServerHandler : global::Sungero.Docflow.ApprovalFunctionStageBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ApprovalConvertPdfStageSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ApprovalConvertPdfStageSearchDialogModel)this.Dialog;
       }
     }

     public ApprovalConvertPdfStageSearchDialogServerHandler(global::Sungero.Docflow.Server.ApprovalConvertPdfStageSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ApprovalConvertPdfStageServerHandlers : global::Sungero.Docflow.ApprovalFunctionStageBaseServerHandlers
  {
    private global::Sungero.Docflow.IApprovalConvertPdfStage _obj
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStage)this.Entity; }
    }

    public ApprovalConvertPdfStageServerHandlers(global::Sungero.Docflow.IApprovalConvertPdfStage entity)
      : base(entity)
    {
    }
  }

  public partial class ApprovalConvertPdfStageCreatingFromServerHandler : global::Sungero.Docflow.ApprovalFunctionStageBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IApprovalConvertPdfStage _source
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStage)this.Source; }
    }

    private global::Sungero.Docflow.IApprovalConvertPdfStageInfo _info
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStageInfo)this._Info; }
    }

    public ApprovalConvertPdfStageCreatingFromServerHandler(global::Sungero.Docflow.IApprovalConvertPdfStage source, global::Sungero.Docflow.IApprovalConvertPdfStageInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ApprovalConvertPdfStageEventArgs.g.cs
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
// ApprovalConvertPdfStageAccessRights.g.cs
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
  public class ApprovalConvertPdfStageAccessRights : 
    Sungero.Docflow.Server.ApprovalFunctionStageBaseAccessRights, Sungero.Docflow.IApprovalConvertPdfStageAccessRights
  {

    public ApprovalConvertPdfStageAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalConvertPdfStageTypeAccessRights : 
    Sungero.Docflow.Server.ApprovalFunctionStageBaseTypeAccessRights, Sungero.Docflow.IApprovalConvertPdfStageAccessRights
  {

    public ApprovalConvertPdfStageTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ApprovalConvertPdfStageRepositoryImplementer.g.cs
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
    public class ApprovalConvertPdfStageRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ApprovalFunctionStageBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalConvertPdfStageRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalConvertPdfStage 
    {
       public new global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalConvertPdfStageAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalConvertPdfStageInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalConvertPdfStageInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ApprovalConvertPdfStageTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalConvertPdfStagePanelNavigationFilters.g.cs
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
// ApprovalConvertPdfStageServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ApprovalConvertPdfStageFunctions : global::Sungero.Docflow.Server.ApprovalFunctionStageBaseFunctions
  {
    private global::Sungero.Docflow.IApprovalConvertPdfStage _obj
    {
      get { return (global::Sungero.Docflow.IApprovalConvertPdfStage)this.Entity; }
    }

    public ApprovalConvertPdfStageFunctions(global::Sungero.Docflow.IApprovalConvertPdfStage entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalConvertPdfStageFunctions.g.cs
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
  internal static class ApprovalConvertPdfStage
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalConvertPdfStageFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult Execute(global::Sungero.Docflow.IApprovalConvertPdfStage approvalConvertPdfStage, global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalConvertPdfStage).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("Execute", new System.Type[] { typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::Sungero.Docflow.Structures.ApprovalFunctionStageBase.ExecutionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { approvalTask });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalConvertPdfStageFunctions" />
    internal static  global::Sungero.Docflow.Structures.OfficialDocument.СonversionToPdfResult ConvertToPdf(global::Sungero.Docflow.IApprovalConvertPdfStage approvalConvertPdfStage, global::Sungero.Docflow.IOfficialDocument document)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)approvalConvertPdfStage).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ConvertToPdf", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument) });
      return (global::Sungero.Docflow.Structures.OfficialDocument.СonversionToPdfResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document });
    }

  }
}

// ==================================================================
// ApprovalConvertPdfStageServerPublicFunctions.g.cs
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
  public class ApprovalConvertPdfStageServerPublicFunctions : global::Sungero.Docflow.Server.IApprovalConvertPdfStageServerPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalConvertPdfStageQueries.g.cs
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
  public class ApprovalConvertPdfStage
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.ApprovalConvertPdfStage.ApprovalConvertPdfStageQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
