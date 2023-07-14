
// ==================================================================
// CompanyState.g.cs
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
  public class CompanyState : 
    global::Sungero.Parties.Shared.CompanyBaseState, global::Sungero.Parties.ICompanyState
  {
    public CompanyState(global::Sungero.Parties.ICompany entity) : base(entity) { }

    public new global::Sungero.Parties.ICompanyPropertyStates Properties
    {
      get { return (global::Sungero.Parties.ICompanyPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CompanyPropertyStates(entity);
    }


    public new global::Sungero.Parties.ICompanyControlStates Controls
    {
      get { return (global::Sungero.Parties.ICompanyControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CompanyControlStates(entity);
    }

    public new global::Sungero.Parties.ICompanyPageStates Pages
    {
      get { return (global::Sungero.Parties.ICompanyPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.CompanyPageStates(entity);
    }

  }


  public class CompanyControlStates : 
    global::Sungero.Parties.Shared.CompanyBaseControlStates, global::Sungero.Parties.ICompanyControlStates
  {

    protected internal CompanyControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CompanyPageStates : 
    global::Sungero.Parties.Shared.CompanyBasePageStates, global::Sungero.Parties.ICompanyPageStates
  {

    protected internal CompanyPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CompanyPropertyStates : 
    global::Sungero.Parties.Shared.CompanyBasePropertyStates, global::Sungero.Parties.ICompanyPropertyStates
  {
            public new global::Sungero.Parties.ICompanyExchangeBoxesCollectionPropertyState<global::Sungero.Parties.ICompanyExchangeBoxes> ExchangeBoxes
            {
              get { return (global::Sungero.Parties.ICompanyExchangeBoxesCollectionPropertyState<global::Sungero.Parties.ICompanyExchangeBoxes>)base.ExchangeBoxes; }
            }

            protected override global::Sungero.Parties.ICounterpartyExchangeBoxesCollectionPropertyState<global::Sungero.Parties.ICounterpartyExchangeBoxes> CreateExchangeBoxesState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Parties.Shared.CompanyExchangeBoxesCollectionPropertyState<global::Sungero.Parties.ICompanyExchangeBoxes>(entity, propertyName);
            }


    protected internal CompanyPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CompanyInfo.g.cs
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
  public class CompanyInfo : 
    global::Sungero.Parties.Shared.CompanyBaseInfo, global::Sungero.Parties.ICompanyInfo
  {
    public CompanyInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.ICompanyPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.ICompanyPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.CompanyPropertiesInfo(entityType);
    }

  }

  public class CompanyPropertiesInfo : 
    global::Sungero.Parties.Shared.CompanyBasePropertiesInfo, global::Sungero.Parties.ICompanyPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Parties.ICompanyExchangeBoxesPropertiesInfo> ExchangeBoxes
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("ExchangeBoxes");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Parties.ICompanyExchangeBoxesPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal CompanyPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// CompanyHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties
{
  public partial class CompanySharedHandlers : global::Sungero.Parties.CompanyBaseSharedHandlers, ICompanySharedHandlers
  {
    private global::Sungero.Parties.ICompany _obj
    {
      get { return (global::Sungero.Parties.ICompany)this.Entity; }
    }


    public CompanySharedHandlers(global::Sungero.Parties.ICompany entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CompanyResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared.Company
{
  /// <summary>
  /// Represents Company resources.
  /// </summary>
  public class CompanyResources : global::Sungero.Parties.Shared.CompanyBase.CompanyBaseResources, global::Sungero.Parties.Company.ICompanyResources
  {
  }
}

// ==================================================================
// CompanySharedFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Shared
{
  public partial class CompanyFunctions : global::Sungero.Parties.Shared.CompanyBaseFunctions
  {
    private global::Sungero.Parties.ICompany _obj
    {
      get { return (global::Sungero.Parties.ICompany)this.Entity; }
    }

    public CompanyFunctions(global::Sungero.Parties.ICompany entity) : base(entity) { }
  }
}

// ==================================================================
// CompanyFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Functions
{
  internal static class Company
  {
  }
}

// ==================================================================
// CompanyFilterState.g.cs
// ==================================================================

namespace Sungero.Parties.Shared.Company
{

  public class CompanyFilterInfo : global::Sungero.Parties.Shared.CompanyBase.CompanyBaseFilterInfo,
    global::Sungero.Parties.ICompanyFilterInfo
  {
  }

  public class CompanyFilterState : global::Sungero.Parties.Shared.CompanyBase.CompanyBaseFilterState,
    global::Sungero.Parties.ICompanyFilterState
  {



    public new Sungero.Parties.ICompanyFilterInfo Info
    {
      get
      {
        return (Sungero.Parties.ICompanyFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Parties.Shared.Company.CompanyFilterInfo();
    }

  }
}

// ==================================================================
// CompanySharedPublicFunctions.g.cs
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
  public class CompanySharedPublicFunctions : global::Sungero.Parties.Shared.ICompanySharedPublicFunctions
  {
  }
}