﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWeather.MoviesRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviesRef.MovieSoap")]
    public interface MovieSoap {
        
        // CODEGEN: Generating message contract since element name textbox from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MoviesMethod", ReplyAction="*")]
        MyWeather.MoviesRef.MoviesMethodResponse MoviesMethod(MyWeather.MoviesRef.MoviesMethodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MoviesMethod", ReplyAction="*")]
        System.Threading.Tasks.Task<MyWeather.MoviesRef.MoviesMethodResponse> MoviesMethodAsync(MyWeather.MoviesRef.MoviesMethodRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoviesMethodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoviesMethod", Namespace="http://tempuri.org/", Order=0)]
        public MyWeather.MoviesRef.MoviesMethodRequestBody Body;
        
        public MoviesMethodRequest() {
        }
        
        public MoviesMethodRequest(MyWeather.MoviesRef.MoviesMethodRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MoviesMethodRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string textbox;
        
        public MoviesMethodRequestBody() {
        }
        
        public MoviesMethodRequestBody(string textbox) {
            this.textbox = textbox;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoviesMethodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoviesMethodResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyWeather.MoviesRef.MoviesMethodResponseBody Body;
        
        public MoviesMethodResponse() {
        }
        
        public MoviesMethodResponse(MyWeather.MoviesRef.MoviesMethodResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MoviesMethodResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MoviesMethodResult;
        
        public MoviesMethodResponseBody() {
        }
        
        public MoviesMethodResponseBody(string MoviesMethodResult) {
            this.MoviesMethodResult = MoviesMethodResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MovieSoapChannel : MyWeather.MoviesRef.MovieSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieSoapClient : System.ServiceModel.ClientBase<MyWeather.MoviesRef.MovieSoap>, MyWeather.MoviesRef.MovieSoap {
        
        public MovieSoapClient() {
        }
        
        public MovieSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyWeather.MoviesRef.MoviesMethodResponse MyWeather.MoviesRef.MovieSoap.MoviesMethod(MyWeather.MoviesRef.MoviesMethodRequest request) {
            return base.Channel.MoviesMethod(request);
        }
        
        public string MoviesMethod(string textbox) {
            MyWeather.MoviesRef.MoviesMethodRequest inValue = new MyWeather.MoviesRef.MoviesMethodRequest();
            inValue.Body = new MyWeather.MoviesRef.MoviesMethodRequestBody();
            inValue.Body.textbox = textbox;
            MyWeather.MoviesRef.MoviesMethodResponse retVal = ((MyWeather.MoviesRef.MovieSoap)(this)).MoviesMethod(inValue);
            return retVal.Body.MoviesMethodResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyWeather.MoviesRef.MoviesMethodResponse> MyWeather.MoviesRef.MovieSoap.MoviesMethodAsync(MyWeather.MoviesRef.MoviesMethodRequest request) {
            return base.Channel.MoviesMethodAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyWeather.MoviesRef.MoviesMethodResponse> MoviesMethodAsync(string textbox) {
            MyWeather.MoviesRef.MoviesMethodRequest inValue = new MyWeather.MoviesRef.MoviesMethodRequest();
            inValue.Body = new MyWeather.MoviesRef.MoviesMethodRequestBody();
            inValue.Body.textbox = textbox;
            return ((MyWeather.MoviesRef.MovieSoap)(this)).MoviesMethodAsync(inValue);
        }
    }
}
