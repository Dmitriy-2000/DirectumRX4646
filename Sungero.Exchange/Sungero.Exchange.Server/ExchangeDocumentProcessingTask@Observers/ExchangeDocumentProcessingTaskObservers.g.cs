
// ==================================================================
// ExchangeDocumentProcessingTaskObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{


  public class ExchangeDocumentProcessingTaskObservers :
    global::Sungero.Workflow.Server.TaskObservers, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObservers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4b78f549-6d32-45f4-80ab-4acc76d46af8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Exchange.Server.ExchangeDocumentProcessingTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Exchange.IExchangeDocumentProcessingTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversState State
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentProcessingTaskObserversState(this);
    }

    public new virtual global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversInfo Info
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ExchangeDocumentProcessingTaskObservers()
    {
    }

  }
}

// ==================================================================
// ExchangeDocumentProcessingTaskObserversHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{

}

// ==================================================================
// ExchangeDocumentProcessingTaskObserversEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}
