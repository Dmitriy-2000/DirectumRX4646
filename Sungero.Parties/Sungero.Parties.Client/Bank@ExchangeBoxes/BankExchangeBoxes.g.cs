
// ==================================================================
// BankExchangeBoxes.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class BankExchangeBoxes :
    global::Sungero.Parties.Client.CompanyBaseExchangeBoxes, global::Sungero.Parties.IBankExchangeBoxes
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b28d2948-f8b6-47e1-bdf0-a6f6be05e64c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.BankExchangeBoxes.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.IBankExchangeBoxes, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Parties.IBankExchangeBoxesState State
    {
      get
      {
        return (global::Sungero.Parties.IBankExchangeBoxesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.BankExchangeBoxesState(this);
    }

    public new global::Sungero.Parties.IBankExchangeBoxesInfo Info
    {
      get
      {
        return (global::Sungero.Parties.IBankExchangeBoxesInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public BankExchangeBoxes()
    {








    }

    #endregion

  }
}
