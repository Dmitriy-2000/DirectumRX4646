
// ==================================================================
// DocumentKindState.g.cs
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
  public class DocumentKindState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IDocumentKindState
  {
    public DocumentKindState(global::Sungero.Docflow.IDocumentKind entity) : base(entity) { }

    public new global::Sungero.Docflow.IDocumentKindPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IDocumentKindPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentKindPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IDocumentKindControlStates Controls
    {
      get { return (global::Sungero.Docflow.IDocumentKindControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentKindControlStates(entity);
    }

    public new global::Sungero.Docflow.IDocumentKindPageStates Pages
    {
      get { return (global::Sungero.Docflow.IDocumentKindPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentKindPageStates(entity);
    }

  }


  public class DocumentKindControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IDocumentKindControlStates
  {

    protected internal DocumentKindControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DocumentKindPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IDocumentKindPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal DocumentKindPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DocumentKindPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IDocumentKindPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> DocumentFlow 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("DocumentFlow"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> DeadlineInDays 
            {
              get { return this.GetPropertyState<global::System.Int32?>("DeadlineInDays"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ShortName 
            {
              get { return this.GetPropertyState<global::System.String>("ShortName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> DeadlineInHours 
            {
              get { return this.GetPropertyState<global::System.Int32?>("DeadlineInHours"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> NumberingType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("NumberingType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> GenerateDocumentName 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("GenerateDocumentName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> AutoNumbering 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("AutoNumbering"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentType> DocumentType 
            {
              get { return this.InternalDocumentType; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentType> InternalDocumentType
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentType>("DocumentType"); }
            }
            public global::Sungero.Docflow.IDocumentKindAvailableActionsCollectionPropertyState<global::Sungero.Docflow.IDocumentKindAvailableActions> AvailableActions 
            {
              get { return this.GetPropertyState("AvailableActions", this.CreateAvailableActionsState); }
            }

            protected virtual global::Sungero.Docflow.IDocumentKindAvailableActionsCollectionPropertyState<global::Sungero.Docflow.IDocumentKindAvailableActions> CreateAvailableActionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.DocumentKindAvailableActionsCollectionPropertyState<global::Sungero.Docflow.IDocumentKindAvailableActions>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> ProjectsAccounting 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("ProjectsAccounting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> GrantRightsToProject 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("GrantRightsToProject"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsDefault 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsDefault"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Code 
            {
              get { return this.GetPropertyState<global::System.String>("Code"); }
            }


    protected internal DocumentKindPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DocumentKindInfo.g.cs
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
  public class DocumentKindInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IDocumentKindInfo
  {
    public DocumentKindInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IDocumentKindPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IDocumentKindPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IDocumentKindActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IDocumentKindActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.DocumentKindPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.DocumentKindActionsInfo(entityType);
    }
  }

  public class DocumentKindPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IDocumentKindPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo DocumentFlow 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("DocumentFlow");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
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
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo DeadlineInDays 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("DeadlineInDays");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ShortName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ShortName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo DeadlineInHours 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("DeadlineInHours");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo NumberingType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("NumberingType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo GenerateDocumentName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("GenerateDocumentName");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo AutoNumbering 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("AutoNumbering");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentTypeInfo, global::Sungero.Docflow.IDocumentType> DocumentType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentType");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentTypeInfo, global::Sungero.Docflow.IDocumentType>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IDocumentKindAvailableActionsPropertiesInfo> AvailableActions 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("AvailableActions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IDocumentKindAvailableActionsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo ProjectsAccounting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("ProjectsAccounting");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo GrantRightsToProject 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("GrantRightsToProject");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsDefault 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsDefault");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Code 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Code");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal DocumentKindPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class DocumentKindActionsInfo : 
    global::Sungero.Domain.Shared.EntityActionsInfo, global::Sungero.Docflow.IDocumentKindActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo ShowSettings 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowSettings")); }
        }


    protected internal DocumentKindActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// DocumentKindHandlers.g.cs
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
  public partial class DocumentKindSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IDocumentKindSharedHandlers
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }
    public virtual void NoteChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void DeadlineInDaysChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void ShortNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void DeadlineInHoursChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }



    public virtual void GenerateDocumentNameChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void AutoNumberingChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void DocumentTypeChanged(global::Sungero.Docflow.Shared.DocumentKindDocumentTypeChangedEventArgs e) { }


    public virtual void AvailableActionsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }



    public virtual void GrantRightsToProjectChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void IsDefaultChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }


    public virtual void CodeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public DocumentKindSharedHandlers(global::Sungero.Docflow.IDocumentKind entity) : base(entity)
    {
    }
  }

  public partial class DocumentKindAvailableActionsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IDocumentKindAvailableActionsSharedHandlers
  {
    private global::Sungero.Docflow.IDocumentKindAvailableActions _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKindAvailableActions)this.Entity; }
    }
    public virtual void AvailableActionsActionChanged(global::Sungero.Docflow.Shared.DocumentKindAvailableActionsActionChangedEventArgs e) { }



    public DocumentKindAvailableActionsSharedHandlers(global::Sungero.Docflow.IDocumentKindAvailableActions entity) : base(entity)
    {
    }
  }

  public partial class DocumentKindAvailableActionsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    { 
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    private global::Sungero.Docflow.IDocumentKindAvailableActions _added
    {
      get { return (global::Sungero.Docflow.IDocumentKindAvailableActions)this._Added; }
    }

    private global::Sungero.Docflow.IDocumentKindAvailableActions _deleted
    {
      get { return (global::Sungero.Docflow.IDocumentKindAvailableActions)this._Deleted; }
    }

    private global::Sungero.Docflow.IDocumentKindAvailableActions _source
    {
      get { return (global::Sungero.Docflow.IDocumentKindAvailableActions)this._Source; }
    }

    public virtual void AvailableActionsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void AvailableActionsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public DocumentKindAvailableActionsSharedCollectionHandlers(global::Sungero.Docflow.IDocumentKind entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// DocumentKindResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.DocumentKind
{
  /// <summary>
  /// Represents DocumentKind resources.
  /// </summary>
  public class DocumentKindResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.DocumentKind.IDocumentKindResources
  {
    public virtual global::CommonLibrary.LocalizedString IncorrectDeadline
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind) , "IncorrectDeadline");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectDeadlineFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind), "IncorrectDeadline", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString CantDelete
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind) , "CantDelete");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CantDeleteFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind), "CantDelete", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString CantChange
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind) , "CantChange");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CantChangeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind), "CantChange", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ClosedDocumentKindCannotBeDefault
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind) , "ClosedDocumentKindCannotBeDefault");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ClosedDocumentKindCannotBeDefaultFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind), "ClosedDocumentKindCannotBeDefault", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString CantClose
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind) , "CantClose");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CantCloseFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IDocumentKind), "CantClose", false, args);
    }

  }
}

// ==================================================================
// DocumentKindSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class DocumentKindFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public DocumentKindFunctions(global::Sungero.Docflow.IDocumentKind entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentKindFunctions.g.cs
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
  internal static class DocumentKind
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetConsiderationDate(global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.CoreEntities.IUser user)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.DocumentKindFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetConsiderationDate",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IDocumentKind), typeof(global::Sungero.CoreEntities.IUser) }, null);
        return (global::System.Nullable<global::System.DateTime>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentKind, user });
      }
      else
      {
        return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetConsiderationDate(documentKind, user);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(System.Type documentType)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.DocumentKindFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetAvailableDocumentKinds",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(System.Type) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentType });
      }
      else
      {
        return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetAvailableDocumentKinds(documentType);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.String> GetDocumentGuids(System.Type documentType)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.DocumentKindFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetDocumentGuids",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(System.Type) }, null);
        return (global::System.Collections.Generic.List<global::System.String>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentType });
      }
      else
      {
        return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetDocumentGuids(documentType);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::Sungero.Docflow.IDocumentKind GetNativeDocumentKindRemote(global::System.Guid externalLink)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IDocumentKind>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "GetNativeDocumentKindRemote(global::System.Guid)"
      , externalLink);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetDocumentKinds()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "GetDocumentKinds()"
      );
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::System.Boolean HasDocumentKindWithNullCode()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "HasDocumentKindWithNullCode()"
      );
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAllDocumentKinds()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "GetAllDocumentKinds()"
      );
      }

    }
  }
}

// ==================================================================
// DocumentKindFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.DocumentKind
{

  public class DocumentKindFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IDocumentKindFilterInfo
  {
  }

  public class DocumentKindFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IDocumentKindFilterState
  {



    public new Sungero.Docflow.IDocumentKindFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IDocumentKindFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.DocumentKind.DocumentKindFilterInfo();
    }

  }
}

// ==================================================================
// DocumentKindSharedPublicFunctions.g.cs
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
  public class DocumentKindSharedPublicFunctions : global::Sungero.Docflow.Shared.IDocumentKindSharedPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(System.Type documentType)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.GetAvailableDocumentKinds(documentType);
    }
    public global::System.Nullable<global::System.DateTime> GetConsiderationDate(global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.CoreEntities.IUser user)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.GetConsiderationDate(documentKind, user);
    }
    public global::System.Collections.Generic.List<global::System.String> GetDocumentGuids(System.Type documentType)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.GetDocumentGuids(documentType);
    }
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> Remote_GetDocumentKinds()
    {
      return global::Sungero.Docflow.Functions.DocumentKind.Remote.GetDocumentKinds();
    }
    public global::Sungero.Docflow.IDocumentKind Remote_GetNativeDocumentKindRemote(global::System.Guid externalLink)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.Remote.GetNativeDocumentKindRemote(externalLink);
    }
  }
}
