
// ==================================================================
// AgendaEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{ 
  public class AgendaMeetingValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Meetings.IMeeting>
  {
    public AgendaMeetingValueInputEventArgs(global::Sungero.Meetings.IMeeting oldValue, global::Sungero.Meetings.IMeeting newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// AgendaHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{

  public partial class AgendaFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Meetings.IAgendaFilterState _filter
    {
      get
      {
        return (Sungero.Meetings.IAgendaFilterState)this.Filter;
      }
    }

    public AgendaFilteringClientHandler(global::Sungero.Meetings.IAgendaFilterState filter)
    : base(filter)
    {
    }

    protected AgendaFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class AgendaClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Meetings.IAgenda _obj
    {
      get { return (global::Sungero.Meetings.IAgenda)this.Entity; }
    }

    public virtual void MeetingValueInput(global::Sungero.Meetings.Client.AgendaMeetingValueInputEventArgs e) { }


    public AgendaClientHandlers(global::Sungero.Meetings.IAgenda entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AgendaClientFunctions.g.cs
// ==================================================================

namespace Sungero.Meetings.Client
{
  public partial class AgendaFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Meetings.IAgenda _obj
    {
      get { return (global::Sungero.Meetings.IAgenda)this.Entity; }
    }

    public AgendaFunctions(global::Sungero.Meetings.IAgenda entity) : base(entity) { }
  }
}

// ==================================================================
// AgendaFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Functions
{
  internal static class Agenda
  {
    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.AgendaFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Meetings.IAgenda agenda)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)agenda).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.AgendaFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Meetings.IAgenda agenda, global::System.Boolean isEnabled, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)agenda).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeDocumentPropertiesAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, repeatRegister });
    }
    /// <redirect project="Sungero.Meetings.Shared" type="Sungero.Meetings.Shared.AgendaFunctions" />
    internal static  void FillName(global::Sungero.Meetings.IAgenda agenda)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)agenda).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Meetings.Server" type="Sungero.Meetings.Server.AgendaFunctions" />
      internal static  global::Sungero.Meetings.IAgenda CreateAgenda()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Meetings.IAgenda>(
          global::System.Guid.Parse("5261da93-7879-4210-b3db-c92fa894ab4d"),
          "CreateAgenda()"
      );
      }

    }
  }
}

// ==================================================================
// AgendaClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{
  public class AgendaClientPublicFunctions : global::Sungero.Meetings.Client.IAgendaClientPublicFunctions
  {
  }
}

// ==================================================================
// AgendaActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{
  public partial class AgendaActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Meetings.IAgenda _obj { get { return (global::Sungero.Meetings.IAgenda)this.Entity; } }
    public AgendaActions(global::Sungero.Meetings.IAgenda entity) : base(entity) { }
  }

  public partial class AgendaCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Meetings.IAgenda> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Meetings.IAgenda>(this.Entities); }
    }
  }

  public partial class AgendaCollectionBulkActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class AgendaAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class AgendaAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }



}