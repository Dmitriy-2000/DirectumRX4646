
// ==================================================================
// Condition.g.cs
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
    public class ConditionFilter<T> :
      global::Sungero.Docflow.Server.ConditionBaseFilter<T>
      where T : class, global::Sungero.Docflow.ICondition
    {
      private global::Sungero.Docflow.IConditionFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IConditionFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ConditionFilter(global::Sungero.Docflow.IConditionFilterState filter)
      : base(filter)
      {
      }

      protected ConditionFilter()
      {
      }
    }
      public class ConditionUiFilter<T> :
        global::Sungero.Docflow.Server.ConditionBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.ICondition
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ConditionSearchDialogModel : global::Sungero.Docflow.Server.ConditionBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Double? Amount { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> AmountOperator { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IApprovalRoleBase> ApprovalRole { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IApprovalRoleBase> ApprovalRoleForComparison { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> RecipientForComparison { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> AddendaDocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ConditionType { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public ConditionAddresseesModel Addressees { get; protected set; }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ConditionCurrenciesModel Currencies { get { return (ConditionCurrenciesModel)base.Currencies; } protected set { base.Currencies = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ConditionDocumentKindsModel DocumentKinds { get { return (ConditionDocumentKindsModel)base.DocumentKinds; } protected set { base.DocumentKinds = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ConditionConditionDocumentKindsModel ConditionDocumentKinds { get { return (ConditionConditionDocumentKindsModel)base.ConditionDocumentKinds; } protected set { base.ConditionDocumentKinds = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new ConditionDeliveryMethodsModel DeliveryMethods { get { return (ConditionDeliveryMethodsModel)base.DeliveryMethods; } protected set { base.DeliveryMethods = value; } }

        }

      public class ConditionCurrenciesModel : global::Sungero.Docflow.Server.ConditionBaseCurrenciesModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ConditionDocumentKindsModel : global::Sungero.Docflow.Server.ConditionBaseDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ConditionConditionDocumentKindsModel : global::Sungero.Docflow.Server.ConditionBaseConditionDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }
      public class ConditionDeliveryMethodsModel : global::Sungero.Docflow.Server.ConditionBaseDeliveryMethodsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }


      public class ConditionAddresseesModel : global::Sungero.Domain.CollectionPropertySearchDialogModel
          {
            public override global::System.Int32? Id { get; protected set; }


         }




  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.ConditionFilter<global::Sungero.Docflow.ICondition>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.ConditionUiFilter<global::Sungero.Docflow.ICondition>))]

  public class Condition :
    global::Sungero.Docflow.Server.ConditionBase, global::Sungero.Docflow.ICondition
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3f6f31c3-16e2-457e-9f88-48b254a500d2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.Condition.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICondition, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IConditionState State
    {
      get { return (global::Sungero.Docflow.IConditionState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ConditionState(this);
    }

    public new virtual global::Sungero.Docflow.IConditionInfo Info
    {
      get { return (global::Sungero.Docflow.IConditionInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IConditionAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IConditionAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.ConditionAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.ConditionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ConditionFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ConditionServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ConditionSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ConditionTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      global::Sungero.Docflow.Server.ConditionBase.ConditionTypeItems,
      typeof(global::Sungero.Docflow.Condition.ConditionType),
      typeof(global::Sungero.Docflow.Server.Condition),
      "ConditionType");

    public static new global::Sungero.Domain.Shared.EnumerationItems ConditionTypeItems
    {
      get { return global::Sungero.Docflow.Server.Condition._ConditionTypeItems; }
    }

    public override global::Sungero.Domain.Shared.EnumerationItems ConditionTypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.Condition.ConditionTypeItems; }
    }




    protected global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionAddressees> _Addressees;

    public virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionAddressees> Addressees
    {
      get
      {
        if (this._Addressees == null)
        {
          this._Addressees = this.CreateAddresseesCollection();
          this.SetAddresseesEventHandlers();
        }
        return this._Addressees;
      }

      set
      {
        if (this._Addressees != null)
          this.UnsetChildCollectionEventHandlers(this._Addressees);

        this._Addressees = value;
        this.SetAddresseesEventHandlers();
      }
    }

    protected virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionAddressees> CreateAddresseesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IConditionAddressees>() { RootEntity = this };
    }

    private void SetAddresseesEventHandlers()
    {
      this.SetChildCollectionEventHandlers(this._Addressees, "Addressees");

      var changeNotifier = (global::Sungero.Domain.Shared.INotifyChildEntityCollectionChanged)this._Addressees;
      changeNotifier.Added += this.AddresseesAddedHandler;
      changeNotifier.Deleted += this.AddresseesDeletedHandler;
      changeNotifier.Added += this.AddresseesCollectionUpdateEventHandler;
      changeNotifier.Deleted += this.AddresseesCollectionUpdateEventHandler;
      changeNotifier.Updated += this.AddresseesCollectionUpdateEventHandler;
    }

    private void AddresseesCollectionUpdateEventHandler(object sender, global::Sungero.Domain.Shared.BaseChildEntityEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      if (this.IsPropertyChangedHandlerEnabled && this.IsPropertyChangedAppliedHandlerEnabled("Addressees"))
        this.AddresseesChangedHandler();
    }


    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseCurrencies> CreateCurrenciesCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IConditionCurrencies>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseDocumentKinds> CreateDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IConditionDocumentKinds>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseConditionDocumentKinds> CreateConditionDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IConditionConditionDocumentKinds>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IConditionBaseDeliveryMethods> CreateDeliveryMethodsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IConditionDeliveryMethods>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.ConditionCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.ICondition)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.ConditionCreatingFromServerHandler((global::Sungero.Docflow.ICondition)entitySource, this.Info);
    }

    #region Framework events

    protected void AddresseesChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.IConditionSharedHandlers)this.SharedHandlers).AddresseesChanged(args);
    }







    protected virtual global::Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers CreateAddresseesAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers CreateAddresseesDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void AddresseesAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, e.Value, null, e.Source });
        var methodInfo = type.GetMethod("AddresseesAdded");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAddresseesAddedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
          collectionHandlers.AddresseesAdded(args);
        }
      }
    }

    protected virtual void AddresseesDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ConditionAddresseesSharedCollectionHandlers");
      if (type != null)
      {
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this, null, e.Value, null });
        var methodInfo = type.GetMethod("AddresseesDeleted");
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { args });
      }
      else
      {
        var collectionHandlers = this.CreateAddresseesDeletedHandler(e);
        if (collectionHandlers != null)
        {
          var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
          collectionHandlers.AddresseesDeleted(args);
        }
      }
    }










    #endregion


    public Condition()
    {
    }

  }
}

// ==================================================================
// ConditionHandlers.g.cs
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

  public partial class ConditionFilteringServerHandler<T>
    : global::Sungero.Docflow.ConditionBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.ICondition
  {
    private global::Sungero.Docflow.IConditionFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IConditionFilterState)this.Filter;
      }
    }

    public ConditionFilteringServerHandler(global::Sungero.Docflow.IConditionFilterState filter)
    : base(filter)
    {
    }

    protected ConditionFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ConditionUiFilteringServerHandler<T>
    : global::Sungero.Docflow.ConditionBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.ICondition
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ConditionSearchDialogServerHandler : global::Sungero.Docflow.ConditionBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.ConditionSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.ConditionSearchDialogModel)this.Dialog;
       }
     }

     public ConditionSearchDialogServerHandler(global::Sungero.Docflow.Server.ConditionSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ConditionServerHandlers : global::Sungero.Docflow.ConditionBaseServerHandlers
  {
    private global::Sungero.Docflow.ICondition _obj
    {
      get { return (global::Sungero.Docflow.ICondition)this.Entity; }
    }

    public ConditionServerHandlers(global::Sungero.Docflow.ICondition entity)
      : base(entity)
    {
    }
  }

  public partial class ConditionCreatingFromServerHandler : global::Sungero.Docflow.ConditionBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.ICondition _source
    {
      get { return (global::Sungero.Docflow.ICondition)this.Source; }
    }

    private global::Sungero.Docflow.IConditionInfo _info
    {
      get { return (global::Sungero.Docflow.IConditionInfo)this._Info; }
    }

    public ConditionCreatingFromServerHandler(global::Sungero.Docflow.ICondition source, global::Sungero.Docflow.IConditionInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ConditionEventArgs.g.cs
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

// ==================================================================
// ConditionAccessRights.g.cs
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
  public class ConditionAccessRights : 
    Sungero.Docflow.Server.ConditionBaseAccessRights, Sungero.Docflow.IConditionAccessRights
  {

    public ConditionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ConditionTypeAccessRights : 
    Sungero.Docflow.Server.ConditionBaseTypeAccessRights, Sungero.Docflow.IConditionAccessRights
  {

    public ConditionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ConditionRepositoryImplementer.g.cs
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
    public class ConditionRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.ConditionBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IConditionRepositoryImplementer<T>
      where T : global::Sungero.Docflow.ICondition 
    {
       public new global::Sungero.Docflow.IConditionAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IConditionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IConditionInfo Info
       {
          get { return (global::Sungero.Docflow.IConditionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.ConditionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ConditionPanelNavigationFilters.g.cs
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

// ==================================================================
// ConditionServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class ConditionFunctions : global::Sungero.Docflow.Server.ConditionBaseFunctions
  {
    private global::Sungero.Docflow.ICondition _obj
    {
      get { return (global::Sungero.Docflow.ICondition)this.Entity; }
    }

    public ConditionFunctions(global::Sungero.Docflow.ICondition entity) : base(entity) { }
  }
}

// ==================================================================
// ConditionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class Condition
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ConditionFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static  global::Sungero.Docflow.ICondition CreateCondition()
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Server.ConditionFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("CreateCondition",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] {  }, null);
        return (global::Sungero.Docflow.ICondition)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] {  });
      }
      else
      {
        return global::Sungero.Docflow.Server.ConditionFunctions.CreateCondition();
      }
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ConditionFunctions" />
    internal static  global::System.String GetConditionName(global::Sungero.Docflow.ICondition condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetConditionName", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ConditionFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetEmployeesFromProperties(global::Sungero.Docflow.ICondition condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEmployeesFromProperties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ConditionFunctions" />
    internal static  System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>> GetSupportedConditions(global::Sungero.Docflow.ICondition condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetSupportedConditions", new System.Type[] {  });
      return (System.Collections.Generic.Dictionary<global::System.String, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>>>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ConditionFunctions" />
    internal static  void ChangePropertiesAccess(global::Sungero.Docflow.ICondition condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangePropertiesAccess", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ConditionFunctions" />
    internal static  void ClearHiddenProperties(global::Sungero.Docflow.ICondition condition)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ClearHiddenProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ConditionFunctions" />
    internal static  global::Sungero.Docflow.Structures.ConditionBase.ConditionResult CheckCondition(global::Sungero.Docflow.ICondition condition, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)condition).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("CheckCondition", new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::Sungero.Docflow.IApprovalTask) });
      return (global::Sungero.Docflow.Structures.ConditionBase.ConditionResult)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { document, task });
    }

  }
}

// ==================================================================
// ConditionServerPublicFunctions.g.cs
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
  public class ConditionServerPublicFunctions : global::Sungero.Docflow.Server.IConditionServerPublicFunctions
  {
  }
}

// ==================================================================
// ConditionQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class Condition
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Condition.ConditionQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
