
// ==================================================================
// EnvelopeC5Report.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class EnvelopeC5Report : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IEnvelopeC5Report
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("8ca78880-7162-4e8f-8d8f-a606673a401f");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::System.String ReportSessionId
    {
      get
      {
          return this.GetParameterValue("ReportSessionId") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ReportSessionId", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> PrintSender
    {
      get
      {
          return this.GetParameterValue("PrintSender") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("PrintSender", value);
      }
    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase> _OutgoingDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase> OutgoingDocuments
    {
      get
      {
          if(this._OutgoingDocumentsAdapter == null)
            this._OutgoingDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase>(this, "OutgoingDocuments");
          return this._OutgoingDocumentsAdapter;
      }

    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase> _ContractualDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase> ContractualDocuments
    {
      get
      {
          if(this._ContractualDocumentsAdapter == null)
            this._ContractualDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase>(this, "ContractualDocuments");
          return this._ContractualDocumentsAdapter;
      }

    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase> _AccountingDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase> AccountingDocuments
    {
      get
      {
          if(this._AccountingDocumentsAdapter == null)
            this._AccountingDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase>(this, "AccountingDocuments");
          return this._AccountingDocumentsAdapter;
      }

    }


    public EnvelopeC5Report()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.EnvelopeC5ReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.EnvelopeC5ReportClientHandlers(this);
    }
  }
}

// ==================================================================
// EnvelopeC5ReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class EnvelopeC5ReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IEnvelopeC5ReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IEnvelopeC5Report
    {
    }
}
