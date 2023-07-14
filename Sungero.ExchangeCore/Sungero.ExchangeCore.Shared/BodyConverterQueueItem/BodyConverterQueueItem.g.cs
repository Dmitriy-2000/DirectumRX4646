
// ==================================================================
// BodyConverterQueueItemState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class BodyConverterQueueItemState : 
    global::Sungero.ExchangeCore.Shared.QueueItemBaseState, global::Sungero.ExchangeCore.IBodyConverterQueueItemState
  {
    public BodyConverterQueueItemState(global::Sungero.ExchangeCore.IBodyConverterQueueItem entity) : base(entity) { }

    public new global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemPropertyStates(entity);
    }


    public new global::Sungero.ExchangeCore.IBodyConverterQueueItemControlStates Controls
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItemControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemControlStates(entity);
    }

    public new global::Sungero.ExchangeCore.IBodyConverterQueueItemPageStates Pages
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItemPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemPageStates(entity);
    }

  }


  public class BodyConverterQueueItemControlStates : 
    global::Sungero.ExchangeCore.Shared.QueueItemBaseControlStates, global::Sungero.ExchangeCore.IBodyConverterQueueItemControlStates
  {

    protected internal BodyConverterQueueItemControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class BodyConverterQueueItemPageStates : 
    global::Sungero.ExchangeCore.Shared.QueueItemBasePageStates, global::Sungero.ExchangeCore.IBodyConverterQueueItemPageStates
  {

    protected internal BodyConverterQueueItemPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class BodyConverterQueueItemPropertyStates : 
    global::Sungero.ExchangeCore.Shared.QueueItemBasePropertyStates, global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> Document 
            {
              get { return this.InternalDocument; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IOfficialDocument>("Document"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> VersionId 
            {
              get { return this.GetPropertyState<global::System.Int32?>("VersionId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> ExchangeState 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("ExchangeState"); }
            }


    protected internal BodyConverterQueueItemPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// BodyConverterQueueItemInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class BodyConverterQueueItemInfo : 
    global::Sungero.ExchangeCore.Shared.QueueItemBaseInfo, global::Sungero.ExchangeCore.IBodyConverterQueueItemInfo
  {
    public BodyConverterQueueItemInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertiesInfo Properties
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemPropertiesInfo(entityType);
    }

  }

  public class BodyConverterQueueItemPropertiesInfo : 
    global::Sungero.ExchangeCore.Shared.QueueItemBasePropertiesInfo, global::Sungero.ExchangeCore.IBodyConverterQueueItemPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IOfficialDocumentInfo, global::Sungero.Docflow.IOfficialDocument> Document 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Document");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IOfficialDocumentInfo, global::Sungero.Docflow.IOfficialDocument>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo VersionId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("VersionId");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo ExchangeState 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("ExchangeState");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal BodyConverterQueueItemPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// BodyConverterQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{
  public partial class BodyConverterQueueItemSharedHandlers : global::Sungero.ExchangeCore.QueueItemBaseSharedHandlers, IBodyConverterQueueItemSharedHandlers
  {
    private global::Sungero.ExchangeCore.IBodyConverterQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItem)this.Entity; }
    }
    public virtual void DocumentChanged(global::Sungero.ExchangeCore.Shared.BodyConverterQueueItemDocumentChangedEventArgs e) { }


    public virtual void VersionIdChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void ExchangeStateChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }




    public BodyConverterQueueItemSharedHandlers(global::Sungero.ExchangeCore.IBodyConverterQueueItem entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// BodyConverterQueueItemResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared.BodyConverterQueueItem
{
  /// <summary>
  /// Represents BodyConverterQueueItem resources.
  /// </summary>
  public class BodyConverterQueueItemResources : global::Sungero.ExchangeCore.Shared.QueueItemBase.QueueItemBaseResources, global::Sungero.ExchangeCore.BodyConverterQueueItem.IBodyConverterQueueItemResources
  {
  }
}

// ==================================================================
// BodyConverterQueueItemSharedFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared
{
  public partial class BodyConverterQueueItemFunctions : global::Sungero.ExchangeCore.Shared.QueueItemBaseFunctions
  {
    private global::Sungero.ExchangeCore.IBodyConverterQueueItem _obj
    {
      get { return (global::Sungero.ExchangeCore.IBodyConverterQueueItem)this.Entity; }
    }

    public BodyConverterQueueItemFunctions(global::Sungero.ExchangeCore.IBodyConverterQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// BodyConverterQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class BodyConverterQueueItem
  {
  }
}

// ==================================================================
// BodyConverterQueueItemFilterState.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared.BodyConverterQueueItem
{

  public class BodyConverterQueueItemFilterInfo : global::Sungero.ExchangeCore.Shared.QueueItemBase.QueueItemBaseFilterInfo,
    global::Sungero.ExchangeCore.IBodyConverterQueueItemFilterInfo
  {
  }

  public class BodyConverterQueueItemFilterState : global::Sungero.ExchangeCore.Shared.QueueItemBase.QueueItemBaseFilterState,
    global::Sungero.ExchangeCore.IBodyConverterQueueItemFilterState
  {



    public new Sungero.ExchangeCore.IBodyConverterQueueItemFilterInfo Info
    {
      get
      {
        return (Sungero.ExchangeCore.IBodyConverterQueueItemFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.ExchangeCore.Shared.BodyConverterQueueItem.BodyConverterQueueItemFilterInfo();
    }

  }
}

// ==================================================================
// BodyConverterQueueItemSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class BodyConverterQueueItemSharedPublicFunctions : global::Sungero.ExchangeCore.Shared.IBodyConverterQueueItemSharedPublicFunctions
  {
  }
}