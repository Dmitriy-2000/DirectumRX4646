
// ==================================================================
// ApprovalRuleCardReport.g.cs
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
  public class ApprovalRuleCardReport : global::Sungero.Reporting.Server.Report, global::Sungero.Docflow.IApprovalRuleCardReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("b13e1d18-c0a3-4493-8f62-c7e0a28318c5");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRuleCardReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::Sungero.Docflow.IApprovalRuleBase ApprovalRule
    {
      get
      {
          return this.GetParameterValue("ApprovalRule") as global::Sungero.Docflow.IApprovalRuleBase;
      }

      set
      {
        this.SetParameterValue("ApprovalRule", value);
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

    public global::System.Nullable<global::System.DateTime> CurrentDate
    {
      get
      {
          return this.GetParameterValue("CurrentDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("CurrentDate", value);
      }
    }

    public global::System.String RuleStatusLocalized
    {
      get
      {
          return this.GetParameterValue("RuleStatusLocalized") as global::System.String;
      }

      set
      {
        this.SetParameterValue("RuleStatusLocalized", value);
      }
    }

    public global::System.String RuleFlowLocalized
    {
      get
      {
          return this.GetParameterValue("RuleFlowLocalized") as global::System.String;
      }

      set
      {
        this.SetParameterValue("RuleFlowLocalized", value);
      }
    }

    public global::System.String SignSettHeader
    {
      get
      {
          return this.GetParameterValue("SignSettHeader") as global::System.String;
      }

      set
      {
        this.SetParameterValue("SignSettHeader", value);
      }
    }

    public global::System.String SignSettEmpty
    {
      get
      {
          return this.GetParameterValue("SignSettEmpty") as global::System.String;
      }

      set
      {
        this.SetParameterValue("SignSettEmpty", value);
      }
    }

    public global::System.String ReworkPerformer
    {
      get
      {
          return this.GetParameterValue("ReworkPerformer") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ReworkPerformer", value);
      }
    }

    public global::System.String ReworkDeadline
    {
      get
      {
          return this.GetParameterValue("ReworkDeadline") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ReworkDeadline", value);
      }
    }


    public ApprovalRuleCardReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ApprovalRuleCardReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.ApprovalRuleCardReportServerHandlers(this);
    }
  }
}

// ==================================================================
// ApprovalRuleCardReportHandlers.g.cs
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
  public partial class ApprovalRuleCardReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleCardReport ApprovalRuleCardReport
    {
      get { return (global::Sungero.Docflow.IApprovalRuleCardReport)this._Report; }
    }

    public ApprovalRuleCardReportServerHandlers(global::Sungero.Docflow.IApprovalRuleCardReport report) : base(report) { }
  }
}

// ==================================================================
// ApprovalRuleCardReportRepositoryImplementer.g.cs
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
  public class ApprovalRuleCardReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Docflow.IApprovalRuleCardReportRepositoryImplementer<T>
    where T : global::Sungero.Docflow.IApprovalRuleCardReport 
  {
  }
}

// ==================================================================
// ApprovalRuleCardReportQueries.g.cs
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
  public class ApprovalRuleCardReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Reports.ApprovalRuleCardReport.ApprovalRuleCardReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string CreateCriteriaSourceTable
    {
       get { return resolver.GetQuery("CreateCriteriaSourceTable"); }
    }
    public static string SelectCriteriaDataFromTable
    {
       get { return resolver.GetQuery("SelectCriteriaDataFromTable"); }
    }
    public static string CreateConditionsSourceTable
    {
       get { return resolver.GetQuery("CreateConditionsSourceTable"); }
    }
    public static string SelectConditionsDataFromTable
    {
       get { return resolver.GetQuery("SelectConditionsDataFromTable"); }
    }
    public static string CreateSignatureSettingsTable
    {
       get { return resolver.GetQuery("CreateSignatureSettingsTable"); }
    }
    public static string SelectSignatureSettingsDataFromTable
    {
       get { return resolver.GetQuery("SelectSignatureSettingsDataFromTable"); }
    }
  }
}
