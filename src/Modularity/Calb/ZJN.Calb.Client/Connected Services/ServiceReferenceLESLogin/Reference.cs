﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceLESLogin
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.token_webservice.webservive.hand.com/", ConfigurationName="ServiceReferenceLESLogin.tokenInfoGet")]
    public interface tokenInfoGet
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReferenceLESLogin.tokenInfoResponse> tokenInfoAsync(ServiceReferenceLESLogin.tokenInfo request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.token_webservice.webservive.hand.com/")]
    public partial class tokenRequestDTO
    {
        
        private string clientIdField;
        
        private string clientSecretField;
        
        private string grantTypeField;
        
        private string passwordField;
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string clientSecret
        {
            get
            {
                return this.clientSecretField;
            }
            set
            {
                this.clientSecretField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string grantType
        {
            get
            {
                return this.grantTypeField;
            }
            set
            {
                this.grantTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.token_webservice.webservive.hand.com/")]
    public partial class tokenResponseDTO
    {
        
        private string accessTokenField;
        
        private string expiresInField;
        
        private string keyField;
        
        private string msgField;
        
        private string refreshTokenField;
        
        private string scopeField;
        
        private string statusField;
        
        private string tokenTypeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string accessToken
        {
            get
            {
                return this.accessTokenField;
            }
            set
            {
                this.accessTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string expiresIn
        {
            get
            {
                return this.expiresInField;
            }
            set
            {
                this.expiresInField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string refreshToken
        {
            get
            {
                return this.refreshTokenField;
            }
            set
            {
                this.refreshTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string tokenType
        {
            get
            {
                return this.tokenTypeField;
            }
            set
            {
                this.tokenTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tokenInfo", WrapperNamespace="http://service.token_webservice.webservive.hand.com/", IsWrapped=true)]
    public partial class tokenInfo
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.token_webservice.webservive.hand.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceLESLogin.tokenRequestDTO requestData;
        
        public tokenInfo()
        {
        }
        
        public tokenInfo(ServiceReferenceLESLogin.tokenRequestDTO requestData)
        {
            this.requestData = requestData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tokenInfoResponse", WrapperNamespace="http://service.token_webservice.webservive.hand.com/", IsWrapped=true)]
    public partial class tokenInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.token_webservice.webservive.hand.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReferenceLESLogin.tokenResponseDTO @return;
        
        public tokenInfoResponse()
        {
        }
        
        public tokenInfoResponse(ServiceReferenceLESLogin.tokenResponseDTO @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface tokenInfoGetChannel : ServiceReferenceLESLogin.tokenInfoGet, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class tokenInfoGetClient : System.ServiceModel.ClientBase<ServiceReferenceLESLogin.tokenInfoGet>, ServiceReferenceLESLogin.tokenInfoGet
    {
        
        /// <summary>
        /// 实现此分部方法，配置服务终结点。
        /// </summary>
        /// <param name="serviceEndpoint">要配置的终结点</param>
        /// <param name="clientCredentials">客户端凭据</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public tokenInfoGetClient() : 
                base(tokenInfoGetClient.GetDefaultBinding(), tokenInfoGetClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WmsTokenInfoGetServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public tokenInfoGetClient(EndpointConfiguration endpointConfiguration) : 
                base(tokenInfoGetClient.GetBindingForEndpoint(endpointConfiguration), tokenInfoGetClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public tokenInfoGetClient( string remoteAddress) :
          base(tokenInfoGetClient.GetDefaultBinding(), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = EndpointConfiguration.WmsTokenInfoGetServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }


        public tokenInfoGetClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(tokenInfoGetClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public tokenInfoGetClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(tokenInfoGetClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public tokenInfoGetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceLESLogin.tokenInfoResponse> ServiceReferenceLESLogin.tokenInfoGet.tokenInfoAsync(ServiceReferenceLESLogin.tokenInfo request)
        {
            return base.Channel.tokenInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceLESLogin.tokenInfoResponse> tokenInfoAsync(ServiceReferenceLESLogin.tokenRequestDTO requestData)
        {
            ServiceReferenceLESLogin.tokenInfo inValue = new ServiceReferenceLESLogin.tokenInfo();
            inValue.requestData = requestData;
            return ((ServiceReferenceLESLogin.tokenInfoGet)(this)).tokenInfoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WmsTokenInfoGetServiceImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WmsTokenInfoGetServiceImplPort))
            {
                return new System.ServiceModel.EndpointAddress("http://10.79.5.14:30070/calb/tokenInfoGet");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return tokenInfoGetClient.GetBindingForEndpoint(EndpointConfiguration.WmsTokenInfoGetServiceImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return tokenInfoGetClient.GetEndpointAddress(EndpointConfiguration.WmsTokenInfoGetServiceImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            WmsTokenInfoGetServiceImplPort,
        }
    }
}
