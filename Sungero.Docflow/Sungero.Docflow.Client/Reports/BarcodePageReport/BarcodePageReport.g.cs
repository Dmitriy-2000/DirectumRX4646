
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

namespace Sungero.Docflow.Client
{
  public class BarcodePageReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IBarcodePageReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("96070918-90b8-431a-a72c-b37800fedbea");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
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
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.BarcodePageReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.BarcodePageReportClientHandlers(this);
    }
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

namespace Sungero.Docflow.Client
{ 
  public class BarcodePageReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IBarcodePageReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IBarcodePageReport
    {
    }
}
