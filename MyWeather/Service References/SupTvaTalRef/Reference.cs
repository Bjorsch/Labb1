﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWeather.SupTvaTalRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SupTvaTalRef.SupTvaTalSoap")]
    public interface SupTvaTalSoap {
        
        // CODEGEN: Generating message contract since element name tal1 from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SupTvatalMetod", ReplyAction="*")]
        MyWeather.SupTvaTalRef.SupTvatalMetodResponse SupTvatalMetod(MyWeather.SupTvaTalRef.SupTvatalMetodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SupTvatalMetod", ReplyAction="*")]
        System.Threading.Tasks.Task<MyWeather.SupTvaTalRef.SupTvatalMetodResponse> SupTvatalMetodAsync(MyWeather.SupTvaTalRef.SupTvatalMetodRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SupTvatalMetodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SupTvatalMetod", Namespace="http://tempuri.org/", Order=0)]
        public MyWeather.SupTvaTalRef.SupTvatalMetodRequestBody Body;
        
        public SupTvatalMetodRequest() {
        }
        
        public SupTvatalMetodRequest(MyWeather.SupTvaTalRef.SupTvatalMetodRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SupTvatalMetodRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tal1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tal2;
        
        public SupTvatalMetodRequestBody() {
        }
        
        public SupTvatalMetodRequestBody(string tal1, string tal2) {
            this.tal1 = tal1;
            this.tal2 = tal2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SupTvatalMetodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SupTvatalMetodResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyWeather.SupTvaTalRef.SupTvatalMetodResponseBody Body;
        
        public SupTvatalMetodResponse() {
        }
        
        public SupTvatalMetodResponse(MyWeather.SupTvaTalRef.SupTvatalMetodResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SupTvatalMetodResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SupTvatalMetodResult;
        
        public SupTvatalMetodResponseBody() {
        }
        
        public SupTvatalMetodResponseBody(string SupTvatalMetodResult) {
            this.SupTvatalMetodResult = SupTvatalMetodResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SupTvaTalSoapChannel : MyWeather.SupTvaTalRef.SupTvaTalSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupTvaTalSoapClient : System.ServiceModel.ClientBase<MyWeather.SupTvaTalRef.SupTvaTalSoap>, MyWeather.SupTvaTalRef.SupTvaTalSoap {
        
        public SupTvaTalSoapClient() {
        }
        
        public SupTvaTalSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupTvaTalSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupTvaTalSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupTvaTalSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyWeather.SupTvaTalRef.SupTvatalMetodResponse MyWeather.SupTvaTalRef.SupTvaTalSoap.SupTvatalMetod(MyWeather.SupTvaTalRef.SupTvatalMetodRequest request) {
            return base.Channel.SupTvatalMetod(request);
        }
        
        public string SupTvatalMetod(string tal1, string tal2) {
            MyWeather.SupTvaTalRef.SupTvatalMetodRequest inValue = new MyWeather.SupTvaTalRef.SupTvatalMetodRequest();
            inValue.Body = new MyWeather.SupTvaTalRef.SupTvatalMetodRequestBody();
            inValue.Body.tal1 = tal1;
            inValue.Body.tal2 = tal2;
            MyWeather.SupTvaTalRef.SupTvatalMetodResponse retVal = ((MyWeather.SupTvaTalRef.SupTvaTalSoap)(this)).SupTvatalMetod(inValue);
            return retVal.Body.SupTvatalMetodResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyWeather.SupTvaTalRef.SupTvatalMetodResponse> MyWeather.SupTvaTalRef.SupTvaTalSoap.SupTvatalMetodAsync(MyWeather.SupTvaTalRef.SupTvatalMetodRequest request) {
            return base.Channel.SupTvatalMetodAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyWeather.SupTvaTalRef.SupTvatalMetodResponse> SupTvatalMetodAsync(string tal1, string tal2) {
            MyWeather.SupTvaTalRef.SupTvatalMetodRequest inValue = new MyWeather.SupTvaTalRef.SupTvatalMetodRequest();
            inValue.Body = new MyWeather.SupTvaTalRef.SupTvatalMetodRequestBody();
            inValue.Body.tal1 = tal1;
            inValue.Body.tal2 = tal2;
            return ((MyWeather.SupTvaTalRef.SupTvaTalSoap)(this)).SupTvatalMetodAsync(inValue);
        }
    }
}