
// ==================================================================
// MessageQueueItemDocuments.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{


  public class MessageQueueItemDocuments :
    global::Sungero.Domain.ChildEntity, global::Sungero.ExchangeCore.IMessageQueueItemDocuments
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ff5abd47-6495-4a84-9efc-3b08afebc6af");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Server.MessageQueueItemDocuments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IMessageQueueItemDocuments, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.ExchangeCore.IMessageQueueItemDocumentsState State
    {
      get { return (global::Sungero.ExchangeCore.IMessageQueueItemDocumentsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.MessageQueueItemDocumentsState(this);
    }

    public new virtual global::Sungero.ExchangeCore.IMessageQueueItemDocumentsInfo Info
    {
      get { return (global::Sungero.ExchangeCore.IMessageQueueItemDocumentsInfo)base.Info; }
    }


    public global::Sungero.ExchangeCore.IMessageQueueItem MessageQueueItem { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.MessageQueueItem; }
      set { this.MessageQueueItem = (global::Sungero.ExchangeCore.IMessageQueueItem)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.MessageQueueItemDocumentsSharedHandlers(this);
    }

    private global::System.String _ExternalId;
    public virtual global::System.String ExternalId
    {
      get
      {
        return this._ExternalId;
      }

      set
      {
        this.SetPropertyValue("ExternalId", this._ExternalId, value, (propertyValue) => { this._ExternalId = propertyValue; }, this.ExternalIdChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _TypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.ExchangeCore.MessageQueueItemDocuments.Type),
      typeof(global::Sungero.ExchangeCore.Server.MessageQueueItemDocuments),
      "Type");

    public static global::Sungero.Domain.Shared.EnumerationItems TypeItems
    {
      get { return global::Sungero.ExchangeCore.Server.MessageQueueItemDocuments._TypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems TypeAllowedItems
    {
      get { return global::Sungero.ExchangeCore.Server.MessageQueueItemDocuments.TypeItems; }
    }

    private global::Sungero.Core.Enumeration? _Type;

    public virtual global::Sungero.Core.Enumeration? Type
    {
      get { return this._Type; }
      set { this.SetEnumPropertyValue("Type", this._Type, value, (propertyValue) => { this._Type = propertyValue; }, this.TypeChangedHandler, this.TypeAllowedItems); }
    }





    #region Framework events

    protected void ExternalIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ExternalId, this.ExternalId, this);
     ((global::Sungero.ExchangeCore.IMessageQueueItemDocumentsSharedHandlers)this.SharedHandlers).DocumentsExternalIdChanged(args);
    }

    protected void TypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Type, this.Type, this);
     ((global::Sungero.ExchangeCore.IMessageQueueItemDocumentsSharedHandlers)this.SharedHandlers).DocumentsTypeChanged(args);
    }



    #endregion


    public MessageQueueItemDocuments()
    {
    }

  }
}

// ==================================================================
// MessageQueueItemDocumentsHandlers.g.cs
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

}

// ==================================================================
// MessageQueueItemDocumentsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Server
{
}
