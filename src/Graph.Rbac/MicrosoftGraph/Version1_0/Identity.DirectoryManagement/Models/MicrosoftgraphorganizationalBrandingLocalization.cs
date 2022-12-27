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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphorganizationalBrandingLocalization : MicrosoftgraphorganizationalBrandingProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphorganizationalBrandingLocalization class.
        /// </summary>
        public MicrosoftgraphorganizationalBrandingLocalization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphorganizationalBrandingLocalization class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">The unique idenfier for an entity.
        /// Read-only.</param>
        /// <param name="backgroundColor">Color that will appear in place of
        /// the background image in low-bandwidth connections. We recommend
        /// that you use the primary color of your banner logo or your
        /// organization color. Specify this in hexadecimal format, for
        /// example, white is #FFFFFF.</param>
        /// <param name="backgroundImage">Image that appears as the background
        /// of the sign-in page. The allowed types are PNG or JPEG not smaller
        /// than 300 KB and not larger than 1920 ├ù 1080 pixels. A smaller
        /// image will reduce bandwidth requirements and make the page load
        /// faster.</param>
        /// <param name="backgroundImageRelativeUrl">A relative URL for the
        /// backgroundImage property that is combined with a CDN base URL from
        /// the cdnList to provide the version served by a CDN.
        /// Read-only.</param>
        /// <param name="bannerLogo">A banner version of your company logo that
        /// appears on the sign-in page. The allowed types are PNG or JPEG no
        /// larger than 36 ├ù 245 pixels. We recommend using a transparent
        /// image with no padding around the logo.</param>
        /// <param name="bannerLogoRelativeUrl">A relative url for the
        /// bannerLogo property that is combined with a CDN base URL from the
        /// cdnList to provide the read-only version served by a CDN.
        /// Read-only.</param>
        /// <param name="cdnList">A list of base URLs for all available CDN
        /// providers that are serving the assets of the current resource.
        /// Several CDN providers are used at the same time for high
        /// availability of read requests. Read-only.</param>
        /// <param name="signInPageText">Text that appears at the bottom of the
        /// sign-in box. You can use this to communicate additional
        /// information, such as the phone number to your help desk or a legal
        /// statement. This text must be Unicode and not exceed 1024
        /// characters.</param>
        /// <param name="squareLogo">A square version of your company logo that
        /// appears in Windows 10 out-of-box experiences (OOBE) and when
        /// Windows Autopilot is enabled for deployment. Allowed types are PNG
        /// or JPEG no larger than 240 x 240 pixels and no more than 10 KB in
        /// size. We recommend using a transparent image with no padding around
        /// the logo.</param>
        /// <param name="squareLogoRelativeUrl">A relative url for the
        /// squareLogo property that is combined with a CDN base URL from the
        /// cdnList to provide the version served by a CDN. Read-only.</param>
        /// <param name="usernameHintText">String that shows as the hint in the
        /// username textbox on the sign-in screen. This text must be a
        /// Unicode, without links or code, and can't exceed 64
        /// characters.</param>
        public MicrosoftgraphorganizationalBrandingLocalization(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), string backgroundColor = default(string), byte[] backgroundImage = default(byte[]), string backgroundImageRelativeUrl = default(string), byte[] bannerLogo = default(byte[]), string bannerLogoRelativeUrl = default(string), IList<string> cdnList = default(IList<string>), string signInPageText = default(string), byte[] squareLogo = default(byte[]), string squareLogoRelativeUrl = default(string), string usernameHintText = default(string))
            : base(additionalProperties, id, backgroundColor, backgroundImage, backgroundImageRelativeUrl, bannerLogo, bannerLogoRelativeUrl, cdnList, signInPageText, squareLogo, squareLogoRelativeUrl, usernameHintText)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
