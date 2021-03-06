// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> The service tag information. </summary>
    public partial class ServiceTagInformation
    {
        /// <summary> Initializes a new instance of ServiceTagInformation. </summary>
        internal ServiceTagInformation()
        {
        }

        /// <summary> Initializes a new instance of ServiceTagInformation. </summary>
        /// <param name="properties"> Properties of the service tag information. </param>
        /// <param name="name"> The name of service tag. </param>
        /// <param name="id"> The ID of service tag. </param>
        internal ServiceTagInformation(ServiceTagInformationPropertiesFormat properties, string name, string id)
        {
            Properties = properties;
            Name = name;
            Id = id;
        }

        /// <summary> Properties of the service tag information. </summary>
        public ServiceTagInformationPropertiesFormat Properties { get; }
        /// <summary> The name of service tag. </summary>
        public string Name { get; }
        /// <summary> The ID of service tag. </summary>
        public string Id { get; }
    }
}
