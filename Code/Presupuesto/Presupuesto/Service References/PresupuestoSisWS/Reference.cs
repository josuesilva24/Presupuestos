﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presupuesto.PresupuestoSisWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WS_PresupuestoSis")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CentroCostosMap", Namespace="http://schemas.datacontract.org/2004/07/ModelMap")]
    [System.SerializableAttribute()]
    public partial class CentroCostosMap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBD {
            get {
                return this.IdBDField;
            }
            set {
                if ((this.IdBDField.Equals(value) != true)) {
                    this.IdBDField = value;
                    this.RaisePropertyChanged("IdBD");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProyectoCentroCostosMap", Namespace="http://schemas.datacontract.org/2004/07/ModelMap")]
    [System.SerializableAttribute()]
    public partial class ProyectoCentroCostosMap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CentroCostoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CentroCosto {
            get {
                return this.CentroCostoField;
            }
            set {
                if ((object.ReferenceEquals(this.CentroCostoField, value) != true)) {
                    this.CentroCostoField = value;
                    this.RaisePropertyChanged("CentroCosto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBD {
            get {
                return this.IdBDField;
            }
            set {
                if ((this.IdBDField.Equals(value) != true)) {
                    this.IdBDField = value;
                    this.RaisePropertyChanged("IdBD");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InflacionMap", Namespace="http://schemas.datacontract.org/2004/07/ModelMap")]
    [System.SerializableAttribute()]
    public partial class InflacionMap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AnnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdBDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimerSemestreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SegundoSemestreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Anno {
            get {
                return this.AnnoField;
            }
            set {
                if ((this.AnnoField.Equals(value) != true)) {
                    this.AnnoField = value;
                    this.RaisePropertyChanged("Anno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdBD {
            get {
                return this.IdBDField;
            }
            set {
                if ((this.IdBDField.Equals(value) != true)) {
                    this.IdBDField = value;
                    this.RaisePropertyChanged("IdBD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrimerSemestre {
            get {
                return this.PrimerSemestreField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimerSemestreField, value) != true)) {
                    this.PrimerSemestreField = value;
                    this.RaisePropertyChanged("PrimerSemestre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SegundoSemestre {
            get {
                return this.SegundoSemestreField;
            }
            set {
                if ((object.ReferenceEquals(this.SegundoSemestreField, value) != true)) {
                    this.SegundoSemestreField = value;
                    this.RaisePropertyChanged("SegundoSemestre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PresupuestoSisWS.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Presupuesto.PresupuestoSisWS.CompositeType GetDataUsingDataContract(Presupuesto.PresupuestoSisWS.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.CompositeType> GetDataUsingDataContractAsync(Presupuesto.PresupuestoSisWS.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCentrosCosto", ReplyAction="http://tempuri.org/IService1/getCentrosCostoResponse")]
        Presupuesto.PresupuestoSisWS.CentroCostosMap[] getCentrosCosto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCentrosCosto", ReplyAction="http://tempuri.org/IService1/getCentrosCostoResponse")]
        System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.CentroCostosMap[]> getCentrosCostoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateCentroCosto", ReplyAction="http://tempuri.org/IService1/updateCentroCostoResponse")]
        bool updateCentroCosto(int id, bool estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateCentroCosto", ReplyAction="http://tempuri.org/IService1/updateCentroCostoResponse")]
        System.Threading.Tasks.Task<bool> updateCentroCostoAsync(int id, bool estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProyectosCentrosCosto", ReplyAction="http://tempuri.org/IService1/getProyectosCentrosCostoResponse")]
        Presupuesto.PresupuestoSisWS.ProyectoCentroCostosMap[] getProyectosCentrosCosto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProyectosCentrosCosto", ReplyAction="http://tempuri.org/IService1/getProyectosCentrosCostoResponse")]
        System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.ProyectoCentroCostosMap[]> getProyectosCentrosCostoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getInflaciones", ReplyAction="http://tempuri.org/IService1/getInflacionesResponse")]
        Presupuesto.PresupuestoSisWS.InflacionMap[] getInflaciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getInflaciones", ReplyAction="http://tempuri.org/IService1/getInflacionesResponse")]
        System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.InflacionMap[]> getInflacionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateInflaciones", ReplyAction="http://tempuri.org/IService1/UpdateInflacionesResponse")]
        bool UpdateInflaciones(int id, string semestreI, string semestreII);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateInflaciones", ReplyAction="http://tempuri.org/IService1/UpdateInflacionesResponse")]
        System.Threading.Tasks.Task<bool> UpdateInflacionesAsync(int id, string semestreI, string semestreII);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddInflaciones", ReplyAction="http://tempuri.org/IService1/AddInflacionesResponse")]
        bool AddInflaciones(int anno, string semestreI, string semestreII);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddInflaciones", ReplyAction="http://tempuri.org/IService1/AddInflacionesResponse")]
        System.Threading.Tasks.Task<bool> AddInflacionesAsync(int anno, string semestreI, string semestreII);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Presupuesto.PresupuestoSisWS.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Presupuesto.PresupuestoSisWS.IService1>, Presupuesto.PresupuestoSisWS.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Presupuesto.PresupuestoSisWS.CompositeType GetDataUsingDataContract(Presupuesto.PresupuestoSisWS.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.CompositeType> GetDataUsingDataContractAsync(Presupuesto.PresupuestoSisWS.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public Presupuesto.PresupuestoSisWS.CentroCostosMap[] getCentrosCosto() {
            return base.Channel.getCentrosCosto();
        }
        
        public System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.CentroCostosMap[]> getCentrosCostoAsync() {
            return base.Channel.getCentrosCostoAsync();
        }
        
        public bool updateCentroCosto(int id, bool estado) {
            return base.Channel.updateCentroCosto(id, estado);
        }
        
        public System.Threading.Tasks.Task<bool> updateCentroCostoAsync(int id, bool estado) {
            return base.Channel.updateCentroCostoAsync(id, estado);
        }
        
        public Presupuesto.PresupuestoSisWS.ProyectoCentroCostosMap[] getProyectosCentrosCosto() {
            return base.Channel.getProyectosCentrosCosto();
        }
        
        public System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.ProyectoCentroCostosMap[]> getProyectosCentrosCostoAsync() {
            return base.Channel.getProyectosCentrosCostoAsync();
        }
        
        public Presupuesto.PresupuestoSisWS.InflacionMap[] getInflaciones() {
            return base.Channel.getInflaciones();
        }
        
        public System.Threading.Tasks.Task<Presupuesto.PresupuestoSisWS.InflacionMap[]> getInflacionesAsync() {
            return base.Channel.getInflacionesAsync();
        }
        
        public bool UpdateInflaciones(int id, string semestreI, string semestreII) {
            return base.Channel.UpdateInflaciones(id, semestreI, semestreII);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateInflacionesAsync(int id, string semestreI, string semestreII) {
            return base.Channel.UpdateInflacionesAsync(id, semestreI, semestreII);
        }
        
        public bool AddInflaciones(int anno, string semestreI, string semestreII) {
            return base.Channel.AddInflaciones(anno, semestreI, semestreII);
        }
        
        public System.Threading.Tasks.Task<bool> AddInflacionesAsync(int anno, string semestreI, string semestreII) {
            return base.Channel.AddInflacionesAsync(anno, semestreI, semestreII);
        }
    }
}
