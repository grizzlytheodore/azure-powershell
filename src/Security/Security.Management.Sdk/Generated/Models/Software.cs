// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a software data
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Software : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Software class.
        /// </summary>
        public Software()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Software class.
        /// </summary>

        /// <param name="id">Resource Id
        /// </param>

        /// <param name="name">Resource name
        /// </param>

        /// <param name="type">Resource type
        /// </param>

        /// <param name="deviceId">Unique identifier for the virtual machine in the service.
        /// </param>

        /// <param name="osPlatform">Platform of the operating system running on the device.
        /// </param>

        /// <param name="vendor">Name of the software vendor.
        /// </param>

        /// <param name="softwareName">Name of the software product.
        /// </param>

        /// <param name="version">Version number of the software product.
        /// </param>

        /// <param name="endOfSupportStatus">End of support status.
        /// Possible values include: 'None', 'noLongerSupported',
        /// 'versionNoLongerSupported', 'upcomingNoLongerSupported',
        /// 'upcomingVersionNoLongerSupported'</param>

        /// <param name="endOfSupportDate">The end of support date in case the product is upcoming end of support.
        /// </param>

        /// <param name="numberOfKnownVulnerabilities">Number of weaknesses.
        /// </param>

        /// <param name="firstSeenAt">First time that the software was seen in the device.
        /// </param>
        public Software(string id = default(string), string name = default(string), string type = default(string), string deviceId = default(string), string osPlatform = default(string), string vendor = default(string), string softwareName = default(string), string version = default(string), string endOfSupportStatus = default(string), string endOfSupportDate = default(string), int? numberOfKnownVulnerabilities = default(int?), string firstSeenAt = default(string))

        : base(id, name, type)
        {
            this.DeviceId = deviceId;
            this.OSPlatform = osPlatform;
            this.Vendor = vendor;
            this.SoftwareName = softwareName;
            this.Version = version;
            this.EndOfSupportStatus = endOfSupportStatus;
            this.EndOfSupportDate = endOfSupportDate;
            this.NumberOfKnownVulnerabilities = numberOfKnownVulnerabilities;
            this.FirstSeenAt = firstSeenAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets unique identifier for the virtual machine in the service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.deviceId")]
        public string DeviceId {get; set; }

        /// <summary>
        /// Gets or sets platform of the operating system running on the device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.osPlatform")]
        public string OSPlatform {get; set; }

        /// <summary>
        /// Gets or sets name of the software vendor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vendor")]
        public string Vendor {get; set; }

        /// <summary>
        /// Gets or sets name of the software product.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.softwareName")]
        public string SoftwareName {get; set; }

        /// <summary>
        /// Gets or sets version number of the software product.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.version")]
        public string Version {get; set; }

        /// <summary>
        /// Gets or sets end of support status. Possible values include: &#39;None&#39;, &#39;noLongerSupported&#39;, &#39;versionNoLongerSupported&#39;, &#39;upcomingNoLongerSupported&#39;, &#39;upcomingVersionNoLongerSupported&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.endOfSupportStatus")]
        public string EndOfSupportStatus {get; set; }

        /// <summary>
        /// Gets or sets the end of support date in case the product is upcoming end of
        /// support.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.endOfSupportDate")]
        public string EndOfSupportDate {get; set; }

        /// <summary>
        /// Gets or sets number of weaknesses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.numberOfKnownVulnerabilities")]
        public int? NumberOfKnownVulnerabilities {get; set; }

        /// <summary>
        /// Gets or sets first time that the software was seen in the device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.firstSeenAt")]
        public string FirstSeenAt {get; set; }
    }
}