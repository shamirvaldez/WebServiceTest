﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceTest.ClientInfoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clients", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Clients : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Age {
            get {
                return this.AgeField;
            }
            set {
                if ((object.ReferenceEquals(this.AgeField, value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientInfoWS.InfoWebServiceSoap")]
    public interface InfoWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServiceTest.ClientInfoWS.HelloWorldResponse HelloWorld(WebServiceTest.ClientInfoWS.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.HelloWorldResponse> HelloWorldAsync(WebServiceTest.ClientInfoWS.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetClientResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClient", ReplyAction="*")]
        WebServiceTest.ClientInfoWS.GetClientResponse GetClient(WebServiceTest.ClientInfoWS.GetClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClient", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.GetClientResponse> GetClientAsync(WebServiceTest.ClientInfoWS.GetClientRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddClient", ReplyAction="*")]
        WebServiceTest.ClientInfoWS.AddClientResponse AddClient(WebServiceTest.ClientInfoWS.AddClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddClient", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.AddClientResponse> AddClientAsync(WebServiceTest.ClientInfoWS.AddClientRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServiceTest.ClientInfoWS.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServiceTest.ClientInfoWS.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClient", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.GetClientRequestBody Body;
        
        public GetClientRequest() {
        }
        
        public GetClientRequest(WebServiceTest.ClientInfoWS.GetClientRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetClientRequestBody {
        
        public GetClientRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClientResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.GetClientResponseBody Body;
        
        public GetClientResponse() {
        }
        
        public GetClientResponse(WebServiceTest.ClientInfoWS.GetClientResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetClientResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceTest.ClientInfoWS.Clients[] GetClientResult;
        
        public GetClientResponseBody() {
        }
        
        public GetClientResponseBody(WebServiceTest.ClientInfoWS.Clients[] GetClientResult) {
            this.GetClientResult = GetClientResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddClient", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.AddClientRequestBody Body;
        
        public AddClientRequest() {
        }
        
        public AddClientRequest(WebServiceTest.ClientInfoWS.AddClientRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddClientRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string age;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string country;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string number;
        
        public AddClientRequestBody() {
        }
        
        public AddClientRequestBody(string name, string lastName, string age, string country, string number) {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.country = country;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddClientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddClientResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.ClientInfoWS.AddClientResponseBody Body;
        
        public AddClientResponse() {
        }
        
        public AddClientResponse(WebServiceTest.ClientInfoWS.AddClientResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddClientResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceTest.ClientInfoWS.Clients[] AddClientResult;
        
        public AddClientResponseBody() {
        }
        
        public AddClientResponseBody(WebServiceTest.ClientInfoWS.Clients[] AddClientResult) {
            this.AddClientResult = AddClientResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InfoWebServiceSoapChannel : WebServiceTest.ClientInfoWS.InfoWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfoWebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceTest.ClientInfoWS.InfoWebServiceSoap>, WebServiceTest.ClientInfoWS.InfoWebServiceSoap {
        
        public InfoWebServiceSoapClient() {
        }
        
        public InfoWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfoWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfoWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTest.ClientInfoWS.HelloWorldResponse WebServiceTest.ClientInfoWS.InfoWebServiceSoap.HelloWorld(WebServiceTest.ClientInfoWS.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServiceTest.ClientInfoWS.HelloWorldRequest inValue = new WebServiceTest.ClientInfoWS.HelloWorldRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.HelloWorldRequestBody();
            WebServiceTest.ClientInfoWS.HelloWorldResponse retVal = ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.HelloWorldResponse> WebServiceTest.ClientInfoWS.InfoWebServiceSoap.HelloWorldAsync(WebServiceTest.ClientInfoWS.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.HelloWorldResponse> HelloWorldAsync() {
            WebServiceTest.ClientInfoWS.HelloWorldRequest inValue = new WebServiceTest.ClientInfoWS.HelloWorldRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.HelloWorldRequestBody();
            return ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTest.ClientInfoWS.GetClientResponse WebServiceTest.ClientInfoWS.InfoWebServiceSoap.GetClient(WebServiceTest.ClientInfoWS.GetClientRequest request) {
            return base.Channel.GetClient(request);
        }
        
        public WebServiceTest.ClientInfoWS.Clients[] GetClient() {
            WebServiceTest.ClientInfoWS.GetClientRequest inValue = new WebServiceTest.ClientInfoWS.GetClientRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.GetClientRequestBody();
            WebServiceTest.ClientInfoWS.GetClientResponse retVal = ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).GetClient(inValue);
            return retVal.Body.GetClientResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.GetClientResponse> WebServiceTest.ClientInfoWS.InfoWebServiceSoap.GetClientAsync(WebServiceTest.ClientInfoWS.GetClientRequest request) {
            return base.Channel.GetClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.GetClientResponse> GetClientAsync() {
            WebServiceTest.ClientInfoWS.GetClientRequest inValue = new WebServiceTest.ClientInfoWS.GetClientRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.GetClientRequestBody();
            return ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).GetClientAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTest.ClientInfoWS.AddClientResponse WebServiceTest.ClientInfoWS.InfoWebServiceSoap.AddClient(WebServiceTest.ClientInfoWS.AddClientRequest request) {
            return base.Channel.AddClient(request);
        }
        
        public WebServiceTest.ClientInfoWS.Clients[] AddClient(string name, string lastName, string age, string country, string number) {
            WebServiceTest.ClientInfoWS.AddClientRequest inValue = new WebServiceTest.ClientInfoWS.AddClientRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.AddClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.age = age;
            inValue.Body.country = country;
            inValue.Body.number = number;
            WebServiceTest.ClientInfoWS.AddClientResponse retVal = ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).AddClient(inValue);
            return retVal.Body.AddClientResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.AddClientResponse> WebServiceTest.ClientInfoWS.InfoWebServiceSoap.AddClientAsync(WebServiceTest.ClientInfoWS.AddClientRequest request) {
            return base.Channel.AddClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceTest.ClientInfoWS.AddClientResponse> AddClientAsync(string name, string lastName, string age, string country, string number) {
            WebServiceTest.ClientInfoWS.AddClientRequest inValue = new WebServiceTest.ClientInfoWS.AddClientRequest();
            inValue.Body = new WebServiceTest.ClientInfoWS.AddClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.age = age;
            inValue.Body.country = country;
            inValue.Body.number = number;
            return ((WebServiceTest.ClientInfoWS.InfoWebServiceSoap)(this)).AddClientAsync(inValue);
        }
    }
}
