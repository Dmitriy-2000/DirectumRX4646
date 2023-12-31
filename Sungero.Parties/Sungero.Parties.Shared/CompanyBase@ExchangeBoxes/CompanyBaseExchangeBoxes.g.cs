
// ==================================================================
// CompanyBaseExchangeBoxesState.g.cs
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
  public class CompanyBaseExchangeBoxesState : 
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesState, global::Sungero.Parties.ICompanyBaseExchangeBoxesState
  {
    public CompanyBaseExchangeBoxesState(global::Sungero.Parties.ICompanyBaseExchangeBoxes entity) : base(entity) { }

    public new global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertyStates Properties
    {
      get { return (global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesPropertyStates(entity);
    }


  }


  public class CompanyBaseExchangeBoxesPropertyStates : 
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesPropertyStates, global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICompanyBase> Counterparty
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICompanyBase>)base.Counterparty; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCounterparty
            {
              get { return this.GetPropertyState<global::Sungero.Parties.ICompanyBase>("Counterparty"); }
            }


    protected internal CompanyBaseExchangeBoxesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CompanyBaseExchangeBoxesCollectionPropertyState<T> :
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesCollectionPropertyState<T>, global::Sungero.Parties.ICompanyBaseExchangeBoxesCollectionPropertyState<T>
    where T : global::Sungero.Parties.ICompanyBaseExchangeBoxes
  {
    public new global::Sungero.Parties.ICompanyBaseExchangeBoxesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Parties.ICompanyBaseExchangeBoxesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal CompanyBaseExchangeBoxesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class CompanyBaseExchangeBoxesCollectionPropertyStates :
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesCollectionPropertyStates, global::Sungero.Parties.ICompanyBaseExchangeBoxesCollectionPropertyStates
  {

    protected internal CompanyBaseExchangeBoxesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// CompanyBaseExchangeBoxesInfo.g.cs
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
  public class CompanyBaseExchangeBoxesInfo : 
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesInfo, global::Sungero.Parties.ICompanyBaseExchangeBoxesInfo
  {
    public CompanyBaseExchangeBoxesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesPropertiesInfo(entityType);
    }

  }

  public class CompanyBaseExchangeBoxesPropertiesInfo : 
    global::Sungero.Parties.Shared.CounterpartyExchangeBoxesPropertiesInfo, global::Sungero.Parties.ICompanyBaseExchangeBoxesPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.ICompanyBaseInfo, global::Sungero.Parties.ICompanyBase> Counterparty
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Counterparty");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.ICompanyBaseInfo, global::Sungero.Parties.ICompanyBase>(propertyMetadata);
          }
        }


    protected internal CompanyBaseExchangeBoxesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
