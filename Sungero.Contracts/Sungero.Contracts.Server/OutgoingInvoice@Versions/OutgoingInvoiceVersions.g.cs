
// ==================================================================
// OutgoingInvoiceVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{


  public class OutgoingInvoiceVersions :
    global::Sungero.Docflow.Server.AccountingDocumentBaseVersions, global::Sungero.Contracts.IOutgoingInvoiceVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5101183d-0a1a-4904-9361-96d9777244d3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.OutgoingInvoiceVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IOutgoingInvoiceVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IOutgoingInvoiceVersionsState State
    {
      get { return (global::Sungero.Contracts.IOutgoingInvoiceVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.OutgoingInvoiceVersionsState(this);
    }

    public new virtual global::Sungero.Contracts.IOutgoingInvoiceVersionsInfo Info
    {
      get { return (global::Sungero.Contracts.IOutgoingInvoiceVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public OutgoingInvoiceVersions()
    {
    }

  }
}

// ==================================================================
// OutgoingInvoiceVersionsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{

}

// ==================================================================
// OutgoingInvoiceVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{
}