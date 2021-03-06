// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Http listener of application gateway
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayHttpListener : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        public ApplicationGatewayHttpListener() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        public ApplicationGatewayHttpListener(string id = default(string), SubResource frontendIPConfiguration = default(SubResource), SubResource frontendPort = default(SubResource), string protocol = default(string), string hostName = default(string), SubResource sslCertificate = default(SubResource), bool? requireServerNameIndication = default(bool?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Protocol = protocol;
            HostName = hostName;
            SslCertificate = sslCertificate;
            RequireServerNameIndication = requireServerNameIndication;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets frontend IP configuration resource of application
        /// gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public SubResource FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets the protocol. Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the host name of http listener
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets ssl certificate resource of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificate")]
        public SubResource SslCertificate { get; set; }

        /// <summary>
        /// Gets or sets the requireServerNameIndication of http listener
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireServerNameIndication")]
        public bool? RequireServerNameIndication { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the http listener resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
