
// ==================================================================
// BlobPackageEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{ 
  public class BlobPackageMailBodyBlobValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.SmartProcessing.IBlob>
  {
    public BlobPackageMailBodyBlobValueInputEventArgs(global::Sungero.SmartProcessing.IBlob oldValue, global::Sungero.SmartProcessing.IBlob newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }









}

// ==================================================================
// BlobPackageHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{

  public partial class BlobPackageFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.SmartProcessing.IBlobPackageFilterState Filter { get; private set; }

    private global::Sungero.SmartProcessing.IBlobPackageFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public BlobPackageFilteringClientHandler(global::Sungero.SmartProcessing.IBlobPackageFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected BlobPackageFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class BlobPackageClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.SmartProcessing.IBlobPackage _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackage)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PackageFolderPathValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SenderLineValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SourceTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }



    public virtual void FromNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void FromAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }




    public virtual void MailBodyBlobValueInput(global::Sungero.SmartProcessing.Client.BlobPackageMailBodyBlobValueInputEventArgs e) { }


    public virtual void SubjectValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ProcessStateValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void PackageIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SourceNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DcsProcessingBeginDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void MessageIdValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PriorityValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SendDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> SourceTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }









    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ProcessStateFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }








    public BlobPackageClientHandlers(global::Sungero.SmartProcessing.IBlobPackage entity) : base(entity)
    {
    }
  }

  public partial class BlobPackageBlobsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.SmartProcessing.IBlobPackageBlobs _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageBlobs)this.Entity; }
    }
    public virtual void BlobsBlobValueInput(global::Sungero.SmartProcessing.Client.BlobPackageBlobsBlobValueInputEventArgs e) { }


    public BlobPackageBlobsClientHandlers(global::Sungero.SmartProcessing.IBlobPackageBlobs entity) : base(entity)
    {
    }
  }

  public partial class BlobPackageToClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.SmartProcessing.IBlobPackageTo _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageTo)this.Entity; }
    }
    public virtual void ToNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ToAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public BlobPackageToClientHandlers(global::Sungero.SmartProcessing.IBlobPackageTo entity) : base(entity)
    {
    }
  }

  public partial class BlobPackageCCClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.SmartProcessing.IBlobPackageCC _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageCC)this.Entity; }
    }
    public virtual void CCNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CCAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public BlobPackageCCClientHandlers(global::Sungero.SmartProcessing.IBlobPackageCC entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// BlobPackageClientFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Client
{
  public partial class BlobPackageFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.SmartProcessing.IBlobPackage _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackage)this.Entity; }
    }

    public BlobPackageFunctions(global::Sungero.SmartProcessing.IBlobPackage entity) : base(entity) { }
  }
}

// ==================================================================
// BlobPackageFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class BlobPackage
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.BlobPackageFunctions" />
      internal static  global::Sungero.SmartProcessing.IBlobPackage CreateBlobPackage()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.SmartProcessing.IBlobPackage>(
          global::System.Guid.Parse("1e9415ec-6ba8-46b5-b864-94b4385ffb52"),
          "CreateBlobPackage()"
      );
      }

    }
  }
}

// ==================================================================
// BlobPackageClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class BlobPackageClientPublicFunctions : global::Sungero.SmartProcessing.Client.IBlobPackageClientPublicFunctions
  {
  }
}

// ==================================================================
// BlobPackageActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public partial class BlobPackageActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.SmartProcessing.IBlobPackage _obj { get { return (global::Sungero.SmartProcessing.IBlobPackage)this.Entity; } }
    public BlobPackageActions(global::Sungero.SmartProcessing.IBlobPackage entity) : base(entity) { }
  }

  public partial class BlobPackageCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.SmartProcessing.IBlobPackage> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.SmartProcessing.IBlobPackage>(this.Entities); }
    }
  }

  public partial class BlobPackageCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int32> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class BlobPackageAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class BlobPackageAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
