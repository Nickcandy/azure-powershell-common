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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// assignedPlan
    /// </summary>
    public partial class MicrosoftgraphassignedPlan
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphassignedPlan class.
        /// </summary>
        public MicrosoftgraphassignedPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphassignedPlan class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="assignedDateTime">The date and time at which the plan
        /// was assigned. The Timestamp type represents date and time
        /// information using ISO 8601 format and is always in UTC time. For
        /// example, midnight UTC on Jan 1, 2014 is
        /// 2014-01-01T00:00:00Z.</param>
        /// <param name="capabilityStatus">Condition of the capability
        /// assignment. The possible values are Enabled, Warning, Suspended,
        /// Deleted, LockedOut. See a detailed description of each
        /// value.</param>
        /// <param name="service">The name of the service; for example,
        /// exchange.</param>
        /// <param name="servicePlanId">A GUID that identifies the service
        /// plan. For a complete list of GUIDs and their equivalent friendly
        /// service names, see Product names and service plan identifiers for
        /// licensing.</param>
        public MicrosoftgraphassignedPlan(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), System.DateTime? assignedDateTime = default(System.DateTime?), string capabilityStatus = default(string), string service = default(string), System.Guid? servicePlanId = default(System.Guid?))
        {
            AdditionalProperties = additionalProperties;
            AssignedDateTime = assignedDateTime;
            CapabilityStatus = capabilityStatus;
            Service = service;
            ServicePlanId = servicePlanId;
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
        /// Gets or sets the date and time at which the plan was assigned. The
        /// Timestamp type represents date and time information using ISO 8601
        /// format and is always in UTC time. For example, midnight UTC on Jan
        /// 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "assignedDateTime")]
        public System.DateTime? AssignedDateTime { get; set; }

        /// <summary>
        /// Gets or sets condition of the capability assignment. The possible
        /// values are Enabled, Warning, Suspended, Deleted, LockedOut. See a
        /// detailed description of each value.
        /// </summary>
        [JsonProperty(PropertyName = "capabilityStatus")]
        public string CapabilityStatus { get; set; }

        /// <summary>
        /// Gets or sets the name of the service; for example, exchange.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets a GUID that identifies the service plan. For a
        /// complete list of GUIDs and their equivalent friendly service names,
        /// see Product names and service plan identifiers for licensing.
        /// </summary>
        [JsonProperty(PropertyName = "servicePlanId")]
        public System.Guid? ServicePlanId { get; set; }
    }
}
