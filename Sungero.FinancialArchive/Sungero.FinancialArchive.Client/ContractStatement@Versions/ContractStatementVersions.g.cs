
// ==================================================================
// ContractStatementVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class ContractStatementVersions :
    global::Sungero.Docflow.Client.AccountingDocumentBaseVersions, global::Sungero.FinancialArchive.IContractStatementVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ae5566c8-cefa-412f-81ee-b1a84f153024");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.ContractStatementVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IContractStatementVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.FinancialArchive.IContractStatementVersionsState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IContractStatementVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.ContractStatementVersionsState(this);
    }

    public new global::Sungero.FinancialArchive.IContractStatementVersionsInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IContractStatementVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public ContractStatementVersions()
    {








    }

    #endregion

  }
}
