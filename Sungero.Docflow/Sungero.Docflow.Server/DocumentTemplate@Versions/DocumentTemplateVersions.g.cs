
// ==================================================================
// DocumentTemplateVersions.g.cs
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


  public class DocumentTemplateVersions :
    global::Sungero.Content.Server.ElectronicDocumentTemplateVersions, global::Sungero.Docflow.IDocumentTemplateVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("de4029f1-bb10-43ed-836c-1b1badc2ecab");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentTemplateVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentTemplateVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateVersionsState State
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentTemplateVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public DocumentTemplateVersions()
    {
    }

  }
}

// ==================================================================
// DocumentTemplateVersionsHandlers.g.cs
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
// DocumentTemplateVersionsEventArgs.g.cs
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
