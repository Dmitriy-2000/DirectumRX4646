
// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExe.g.cs
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


  public class ApprovalExecutionAssignmentCollapsedStagesTypesExe :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5043014a-672b-44c4-8982-b61292b4b570");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalExecutionAssignmentCollapsedStagesTypesExe.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeState State
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentCollapsedStagesTypesExeState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalExecutionAssignment ApprovalExecutionAssignment { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalExecutionAssignment; }
      set { this.ApprovalExecutionAssignment = (global::Sungero.Docflow.IApprovalExecutionAssignment)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalExecutionAssignmentCollapsedStagesTypesExeSharedHandlers(this);
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _StageTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.ApprovalExecutionAssignmentCollapsedStagesTypesExe.StageType),
      typeof(global::Sungero.Docflow.Server.ApprovalExecutionAssignmentCollapsedStagesTypesExe),
      "StageType");

    public static global::Sungero.Domain.Shared.EnumerationItems StageTypeItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalExecutionAssignmentCollapsedStagesTypesExe._StageTypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems StageTypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalExecutionAssignmentCollapsedStagesTypesExe.StageTypeItems; }
    }

    private global::Sungero.Core.Enumeration? _StageType;

    public virtual global::Sungero.Core.Enumeration? StageType
    {
      get { return this._StageType; }
      set { this.SetEnumPropertyValue("StageType", this._StageType, value, (propertyValue) => { this._StageType = propertyValue; }, this.StageTypeChangedHandler, this.StageTypeAllowedItems); }
    }





    #region Framework events

    protected void StageTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.StageType, this.StageType, this);
     ((global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeSharedHandlers)this.SharedHandlers).CollapsedStagesTypesExeStageTypeChanged(args);
    }



    #endregion


    public ApprovalExecutionAssignmentCollapsedStagesTypesExe()
    {
    }

  }
}

// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExeHandlers.g.cs
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

}

// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExeEventArgs.g.cs
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
