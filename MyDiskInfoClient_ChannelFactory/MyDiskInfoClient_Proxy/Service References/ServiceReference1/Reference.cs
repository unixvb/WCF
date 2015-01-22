﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDiskInfoClient_Proxy.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyDiskInfo")]
    public interface IMyDiskInfo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/FreeSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/FreeSpaceResponse")]
        string FreeSpace(string DiskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/FreeSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/FreeSpaceResponse")]
        System.Threading.Tasks.Task<string> FreeSpaceAsync(string DiskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/TotalSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/TotalSpaceResponse")]
        string TotalSpace(string DiskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/TotalSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/TotalSpaceResponse")]
        System.Threading.Tasks.Task<string> TotalSpaceAsync(string DiskName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyDiskInfoChannel : MyDiskInfoClient_Proxy.ServiceReference1.IMyDiskInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyDiskInfoClient : System.ServiceModel.ClientBase<MyDiskInfoClient_Proxy.ServiceReference1.IMyDiskInfo>, MyDiskInfoClient_Proxy.ServiceReference1.IMyDiskInfo {
        
        public MyDiskInfoClient() {
        }
        
        public MyDiskInfoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyDiskInfoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyDiskInfoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyDiskInfoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string FreeSpace(string DiskName) {
            return base.Channel.FreeSpace(DiskName);
        }
        
        public System.Threading.Tasks.Task<string> FreeSpaceAsync(string DiskName) {
            return base.Channel.FreeSpaceAsync(DiskName);
        }
        
        public string TotalSpace(string DiskName) {
            return base.Channel.TotalSpace(DiskName);
        }
        
        public System.Threading.Tasks.Task<string> TotalSpaceAsync(string DiskName) {
            return base.Channel.TotalSpaceAsync(DiskName);
        }
    }
}