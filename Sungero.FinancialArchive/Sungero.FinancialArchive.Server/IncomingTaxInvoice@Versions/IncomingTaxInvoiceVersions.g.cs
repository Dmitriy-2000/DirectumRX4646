
// ==================================================================
// IncomingTaxInvoiceVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{


  public class IncomingTaxInvoiceVersions :
    global::Sungero.Docflow.Server.AccountingDocumentBaseVersions, global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("bb90f6e2-57e5-42ed-9c8a-9d37cbe6f593");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IIncomingTaxInvoiceVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsState State
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceVersionsState(this);
    }

    public new virtual global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsInfo Info
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public IncomingTaxInvoiceVersions()
    {
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceVersionsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{

}

// ==================================================================
// IncomingTaxInvoiceVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
}
