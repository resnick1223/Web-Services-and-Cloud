﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorConsumer.Console.ServiceCalculator {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculationOperation", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceCalculator.Web")]
    public enum CalculationOperation : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Add = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Substract = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Multiply = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Divide = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCalculator.IServiceCalculator")]
    public interface IServiceCalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculator/Calculate", ReplyAction="http://tempuri.org/IServiceCalculator/CalculateResponse")]
        int Calculate(int firstValue, int secondValue, CalculatorConsumer.Console.ServiceCalculator.CalculationOperation operationType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCalculatorChannel : CalculatorConsumer.Console.ServiceCalculator.IServiceCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCalculatorClient : System.ServiceModel.ClientBase<CalculatorConsumer.Console.ServiceCalculator.IServiceCalculator>, CalculatorConsumer.Console.ServiceCalculator.IServiceCalculator {
        
        public ServiceCalculatorClient() {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Calculate(int firstValue, int secondValue, CalculatorConsumer.Console.ServiceCalculator.CalculationOperation operationType) {
            return base.Channel.Calculate(firstValue, secondValue, operationType);
        }
    }
}
