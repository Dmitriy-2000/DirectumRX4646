
// ==================================================================
// BankExchangeBoxesState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared
{
  public class BankExchangeBoxesState : 
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesState, global::Sungero.Parties.IBankExchangeBoxesState
  {
    public BankExchangeBoxesState(global::Sungero.Parties.IBankExchangeBoxes entity) : base(entity) { }

    public new global::Sungero.Parties.IBankExchangeBoxesPropertyStates Properties
    {
      get { return (global::Sungero.Parties.IBankExchangeBoxesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.BankExchangeBoxesPropertyStates(entity);
    }


  }


  public class BankExchangeBoxesPropertyStates : 
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesPropertyStates, global::Sungero.Parties.IBankExchangeBoxesPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IBank> Counterparty
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IBank>)base.Counterparty; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCounterparty
            {
              get { return this.GetPropertyState<global::Sungero.Parties.IBank>("Counterparty"); }
            }


    protected internal BankExchangeBoxesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class BankExchangeBoxesCollectionPropertyState<T> :
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesCollectionPropertyState<T>, global::Sungero.Parties.IBankExchangeBoxesCollectionPropertyState<T>
    where T : global::Sungero.Parties.IBankExchangeBoxes
  {
    public new global::Sungero.Parties.IBankExchangeBoxesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Parties.IBankExchangeBoxesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Parties.Shared.BankExchangeBoxesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal BankExchangeBoxesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class BankExchangeBoxesCollectionPropertyStates :
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesCollectionPropertyStates, global::Sungero.Parties.IBankExchangeBoxesCollectionPropertyStates
  {

    protected internal BankExchangeBoxesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// BankExchangeBoxesInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared
{
  public class BankExchangeBoxesInfo : 
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesInfo, global::Sungero.Parties.IBankExchangeBoxesInfo
  {
    public BankExchangeBoxesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.IBankExchangeBoxesPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.IBankExchangeBoxesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.BankExchangeBoxesPropertiesInfo(entityType);
    }

  }

  public class BankExchangeBoxesPropertiesInfo : 
    global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesPropertiesInfo, global::Sungero.Parties.IBankExchangeBoxesPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.IBankInfo, global::Sungero.Parties.IBank> Counterparty
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Counterparty");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.IBankInfo, global::Sungero.Parties.IBank>(propertyMetadata);
          }
        }


    protected internal BankExchangeBoxesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
