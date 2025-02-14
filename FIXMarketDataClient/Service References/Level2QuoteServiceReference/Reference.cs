﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIXMarketDataClient.Level2QuoteServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Level2QuoteServiceReference.IPubSub", CallbackContract=typeof(FIXMarketDataClient.Level2QuoteServiceReference.IPubSubCallback))]
    public interface IPubSub {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPubSub/Subscribe")]
        void Subscribe(string topic);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/IPubSub/Subscribe")]
        System.IAsyncResult BeginSubscribe(string topic, System.AsyncCallback callback, object asyncState);
        
        void EndSubscribe(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPubSub/Publish")]
        void Publish(string topic, MagmaTrader.Data.Level2Book content);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/IPubSub/Publish")]
        System.IAsyncResult BeginPublish(string topic, MagmaTrader.Data.Level2Book content, System.AsyncCallback callback, object asyncState);
        
        void EndPublish(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPubSubCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://microsoft.com/samples/pollingDuplex/notification")]
        void Notify(System.ServiceModel.Channels.Message request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://microsoft.com/samples/pollingDuplex/notification")]
        System.IAsyncResult BeginNotify(System.ServiceModel.Channels.Message request, System.AsyncCallback callback, object asyncState);
        
        void EndNotify(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPubSubChannel : FIXMarketDataClient.Level2QuoteServiceReference.IPubSub, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PubSubClient : System.ServiceModel.DuplexClientBase<FIXMarketDataClient.Level2QuoteServiceReference.IPubSub>, FIXMarketDataClient.Level2QuoteServiceReference.IPubSub {
        
        private BeginOperationDelegate onBeginSubscribeDelegate;
        
        private EndOperationDelegate onEndSubscribeDelegate;
        
        private System.Threading.SendOrPostCallback onSubscribeCompletedDelegate;
        
        private BeginOperationDelegate onBeginPublishDelegate;
        
        private EndOperationDelegate onEndPublishDelegate;
        
        private System.Threading.SendOrPostCallback onPublishCompletedDelegate;
        
        public PubSubClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PubSubClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PubSubClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PubSubClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PubSubClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SubscribeCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> PublishCompleted;
        
        public void Subscribe(string topic) {
            base.Channel.Subscribe(topic);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSubscribe(string topic, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSubscribe(topic, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSubscribe(System.IAsyncResult result) {
            base.Channel.EndSubscribe(result);
        }
        
        private System.IAsyncResult OnBeginSubscribe(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string topic = ((string)(inValues[0]));
            return this.BeginSubscribe(topic, callback, asyncState);
        }
        
        private object[] OnEndSubscribe(System.IAsyncResult result) {
            this.EndSubscribe(result);
            return null;
        }
        
        private void OnSubscribeCompleted(object state) {
            if ((this.SubscribeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SubscribeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SubscribeAsync(string topic) {
            this.SubscribeAsync(topic, null);
        }
        
        public void SubscribeAsync(string topic, object userState) {
            if ((this.onBeginSubscribeDelegate == null)) {
                this.onBeginSubscribeDelegate = new BeginOperationDelegate(this.OnBeginSubscribe);
            }
            if ((this.onEndSubscribeDelegate == null)) {
                this.onEndSubscribeDelegate = new EndOperationDelegate(this.OnEndSubscribe);
            }
            if ((this.onSubscribeCompletedDelegate == null)) {
                this.onSubscribeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSubscribeCompleted);
            }
            base.InvokeAsync(this.onBeginSubscribeDelegate, new object[] {
                        topic}, this.onEndSubscribeDelegate, this.onSubscribeCompletedDelegate, userState);
        }
        
        public void Publish(string topic, MagmaTrader.Data.Level2Book content) {
            base.Channel.Publish(topic, content);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginPublish(string topic, MagmaTrader.Data.Level2Book content, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginPublish(topic, content, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndPublish(System.IAsyncResult result) {
            base.Channel.EndPublish(result);
        }
        
        private System.IAsyncResult OnBeginPublish(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string topic = ((string)(inValues[0]));
            MagmaTrader.Data.Level2Book content = ((MagmaTrader.Data.Level2Book)(inValues[1]));
            return this.BeginPublish(topic, content, callback, asyncState);
        }
        
        private object[] OnEndPublish(System.IAsyncResult result) {
            this.EndPublish(result);
            return null;
        }
        
        private void OnPublishCompleted(object state) {
            if ((this.PublishCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.PublishCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void PublishAsync(string topic, MagmaTrader.Data.Level2Book content) {
            this.PublishAsync(topic, content, null);
        }
        
        public void PublishAsync(string topic, MagmaTrader.Data.Level2Book content, object userState) {
            if ((this.onBeginPublishDelegate == null)) {
                this.onBeginPublishDelegate = new BeginOperationDelegate(this.OnBeginPublish);
            }
            if ((this.onEndPublishDelegate == null)) {
                this.onEndPublishDelegate = new EndOperationDelegate(this.OnEndPublish);
            }
            if ((this.onPublishCompletedDelegate == null)) {
                this.onPublishCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnPublishCompleted);
            }
            base.InvokeAsync(this.onBeginPublishDelegate, new object[] {
                        topic,
                        content}, this.onEndPublishDelegate, this.onPublishCompletedDelegate, userState);
        }
    }
}
