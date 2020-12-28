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
        void register(string name, string gender, int age, string gmail, float weight, float blood_pressure, string username, string password, float height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/register", ReplyAction="*")]
        System.Threading.Tasks.Task registerAsync(string name, string gender, int age, string gmail, float weight, float blood_pressure, string username, string password, float height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        userClient.CRUDservice.loginResponse login(userClient.CRUDservice.loginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/login", ReplyAction="*")]
        System.Threading.Tasks.Task<userClient.CRUDservice.loginResponse> loginAsync(userClient.CRUDservice.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update_info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool update_info(int id, string name, int age, float weight, string username, string password, float height, string gmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update_info", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> update_infoAsync(int id, string name, int age, float weight, string username, string password, float height, string gmail);
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getLatestBP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        double getLatestBP(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getLatestBP", ReplyAction="*")]
        System.Threading.Tasks.Task<double> getLatestBPAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDietPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        userClient.CRUDservice.getDietPlanResponse getDietPlan(userClient.CRUDservice.getDietPlanRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDietPlan", ReplyAction="*")]
        System.Threading.Tasks.Task<userClient.CRUDservice.getDietPlanResponse> getDietPlanAsync(userClient.CRUDservice.getDietPlanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getGmail(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGmail", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getGmailAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sendDietPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool sendDietPlan(string userGmail, string mailBody);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sendDietPlan", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> sendDietPlanAsync(string userGmail, string mailBody);
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public double height;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=9)]
        public string gmail;
        
        public view_infoRequest() {
        }
        
        public view_infoRequest(int id, string name, string gender, int age, double weight, double blood_pressure, string username, string password, double height, string gmail) {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.blood_pressure = blood_pressure;
            this.username = username;
            this.password = password;
            this.height = height;
            this.gmail = gmail;
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public double height;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public string gmail;
        
        public view_infoResponse() {
        }
        
        public view_infoResponse(string name, string gender, int age, double weight, double blood_pressure, string username, string password, double height, string gmail) {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.blood_pressure = blood_pressure;
            this.username = username;
            this.password = password;
            this.height = height;
            this.gmail = gmail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDietPlan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getDietPlanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string range;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string breakfast;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string lunch;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string dinner;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string notes;
        
        public getDietPlanRequest() {
        }
        
        public getDietPlanRequest(string range, string breakfast, string lunch, string dinner, string notes) {
            this.range = range;
            this.breakfast = breakfast;
            this.lunch = lunch;
            this.dinner = dinner;
            this.notes = notes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDietPlanResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getDietPlanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string breakfast;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string lunch;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string dinner;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string notes;
        
        public getDietPlanResponse() {
        }
        
        public getDietPlanResponse(string breakfast, string lunch, string dinner, string notes) {
            this.breakfast = breakfast;
            this.lunch = lunch;
            this.dinner = dinner;
            this.notes = notes;
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
        
        public void register(string name, string gender, int age, string gmail, float weight, float blood_pressure, string username, string password, float height) {
            base.Channel.register(name, gender, age, gmail, weight, blood_pressure, username, password, height);
        }
        
        public System.Threading.Tasks.Task registerAsync(string name, string gender, int age, string gmail, float weight, float blood_pressure, string username, string password, float height) {
            return base.Channel.registerAsync(name, gender, age, gmail, weight, blood_pressure, username, password, height);
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
        
        public bool update_info(int id, string name, int age, float weight, string username, string password, float height, string gmail) {
            return base.Channel.update_info(id, name, age, weight, username, password, height, gmail);
        }
        
        public System.Threading.Tasks.Task<bool> update_infoAsync(int id, string name, int age, float weight, string username, string password, float height, string gmail) {
            return base.Channel.update_infoAsync(id, name, age, weight, username, password, height, gmail);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        userClient.CRUDservice.view_infoResponse userClient.CRUDservice.WebService1Soap.view_info(userClient.CRUDservice.view_infoRequest request) {
            return base.Channel.view_info(request);
        }
        
        public void view_info(int id, ref string name, ref string gender, ref int age, ref double weight, ref double blood_pressure, ref string username, ref string password, ref double height, ref string gmail) {
            userClient.CRUDservice.view_infoRequest inValue = new userClient.CRUDservice.view_infoRequest();
            inValue.id = id;
            inValue.name = name;
            inValue.gender = gender;
            inValue.age = age;
            inValue.weight = weight;
            inValue.blood_pressure = blood_pressure;
            inValue.username = username;
            inValue.password = password;
            inValue.height = height;
            inValue.gmail = gmail;
            userClient.CRUDservice.view_infoResponse retVal = ((userClient.CRUDservice.WebService1Soap)(this)).view_info(inValue);
            name = retVal.name;
            gender = retVal.gender;
            age = retVal.age;
            weight = retVal.weight;
            blood_pressure = retVal.blood_pressure;
            username = retVal.username;
            password = retVal.password;
            height = retVal.height;
            gmail = retVal.gmail;
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
        
        public double getLatestBP(int id) {
            return base.Channel.getLatestBP(id);
        }
        
        public System.Threading.Tasks.Task<double> getLatestBPAsync(int id) {
            return base.Channel.getLatestBPAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        userClient.CRUDservice.getDietPlanResponse userClient.CRUDservice.WebService1Soap.getDietPlan(userClient.CRUDservice.getDietPlanRequest request) {
            return base.Channel.getDietPlan(request);
        }
        
        public void getDietPlan(string range, ref string breakfast, ref string lunch, ref string dinner, ref string notes) {
            userClient.CRUDservice.getDietPlanRequest inValue = new userClient.CRUDservice.getDietPlanRequest();
            inValue.range = range;
            inValue.breakfast = breakfast;
            inValue.lunch = lunch;
            inValue.dinner = dinner;
            inValue.notes = notes;
            userClient.CRUDservice.getDietPlanResponse retVal = ((userClient.CRUDservice.WebService1Soap)(this)).getDietPlan(inValue);
            breakfast = retVal.breakfast;
            lunch = retVal.lunch;
            dinner = retVal.dinner;
            notes = retVal.notes;
        }
        
        public System.Threading.Tasks.Task<userClient.CRUDservice.getDietPlanResponse> getDietPlanAsync(userClient.CRUDservice.getDietPlanRequest request) {
            return base.Channel.getDietPlanAsync(request);
        }
        
        public string getGmail(int id) {
            return base.Channel.getGmail(id);
        }
        
        public System.Threading.Tasks.Task<string> getGmailAsync(int id) {
            return base.Channel.getGmailAsync(id);
        }
        
        public bool sendDietPlan(string userGmail, string mailBody) {
            return base.Channel.sendDietPlan(userGmail, mailBody);
        }
        
        public System.Threading.Tasks.Task<bool> sendDietPlanAsync(string userGmail, string mailBody) {
            return base.Channel.sendDietPlanAsync(userGmail, mailBody);
        }
    }
}
