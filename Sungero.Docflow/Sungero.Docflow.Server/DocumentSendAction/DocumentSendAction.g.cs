
// ==================================================================
// DocumentSendAction.g.cs
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
    public class DocumentSendActionFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Docflow.IDocumentSendAction
    {
      protected new global::Sungero.Docflow.IDocumentSendActionFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IDocumentSendActionFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public DocumentSendActionFilter(global::Sungero.Docflow.IDocumentSendActionFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected DocumentSendActionFilter()
      {
      }
    }
      public class DocumentSendActionUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Docflow.IDocumentSendAction
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class DocumentSendActionSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String ActionGuid { get; protected set; }



        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.DocumentSendActionFilter<global::Sungero.Docflow.IDocumentSendAction>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.DocumentSendActionUiFilter<global::Sungero.Docflow.IDocumentSendAction>))]

  public class DocumentSendAction :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Docflow.IDocumentSendAction
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("218ac7df-9b29-400a-b3fc-c2e22927f638");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentSendAction.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentSendAction, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IDocumentSendActionState State
    {
      get { return (global::Sungero.Docflow.IDocumentSendActionState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentSendActionState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentSendActionInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentSendActionInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IDocumentSendActionAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IDocumentSendActionAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.DocumentSendActionAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.DocumentSendActionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentSendActionFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentSendActionServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentSendActionSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.String _ActionGuid;
    public virtual global::System.String ActionGuid
    {
      get
      {
        return this._ActionGuid;
      }

      set
      {
        this.SetPropertyValue("ActionGuid", this._ActionGuid, value, (propertyValue) => { this._ActionGuid = propertyValue; }, this.ActionGuidChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.DocumentSendActionCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IDocumentSendAction)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.DocumentSendActionCreatingFromServerHandler((global::Sungero.Docflow.IDocumentSendAction)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IDocumentSendActionSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void ActionGuidChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ActionGuid, this.ActionGuid, this);
     ((global::Sungero.Docflow.IDocumentSendActionSharedHandlers)this.SharedHandlers).ActionGuidChanged(args);
    }



    #endregion


    public DocumentSendAction()
    {
    }

  }
}

// ==================================================================
// DocumentSendActionHandlers.g.cs
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

  public partial class DocumentSendActionFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IDocumentSendAction
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IDocumentSendActionFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDocumentSendActionFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentSendActionFilteringServerHandler(global::Sungero.Docflow.IDocumentSendActionFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentSendActionFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class DocumentSendActionUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IDocumentSendAction
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class DocumentSendActionSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.DocumentSendActionSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.DocumentSendActionSearchDialogModel)this.Dialog;
       }
     }

     public DocumentSendActionSearchDialogServerHandler(global::Sungero.Docflow.Server.DocumentSendActionSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DocumentSendActionServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Docflow.IDocumentSendAction _obj
    {
      get { return (global::Sungero.Docflow.IDocumentSendAction)this.Entity; }
    }

    public DocumentSendActionServerHandlers(global::Sungero.Docflow.IDocumentSendAction entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentSendActionCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IDocumentSendAction _source
    {
      get { return (global::Sungero.Docflow.IDocumentSendAction)this.Source; }
    }

    private global::Sungero.Docflow.IDocumentSendActionInfo _info
    {
      get { return (global::Sungero.Docflow.IDocumentSendActionInfo)this._Info; }
    }

    public DocumentSendActionCreatingFromServerHandler(global::Sungero.Docflow.IDocumentSendAction source, global::Sungero.Docflow.IDocumentSendActionInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DocumentSendActionEventArgs.g.cs
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
// DocumentSendActionAccessRights.g.cs
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
  public class DocumentSendActionAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Docflow.IDocumentSendActionAccessRights
  {

    public DocumentSendActionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentSendActionTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Docflow.IDocumentSendActionAccessRights
  {

    public DocumentSendActionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DocumentSendActionRepositoryImplementer.g.cs
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
    public class DocumentSendActionRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentSendActionRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentSendAction 
    {
       public new global::Sungero.Docflow.IDocumentSendActionAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentSendActionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentSendActionInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentSendActionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.DocumentSendActionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentSendActionPanelNavigationFilters.g.cs
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
// DocumentSendActionServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class DocumentSendActionFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentSendAction _obj
    {
      get { return (global::Sungero.Docflow.IDocumentSendAction)this.Entity; }
    }

    public DocumentSendActionFunctions(global::Sungero.Docflow.IDocumentSendAction entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentSendActionFunctions.g.cs
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
  internal static class DocumentSendAction
  {
  }
}

// ==================================================================
// DocumentSendActionServerPublicFunctions.g.cs
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
  public class DocumentSendActionServerPublicFunctions : global::Sungero.Docflow.Server.IDocumentSendActionServerPublicFunctions
  {
  }
}

// ==================================================================
// DocumentSendActionQueries.g.cs
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
  public class DocumentSendAction
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.DocumentSendAction.DocumentSendActionQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
