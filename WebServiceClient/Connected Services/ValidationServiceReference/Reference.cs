﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceClient.ValidationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeclarationDocument", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DeclarationDocument : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentStructureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeclarationCommandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiteIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string DocumentStructure {
            get {
                return this.DocumentStructureField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentStructureField, value) != true)) {
                    this.DocumentStructureField = value;
                    this.RaisePropertyChanged("DocumentStructure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string DeclarationCommand {
            get {
                return this.DeclarationCommandField;
            }
            set {
                if ((object.ReferenceEquals(this.DeclarationCommandField, value) != true)) {
                    this.DeclarationCommandField = value;
                    this.RaisePropertyChanged("DeclarationCommand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SiteId {
            get {
                return this.SiteIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteIdField, value) != true)) {
                    this.SiteIdField = value;
                    this.RaisePropertyChanged("SiteId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ValidationServiceReference.DocumentValidationWebServiceSoap")]
    public interface DocumentValidationWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name doc from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateDocument", ReplyAction="*")]
        WebServiceClient.ValidationServiceReference.ValidateDocumentResponse ValidateDocument(WebServiceClient.ValidationServiceReference.ValidateDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.ValidateDocumentResponse> ValidateDocumentAsync(WebServiceClient.ValidationServiceReference.ValidateDocumentRequest request);
        
        // CODEGEN: Generating message contract since element name data from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadDocument", ReplyAction="*")]
        WebServiceClient.ValidationServiceReference.UploadDocumentResponse UploadDocument(WebServiceClient.ValidationServiceReference.UploadDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.UploadDocumentResponse> UploadDocumentAsync(WebServiceClient.ValidationServiceReference.UploadDocumentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateDocument", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.ValidationServiceReference.ValidateDocumentRequestBody Body;
        
        public ValidateDocumentRequest() {
        }
        
        public ValidateDocumentRequest(WebServiceClient.ValidationServiceReference.ValidateDocumentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateDocumentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doc;
        
        public ValidateDocumentRequestBody() {
        }
        
        public ValidateDocumentRequestBody(string doc) {
            this.doc = doc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateDocumentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.ValidationServiceReference.ValidateDocumentResponseBody Body;
        
        public ValidateDocumentResponse() {
        }
        
        public ValidateDocumentResponse(WebServiceClient.ValidationServiceReference.ValidateDocumentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateDocumentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceClient.ValidationServiceReference.DeclarationDocument ValidateDocumentResult;
        
        public ValidateDocumentResponseBody() {
        }
        
        public ValidateDocumentResponseBody(WebServiceClient.ValidationServiceReference.DeclarationDocument ValidateDocumentResult) {
            this.ValidateDocumentResult = ValidateDocumentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadDocument", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.ValidationServiceReference.UploadDocumentRequestBody Body;
        
        public UploadDocumentRequest() {
        }
        
        public UploadDocumentRequest(WebServiceClient.ValidationServiceReference.UploadDocumentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadDocumentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] data;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fileName;
        
        public UploadDocumentRequestBody() {
        }
        
        public UploadDocumentRequestBody(byte[] data, string fileName) {
            this.data = data;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadDocumentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.ValidationServiceReference.UploadDocumentResponseBody Body;
        
        public UploadDocumentResponse() {
        }
        
        public UploadDocumentResponse(WebServiceClient.ValidationServiceReference.UploadDocumentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadDocumentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UploadDocumentResult;
        
        public UploadDocumentResponseBody() {
        }
        
        public UploadDocumentResponseBody(string UploadDocumentResult) {
            this.UploadDocumentResult = UploadDocumentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DocumentValidationWebServiceSoapChannel : WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentValidationWebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap>, WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap {
        
        public DocumentValidationWebServiceSoapClient() {
        }
        
        public DocumentValidationWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentValidationWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentValidationWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentValidationWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceClient.ValidationServiceReference.ValidateDocumentResponse WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap.ValidateDocument(WebServiceClient.ValidationServiceReference.ValidateDocumentRequest request) {
            return base.Channel.ValidateDocument(request);
        }
        
        public WebServiceClient.ValidationServiceReference.DeclarationDocument ValidateDocument(string doc) {
            WebServiceClient.ValidationServiceReference.ValidateDocumentRequest inValue = new WebServiceClient.ValidationServiceReference.ValidateDocumentRequest();
            inValue.Body = new WebServiceClient.ValidationServiceReference.ValidateDocumentRequestBody();
            inValue.Body.doc = doc;
            WebServiceClient.ValidationServiceReference.ValidateDocumentResponse retVal = ((WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap)(this)).ValidateDocument(inValue);
            return retVal.Body.ValidateDocumentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.ValidateDocumentResponse> WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap.ValidateDocumentAsync(WebServiceClient.ValidationServiceReference.ValidateDocumentRequest request) {
            return base.Channel.ValidateDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.ValidateDocumentResponse> ValidateDocumentAsync(string doc) {
            WebServiceClient.ValidationServiceReference.ValidateDocumentRequest inValue = new WebServiceClient.ValidationServiceReference.ValidateDocumentRequest();
            inValue.Body = new WebServiceClient.ValidationServiceReference.ValidateDocumentRequestBody();
            inValue.Body.doc = doc;
            return ((WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap)(this)).ValidateDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceClient.ValidationServiceReference.UploadDocumentResponse WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap.UploadDocument(WebServiceClient.ValidationServiceReference.UploadDocumentRequest request) {
            return base.Channel.UploadDocument(request);
        }
        
        public string UploadDocument(byte[] data, string fileName) {
            WebServiceClient.ValidationServiceReference.UploadDocumentRequest inValue = new WebServiceClient.ValidationServiceReference.UploadDocumentRequest();
            inValue.Body = new WebServiceClient.ValidationServiceReference.UploadDocumentRequestBody();
            inValue.Body.data = data;
            inValue.Body.fileName = fileName;
            WebServiceClient.ValidationServiceReference.UploadDocumentResponse retVal = ((WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap)(this)).UploadDocument(inValue);
            return retVal.Body.UploadDocumentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.UploadDocumentResponse> WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap.UploadDocumentAsync(WebServiceClient.ValidationServiceReference.UploadDocumentRequest request) {
            return base.Channel.UploadDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceClient.ValidationServiceReference.UploadDocumentResponse> UploadDocumentAsync(byte[] data, string fileName) {
            WebServiceClient.ValidationServiceReference.UploadDocumentRequest inValue = new WebServiceClient.ValidationServiceReference.UploadDocumentRequest();
            inValue.Body = new WebServiceClient.ValidationServiceReference.UploadDocumentRequestBody();
            inValue.Body.data = data;
            inValue.Body.fileName = fileName;
            return ((WebServiceClient.ValidationServiceReference.DocumentValidationWebServiceSoap)(this)).UploadDocumentAsync(inValue);
        }
    }
}