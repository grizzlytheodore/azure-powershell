// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.PowerShell;

    /// <summary>Set of rules for sending logs for the Monitor resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(LogRulesTypeConverter))]
    public partial class LogRules
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogRules"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRules" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRules DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LogRules(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogRules"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRules" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRules DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LogRules(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LogRules" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRules FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogRules"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LogRules(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendAadLog = (bool?) content.GetValueForProperty("SendAadLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendAadLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendSubscriptionLog = (bool?) content.GetValueForProperty("SendSubscriptionLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendSubscriptionLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendActivityLog = (bool?) content.GetValueForProperty("SendActivityLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendActivityLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).FilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IFilteringTag[]) content.GetValueForProperty("FilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).FilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.FilteringTagTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogRules"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LogRules(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendAadLog = (bool?) content.GetValueForProperty("SendAadLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendAadLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendSubscriptionLog = (bool?) content.GetValueForProperty("SendSubscriptionLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendSubscriptionLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendActivityLog = (bool?) content.GetValueForProperty("SendActivityLog",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).SendActivityLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).FilteringTag = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IFilteringTag[]) content.GetValueForProperty("FilteringTag",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogRulesInternal)this).FilteringTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IFilteringTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.FilteringTagTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Set of rules for sending logs for the Monitor resource.
    [System.ComponentModel.TypeConverter(typeof(LogRulesTypeConverter))]
    public partial interface ILogRules

    {

    }
}