
// ==================================================================
// ProjectCoreTeamMembers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectCoreTeamMembers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Projects.IProjectCoreTeamMembers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c06142f1-0fbd-4946-b382-227591508986");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Client.ProjectCoreTeamMembers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectCoreTeamMembers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Projects.IProjectCoreTeamMembersState State
    {
      get
      {
        return (global::Sungero.Projects.IProjectCoreTeamMembersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectCoreTeamMembersState(this);
    }

    public new global::Sungero.Projects.IProjectCoreTeamMembersInfo Info
    {
      get
      {
        return (global::Sungero.Projects.IProjectCoreTeamMembersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Projects.IProjectCore> _ProjectCore;

    public global::Sungero.Projects.IProjectCore ProjectCore
    {
      get { return this._ProjectCore.Value; }
      set { this._ProjectCore.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ProjectCore; }
      set { this.ProjectCore = (global::Sungero.Projects.IProjectCore)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Group;

        public virtual global::Sungero.Core.Enumeration? Group
        {
          get { return this._Group.Value; }
          set { this._Group.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _GroupItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Projects.ProjectCoreTeamMembers.Group),
          typeof(global::Sungero.Projects.Client.ProjectCoreTeamMembers),
          "Group");

        public static global::Sungero.Domain.Shared.EnumerationItems GroupItems
        {
          get { return global::Sungero.Projects.Client.ProjectCoreTeamMembers._GroupItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems GroupAllowedItems
        {
          get { return global::Sungero.Projects.Client.ProjectCoreTeamMembers.GroupItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Member;

              public virtual global::Sungero.CoreEntities.IRecipient Member
              {
              get
              {
                return this._Member.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Member as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectCoreTeamMembersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectCoreTeamMembersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void MemberChangedHandler()
    {
      var args = new global::Sungero.Projects.Shared.ProjectCoreTeamMembersMemberChangedEventArgs(this.State.Properties.Member, this.Member, this);
     ((global::Sungero.Projects.IProjectCoreTeamMembersSharedHandlers)this.SharedHandlers).TeamMembersMemberChanged(args);
    }

    protected void GroupChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Group, this.Group, this);
     ((global::Sungero.Projects.IProjectCoreTeamMembersSharedHandlers)this.SharedHandlers).TeamMembersGroupChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient MemberValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Projects.Client.ProjectCoreTeamMembersMemberValueInputEventArgs(this.Member, value, this, this.Info.Properties.Member);
    ((global::Sungero.Projects.ProjectCoreTeamMembersClientHandlers)this.Handlers).TeamMembersMemberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? GroupValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Group, value, this, this.Info.Properties.Group);
    ((global::Sungero.Projects.ProjectCoreTeamMembersClientHandlers)this.Handlers).TeamMembersGroupValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> GroupFilteringHandler()
  {
    return ((global::Sungero.Projects.ProjectCoreTeamMembersClientHandlers)this.Handlers).TeamMembersGroupFiltering(this.GroupAllowedItems);
  }


    #endregion

    #region Constructors



              protected virtual void InitMemberNavigationProperty()
              {
                this._Member = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Member", this);
                this._Member.ValueChanged += (sender, e) => { this.MemberChangedHandler(); };
                this.AddProperty(this._Member as global::Sungero.Domain.Client.IProperty);
              }




    public ProjectCoreTeamMembers()
    {
      this._ProjectCore = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Projects.IProjectCore>("ProjectCore", this, true);

            this._Group = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Group", this);
            this._Group.ValueChanged += (sender, e) => { this.GroupChangedHandler(); };
            this.AddProperty(this._Group);

            this.InitMemberNavigationProperty();








    }

    #endregion

  }
}
