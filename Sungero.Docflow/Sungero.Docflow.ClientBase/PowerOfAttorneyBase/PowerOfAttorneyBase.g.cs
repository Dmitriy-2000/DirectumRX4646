
// ==================================================================
// PowerOfAttorneyBaseEventArgs.g.cs
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
  public class PowerOfAttorneyBaseIssuedToValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public PowerOfAttorneyBaseIssuedToValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




}

// ==================================================================
// PowerOfAttorneyBaseHandlers.g.cs
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

  public partial class PowerOfAttorneyBaseFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyBaseFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyBaseFilteringClientHandler(global::Sungero.Docflow.IPowerOfAttorneyBaseFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class PowerOfAttorneyBaseClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; }
    }

    public virtual void IssuedToValueInput(global::Sungero.Docflow.Client.PowerOfAttorneyBaseIssuedToValueInputEventArgs e) { }




    public virtual void ValidFromValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public PowerOfAttorneyBaseClientHandlers(global::Sungero.Docflow.IPowerOfAttorneyBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class PowerOfAttorneyBaseFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; }
    }

    public PowerOfAttorneyBaseFunctions(global::Sungero.Docflow.IPowerOfAttorneyBase entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyBaseFunctions.g.cs
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
  internal static class PowerOfAttorneyBase
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.PowerOfAttorneyBaseFunctions" />
    internal static  global::System.String CheckCorrectnessDaysToFinishWorks(global::System.Nullable<global::System.DateTime> validTill, global::System.Nullable<global::System.Int32> daysToFinishWorks)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Client.PowerOfAttorneyBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CheckCorrectnessDaysToFinishWorks",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::System.DateTime>), typeof(global::System.Nullable<global::System.Int32>) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { validTill, daysToFinishWorks });
      }
      else
      {
        return global::Sungero.Docflow.Client.PowerOfAttorneyBaseFunctions.CheckCorrectnessDaysToFinishWorks(validTill, daysToFinishWorks);
      }
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, isRepeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyBaseFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorneyBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>>(
          global::System.Guid.Parse("a8d955b1-4b35-4013-b643-3ea9d80bd1ea"),
          "GetSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase)"
          , powerOfAttorneyBase);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetActiveSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase powerOfAttorneyBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>>(
          global::System.Guid.Parse("a8d955b1-4b35-4013-b643-3ea9d80bd1ea"),
          "GetActiveSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorneyBase)"
          , powerOfAttorneyBase);
      }

    }
  }
}

// ==================================================================
// PowerOfAttorneyBaseClientPublicFunctions.g.cs
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
  public class PowerOfAttorneyBaseClientPublicFunctions : global::Sungero.Docflow.Client.IPowerOfAttorneyBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyBaseActions.g.cs
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
  public partial class PowerOfAttorneyBaseActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.IPowerOfAttorneyBase _obj { get { return (global::Sungero.Docflow.IPowerOfAttorneyBase)this.Entity; } }
    public PowerOfAttorneyBaseActions(global::Sungero.Docflow.IPowerOfAttorneyBase entity) : base(entity) { }
  }

  public partial class PowerOfAttorneyBaseCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IPowerOfAttorneyBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IPowerOfAttorneyBase>(this.Entities); }
    }
  }

  public partial class PowerOfAttorneyBaseCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class PowerOfAttorneyBaseAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class PowerOfAttorneyBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}
