﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Freebris_client.FreebrisServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="FreebrisServer", ConfigurationName="FreebrisServiceReference.FreebrisWebServiceSoap")]
    public interface FreebrisWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetAllUsersNames", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetAllUsersNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetAllUsersNames", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetAllUsersNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CheckPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CheckPassword(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CheckPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> CheckPasswordAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CreateUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CreateUser(string username, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CreateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> CreateUserAsync(string username, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetAllBooks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetAllBooks", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CreateBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CreateBook(string name, int dimension, string description, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/CreateBook", ReplyAction="*")]
        System.Threading.Tasks.Task CreateBookAsync(string name, int dimension, string description, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/ChangeEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ChangeEmail(string username, string newEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/ChangeEmail", ReplyAction="*")]
        System.Threading.Tasks.Task ChangeEmailAsync(string username, string newEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetEmail(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="FreebrisServer/GetEmail", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetEmailAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FreebrisWebServiceSoapChannel : Freebris_client.FreebrisServiceReference.FreebrisWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FreebrisWebServiceSoapClient : System.ServiceModel.ClientBase<Freebris_client.FreebrisServiceReference.FreebrisWebServiceSoap>, Freebris_client.FreebrisServiceReference.FreebrisWebServiceSoap {
        
        public FreebrisWebServiceSoapClient() {
        }
        
        public FreebrisWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FreebrisWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FreebrisWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FreebrisWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string GetAllUsersNames() {
            return base.Channel.GetAllUsersNames();
        }
        
        public System.Threading.Tasks.Task<string> GetAllUsersNamesAsync() {
            return base.Channel.GetAllUsersNamesAsync();
        }
        
        public bool CheckPassword(string username, string password) {
            return base.Channel.CheckPassword(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPasswordAsync(string username, string password) {
            return base.Channel.CheckPasswordAsync(username, password);
        }
        
        public bool CreateUser(string username, string password, string email) {
            return base.Channel.CreateUser(username, password, email);
        }
        
        public System.Threading.Tasks.Task<bool> CreateUserAsync(string username, string password, string email) {
            return base.Channel.CreateUserAsync(username, password, email);
        }
        
        public System.Data.DataTable GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
        
        public void CreateBook(string name, int dimension, string description, string username) {
            base.Channel.CreateBook(name, dimension, description, username);
        }
        
        public System.Threading.Tasks.Task CreateBookAsync(string name, int dimension, string description, string username) {
            return base.Channel.CreateBookAsync(name, dimension, description, username);
        }
        
        public void ChangeEmail(string username, string newEmail) {
            base.Channel.ChangeEmail(username, newEmail);
        }
        
        public System.Threading.Tasks.Task ChangeEmailAsync(string username, string newEmail) {
            return base.Channel.ChangeEmailAsync(username, newEmail);
        }
        
        public string GetEmail(string username) {
            return base.Channel.GetEmail(username);
        }
        
        public System.Threading.Tasks.Task<string> GetEmailAsync(string username) {
            return base.Channel.GetEmailAsync(username);
        }
    }
}
