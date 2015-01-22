﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDiskInfoClient_ChannelFactory.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyDiskInfo")]
    public interface IMyDiskInfo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/FreeSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/FreeSpaceResponse")]
        string FreeSpace(string DiskName);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyDiskInfo/FreeSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/FreeSpaceResponse")]
        System.IAsyncResult BeginFreeSpace(string DiskName, System.AsyncCallback callback, object asyncState);
        
        string EndFreeSpace(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyDiskInfo/TotalSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/TotalSpaceResponse")]
        string TotalSpace(string DiskName);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyDiskInfo/TotalSpace", ReplyAction="http://tempuri.org/IMyDiskInfo/TotalSpaceResponse")]
        System.IAsyncResult BeginTotalSpace(string DiskName, System.AsyncCallback callback, object asyncState);
        
        string EndTotalSpace(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyDiskInfoChannel : MyDiskInfoClient_ChannelFactory.ServiceReference1.IMyDiskInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FreeSpaceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FreeSpaceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TotalSpaceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TotalSpaceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyDiskInfoClient : System.ServiceModel.ClientBase<MyDiskInfoClient_ChannelFactory.ServiceReference1.IMyDiskInfo>, MyDiskInfoClient_ChannelFactory.ServiceReference1.IMyDiskInfo {
        
        private BeginOperationDelegate onBeginFreeSpaceDelegate;
        
        private EndOperationDelegate onEndFreeSpaceDelegate;
        
        private System.Threading.SendOrPostCallback onFreeSpaceCompletedDelegate;
        
        private BeginOperationDelegate onBeginTotalSpaceDelegate;
        
        private EndOperationDelegate onEndTotalSpaceDelegate;
        
        private System.Threading.SendOrPostCallback onTotalSpaceCompletedDelegate;
        
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
        
        public event System.EventHandler<FreeSpaceCompletedEventArgs> FreeSpaceCompleted;
        
        public event System.EventHandler<TotalSpaceCompletedEventArgs> TotalSpaceCompleted;
        
        public string FreeSpace(string DiskName) {
            return base.Channel.FreeSpace(DiskName);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginFreeSpace(string DiskName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFreeSpace(DiskName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndFreeSpace(System.IAsyncResult result) {
            return base.Channel.EndFreeSpace(result);
        }
        
        private System.IAsyncResult OnBeginFreeSpace(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string DiskName = ((string)(inValues[0]));
            return this.BeginFreeSpace(DiskName, callback, asyncState);
        }
        
        private object[] OnEndFreeSpace(System.IAsyncResult result) {
            string retVal = this.EndFreeSpace(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFreeSpaceCompleted(object state) {
            if ((this.FreeSpaceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FreeSpaceCompleted(this, new FreeSpaceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FreeSpaceAsync(string DiskName) {
            this.FreeSpaceAsync(DiskName, null);
        }
        
        public void FreeSpaceAsync(string DiskName, object userState) {
            if ((this.onBeginFreeSpaceDelegate == null)) {
                this.onBeginFreeSpaceDelegate = new BeginOperationDelegate(this.OnBeginFreeSpace);
            }
            if ((this.onEndFreeSpaceDelegate == null)) {
                this.onEndFreeSpaceDelegate = new EndOperationDelegate(this.OnEndFreeSpace);
            }
            if ((this.onFreeSpaceCompletedDelegate == null)) {
                this.onFreeSpaceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFreeSpaceCompleted);
            }
            base.InvokeAsync(this.onBeginFreeSpaceDelegate, new object[] {
                        DiskName}, this.onEndFreeSpaceDelegate, this.onFreeSpaceCompletedDelegate, userState);
        }
        
        public string TotalSpace(string DiskName) {
            return base.Channel.TotalSpace(DiskName);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginTotalSpace(string DiskName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTotalSpace(DiskName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndTotalSpace(System.IAsyncResult result) {
            return base.Channel.EndTotalSpace(result);
        }
        
        private System.IAsyncResult OnBeginTotalSpace(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string DiskName = ((string)(inValues[0]));
            return this.BeginTotalSpace(DiskName, callback, asyncState);
        }
        
        private object[] OnEndTotalSpace(System.IAsyncResult result) {
            string retVal = this.EndTotalSpace(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTotalSpaceCompleted(object state) {
            if ((this.TotalSpaceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TotalSpaceCompleted(this, new TotalSpaceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TotalSpaceAsync(string DiskName) {
            this.TotalSpaceAsync(DiskName, null);
        }
        
        public void TotalSpaceAsync(string DiskName, object userState) {
            if ((this.onBeginTotalSpaceDelegate == null)) {
                this.onBeginTotalSpaceDelegate = new BeginOperationDelegate(this.OnBeginTotalSpace);
            }
            if ((this.onEndTotalSpaceDelegate == null)) {
                this.onEndTotalSpaceDelegate = new EndOperationDelegate(this.OnEndTotalSpace);
            }
            if ((this.onTotalSpaceCompletedDelegate == null)) {
                this.onTotalSpaceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTotalSpaceCompleted);
            }
            base.InvokeAsync(this.onBeginTotalSpaceDelegate, new object[] {
                        DiskName}, this.onEndTotalSpaceDelegate, this.onTotalSpaceCompletedDelegate, userState);
        }
    }
}
