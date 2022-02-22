﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Make15.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMake15Service", CallbackContract=typeof(Project_Make15.ServiceReference1.IMake15ServiceCallback))]
    public interface IMake15Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/MakePlayer", ReplyAction="http://tempuri.org/IMake15Service/MakePlayerResponse")]
        string MakePlayer(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/MakePlayer", ReplyAction="http://tempuri.org/IMake15Service/MakePlayerResponse")]
        System.Threading.Tasks.Task<string> MakePlayerAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/MarkAsTaken", ReplyAction="http://tempuri.org/IMake15Service/MarkAsTakenResponse")]
        void MarkAsTaken(byte number, string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/MarkAsTaken", ReplyAction="http://tempuri.org/IMake15Service/MarkAsTakenResponse")]
        System.Threading.Tasks.Task MarkAsTakenAsync(byte number, string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetUntaken", ReplyAction="http://tempuri.org/IMake15Service/GetUntakenResponse")]
        System.Collections.ObjectModel.ObservableCollection<byte> GetUntaken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetUntaken", ReplyAction="http://tempuri.org/IMake15Service/GetUntakenResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetUntakenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetTakenBy", ReplyAction="http://tempuri.org/IMake15Service/GetTakenByResponse")]
        System.Collections.ObjectModel.ObservableCollection<byte> GetTakenBy(string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetTakenBy", ReplyAction="http://tempuri.org/IMake15Service/GetTakenByResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetTakenByAsync(string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetTakenByOpponent", ReplyAction="http://tempuri.org/IMake15Service/GetTakenByOpponentResponse")]
        System.Collections.ObjectModel.ObservableCollection<byte> GetTakenByOpponent(string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/GetTakenByOpponent", ReplyAction="http://tempuri.org/IMake15Service/GetTakenByOpponentResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetTakenByOpponentAsync(string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/SendMsgToOpponent", ReplyAction="http://tempuri.org/IMake15Service/SendMsgToOpponentResponse")]
        void SendMsgToOpponent(string playerID, string yourName, string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/SendMsgToOpponent", ReplyAction="http://tempuri.org/IMake15Service/SendMsgToOpponentResponse")]
        System.Threading.Tasks.Task SendMsgToOpponentAsync(string playerID, string yourName, string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/RemovePlayer", ReplyAction="http://tempuri.org/IMake15Service/RemovePlayerResponse")]
        void RemovePlayer(string playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/RemovePlayer", ReplyAction="http://tempuri.org/IMake15Service/RemovePlayerResponse")]
        System.Threading.Tasks.Task RemovePlayerAsync(string playerID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMake15ServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/ReceiveMsg", ReplyAction="http://tempuri.org/IMake15Service/ReceiveMsgResponse")]
        void ReceiveMsg(string user, string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/RefreshStat", ReplyAction="http://tempuri.org/IMake15Service/RefreshStatResponse")]
        void RefreshStat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/IsActive", ReplyAction="http://tempuri.org/IMake15Service/IsActiveResponse")]
        void IsActive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/IsHisTurn", ReplyAction="http://tempuri.org/IMake15Service/IsHisTurnResponse")]
        void IsHisTurn(bool isMyTurn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMake15Service/SetNamesWindow", ReplyAction="http://tempuri.org/IMake15Service/SetNamesWindowResponse")]
        void SetNamesWindow(string otherPlayerName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMake15ServiceChannel : Project_Make15.ServiceReference1.IMake15Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Make15ServiceClient : System.ServiceModel.DuplexClientBase<Project_Make15.ServiceReference1.IMake15Service>, Project_Make15.ServiceReference1.IMake15Service {
        
        public Make15ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Make15ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Make15ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Make15ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Make15ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string MakePlayer(string name) {
            return base.Channel.MakePlayer(name);
        }
        
        public System.Threading.Tasks.Task<string> MakePlayerAsync(string name) {
            return base.Channel.MakePlayerAsync(name);
        }
        
        public void MarkAsTaken(byte number, string playerID) {
            base.Channel.MarkAsTaken(number, playerID);
        }
        
        public System.Threading.Tasks.Task MarkAsTakenAsync(byte number, string playerID) {
            return base.Channel.MarkAsTakenAsync(number, playerID);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<byte> GetUntaken() {
            return base.Channel.GetUntaken();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetUntakenAsync() {
            return base.Channel.GetUntakenAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<byte> GetTakenBy(string playerID) {
            return base.Channel.GetTakenBy(playerID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetTakenByAsync(string playerID) {
            return base.Channel.GetTakenByAsync(playerID);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<byte> GetTakenByOpponent(string playerID) {
            return base.Channel.GetTakenByOpponent(playerID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<byte>> GetTakenByOpponentAsync(string playerID) {
            return base.Channel.GetTakenByOpponentAsync(playerID);
        }
        
        public void SendMsgToOpponent(string playerID, string yourName, string msg) {
            base.Channel.SendMsgToOpponent(playerID, yourName, msg);
        }
        
        public System.Threading.Tasks.Task SendMsgToOpponentAsync(string playerID, string yourName, string msg) {
            return base.Channel.SendMsgToOpponentAsync(playerID, yourName, msg);
        }
        
        public void RemovePlayer(string playerID) {
            base.Channel.RemovePlayer(playerID);
        }
        
        public System.Threading.Tasks.Task RemovePlayerAsync(string playerID) {
            return base.Channel.RemovePlayerAsync(playerID);
        }
    }
}