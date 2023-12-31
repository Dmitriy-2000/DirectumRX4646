
// ==================================================================
// IncomingDocumentsProcessingReport.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class IncomingDocumentsProcessingReport : global::Sungero.Reporting.Client.Report, global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("50cd6eb3-ad77-4c3b-a681-6dc040964aaa");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::System.Nullable<global::System.DateTime> BeginDate
    {
      get
      {
          return this.GetParameterValue("BeginDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("BeginDate", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> EndDate
    {
      get
      {
          return this.GetParameterValue("EndDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("EndDate", value);
      }
    }

    public global::System.String DocumentsTableName
    {
      get
      {
          return this.GetParameterValue("DocumentsTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DocumentsTableName", value);
      }
    }

    public global::System.String TasksTableName
    {
      get
      {
          return this.GetParameterValue("TasksTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("TasksTableName", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> ReportDate
    {
      get
      {
          return this.GetParameterValue("ReportDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("ReportDate", value);
      }
    }

    public global::System.String AvailableIdsTableName
    {
      get
      {
          return this.GetParameterValue("AvailableIdsTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("AvailableIdsTableName", value);
      }
    }

    public global::System.String HyperlinksTableName
    {
      get
      {
          return this.GetParameterValue("HyperlinksTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("HyperlinksTableName", value);
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

    public global::System.String ViewDataTableName
    {
      get
      {
          return this.GetParameterValue("ViewDataTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ViewDataTableName", value);
      }
    }

    public global::System.String Empty
    {
      get
      {
          return this.GetParameterValue("Empty") as global::System.String;
      }

      set
      {
        this.SetParameterValue("Empty", value);
      }
    }


    public IncomingDocumentsProcessingReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.IncomingDocumentsProcessingReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.RecordManagement.IncomingDocumentsProcessingReportClientHandlers(this);
    }
  }
}

// ==================================================================
// IncomingDocumentsProcessingReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
  public class IncomingDocumentsProcessingReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IIncomingDocumentsProcessingReportRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport
    {
    }
}
