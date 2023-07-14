
// ==================================================================
// ExchangeDocumentInfoServiceDocuments.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
  public class ExchangeDocumentInfoServiceDocumentsFilterForCertificate<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.ICertificate
    where TSourceEntity : class, global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments
    where TRootEntity : class, global::Sungero.Exchange.IExchangeDocumentInfo
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ExchangeDocumentInfoServiceDocumentsCertificatePropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("ServiceDocumentsCertificateFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ExchangeDocumentInfoServiceDocumentsCertificatePropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ServiceDocumentsCertificateFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ExchangeDocumentInfoServiceDocumentsFilterForCertificate(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ExchangeDocumentInfoServiceDocumentsSearchFilterForCertificate<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.ICertificate
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Exchange.ExchangeDocumentInfoServiceDocumentsCertificateSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("ServiceDocumentsCertificateSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Exchange.ExchangeDocumentInfoServiceDocumentsCertificateSearchPropertyFilteringServerHandler<TQueryEntity>().ServiceDocumentsCertificateSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ExchangeDocumentInfoServiceDocumentsSearchFilterForCertificate(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocumentsFilterForCertificate<global::Sungero.CoreEntities.ICertificate, global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments, global::Sungero.Exchange.IExchangeDocumentInfo>), "Certificate")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocumentsSearchFilterForCertificate<global::Sungero.CoreEntities.ICertificate>), "Certificate")]


  public class ExchangeDocumentInfoServiceDocuments :
    global::Sungero.Domain.ChildEntity, global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4d60313f-8a20-4c5c-be36-0904819e0627");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocuments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Exchange.IExchangeDocumentInfoServiceDocuments, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsState State
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentInfoServiceDocumentsState(this);
    }

    public new virtual global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsInfo Info
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsInfo)base.Info; }
    }


    public global::Sungero.Exchange.IExchangeDocumentInfo ExchangeDocumentInfo { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ExchangeDocumentInfo; }
      set { this.ExchangeDocumentInfo = (global::Sungero.Exchange.IExchangeDocumentInfo)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Exchange.ExchangeDocumentInfoServiceDocumentsSharedHandlers(this);
    }

    private global::System.String _DocumentId;
    public virtual global::System.String DocumentId
    {
      get
      {
        return this._DocumentId;
      }

      set
      {
        this.SetPropertyValue("DocumentId", this._DocumentId, value, (propertyValue) => { this._DocumentId = propertyValue; }, this.DocumentIdChangedHandler);
      }
    }
    private global::System.String _CounterpartyId;
    public virtual global::System.String CounterpartyId
    {
      get
      {
        return this._CounterpartyId;
      }

      set
      {
        this.SetPropertyValue("CounterpartyId", this._CounterpartyId, value, (propertyValue) => { this._CounterpartyId = propertyValue; }, this.CounterpartyIdChangedHandler);
      }
    }
    private global::System.DateTime? _Date;
    public virtual global::System.DateTime? Date
    {
      get
      {
        return this._Date;
      }

      set
      {
        this.SetPropertyValue("Date", this._Date, value, (propertyValue) => { this._Date = propertyValue; }, this.DateChangedHandler);
      }
    }
    private global::System.String _ParentDocumentId;
    public virtual global::System.String ParentDocumentId
    {
      get
      {
        return this._ParentDocumentId;
      }

      set
      {
        this.SetPropertyValue("ParentDocumentId", this._ParentDocumentId, value, (propertyValue) => { this._ParentDocumentId = propertyValue; }, this.ParentDocumentIdChangedHandler);
      }
    }
    private global::System.String _GeneratedName;
    public virtual global::System.String GeneratedName
    {
      get
      {
        return this._GeneratedName;
      }

      set
      {
        this.SetPropertyValue("GeneratedName", this._GeneratedName, value, (propertyValue) => { this._GeneratedName = propertyValue; }, this.GeneratedNameChangedHandler);
      }
    }
    private global::System.String _StageId;
    public virtual global::System.String StageId
    {
      get
      {
        return this._StageId;
      }

      set
      {
        this.SetPropertyValue("StageId", this._StageId, value, (propertyValue) => { this._StageId = propertyValue; }, this.StageIdChangedHandler);
      }
    }
    private global::System.String _FormalizedPoAUnifiedRegNo;
    public virtual global::System.String FormalizedPoAUnifiedRegNo
    {
      get
      {
        return this._FormalizedPoAUnifiedRegNo;
      }

      set
      {
        this.SetPropertyValue("FormalizedPoAUnifiedRegNo", this._FormalizedPoAUnifiedRegNo, value, (propertyValue) => { this._FormalizedPoAUnifiedRegNo = propertyValue; }, this.FormalizedPoAUnifiedRegNoChangedHandler);
      }
    }
    private global::System.String _SecondFormalizedPoAUnifiedRegNo;
    public virtual global::System.String SecondFormalizedPoAUnifiedRegNo
    {
      get
      {
        return this._SecondFormalizedPoAUnifiedRegNo;
      }

      set
      {
        this.SetPropertyValue("SecondFormalizedPoAUnifiedRegNo", this._SecondFormalizedPoAUnifiedRegNo, value, (propertyValue) => { this._SecondFormalizedPoAUnifiedRegNo = propertyValue; }, this.SecondFormalizedPoAUnifiedRegNoChangedHandler);
      }
    }


    private global::System.Byte[] _Body;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.Byte[] Body
    {
      get
      {
        return this._Body;
      }

      set
      {
        this.SetPropertyValue("Body", this._Body, value, (propertyValue) => { this._Body = propertyValue; }, this.BodyChangedHandler);
      }
    }
    private global::System.Byte[] _Sign;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.Byte[] Sign
    {
      get
      {
        return this._Sign;
      }

      set
      {
        this.SetPropertyValue("Sign", this._Sign, value, (propertyValue) => { this._Sign = propertyValue; }, this.SignChangedHandler);
      }
    }
    private global::System.Byte[] _SecondSign;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.Byte[] SecondSign
    {
      get
      {
        return this._SecondSign;
      }

      set
      {
        this.SetPropertyValue("SecondSign", this._SecondSign, value, (propertyValue) => { this._SecondSign = propertyValue; }, this.SecondSignChangedHandler);
      }
    }





    private static global::Sungero.Domain.Shared.EnumerationItems _DocumentTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Exchange.ExchangeDocumentInfoServiceDocuments.DocumentType),
      typeof(global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocuments),
      "DocumentType");

    public static global::Sungero.Domain.Shared.EnumerationItems DocumentTypeItems
    {
      get { return global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocuments._DocumentTypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems DocumentTypeAllowedItems
    {
      get { return global::Sungero.Exchange.Server.ExchangeDocumentInfoServiceDocuments.DocumentTypeItems; }
    }

    private global::Sungero.Core.Enumeration? _DocumentType;

    public virtual global::Sungero.Core.Enumeration? DocumentType
    {
      get { return this._DocumentType; }
      set { this.SetEnumPropertyValue("DocumentType", this._DocumentType, value, (propertyValue) => { this._DocumentType = propertyValue; }, this.DocumentTypeChangedHandler, this.DocumentTypeAllowedItems); }
    }


    private global::Sungero.CoreEntities.ICertificate _Certificate;
    public virtual global::Sungero.CoreEntities.ICertificate Certificate
    {
      get
      {
        return this._Certificate;
      }

      set
      {
        this.SetPropertyValue("Certificate", this._Certificate, value, (propertyValue) => { this._Certificate = propertyValue; }, this.CertificateChangedHandler);
      }
    }




    #region Framework events

    protected void DocumentTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.DocumentType, this.DocumentType, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsDocumentTypeChanged(args);
    }

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsDocumentIdChanged(args);
    }

    protected void CounterpartyIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CounterpartyId, this.CounterpartyId, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsCounterpartyIdChanged(args);
    }

    protected void DateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Date, this.Date, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsDateChanged(args);
    }

    protected void BodyChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DataPropertyChangedEventArgs(this.State.Properties.Body, this.Body, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsBodyChanged(args);
    }

    protected void SignChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DataPropertyChangedEventArgs(this.State.Properties.Sign, this.Sign, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsSignChanged(args);
    }

    protected void ParentDocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ParentDocumentId, this.ParentDocumentId, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsParentDocumentIdChanged(args);
    }

    protected void SecondSignChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DataPropertyChangedEventArgs(this.State.Properties.SecondSign, this.SecondSign, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsSecondSignChanged(args);
    }

    protected void GeneratedNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.GeneratedName, this.GeneratedName, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsGeneratedNameChanged(args);
    }

    protected void CertificateChangedHandler()
    {
      var args = new global::Sungero.Exchange.Shared.ExchangeDocumentInfoServiceDocumentsCertificateChangedEventArgs(this.State.Properties.Certificate, this.Certificate, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsCertificateChanged(args);
    }

    protected void StageIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.StageId, this.StageId, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsStageIdChanged(args);
    }

    protected void FormalizedPoAUnifiedRegNoChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FormalizedPoAUnifiedRegNo, this.FormalizedPoAUnifiedRegNo, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsFormalizedPoAUnifiedRegNoChanged(args);
    }

    protected void SecondFormalizedPoAUnifiedRegNoChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.SecondFormalizedPoAUnifiedRegNo, this.SecondFormalizedPoAUnifiedRegNo, this);
     ((global::Sungero.Exchange.IExchangeDocumentInfoServiceDocumentsSharedHandlers)this.SharedHandlers).ServiceDocumentsSecondFormalizedPoAUnifiedRegNoChanged(args);
    }



    #endregion


    public ExchangeDocumentInfoServiceDocuments()
    {
    }

  }
}

// ==================================================================
// ExchangeDocumentInfoServiceDocumentsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange
{
  public partial class ExchangeDocumentInfoServiceDocumentsCertificatePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.ICertificate
  {
    private global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments _obj
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments)this.Entity; }
    }

    private global::Sungero.Exchange.IExchangeDocumentInfo _root
    {
      get { return (global::Sungero.Exchange.IExchangeDocumentInfo)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ServiceDocumentsCertificateFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ExchangeDocumentInfoServiceDocumentsCertificatePropertyFilteringServerHandler(global::Sungero.Exchange.IExchangeDocumentInfoServiceDocuments entity, global::Sungero.Exchange.IExchangeDocumentInfo root)
      : base(entity, root)
    {
    }
  }

  public partial class ExchangeDocumentInfoServiceDocumentsCertificateSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.ICertificate
  {

    public virtual global::System.Linq.IQueryable<T> ServiceDocumentsCertificateSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ExchangeDocumentInfoServiceDocumentsCertificateSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ExchangeDocumentInfoServiceDocumentsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Server
{
}
