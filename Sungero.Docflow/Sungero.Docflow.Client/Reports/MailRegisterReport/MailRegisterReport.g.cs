
// ==================================================================
// MailRegisterReport.g.cs
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
  public class MailRegisterReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IMailRegisterReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("2875a21b-b6e4-476b-9bef-3693a58040e5");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::System.String FromName
    {
      get
      {
          return this.GetParameterValue("FromName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("FromName", value);
      }
    }

    public global::System.String TotalMailCount
    {
      get
      {
          return this.GetParameterValue("TotalMailCount") as global::System.String;
      }

      set
      {
        this.SetParameterValue("TotalMailCount", value);
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

    public global::System.String TempTableName
    {
      get
      {
          return this.GetParameterValue("TempTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("TempTableName", value);
      }
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


    public MailRegisterReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.MailRegisterReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.MailRegisterReportClientHandlers(this);
    }
  }
}

// ==================================================================
// MailRegisterReportRepositoryImplementer.g.cs
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
  public class MailRegisterReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IMailRegisterReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IMailRegisterReport
    {
    }
}
