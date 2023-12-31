
// ==================================================================
// DocumentGroupBaseState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentGroupBaseState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IDocumentGroupBaseState
  {
    public DocumentGroupBaseState(global::Sungero.Docflow.IDocumentGroupBase entity) : base(entity) { }

    public new global::Sungero.Docflow.IDocumentGroupBasePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBasePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBasePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IDocumentGroupBaseControlStates Controls
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBaseControlStates(entity);
    }

    public new global::Sungero.Docflow.IDocumentGroupBasePageStates Pages
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBasePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBasePageStates(entity);
    }

  }


  public class DocumentGroupBaseControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IDocumentGroupBaseControlStates
  {

    protected internal DocumentGroupBaseControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DocumentGroupBasePageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IDocumentGroupBasePageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal DocumentGroupBasePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DocumentGroupBasePropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IDocumentGroupBasePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Docflow.IDocumentGroupBaseDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds> DocumentKinds 
            {
              get { return this.GetPropertyState("DocumentKinds", this.CreateDocumentKindsState); }
            }

            protected virtual global::Sungero.Docflow.IDocumentGroupBaseDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds> CreateDocumentKindsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.DocumentGroupBaseDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }


    protected internal DocumentGroupBasePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DocumentGroupBaseInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentGroupBaseInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IDocumentGroupBaseInfo
  {
    public DocumentGroupBaseInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IDocumentGroupBasePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBasePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.DocumentGroupBasePropertiesInfo(entityType);
    }

  }

  public class DocumentGroupBasePropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IDocumentGroupBasePropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseDocumentKindsPropertiesInfo> DocumentKinds 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("DocumentKinds");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IDocumentGroupBaseDocumentKindsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Note 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Note");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal DocumentGroupBasePropertiesInfo(global::System.Type entityType) : base(entityType) { }
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
  public partial class DocumentGroupBaseSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IDocumentGroupBaseSharedHandlers
  {
    private global::Sungero.Docflow.IDocumentGroupBase _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBase)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void DocumentKindsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public DocumentGroupBaseSharedHandlers(global::Sungero.Docflow.IDocumentGroupBase entity) : base(entity)
    {
    }
  }

  public partial class DocumentGroupBaseDocumentKindsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IDocumentGroupBaseDocumentKindsSharedHandlers
  {
    private global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds)this.Entity; }
    }
    public virtual void DocumentKindsDocumentKindChanged(global::Sungero.Docflow.Shared.DocumentGroupBaseDocumentKindsDocumentKindChangedEventArgs e) { }



    public DocumentGroupBaseDocumentKindsSharedHandlers(global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds entity) : base(entity)
    {
    }
  }

  public partial class DocumentGroupBaseDocumentKindsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Docflow.IDocumentGroupBase _obj
    { 
      get { return (global::Sungero.Docflow.IDocumentGroupBase)this.Entity; }
    }

    private global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds _added
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds)this._Added; }
    }

    private global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds _deleted
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds)this._Deleted; }
    }

    private global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds _source
    {
      get { return (global::Sungero.Docflow.IDocumentGroupBaseDocumentKinds)this._Source; }
    }

    public virtual void DocumentKindsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void DocumentKindsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public DocumentGroupBaseDocumentKindsSharedCollectionHandlers(global::Sungero.Docflow.IDocumentGroupBase entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// DocumentGroupBaseResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.DocumentGroupBase
{
  /// <summary>
  /// Represents DocumentGroupBase resources.
  /// </summary>
  public class DocumentGroupBaseResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.DocumentGroupBase.IDocumentGroupBaseResources
  {
  }
}

// ==================================================================
// DocumentGroupBaseSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class DocumentGroupBaseFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
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

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentGroupBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetDocumentGroups()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase>>(
          global::System.Guid.Parse("f5061291-4ac6-428f-b091-d53acdbe9ae5"),
          "GetDocumentGroups()"
      );
      }

    }
  }
}

// ==================================================================
// DocumentGroupBaseFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.DocumentGroupBase
{

  public class DocumentGroupBaseFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IDocumentGroupBaseFilterInfo
  {
  }

  public class DocumentGroupBaseFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IDocumentGroupBaseFilterState
  {



    public new Sungero.Docflow.IDocumentGroupBaseFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IDocumentGroupBaseFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.DocumentGroupBase.DocumentGroupBaseFilterInfo();
    }

  }
}

// ==================================================================
// DocumentGroupBaseSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentGroupBaseSharedPublicFunctions : global::Sungero.Docflow.Shared.IDocumentGroupBaseSharedPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> GetAvailableDocumentGroup(global::Sungero.Docflow.IDocumentKind documentKind)
    {
      return global::Sungero.Docflow.Functions.DocumentGroupBase.GetAvailableDocumentGroup(documentKind);
    }
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentGroupBase> Remote_GetDocumentGroups()
    {
      return global::Sungero.Docflow.Functions.DocumentGroupBase.Remote.GetDocumentGroups();
    }
  }
}
