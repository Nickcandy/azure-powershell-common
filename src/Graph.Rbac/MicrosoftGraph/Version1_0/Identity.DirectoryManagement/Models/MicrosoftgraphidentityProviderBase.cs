// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Identity.DirectoryManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphidentityProviderBase : Microsoftgraphentity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphidentityProviderBase class.
        /// </summary>
        public MicrosoftgraphidentityProviderBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphidentityProviderBase class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">The unique idenfier for an entity.
        /// Read-only.</param>
        /// <param name="displayName">The display name of the identity
        /// provider.</param>
        public MicrosoftgraphidentityProviderBase(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), string displayName = default(string))
            : base(additionalProperties, id)
        {
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the identity provider.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
