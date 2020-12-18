﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace userClient.CRUDservice {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRUDservice.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/register", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void register(string name, string gender, int age, float weight, float blood_pressure, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/register", ReplyAction="*")]
        System.Threading.Tasks.Task registerAsync(string name, string gender, int age, float weight, float blood_pressure, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        userClient.CRUDservice.loginResponse login(userClient.CRUDservice.loginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/login", ReplyAction="*")]
        System.Threading.Tasks.Task<userClient.CRUDservice.loginResponse> loginAsync(userClient.CRUDservice.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update_info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void update_info(int id, string name, string gender, int age, float weight, float blood_pressure, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update_info", ReplyAction="*")]
        System.Threading.Tasks.Task update_infoAsync(int id, string name, string gender, int age, float weight, float blood_pressure, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/view_info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        userClient.CRUDservice.view_infoResponse view_info(userClient.CRUDservice.view_infoRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/view_info", ReplyAction="*")]
        System.Threading.Tasks.Task<userClient.CRUDservice.view_infoResponse> view_infoAsync(userClient.CRUDservice.view_infoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveReading", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void saveReading(int id, float blood_pressure);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveReading", ReplyAction="*")]
        System.Threading.Tasks.Task saveReadingAsync(int id, float blood_pressure);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bpReminder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.DateTime bpReminder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bpReminder", ReplyAction="*")]
        System.Threading.Tasks.Task<System.DateTime> bpReminderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/graphPlotting", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet graphPlotting(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/graphPlotting", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> graphPlottingAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string password;
        
        public loginRequest() {
        }
        
        public loginRequest(int id, string username, string password) {
            this.id = id;
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool loginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int id;
        
        public loginResponse() {
        }
        
        public loginResponse(bool loginResult, int id) {
            this.loginResult = loginResult;
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="view_info", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class view_infoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int age;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public double weight;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public double blood_pressure;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string password;
        
        public view_infoRequest() {
        }
        
        public view_infoRequest(int id, string name, string gender, int age, double weight, double blood_pressure, string username, string password) {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.blood_pressure = blood_pressure;
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="view_infoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class view_infoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int age;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public double weight;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public double blood_pressure;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string password;
        
        public view_infoResponse() {
        }
        
        public view_infoResponse(string name, string gender, int age, double weight, double blood_pressure, string username, string password) {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.blood_pressure = blood_pressure;
            this.username = username;
            this.password = password;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : userClient.CRUDservice.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<userClient.CRUDservice.WebService1Soap>, userClient.CRUDservice.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void register(string name, string gender, int age, float weight, float blood_pressure, string username, string password) {
            base.Channel.register(name, gender, age, weight, blood_pressure, username, password);
        }
        
        public System.Threading.Tasks.Task registerAsync(string name, string gender, int age, float weight, float blood_pressure, string username, string password) {
            return base.Channel.registerAsync(name, gender, age, weight, blood_pressure, username, password);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        userClient.CRUDservice.loginResponse userClient.CRUDservice.WebService1Soap.login(userClient.CRUDservice.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public bool login(ref int id, string username, string password) {
            userClient.CRUDservice.loginRequest inValue = new userClient.CRUDservice.loginRequest();
            inValue.id = id;
            inValue.username = username;
            inValue.password = password;
            userClient.CRUDservice.loginResponse retVal = ((userClient.CRUDservice.WebService1Soap)(this)).login(inValue);
            id = retVal.id;
            return retVal.loginResult;
        }
        
        public System.Threading.Tasks.Task<userClient.CRUDservice.loginResponse> loginAsync(userClient.CRUDservice.loginRequest request) {
            return base.Channel.loginAsync(request);
        }
        
        public void update_info(int id, string name, string gender, int age, float weight, float blood_pressure, string username, string password) {
            base.Channel.update_info(id, name, gender, age, weight, blood_pressure, username, password);
        }
        
        public System.Threading.Tasks.Task update_infoAsync(int id, string name, string gender, int age, float weight, float blood_pressure, string username, string password) {
            return base.Channel.update_infoAsync(id, name, gender, age, weight, blood_pressure, username, password);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        userClient.CRUDservice.view_infoResponse userClient.CRUDservice.WebService1Soap.view_info(userClient.CRUDservice.view_infoRequest request) {
            return base.Channel.view_info(request);
        }
        
        public void view_info(int id, ref string name, ref string gender, ref int age, ref double weight, ref double blood_pressure, ref string username, ref string password) {
            userClient.CRUDservice.view_infoRequest inValue = new userClient.CRUDservice.view_infoRequest();
            inValue.id = id;
            inValue.name = name;
            inValue.gender = gender;
            inValue.age = age;
            inValue.weight = weight;
            inValue.blood_pressure = blood_pressure;
            inValue.username = username;
            inValue.password = password;
            userClient.CRUDservice.view_infoResponse retVal = ((userClient.CRUDservice.WebService1Soap)(this)).view_info(inValue);
            name = retVal.name;
            gender = retVal.gender;
            age = retVal.age;
            weight = retVal.weight;
            blood_pressure = retVal.blood_pressure;
            username = retVal.username;
            password = retVal.password;
        }
        
        public System.Threading.Tasks.Task<userClient.CRUDservice.view_infoResponse> view_infoAsync(userClient.CRUDservice.view_infoRequest request) {
            return base.Channel.view_infoAsync(request);
        }
        
        public void saveReading(int id, float blood_pressure) {
            base.Channel.saveReading(id, blood_pressure);
        }
        
        public System.Threading.Tasks.Task saveReadingAsync(int id, float blood_pressure) {
            return base.Channel.saveReadingAsync(id, blood_pressure);
        }
        
        public System.DateTime bpReminder(int id) {
            return base.Channel.bpReminder(id);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> bpReminderAsync(int id) {
            return base.Channel.bpReminderAsync(id);
        }
        
        public System.Data.DataSet graphPlotting(int id) {
            return base.Channel.graphPlotting(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> graphPlottingAsync(int id) {
            return base.Channel.graphPlottingAsync(id);
        }
    }
}
