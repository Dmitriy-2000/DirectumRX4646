
// ==================================================================
// DocumentComparisonInfoEventArgs.g.cs
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
  public class DocumentComparisonInfoAuthorValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.CoreEntities.IUser>
  {
    public DocumentComparisonInfoAuthorValueInputEventArgs(global::Sungero.CoreEntities.IUser oldValue, global::Sungero.CoreEntities.IUser newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


















}

// ==================================================================
// DocumentComparisonInfoHandlers.g.cs
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

  public partial class DocumentComparisonInfoFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDocumentComparisonInfoFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDocumentComparisonInfoFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentComparisonInfoFilteringClientHandler(global::Sungero.Docflow.IDocumentComparisonInfoFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentComparisonInfoFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DocumentComparisonInfoClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IDocumentComparisonInfo _obj
    {
      get { return (global::Sungero.Docflow.IDocumentComparisonInfo)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void AuthorValueInput(global::Sungero.Docflow.Client.DocumentComparisonInfoAuthorValueInputEventArgs e) { }


    public virtual void FirstDocumentIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void SecondDocumentIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void FirstVersionExtensionValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SecondVersionExtensionValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FirstArioTaskIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void SecondArioTaskIdValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }





    public virtual void DifferencesCountValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ErrorMessageValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ProcessingStatusValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void DeletionDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void FirstVersionNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void SecondVersionNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void FirstVersionHashValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SecondVersionHashValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ProcessingStatusFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }







    public DocumentComparisonInfoClientHandlers(global::Sungero.Docflow.IDocumentComparisonInfo entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentComparisonInfoClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DocumentComparisonInfoFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentComparisonInfo _obj
    {
      get { return (global::Sungero.Docflow.IDocumentComparisonInfo)this.Entity; }
    }

    public DocumentComparisonInfoFunctions(global::Sungero.Docflow.IDocumentComparisonInfo entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentComparisonInfoFunctions.g.cs
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
  internal static class DocumentComparisonInfo
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentComparisonInfoFunctions" />
      internal static  global::Sungero.Docflow.IDocumentComparisonInfo GetLastDocumentComparisonInfo(global::System.String firstVersionHash, global::System.String secondVersionHash, global::Sungero.CoreEntities.IUser author)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IDocumentComparisonInfo>(
          global::System.Guid.Parse("0af2153a-ef3e-47fc-aa8a-aa995031019b"),
          "GetLastDocumentComparisonInfo(global::System.String,global::System.String,global::Sungero.CoreEntities.IUser)"
      , firstVersionHash, secondVersionHash, author);
      }

    }
  }
}

// ==================================================================
// DocumentComparisonInfoClientPublicFunctions.g.cs
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
  public class DocumentComparisonInfoClientPublicFunctions : global::Sungero.Docflow.Client.IDocumentComparisonInfoClientPublicFunctions
  {
  }
}

// ==================================================================
// DocumentComparisonInfoActions.g.cs
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
  public partial class DocumentComparisonInfoActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IDocumentComparisonInfo _obj { get { return (global::Sungero.Docflow.IDocumentComparisonInfo)this.Entity; } }
    public DocumentComparisonInfoActions(global::Sungero.Docflow.IDocumentComparisonInfo entity) : base(entity) { }
  }

  public partial class DocumentComparisonInfoCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDocumentComparisonInfo> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDocumentComparisonInfo>(this.Entities); }
    }
  }

  public partial class DocumentComparisonInfoCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class DocumentComparisonInfoAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class DocumentComparisonInfoAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
