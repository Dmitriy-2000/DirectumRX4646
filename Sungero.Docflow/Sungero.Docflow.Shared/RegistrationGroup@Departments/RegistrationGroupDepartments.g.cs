
// ==================================================================
// RegistrationGroupDepartmentsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class RegistrationGroupDepartmentsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IRegistrationGroupDepartmentsState
  {
    public RegistrationGroupDepartmentsState(global::Sungero.Docflow.IRegistrationGroupDepartments entity) : base(entity) { }

    public new global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupDepartmentsPropertyStates(entity);
    }


  }


  public class RegistrationGroupDepartmentsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationGroup> RegistrationGroup 
            {
              get { return this.InternalRegistrationGroup; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationGroup> InternalRegistrationGroup
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IRegistrationGroup>("RegistrationGroup"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IDepartment> Department 
            {
              get { return this.InternalDepartment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IDepartment> InternalDepartment
            {
              get { return this.GetPropertyState<global::Sungero.Company.IDepartment>("Department"); }
            }


    protected internal RegistrationGroupDepartmentsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RegistrationGroupDepartmentsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IRegistrationGroupDepartmentsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IRegistrationGroupDepartments
  {
    public new global::Sungero.Docflow.IRegistrationGroupDepartmentsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupDepartmentsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupDepartmentsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal RegistrationGroupDepartmentsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class RegistrationGroupDepartmentsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IRegistrationGroupDepartmentsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState RegistrationGroup
        {
          get { return this.GetChildPropertySummaryState("RegistrationGroup"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Department
        {
          get { return this.GetChildPropertySummaryState("Department"); }
        }


    protected internal RegistrationGroupDepartmentsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// RegistrationGroupDepartmentsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class RegistrationGroupDepartmentsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IRegistrationGroupDepartmentsInfo
  {
    public RegistrationGroupDepartmentsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupDepartmentsPropertiesInfo(entityType);
    }

  }

  public class RegistrationGroupDepartmentsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IRegistrationGroupDepartmentsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IRegistrationGroupInfo, global::Sungero.Docflow.IRegistrationGroup> RegistrationGroup 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("RegistrationGroup");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IRegistrationGroupInfo, global::Sungero.Docflow.IRegistrationGroup>(propertyMetadata);
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


    protected internal RegistrationGroupDepartmentsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
