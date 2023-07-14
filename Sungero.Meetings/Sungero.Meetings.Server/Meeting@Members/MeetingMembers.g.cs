
// ==================================================================
// MeetingMembers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
  public class MeetingMembersFilterForMember<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Meetings.IMeetingMembers
    where TRootEntity : class, global::Sungero.Meetings.IMeeting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.MeetingMembersMemberPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("MembersMemberFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Meetings.MeetingMembersMemberPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).MembersMemberFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MeetingMembersFilterForMember(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class MeetingMembersSearchFilterForMember<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Meetings.MeetingMembersMemberSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("MembersMemberSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Meetings.MeetingMembersMemberSearchPropertyFilteringServerHandler<TQueryEntity>().MembersMemberSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public MeetingMembersSearchFilterForMember(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Meetings.Server.MeetingMembersFilterForMember<global::Sungero.CoreEntities.IRecipient, global::Sungero.Meetings.IMeetingMembers, global::Sungero.Meetings.IMeeting>), "Member")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Meetings.Server.MeetingMembersSearchFilterForMember<global::Sungero.CoreEntities.IRecipient>), "Member")]


  public class MeetingMembers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Meetings.IMeetingMembers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c6d29374-7baa-4442-96dc-b13aa3ff42b8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Server.MeetingMembers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IMeetingMembers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Meetings.IMeetingMembersState State
    {
      get { return (global::Sungero.Meetings.IMeetingMembersState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.MeetingMembersState(this);
    }

    public new virtual global::Sungero.Meetings.IMeetingMembersInfo Info
    {
      get { return (global::Sungero.Meetings.IMeetingMembersInfo)base.Info; }
    }


    public global::Sungero.Meetings.IMeeting Meeting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.Meeting; }
      set { this.Meeting = (global::Sungero.Meetings.IMeeting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Meetings.MeetingMembersSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Member;
    public virtual global::Sungero.CoreEntities.IRecipient Member
    {
      get
      {
        return this._Member;
      }

      set
      {
        this.SetPropertyValue("Member", this._Member, value, (propertyValue) => { this._Member = propertyValue; }, this.MemberChangedHandler);
      }
    }




    #region Framework events

    protected void MemberChangedHandler()
    {
      var args = new global::Sungero.Meetings.Shared.MeetingMembersMemberChangedEventArgs(this.State.Properties.Member, this.Member, this);
     ((global::Sungero.Meetings.IMeetingMembersSharedHandlers)this.SharedHandlers).MembersMemberChanged(args);
    }



    #endregion


    public MeetingMembers()
    {
    }

  }
}

// ==================================================================
// MeetingMembersHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{
  public partial class MeetingMembersMemberPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Meetings.IMeetingMembers _obj
    {
      get { return (global::Sungero.Meetings.IMeetingMembers)this.Entity; }
    }

    private global::Sungero.Meetings.IMeeting _root
    {
      get { return (global::Sungero.Meetings.IMeeting)this.Root; }
    }

    public MeetingMembersMemberPropertyFilteringServerHandler(global::Sungero.Meetings.IMeetingMembers entity, global::Sungero.Meetings.IMeeting root)
      : base(entity, root)
    {
    }
  }

  public partial class MeetingMembersMemberSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> MembersMemberSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public MeetingMembersMemberSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// MeetingMembersEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
}
