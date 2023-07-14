
// ==================================================================
// BarcodePageReport.g.cs
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
  public class BarcodePageReport : global::Sungero.Reporting.Server.Report, global::Sungero.Docflow.IBarcodePageReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("96070918-90b8-431a-a72c-b37800fedbea");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.BarcodePageReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::System.String barcode
    {
      get
      {
          return this.GetParameterValue("barcode") as global::System.String;
      }

      set
      {
        this.SetParameterValue("barcode", value);
      }
    }

    public global::System.String barcodeName
    {
      get
      {
          return this.GetParameterValue("barcodeName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("barcodeName", value);
      }
    }


    public BarcodePageReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.BarcodePageReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.BarcodePageReportServerHandlers(this);
    }
  }
}

// ==================================================================
// BarcodePageReportHandlers.g.cs
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
  public partial class BarcodePageReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Docflow.IBarcodePageReport BarcodePageReport
    {
      get { return (global::Sungero.Docflow.IBarcodePageReport)this._Report; }
    }

    public BarcodePageReportServerHandlers(global::Sungero.Docflow.IBarcodePageReport report) : base(report) { }
  }
}

// ==================================================================
// BarcodePageReportRepositoryImplementer.g.cs
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
  public class BarcodePageReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Docflow.IBarcodePageReportRepositoryImplementer<T>
    where T : global::Sungero.Docflow.IBarcodePageReport 
  {
  }
}

// ==================================================================
// BarcodePageReportQueries.g.cs
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
  public class BarcodePageReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Reports.BarcodePageReport.BarcodePageReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}