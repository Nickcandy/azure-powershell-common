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

    /// <summary>
    /// Collection of extension
    /// </summary>
    public partial class MicrosoftgraphextensionCollectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphextensionCollectionResponse class.
        /// </summary>
        public MicrosoftgraphextensionCollectionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphextensionCollectionResponse class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public MicrosoftgraphextensionCollectionResponse(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string odatanextLink = default(string), IList<Microsoftgraphextension> value = default(IList<Microsoftgraphextension>))
        {
            AdditionalProperties = additionalProperties;
            OdatanextLink = odatanextLink;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.nextLink")]
        public string OdatanextLink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Microsoftgraphextension> Value { get; set; }

    }
}
