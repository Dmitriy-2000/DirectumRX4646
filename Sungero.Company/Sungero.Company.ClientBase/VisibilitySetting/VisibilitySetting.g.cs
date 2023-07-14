
// ==================================================================
// VisibilitySettingEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{ 
}

// ==================================================================
// VisibilitySettingHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{

  public partial class VisibilitySettingFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Company.IVisibilitySettingFilterState Filter { get; private set; }

    private global::Sungero.Company.IVisibilitySettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public VisibilitySettingFilteringClientHandler(global::Sungero.Company.IVisibilitySettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected VisibilitySettingFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class VisibilitySettingClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Company.IVisibilitySetting _obj
    {
      get { return (global::Sungero.Company.IVisibilitySetting)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }




    public virtual void NeedRestrictVisibilityDescriptionValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public VisibilitySettingClientHandlers(global::Sungero.Company.IVisibilitySetting entity) : base(entity)
    {
    }
  }

  public partial class VisibilitySettingUnrestrictedRecipientsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients _obj
    {
      get { return (global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients)this.Entity; }
    }
    public virtual void UnrestrictedRecipientsRecipientValueInput(global::Sungero.Company.Client.VisibilitySettingUnrestrictedRecipientsRecipientValueInputEventArgs e) { }


    public VisibilitySettingUnrestrictedRecipientsClientHandlers(global::Sungero.Company.IVisibilitySettingUnrestrictedRecipients entity) : base(entity)
    {
    }
  }

  public partial class VisibilitySettingHiddenRecipientsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Company.IVisibilitySettingHiddenRecipients _obj
    {
      get { return (global::Sungero.Company.IVisibilitySettingHiddenRecipients)this.Entity; }
    }
    public virtual void HiddenRecipientsRecipientValueInput(global::Sungero.Company.Client.VisibilitySettingHiddenRecipientsRecipientValueInputEventArgs e) { }


    public VisibilitySettingHiddenRecipientsClientHandlers(global::Sungero.Company.IVisibilitySettingHiddenRecipients entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// VisibilitySettingClientFunctions.g.cs
// ==================================================================

namespace Sungero.Company.Client
{
  public partial class VisibilitySettingFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Company.IVisibilitySetting _obj
    {
      get { return (global::Sungero.Company.IVisibilitySetting)this.Entity; }
    }

    public VisibilitySettingFunctions(global::Sungero.Company.IVisibilitySetting entity) : base(entity) { }
  }
}

// ==================================================================
// VisibilitySettingFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Functions
{
  internal static class VisibilitySetting
  {
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.VisibilitySettingFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Company.IVisibilitySetting visibilitySetting)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)visibilitySetting).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// VisibilitySettingClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilitySettingClientPublicFunctions : global::Sungero.Company.Client.IVisibilitySettingClientPublicFunctions
  {
  }
}

// ==================================================================
// VisibilitySettingActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public partial class VisibilitySettingActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Company.IVisibilitySetting _obj { get { return (global::Sungero.Company.IVisibilitySetting)this.Entity; } }
    public VisibilitySettingActions(global::Sungero.Company.IVisibilitySetting entity) : base(entity) { }
  }

  public partial class VisibilitySettingCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Company.IVisibilitySetting> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Company.IVisibilitySetting>(this.Entities); }
    }
  }

  public partial class VisibilitySettingCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class VisibilitySettingAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class VisibilitySettingAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
