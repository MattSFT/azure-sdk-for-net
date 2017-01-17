// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Resource.Fluent;

    /// <summary>
    /// Subnet in a virtual network resource.
    /// </summary>
    [JsonTransformation]
    public partial class SubnetInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SubnetInner class.
        /// </summary>
        public SubnetInner() { }

        /// <summary>
        /// Initializes a new instance of the SubnetInner class.
        /// </summary>
        /// <param name="addressPrefix">The address prefix for the
        /// subnet.</param>
        /// <param name="networkSecurityGroup">The reference of the
        /// NetworkSecurityGroup resource.</param>
        /// <param name="routeTable">The reference of the RouteTable
        /// resource.</param>
        /// <param name="ipConfigurations">Gets an array of references to the
        /// network interface IP configurations using subnet.</param>
        /// <param name="resourceNavigationLinks">Gets an array of references
        /// to the external resources using subnet.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public SubnetInner(string id = default(string), string addressPrefix = default(string), NetworkSecurityGroupInner networkSecurityGroup = default(NetworkSecurityGroupInner), RouteTableInner routeTable = default(RouteTableInner), IList<IPConfigurationInner> ipConfigurations = default(IList<IPConfigurationInner>), IList<ResourceNavigationLinkInner> resourceNavigationLinks = default(IList<ResourceNavigationLinkInner>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AddressPrefix = addressPrefix;
            if (networkSecurityGroup != null)
            {
                NetworkSecurityGroup = new SubResource
                {
                    Id = networkSecurityGroup.Id
                };
            }

            if (routeTable != null)
            {
                RouteTable = new SubResource
                {
                    Id = routeTable.Id
                };
            }

            IpConfigurations = ipConfigurations;
            ResourceNavigationLinks = resourceNavigationLinks;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the address prefix for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the reference of the NetworkSecurityGroup resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets the reference of the RouteTable resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routeTable")]
        public SubResource RouteTable { get; set; }

        /// <summary>
        /// Gets an array of references to the network interface IP
        /// configurations using subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<IPConfigurationInner> IpConfigurations { get; protected set; }

        /// <summary>
        /// Gets an array of references to the external resources using subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceNavigationLinks")]
        public IList<ResourceNavigationLinkInner> ResourceNavigationLinks { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
