
// ==================================================================
// AccountingDocumentBaseVersions.g.cs
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


  public class AccountingDocumentBaseVersions :
    global::Sungero.Docflow.Server.OfficialDocumentVersions, global::Sungero.Docflow.IAccountingDocumentBaseVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fd8ac5de-440e-451f-9d12-0213f4fd59ba");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.AccountingDocumentBaseVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccountingDocumentBaseVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IAccountingDocumentBaseVersionsState State
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBaseVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IAccountingDocumentBaseVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IAccountingDocumentBaseVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public AccountingDocumentBaseVersions()
    {
    }

  }
}

// ==================================================================
// AccountingDocumentBaseVersionsHandlers.g.cs
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

}

// ==================================================================
// AccountingDocumentBaseVersionsEventArgs.g.cs
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