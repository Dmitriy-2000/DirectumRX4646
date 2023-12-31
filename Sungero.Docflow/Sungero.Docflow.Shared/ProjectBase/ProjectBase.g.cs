
// ==================================================================
// ProjectBaseState.g.cs
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
  public class ProjectBaseState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IProjectBaseState
  {
    public ProjectBaseState(global::Sungero.Docflow.IProjectBase entity) : base(entity) { }

    public new global::Sungero.Docflow.IProjectBasePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IProjectBasePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ProjectBasePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IProjectBaseControlStates Controls
    {
      get { return (global::Sungero.Docflow.IProjectBaseControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ProjectBaseControlStates(entity);
    }

    public new global::Sungero.Docflow.IProjectBasePageStates Pages
    {
      get { return (global::Sungero.Docflow.IProjectBasePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ProjectBasePageStates(entity);
    }

  }


  public class ProjectBaseControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IProjectBaseControlStates
  {

    protected internal ProjectBaseControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ProjectBasePageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IProjectBasePageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal ProjectBasePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ProjectBasePropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IProjectBasePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }


    protected internal ProjectBasePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ProjectBaseInfo.g.cs
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
  public class ProjectBaseInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IProjectBaseInfo
  {
    public ProjectBaseInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IProjectBasePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IProjectBasePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ProjectBasePropertiesInfo(entityType);
    }

  }

  public class ProjectBasePropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IProjectBasePropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal ProjectBasePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ProjectBaseHandlers.g.cs
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
  public partial class ProjectBaseSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IProjectBaseSharedHandlers
  {
    private global::Sungero.Docflow.IProjectBase _obj
    {
      get { return (global::Sungero.Docflow.IProjectBase)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public ProjectBaseSharedHandlers(global::Sungero.Docflow.IProjectBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectBaseResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ProjectBase
{
  /// <summary>
  /// Represents ProjectBase resources.
  /// </summary>
  public class ProjectBaseResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.ProjectBase.IProjectBaseResources
  {
  }
}

// ==================================================================
// ProjectBaseSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ProjectBaseFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IProjectBase _obj
    {
      get { return (global::Sungero.Docflow.IProjectBase)this.Entity; }
    }

    public ProjectBaseFunctions(global::Sungero.Docflow.IProjectBase entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectBaseFunctions.g.cs
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
  internal static class ProjectBase
  {
  }
}

// ==================================================================
// ProjectBaseFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ProjectBase
{

  public class ProjectBaseFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IProjectBaseFilterInfo
  {
  }

  public class ProjectBaseFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IProjectBaseFilterState
  {



    public new Sungero.Docflow.IProjectBaseFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IProjectBaseFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ProjectBase.ProjectBaseFilterInfo();
    }

  }
}

// ==================================================================
// ProjectBaseSharedPublicFunctions.g.cs
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
  public class ProjectBaseSharedPublicFunctions : global::Sungero.Docflow.Shared.IProjectBaseSharedPublicFunctions
  {
  }
}
