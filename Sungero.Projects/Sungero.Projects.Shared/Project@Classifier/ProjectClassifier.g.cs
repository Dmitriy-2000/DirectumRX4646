
// ==================================================================
// ProjectClassifierState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectClassifierState : 
    global::Sungero.Projects.Shared.ProjectCoreClassifierState, global::Sungero.Projects.IProjectClassifierState
  {
    public ProjectClassifierState(global::Sungero.Projects.IProjectClassifier entity) : base(entity) { }

    public new global::Sungero.Projects.IProjectClassifierPropertyStates Properties
    {
      get { return (global::Sungero.Projects.IProjectClassifierPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectClassifierPropertyStates(entity);
    }


  }


  public class ProjectClassifierPropertyStates : 
    global::Sungero.Projects.Shared.ProjectCoreClassifierPropertyStates, global::Sungero.Projects.IProjectClassifierPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Projects.IProject> ProjectCore
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Projects.IProject>)base.ProjectCore; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Projects.IProjectCore> InternalProjectCore
            {
              get { return this.GetPropertyState<global::Sungero.Projects.IProject>("ProjectCore"); }
            }


    protected internal ProjectClassifierPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ProjectClassifierCollectionPropertyState<T> :
    global::Sungero.Projects.Shared.ProjectCoreClassifierCollectionPropertyState<T>, global::Sungero.Projects.IProjectClassifierCollectionPropertyState<T>
    where T : global::Sungero.Projects.IProjectClassifier
  {
    public new global::Sungero.Projects.IProjectClassifierCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Projects.IProjectClassifierCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Projects.Shared.ProjectClassifierCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ProjectClassifierCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ProjectClassifierCollectionPropertyStates :
    global::Sungero.Projects.Shared.ProjectCoreClassifierCollectionPropertyStates, global::Sungero.Projects.IProjectClassifierCollectionPropertyStates
  {

    protected internal ProjectClassifierCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ProjectClassifierInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectClassifierInfo : 
    global::Sungero.Projects.Shared.ProjectCoreClassifierInfo, global::Sungero.Projects.IProjectClassifierInfo
  {
    public ProjectClassifierInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Projects.IProjectClassifierPropertiesInfo Properties
    {
      get { return (global::Sungero.Projects.IProjectClassifierPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Projects.Shared.ProjectClassifierPropertiesInfo(entityType);
    }

  }

  public class ProjectClassifierPropertiesInfo : 
    global::Sungero.Projects.Shared.ProjectCoreClassifierPropertiesInfo, global::Sungero.Projects.IProjectClassifierPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Projects.IProjectInfo, global::Sungero.Projects.IProject> ProjectCore
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ProjectCore");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Projects.IProjectInfo, global::Sungero.Projects.IProject>(propertyMetadata);
          }
        }


    protected internal ProjectClassifierPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
