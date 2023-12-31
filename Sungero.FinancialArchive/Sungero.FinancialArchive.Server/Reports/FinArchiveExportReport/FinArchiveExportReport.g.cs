
// ==================================================================
// FinArchiveExportReport.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
  public class FinArchiveExportReport : global::Sungero.Reporting.Server.Report, global::Sungero.FinancialArchive.IFinArchiveExportReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("e5081ffe-8a47-41fd-ad9f-407d1b181464");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.FinancialArchive.FinArchiveExportReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::System.Nullable<global::System.DateTime> CurrentTime
    {
      get
      {
          return this.GetParameterValue("CurrentTime") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("CurrentTime", value);
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

    public global::System.Nullable<global::System.Int32> Exported
    {
      get
      {
          return this.GetParameterValue("Exported") as global::System.Nullable<global::System.Int32>;
      }

      set
      {
        this.SetParameterValue("Exported", value);
      }
    }

    public global::System.Nullable<global::System.Int32> NotExported
    {
      get
      {
          return this.GetParameterValue("NotExported") as global::System.Nullable<global::System.Int32>;
      }

      set
      {
        this.SetParameterValue("NotExported", value);
      }
    }


    public FinArchiveExportReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.FinancialArchive.FinArchiveExportReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.FinancialArchive.FinArchiveExportReportServerHandlers(this);
    }
  }
}

// ==================================================================
// FinArchiveExportReportHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{
  public partial class FinArchiveExportReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.FinancialArchive.IFinArchiveExportReport FinArchiveExportReport
    {
      get { return (global::Sungero.FinancialArchive.IFinArchiveExportReport)this._Report; }
    }

    public FinArchiveExportReportServerHandlers(global::Sungero.FinancialArchive.IFinArchiveExportReport report) : base(report) { }
  }
}

// ==================================================================
// FinArchiveExportReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Server
{
  public class FinArchiveExportReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.FinancialArchive.IFinArchiveExportReportRepositoryImplementer<T>
    where T : global::Sungero.FinancialArchive.IFinArchiveExportReport 
  {
  }
}

// ==================================================================
// FinArchiveExportReportQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Queries
{
  public class FinArchiveExportReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.FinancialArchive.Server.Reports.FinArchiveExportReport.FinArchiveExportReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string CreateFinArchiveExportReportTable
    {
       get { return resolver.GetQuery("CreateFinArchiveExportReportTable"); }
    }
    public static string SelectFromFinArchiveExportReportTable
    {
       get { return resolver.GetQuery("SelectFromFinArchiveExportReportTable"); }
    }
  }
}
