
// ==================================================================
// ApprovalRulesConsolidatedReport.g.cs
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
  public class ApprovalRulesConsolidatedReport : global::Sungero.Reporting.Server.Report, global::Sungero.Docflow.IApprovalRulesConsolidatedReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("65a79eb2-8bae-4640-b817-e033c8ba9589");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRulesConsolidatedReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
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

    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get
      {
          return this.GetParameterValue("BusinessUnit") as global::Sungero.Company.IBusinessUnit;
      }

      set
      {
        this.SetParameterValue("BusinessUnit", value);
      }
    }

    public global::Sungero.Company.IDepartment Department
    {
      get
      {
          return this.GetParameterValue("Department") as global::Sungero.Company.IDepartment;
      }

      set
      {
        this.SetParameterValue("Department", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> IncludeSubsidiary
    {
      get
      {
          return this.GetParameterValue("IncludeSubsidiary") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("IncludeSubsidiary", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> FilterDepartmentsForBusinessUnits
    {
      get
      {
          return this.GetParameterValue("FilterDepartmentsForBusinessUnits") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("FilterDepartmentsForBusinessUnits", value);
      }
    }

    public global::System.String DocumentFlow
    {
      get
      {
          return this.GetParameterValue("DocumentFlow") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DocumentFlow", value);
      }
    }

    public global::Sungero.Docflow.IDocumentKind DocumentKind
    {
      get
      {
          return this.GetParameterValue("DocumentKind") as global::Sungero.Docflow.IDocumentKind;
      }

      set
      {
        this.SetParameterValue("DocumentKind", value);
      }
    }

    public global::Sungero.Docflow.IDocumentGroupBase Category
    {
      get
      {
          return this.GetParameterValue("Category") as global::Sungero.Docflow.IDocumentGroupBase;
      }

      set
      {
        this.SetParameterValue("Category", value);
      }
    }


    public ApprovalRulesConsolidatedReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRulesConsolidatedReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.ApprovalRulesConsolidatedReportServerHandlers(this);
    }
  }
}

// ==================================================================
// ApprovalRulesConsolidatedReportHandlers.g.cs
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
  public partial class ApprovalRulesConsolidatedReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Docflow.IApprovalRulesConsolidatedReport ApprovalRulesConsolidatedReport
    {
      get { return (global::Sungero.Docflow.IApprovalRulesConsolidatedReport)this._Report; }
    }

    public ApprovalRulesConsolidatedReportServerHandlers(global::Sungero.Docflow.IApprovalRulesConsolidatedReport report) : base(report) { }
  }
}

// ==================================================================
// ApprovalRulesConsolidatedReportRepositoryImplementer.g.cs
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
  public class ApprovalRulesConsolidatedReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Docflow.IApprovalRulesConsolidatedReportRepositoryImplementer<T>
    where T : global::Sungero.Docflow.IApprovalRulesConsolidatedReport 
  {
  }
}

// ==================================================================
// ApprovalRulesConsolidatedReportQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class ApprovalRulesConsolidatedReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Reports.ApprovalRulesConsolidatedReport.ApprovalRulesConsolidatedReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string CreateSourceTable
    {
       get { return resolver.GetQuery("CreateSourceTable"); }
    }
    public static string SelectFromTempTable
    {
       get { return resolver.GetQuery("SelectFromTempTable"); }
    }
  }
}
