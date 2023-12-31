
// ==================================================================
// DistributionSheetReport.g.cs
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
  public class DistributionSheetReport : global::Sungero.Reporting.Server.Report, global::Sungero.Docflow.IDistributionSheetReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("df6387b8-9209-411e-8192-d9eabd494afd");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DistributionSheetReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::Sungero.Docflow.IOutgoingDocumentBase OutgoingDocument
    {
      get
      {
          return this.GetParameterValue("OutgoingDocument") as global::Sungero.Docflow.IOutgoingDocumentBase;
      }

      set
      {
        this.SetParameterValue("OutgoingDocument", value);
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

    public global::System.String LetterSubject
    {
      get
      {
          return this.GetParameterValue("LetterSubject") as global::System.String;
      }

      set
      {
        this.SetParameterValue("LetterSubject", value);
      }
    }


    public DistributionSheetReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DistributionSheetReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.DistributionSheetReportServerHandlers(this);
    }
  }
}

// ==================================================================
// DistributionSheetReportHandlers.g.cs
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
  public partial class DistributionSheetReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Docflow.IDistributionSheetReport DistributionSheetReport
    {
      get { return (global::Sungero.Docflow.IDistributionSheetReport)this._Report; }
    }

    public DistributionSheetReportServerHandlers(global::Sungero.Docflow.IDistributionSheetReport report) : base(report) { }
  }
}

// ==================================================================
// DistributionSheetReportRepositoryImplementer.g.cs
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
  public class DistributionSheetReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Docflow.IDistributionSheetReportRepositoryImplementer<T>
    where T : global::Sungero.Docflow.IDistributionSheetReport 
  {
  }
}

// ==================================================================
// DistributionSheetReportQueries.g.cs
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
  public class DistributionSheetReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Reports.DistributionSheetReport.DistributionSheetReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
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
