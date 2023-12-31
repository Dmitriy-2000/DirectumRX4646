
// ==================================================================
// DepartmentBoxState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class DepartmentBoxState : 
    global::Sungero.ExchangeCore.Shared.BoxBaseState, global::Sungero.ExchangeCore.IDepartmentBoxState
  {
    public DepartmentBoxState(global::Sungero.ExchangeCore.IDepartmentBox entity) : base(entity) { }

    public new global::Sungero.ExchangeCore.IDepartmentBoxPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBoxPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.DepartmentBoxPropertyStates(entity);
    }


    public new global::Sungero.ExchangeCore.IDepartmentBoxControlStates Controls
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBoxControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.DepartmentBoxControlStates(entity);
    }

    public new global::Sungero.ExchangeCore.IDepartmentBoxPageStates Pages
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBoxPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.DepartmentBoxPageStates(entity);
    }

  }


  public class DepartmentBoxControlStates : 
    global::Sungero.ExchangeCore.Shared.BoxBaseControlStates, global::Sungero.ExchangeCore.IDepartmentBoxControlStates
  {

    protected internal DepartmentBoxControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DepartmentBoxPageStates : 
    global::Sungero.ExchangeCore.Shared.BoxBasePageStates, global::Sungero.ExchangeCore.IDepartmentBoxPageStates
  {

    protected internal DepartmentBoxPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DepartmentBoxPropertyStates : 
    global::Sungero.ExchangeCore.Shared.BoxBasePropertyStates, global::Sungero.ExchangeCore.IDepartmentBoxPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBoxBase> ParentBox 
            {
              get { return this.InternalParentBox; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBoxBase> InternalParentBox
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IBoxBase>("ParentBox"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IDepartment> Department 
            {
              get { return this.InternalDepartment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IDepartment> InternalDepartment
            {
              get { return this.GetPropertyState<global::Sungero.Company.IDepartment>("Department"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> RootBox 
            {
              get { return this.InternalRootBox; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox> InternalRootBox
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IBusinessUnitBox>("RootBox"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ServiceId 
            {
              get { return this.GetPropertyState<global::System.String>("ServiceId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsDeleted 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsDeleted"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ServiceName 
            {
              get { return this.GetPropertyState<global::System.String>("ServiceName"); }
            }


    protected internal DepartmentBoxPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DepartmentBoxInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class DepartmentBoxInfo : 
    global::Sungero.ExchangeCore.Shared.BoxBaseInfo, global::Sungero.ExchangeCore.IDepartmentBoxInfo
  {
    public DepartmentBoxInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.ExchangeCore.IDepartmentBoxPropertiesInfo Properties
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBoxPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.DepartmentBoxPropertiesInfo(entityType);
    }

  }

  public class DepartmentBoxPropertiesInfo : 
    global::Sungero.ExchangeCore.Shared.BoxBasePropertiesInfo, global::Sungero.ExchangeCore.IDepartmentBoxPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IBoxBaseInfo, global::Sungero.ExchangeCore.IBoxBase> ParentBox 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ParentBox");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IBoxBaseInfo, global::Sungero.ExchangeCore.IBoxBase>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IDepartmentInfo, global::Sungero.Company.IDepartment> Department 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Department");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IDepartmentInfo, global::Sungero.Company.IDepartment>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox> RootBox 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("RootBox");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IBusinessUnitBoxInfo, global::Sungero.ExchangeCore.IBusinessUnitBox>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ServiceId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ServiceId");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsDeleted 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsDeleted");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ServiceName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ServiceName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal DepartmentBoxPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// DepartmentBoxHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{
  public partial class DepartmentBoxSharedHandlers : global::Sungero.ExchangeCore.BoxBaseSharedHandlers, IDepartmentBoxSharedHandlers
  {
    private global::Sungero.ExchangeCore.IDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBox)this.Entity; }
    }
    public virtual void DepartmentChanged(global::Sungero.ExchangeCore.Shared.DepartmentBoxDepartmentChangedEventArgs e) { }


    public virtual void RootBoxChanged(global::Sungero.ExchangeCore.Shared.DepartmentBoxRootBoxChangedEventArgs e) { }


    public virtual void ServiceIdChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void IsDeletedChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }





    public DepartmentBoxSharedHandlers(global::Sungero.ExchangeCore.IDepartmentBox entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DepartmentBoxResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared.DepartmentBox
{
  /// <summary>
  /// Represents DepartmentBox resources.
  /// </summary>
  public class DepartmentBoxResources : global::Sungero.ExchangeCore.Shared.BoxBase.BoxBaseResources, global::Sungero.ExchangeCore.DepartmentBox.IDepartmentBoxResources
  {
    public virtual global::CommonLibrary.LocalizedString DepartmentBoxNoticeSubject
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "DepartmentBoxNoticeSubject");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DepartmentBoxNoticeSubjectFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "DepartmentBoxNoticeSubject", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DepartmentBoxAssignmentSubject
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "DepartmentBoxAssignmentSubject");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DepartmentBoxAssignmentSubjectFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "DepartmentBoxAssignmentSubject", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ChangedDepartmentBoxesNotice
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "ChangedDepartmentBoxesNotice");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ChangedDepartmentBoxesNoticeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "ChangedDepartmentBoxesNotice", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeletedDepartmentBoxesNotice
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "DeletedDepartmentBoxesNotice");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeletedDepartmentBoxesNoticeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "DeletedDepartmentBoxesNotice", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString NewDepartmentBoxesNotice
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "NewDepartmentBoxesNotice");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NewDepartmentBoxesNoticeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "NewDepartmentBoxesNotice", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DeletedDepartmentBoxesReponsibleNotice
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox) , "DeletedDepartmentBoxesReponsibleNotice");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DeletedDepartmentBoxesReponsibleNoticeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.ExchangeCore.IDepartmentBox), "DeletedDepartmentBoxesReponsibleNotice", false, args);
    }

  }
}

// ==================================================================
// DepartmentBoxSharedFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared
{
  public partial class DepartmentBoxFunctions : global::Sungero.ExchangeCore.Shared.BoxBaseFunctions
  {
    private global::Sungero.ExchangeCore.IDepartmentBox _obj
    {
      get { return (global::Sungero.ExchangeCore.IDepartmentBox)this.Entity; }
    }

    public DepartmentBoxFunctions(global::Sungero.ExchangeCore.IDepartmentBox entity) : base(entity) { }
  }
}

// ==================================================================
// DepartmentBoxFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class DepartmentBox
  {
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.DepartmentBoxFunctions" />
    internal static  void SetDepartmentBoxName(global::Sungero.ExchangeCore.IDepartmentBox departmentBox)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)departmentBox).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetDepartmentBoxName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.DepartmentBoxFunctions" />
    internal static  global::Sungero.ExchangeCore.IBusinessUnitBox GetRootBox(global::Sungero.ExchangeCore.IDepartmentBox departmentBox)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)departmentBox).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetRootBox", new System.Type[] {  });
      return (global::Sungero.ExchangeCore.IBusinessUnitBox)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// DepartmentBoxFilterState.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared.DepartmentBox
{

  public class DepartmentBoxFilterInfo : global::Sungero.ExchangeCore.Shared.BoxBase.BoxBaseFilterInfo,
    global::Sungero.ExchangeCore.IDepartmentBoxFilterInfo
  {
  }

  public class DepartmentBoxFilterState : global::Sungero.ExchangeCore.Shared.BoxBase.BoxBaseFilterState,
    global::Sungero.ExchangeCore.IDepartmentBoxFilterState
  {



    public new Sungero.ExchangeCore.IDepartmentBoxFilterInfo Info
    {
      get
      {
        return (Sungero.ExchangeCore.IDepartmentBoxFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.ExchangeCore.Shared.DepartmentBox.DepartmentBoxFilterInfo();
    }

  }
}

// ==================================================================
// DepartmentBoxSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class DepartmentBoxSharedPublicFunctions : global::Sungero.ExchangeCore.Shared.IDepartmentBoxSharedPublicFunctions
  {
    public global::Sungero.ExchangeCore.IBusinessUnitBox GetRootBox(global::Sungero.ExchangeCore.IDepartmentBox departmentBox)
    {
      return global::Sungero.ExchangeCore.Functions.DepartmentBox.GetRootBox(departmentBox);
    }
  }
}
