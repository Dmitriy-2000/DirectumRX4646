
// ==================================================================
// DocumentGroupBase.g.cs
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
    public class DocumentGroupBaseFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Docflow.IDocumentGroupBase
    {
      protected new global::Sungero.Docflow.IDocumentGroupBaseFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IDocumentGroupBaseFilterState filter
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

      public DocumentGroupBaseFilter(global::Sungero.Docflow.IDocumentGroupBaseFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected DocumentGroupBaseFilter()
      {
      }
    }
      public class DocumentGroupBaseUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Docflow.IDocumentGroupBase
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class DocumentGroupBaseSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Note { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }


                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public DocumentGroupBaseDocumentKindsModel DocumentKinds { get; protected set; }

        }


      public class DocumentGroupBaseDocumentKindsModel : global::Sungero.Domain.CollectionPropertySearchDialogModel
          {
            public override global::System.Int32? Id { get; protected set; }


         }




  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.DocumentGroupBaseFilter<global::Sungero.Docflow.IDocumentGroupBase>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.DocumentGroupBaseUiFilter<global::Sungero.Docflow.IDocumentGroupBase>))]

  public class DocumentGroupBase :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Docflow.IDocumentGroupBase
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f5061291-4ac6-428f-b091-d53acdbe9ae5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentGroupBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentGroupBase, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IDocumentGroupBaseState State
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBaseState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentGroupBaseInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IDocumentGroupBaseAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.DocumentGroupBaseAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.DocumentGroupBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBaseFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentGroupBaseServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentGroupBaseSharedHandlers(this);
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
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }








    protected global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds> _DocumentKinds;

    public virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds> DocumentKinds
    {
      get
      {
        if (this._DocumentKinds == null)
        {
          this._DocumentKinds = this.CreateDocumentKindsCollection();
          this.SetDocumentKindsEventHandlers();
        }
        return this._DocumentKinds;
      }

      set
      {
        if (this._DocumentKinds != null)
          this.UnsetChildCollectionEventHandlers(this._DocumentKinds);

        this._DocumentKinds = value;
        this.SetDocumentKindsEventHandlers();
      }
    }

    protected virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds> CreateDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds>() { RootEntity = this };
    }

    private void SetDocumentKindsEventHandlers()
    {
      this.SetChildCollectionEventHandlers(this._DocumentKinds, "DocumentKinds");

      var changeNotifier = (global::Sungero.Domain.Shared.INotifyChildEntityCollectionChanged)this._DocumentKinds;
      changeNotifier.Added += this.DocumentKindsAddedHandler;
      changeNotifier.Deleted += this.DocumentKindsDeletedHandler;
      changeNotifier.Added += this.DocumentKindsCollectionUpdateEventHandler;
      changeNotifier.Deleted += this.DocumentKindsCollectionUpdateEventHandler;
      changeNotifier.Updated += this.DocumentKindsCollectionUpdateEventHandler;
    }

    private void DocumentKindsCollectionUpdateEventHandler(object sender, global::Sungero.Domain.Shared.BaseChildEntityEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      if (this.IsPropertyChangedHandlerEnabled && this.IsPropertyChangedAppliedHandlerEnabled("DocumentKinds"))
        this.DocumentKindsChangedHandler();
    }



    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.DocumentGroupBaseCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IDocumentGroupBase)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.DocumentGroupBaseCreatingFromServerHandler((global::Sungero.Docflow.IDocumentGroupBase)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.IDocumentGroupBaseSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DocumentKindsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IDocumentGroupBaseSharedHandlers)this.SharedHandlers).DocumentKindsChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.IDocumentGroupBaseSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }



    protected virtual global::Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers CreateDocumentKindsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers CreateDocumentKindsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void DocumentKindsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("DocumentKindsAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateDocumentKindsAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.DocumentKindsAdded(args);
        }
      }
    }

    protected virtual void DocumentKindsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DocumentGroupBaseDocumentKindsSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("DocumentKindsDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateDocumentKindsDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.DocumentKindsDeleted(args);
        }
      }
    }


    #endregion


    public DocumentGroupBase()
    {
    }

  }
}

// ==================================================================
// DocumentGroupBaseHandlers.g.cs
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

  public partial class DocumentGroupBaseFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IDocumentGroupBase
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IDocumentGroupBaseFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDocumentGroupBaseFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentGroupBaseFilteringServerHandler(global::Sungero.Docflow.IDocumentGroupBaseFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentGroupBaseFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class DocumentGroupBaseUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IDocumentGroupBase
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class DocumentGroupBaseSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.DocumentGroupBaseSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.DocumentGroupBaseSearchDialogModel)this.Dialog;
       }
     }

     public DocumentGroupBaseSearchDialogServerHandler(global::Sungero.Docflow.Server.DocumentGroupBaseSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DocumentGroupBaseServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Docflow.IDocumentGroupBase _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBase)this.Entity; }
    }

    public DocumentGroupBaseServerHandlers(global::Sungero.Docflow.IDocumentGroupBase entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentGroupBaseCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IDocumentGroupBase _source
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBase)this.Source; }
    }

    private global::Sungero.Docflow.IDocumentGroupBaseInfo _info
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseInfo)this._Info; }
    }

    public DocumentGroupBaseCreatingFromServerHandler(global::Sungero.Docflow.IDocumentGroupBase source, global::Sungero.Docflow.IDocumentGroupBaseInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DocumentGroupBaseEventArgs.g.cs
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
// DocumentGroupBaseAccessRights.g.cs
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
  public class DocumentGroupBaseAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Docflow.IDocumentGroupBaseAccessRights
  {

    public DocumentGroupBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentGroupBaseTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Docflow.IDocumentGroupBaseAccessRights
  {

    public DocumentGroupBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DocumentGroupBaseRepositoryImplementer.g.cs
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
    public class DocumentGroupBaseRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentGroupBaseRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentGroupBase 
    {
       public new global::Sungero.Docflow.IDocumentGroupBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentGroupBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentGroupBaseInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentGroupBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.DocumentGroupBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentGroupBasePanelNavigationFilters.g.cs
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
// DocumentGroupBaseServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class DocumentGroupBaseFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentGroupBase _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBase)this.Entity; }
    }

    public DocumentGroupBaseFunctions(global::Sungero.Docflow.IDocumentGroupBase entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentGroupBaseFunctions.g.cs
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
  internal static class DocumentGroupBase
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentGroupBaseFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetDocumentGroups()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DocumentGroupBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDocumentGroups",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Docflow.Server.DocumentGroupBaseFunctions.GetDocumentGroups();
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentGroupBaseFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetDocumentGroupsByDocumentKind(global::Sungero.Docflow.IDocumentKind documentKind)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.DocumentGroupBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDocumentGroupsByDocumentKind",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IDocumentKind) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentKind });
      }
      else
      {
        return global::Sungero.Docflow.Server.DocumentGroupBaseFunctions.GetDocumentGroupsByDocumentKind(documentKind);
      }
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentGroupBaseFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetAvailableDocumentGroup(global::Sungero.Docflow.IDocumentKind documentKind)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.DocumentGroupBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetAvailableDocumentGroup",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IDocumentKind) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentKind });
      }
      else
      {
        return global::Sungero.Docflow.Shared.DocumentGroupBaseFunctions.GetAvailableDocumentGroup(documentKind);
      }
    }

  }
}

// ==================================================================
// DocumentGroupBaseServerPublicFunctions.g.cs
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
  public class DocumentGroupBaseServerPublicFunctions : global::Sungero.Docflow.Server.IDocumentGroupBaseServerPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetDocumentGroupsByDocumentKind(global::Sungero.Docflow.IDocumentKind documentKind)
    {
      return global::Sungero.Docflow.Functions.DocumentGroupBase.GetDocumentGroupsByDocumentKind(documentKind);
    }
  }
}

// ==================================================================
// DocumentGroupBaseQueries.g.cs
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
  public class DocumentGroupBase
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.DocumentGroupBase.DocumentGroupBaseQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
