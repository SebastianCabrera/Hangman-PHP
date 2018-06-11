﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JuegoAhorcado.ECCI_Ahorcado {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_Ahorcado", ConfigurationName="ECCI_Ahorcado.ECCI_AhorcadoPort")]
    public interface ECCI_AhorcadoPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#iniciarJuego", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void iniciarJuego();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#iniciarJuego", ReplyAction="*")]
        System.Threading.Tasks.Task iniciarJuegoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#palabraEscondida", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string palabraEscondida();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#palabraEscondida", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> palabraEscondidaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#verificarLetra", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string verificarLetra(string nombre, string nombre2);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#verificarLetra", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> verificarLetraAsync(string nombre, string nombre2);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getIntentos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int getIntentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getIntentos", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> getIntentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#verificarResultadoDeJuego", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string verificarResultadoDeJuego(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#verificarResultadoDeJuego", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> verificarResultadoDeJuegoAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkEmpty", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkEmpty();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkEmpty", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> checkEmptyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkLetter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkLetter();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkLetter", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> checkLetterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkRepeated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkRepeated();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#checkRepeated", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> checkRepeatedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getPalabra", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getPalabra();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getPalabra", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getPalabraAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getletrasIngresadas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getletrasIngresadas();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Ahorcado#Ahorcado#getletrasIngresadas", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getletrasIngresadasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_AhorcadoPortChannel : JuegoAhorcado.ECCI_Ahorcado.ECCI_AhorcadoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_AhorcadoPortClient : System.ServiceModel.ClientBase<JuegoAhorcado.ECCI_Ahorcado.ECCI_AhorcadoPort>, JuegoAhorcado.ECCI_Ahorcado.ECCI_AhorcadoPort {
        
        public ECCI_AhorcadoPortClient() {
        }
        
        public ECCI_AhorcadoPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_AhorcadoPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_AhorcadoPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_AhorcadoPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void iniciarJuego() {
            base.Channel.iniciarJuego();
        }
        
        public System.Threading.Tasks.Task iniciarJuegoAsync() {
            return base.Channel.iniciarJuegoAsync();
        }
        
        public string palabraEscondida() {
            return base.Channel.palabraEscondida();
        }
        
        public System.Threading.Tasks.Task<string> palabraEscondidaAsync() {
            return base.Channel.palabraEscondidaAsync();
        }
        
        public string verificarLetra(string nombre, string nombre2) {
            return base.Channel.verificarLetra(nombre, nombre2);
        }
        
        public System.Threading.Tasks.Task<string> verificarLetraAsync(string nombre, string nombre2) {
            return base.Channel.verificarLetraAsync(nombre, nombre2);
        }
        
        public int getIntentos() {
            return base.Channel.getIntentos();
        }
        
        public System.Threading.Tasks.Task<int> getIntentosAsync() {
            return base.Channel.getIntentosAsync();
        }
        
        public string verificarResultadoDeJuego(string nombre) {
            return base.Channel.verificarResultadoDeJuego(nombre);
        }
        
        public System.Threading.Tasks.Task<string> verificarResultadoDeJuegoAsync(string nombre) {
            return base.Channel.verificarResultadoDeJuegoAsync(nombre);
        }
        
        public bool checkEmpty() {
            return base.Channel.checkEmpty();
        }
        
        public System.Threading.Tasks.Task<bool> checkEmptyAsync() {
            return base.Channel.checkEmptyAsync();
        }
        
        public bool checkLetter() {
            return base.Channel.checkLetter();
        }
        
        public System.Threading.Tasks.Task<bool> checkLetterAsync() {
            return base.Channel.checkLetterAsync();
        }
        
        public bool checkRepeated() {
            return base.Channel.checkRepeated();
        }
        
        public System.Threading.Tasks.Task<bool> checkRepeatedAsync() {
            return base.Channel.checkRepeatedAsync();
        }
        
        public string getPalabra() {
            return base.Channel.getPalabra();
        }
        
        public System.Threading.Tasks.Task<string> getPalabraAsync() {
            return base.Channel.getPalabraAsync();
        }
        
        public string getletrasIngresadas() {
            return base.Channel.getletrasIngresadas();
        }
        
        public System.Threading.Tasks.Task<string> getletrasIngresadasAsync() {
            return base.Channel.getletrasIngresadasAsync();
        }
    }
}
