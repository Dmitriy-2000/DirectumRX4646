
// ==================================================================
// FileRetentionPeriodState.g.cs
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
  public class FileRetentionPeriodState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IFileRetentionPeriodState
  {
    public FileRetentionPeriodState(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity) { }

    public new global::Sungero.Docflow.IFileRetentionPeriodPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriodPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FileRetentionPeriodPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IFileRetentionPeriodControlStates Controls
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriodControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FileRetentionPeriodControlStates(entity);
    }

    public new global::Sungero.Docflow.IFileRetentionPeriodPageStates Pages
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriodPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FileRetentionPeriodPageStates(entity);
    }

  }


  public class FileRetentionPeriodControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IFileRetentionPeriodControlStates
  {

    protected internal FileRetentionPeriodControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class FileRetentionPeriodPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IFileRetentionPeriodPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal FileRetentionPeriodPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class FileRetentionPeriodPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IFileRetentionPeriodPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> RetentionPeriod 
            {
              get { return this.GetPropertyState<global::System.Int32?>("RetentionPeriod"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }


    protected internal FileRetentionPeriodPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// FileRetentionPeriodInfo.g.cs
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
  public class FileRetentionPeriodInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IFileRetentionPeriodInfo
  {
    public FileRetentionPeriodInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IFileRetentionPeriodPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriodPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FileRetentionPeriodPropertiesInfo(entityType);
    }

  }

  public class FileRetentionPeriodPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IFileRetentionPeriodPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo RetentionPeriod 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("RetentionPeriod");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
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


    protected internal FileRetentionPeriodPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// FileRetentionPeriodHandlers.g.cs
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
  public partial class FileRetentionPeriodSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IFileRetentionPeriodSharedHandlers
  {
    private global::Sungero.Docflow.IFileRetentionPeriod _obj
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriod)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void RetentionPeriodChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public FileRetentionPeriodSharedHandlers(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FileRetentionPeriodResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.FileRetentionPeriod
{
  /// <summary>
  /// Represents FileRetentionPeriod resources.
  /// </summary>
  public class FileRetentionPeriodResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.FileRetentionPeriod.IFileRetentionPeriodResources
  {
    public virtual global::CommonLibrary.LocalizedString WrongRetentionPeriod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFileRetentionPeriod) , "WrongRetentionPeriod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString WrongRetentionPeriodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFileRetentionPeriod), "WrongRetentionPeriod", false, args);
    }

  }
}

// ==================================================================
// FileRetentionPeriodSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class FileRetentionPeriodFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IFileRetentionPeriod _obj
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriod)this.Entity; }
    }

    public FileRetentionPeriodFunctions(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity) { }
  }
}

// ==================================================================
// FileRetentionPeriodFunctions.g.cs
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
  internal static class FileRetentionPeriod
  {
  }
}

// ==================================================================
// FileRetentionPeriodFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.FileRetentionPeriod
{

  public class FileRetentionPeriodFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IFileRetentionPeriodFilterInfo
  {
  }

  public class FileRetentionPeriodFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IFileRetentionPeriodFilterState
  {



    public new Sungero.Docflow.IFileRetentionPeriodFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IFileRetentionPeriodFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.FileRetentionPeriod.FileRetentionPeriodFilterInfo();
    }

  }
}

// ==================================================================
// FileRetentionPeriodSharedPublicFunctions.g.cs
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
  public class FileRetentionPeriodSharedPublicFunctions : global::Sungero.Docflow.Shared.IFileRetentionPeriodSharedPublicFunctions
  {
  }
}
