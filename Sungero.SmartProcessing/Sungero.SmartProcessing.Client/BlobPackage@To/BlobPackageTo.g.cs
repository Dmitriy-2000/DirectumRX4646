
// ==================================================================
// BlobPackageTo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class BlobPackageTo :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.SmartProcessing.IBlobPackageTo
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6b16e807-26cd-4c4b-aadf-b2a255609cc6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Client.BlobPackageTo.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IBlobPackageTo, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.SmartProcessing.IBlobPackageToState State
    {
      get
      {
        return (global::Sungero.SmartProcessing.IBlobPackageToState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPackageToState(this);
    }

    public new global::Sungero.SmartProcessing.IBlobPackageToInfo Info
    {
      get
      {
        return (global::Sungero.SmartProcessing.IBlobPackageToInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.SmartProcessing.IBlobPackage> _BlobPackage;

    public global::Sungero.SmartProcessing.IBlobPackage BlobPackage
    {
      get { return this._BlobPackage.Value; }
      set { this._BlobPackage.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.BlobPackage; }
      set { this.BlobPackage = (global::Sungero.SmartProcessing.IBlobPackage)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Address;

        public virtual global::System.String Address
        {
          get { return this._Address.Value; }
          set { this._Address.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.BlobPackageToClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.BlobPackageToSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.SmartProcessing.IBlobPackageToSharedHandlers)this.SharedHandlers).ToNameChanged(args);
    }

    protected void AddressChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Address, this.Address, this);
     ((global::Sungero.SmartProcessing.IBlobPackageToSharedHandlers)this.SharedHandlers).ToAddressChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.SmartProcessing.BlobPackageToClientHandlers)this.Handlers).ToNameValueInput(args);
    return args.NewValue;
  }

  protected global::System.String AddressValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Address, value, this, this.Info.Properties.Address);
    ((global::Sungero.SmartProcessing.BlobPackageToClientHandlers)this.Handlers).ToAddressValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public BlobPackageTo()
    {
      this._BlobPackage = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.SmartProcessing.IBlobPackage>("BlobPackage", this, true);

            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._Address = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Address", this);
            this._Address.ValueChanged += (sender, e) => { this.AddressChangedHandler(); };
            this.AddProperty(this._Address);








    }

    #endregion

  }
}
