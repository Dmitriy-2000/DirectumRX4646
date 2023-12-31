
// ==================================================================
// PersonState.g.cs
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
  public class PersonState : 
    global::Sungero.Parties.Shared.CounterpartyState, global::Sungero.Parties.IPersonState
  {
    public PersonState(global::Sungero.Parties.IPerson entity) : base(entity) { }

    public new global::Sungero.Parties.IPersonPropertyStates Properties
    {
      get { return (global::Sungero.Parties.IPersonPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.PersonPropertyStates(entity);
    }


    public new global::Sungero.Parties.IPersonControlStates Controls
    {
      get { return (global::Sungero.Parties.IPersonControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.PersonControlStates(entity);
    }

    public new global::Sungero.Parties.IPersonPageStates Pages
    {
      get { return (global::Sungero.Parties.IPersonPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Parties.Shared.PersonPageStates(entity);
    }

  }


  public class PersonControlStates : 
    global::Sungero.Parties.Shared.CounterpartyControlStates, global::Sungero.Parties.IPersonControlStates
  {

    protected internal PersonControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class PersonPageStates : 
    global::Sungero.Parties.Shared.CounterpartyPageStates, global::Sungero.Parties.IPersonPageStates
  {

    protected internal PersonPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class PersonPropertyStates : 
    global::Sungero.Parties.Shared.CounterpartyPropertyStates, global::Sungero.Parties.IPersonPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> LastName 
            {
              get { return this.GetPropertyState<global::System.String>("LastName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> FirstName 
            {
              get { return this.GetPropertyState<global::System.String>("FirstName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> MiddleName 
            {
              get { return this.GetPropertyState<global::System.String>("MiddleName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> DateOfBirth 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("DateOfBirth"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> Sex 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("Sex"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> INILA 
            {
              get { return this.GetPropertyState<global::System.String>("INILA"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ShortName 
            {
              get { return this.GetPropertyState<global::System.String>("ShortName"); }
            }
            public new global::Sungero.Parties.IPersonExchangeBoxesCollectionPropertyState<global::Sungero.Parties.IPersonExchangeBoxes> ExchangeBoxes
            {
              get { return (global::Sungero.Parties.IPersonExchangeBoxesCollectionPropertyState<global::Sungero.Parties.IPersonExchangeBoxes>)base.ExchangeBoxes; }
            }

            protected override global::Sungero.Parties.ICounterpartyExchangeBoxesCollectionPropertyState<global::Sungero.Parties.ICounterpartyExchangeBoxes> CreateExchangeBoxesState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Parties.Shared.PersonExchangeBoxesCollectionPropertyState<global::Sungero.Parties.IPersonExchangeBoxes>(entity, propertyName);
            }


    protected internal PersonPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// PersonInfo.g.cs
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
  public class PersonInfo : 
    global::Sungero.Parties.Shared.CounterpartyInfo, global::Sungero.Parties.IPersonInfo
  {
    public PersonInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Parties.IPersonPropertiesInfo Properties
    {
      get { return (global::Sungero.Parties.IPersonPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Parties.Shared.PersonPropertiesInfo(entityType);
    }

  }

  public class PersonPropertiesInfo : 
    global::Sungero.Parties.Shared.CounterpartyPropertiesInfo, global::Sungero.Parties.IPersonPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo LastName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("LastName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo FirstName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("FirstName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo MiddleName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("MiddleName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo DateOfBirth 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("DateOfBirth");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo Sex 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("Sex");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo INILA 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("INILA");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ShortName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ShortName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Parties.IPersonExchangeBoxesPropertiesInfo> ExchangeBoxes
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("ExchangeBoxes");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Parties.IPersonExchangeBoxesPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal PersonPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// PersonHandlers.g.cs
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
  public partial class PersonSharedHandlers : global::Sungero.Parties.CounterpartySharedHandlers, IPersonSharedHandlers
  {
    private global::Sungero.Parties.IPerson _obj
    {
      get { return (global::Sungero.Parties.IPerson)this.Entity; }
    }
    public virtual void DateOfBirthChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void SexChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void INILAChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ShortNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }





    public PersonSharedHandlers(global::Sungero.Parties.IPerson entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PersonResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Shared.Person
{
  /// <summary>
  /// Represents Person resources.
  /// </summary>
  public class PersonResources : global::Sungero.Parties.Shared.Counterparty.CounterpartyResources, global::Sungero.Parties.Person.IPersonResources
  {
    public virtual global::CommonLibrary.LocalizedString IncorrectTinLength
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "IncorrectTinLength");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectTinLengthFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "IncorrectTinLength", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString FullName
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "FullName");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FullNameFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "FullName", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString FullNameWithoutMiddle
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "FullNameWithoutMiddle");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FullNameWithoutMiddleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "FullNameWithoutMiddle", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ShortName
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "ShortName");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ShortNameFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "ShortName", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ShortNameWithoutMiddle
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "ShortNameWithoutMiddle");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ShortNameWithoutMiddleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "ShortNameWithoutMiddle", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ShortReverseName
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "ShortReverseName");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ShortReverseNameFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "ShortReverseName", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ShortReverseNameWithoutMiddle
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson) , "ShortReverseNameWithoutMiddle");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ShortReverseNameWithoutMiddleFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Parties.IPerson), "ShortReverseNameWithoutMiddle", false, args);
    }

  }
}

// ==================================================================
// PersonSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Shared
{
  public partial class PersonFunctions : global::Sungero.Parties.Shared.CounterpartyFunctions
  {
    private global::Sungero.Parties.IPerson _obj
    {
      get { return (global::Sungero.Parties.IPerson)this.Entity; }
    }

    public PersonFunctions(global::Sungero.Parties.IPerson entity) : base(entity) { }
  }
}

// ==================================================================
// PersonFunctions.g.cs
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
  internal static class Person
  {
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicates(global::Sungero.Parties.IPerson person, global::System.Boolean excludeClosed)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDuplicates", new System.Type[] { typeof(global::System.Boolean) });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { excludeClosed });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.Nullable<global::Sungero.Core.Enumeration> GetGender(global::Sungero.Parties.IPerson person)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetGender", new System.Type[] {  });
      return (global::System.Nullable<global::Sungero.Core.Enumeration>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  void FillName(global::Sungero.Parties.IPerson person)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.String GetFullName(global::Sungero.Parties.IPerson person, Sungero.Core.DeclensionCase declensionCase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetFullName", new System.Type[] { typeof(Sungero.Core.DeclensionCase) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { declensionCase });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.String GetSurnameAndInitialsInTenantCulture(global::System.String firstName, global::System.String middleName, global::System.String lastName)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.PersonFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSurnameAndInitialsInTenantCulture",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String), typeof(global::System.String), typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { firstName, middleName, lastName });
      }
      else
      {
        return global::Sungero.Parties.Shared.PersonFunctions.GetSurnameAndInitialsInTenantCulture(firstName, middleName, lastName);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.String SetUppercaseFirstLetter(global::System.String source)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Parties.Shared.PersonFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("SetUppercaseFirstLetter",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.String) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { source });
      }
      else
      {
        return global::Sungero.Parties.Shared.PersonFunctions.SetUppercaseFirstLetter(source);
      }
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.String CheckTin(global::Sungero.Parties.IPerson person, global::System.String tin)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckTin", new System.Type[] { typeof(global::System.String) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { tin });
    }
    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.PersonFunctions" />
    internal static  global::System.String GetLastNameAndInitials(global::Sungero.Parties.IPerson person, Sungero.Core.DeclensionCase declension)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)person).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetLastNameAndInitials", new System.Type[] { typeof(Sungero.Core.DeclensionCase) });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { declension });
    }

  }
}

// ==================================================================
// PersonFilterState.g.cs
// ==================================================================

namespace Sungero.Parties.Shared.Person
{

  public class PersonFilterInfo : global::Sungero.Parties.Shared.Counterparty.CounterpartyFilterInfo,
    global::Sungero.Parties.IPersonFilterInfo
  {
  }

  public class PersonFilterState : global::Sungero.Parties.Shared.Counterparty.CounterpartyFilterState,
    global::Sungero.Parties.IPersonFilterState
  {



    public new Sungero.Parties.IPersonFilterInfo Info
    {
      get
      {
        return (Sungero.Parties.IPersonFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Parties.Shared.Person.PersonFilterInfo();
    }

  }
}

// ==================================================================
// PersonSharedPublicFunctions.g.cs
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
  public class PersonSharedPublicFunctions : global::Sungero.Parties.Shared.IPersonSharedPublicFunctions
  {
    public global::System.String GetFullName(global::Sungero.Parties.IPerson person, Sungero.Core.DeclensionCase declensionCase)
    {
      return global::Sungero.Parties.Functions.Person.GetFullName(person, declensionCase);
    }
    public global::System.Nullable<global::Sungero.Core.Enumeration> GetGender(global::Sungero.Parties.IPerson person)
    {
      return global::Sungero.Parties.Functions.Person.GetGender(person);
    }
    public global::System.String GetLastNameAndInitials(global::Sungero.Parties.IPerson person, Sungero.Core.DeclensionCase declension)
    {
      return global::Sungero.Parties.Functions.Person.GetLastNameAndInitials(person, declension);
    }
    public global::System.String GetSurnameAndInitialsInTenantCulture(global::System.String firstName, global::System.String middleName, global::System.String lastName)
    {
      return global::Sungero.Parties.Functions.Person.GetSurnameAndInitialsInTenantCulture(firstName, middleName, lastName);
    }
  }
}
