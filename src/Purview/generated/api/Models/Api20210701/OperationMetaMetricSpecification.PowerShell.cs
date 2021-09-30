namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell;

    /// <summary>metric specifications for the operation</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationMetaMetricSpecificationTypeConverter))]
    public partial class OperationMetaMetricSpecification
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaMetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationMetaMetricSpecification(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaMetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationMetaMetricSpecification(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationMetaMetricSpecification" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaMetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationMetaMetricSpecification(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).AggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.DimensionPropertiesTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).EnableRegionalMdmAccount = (string) content.GetValueForProperty("EnableRegionalMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).EnableRegionalMdmAccount, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).InternalMetricName = (string) content.GetValueForProperty("InternalMetricName",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).InternalMetricName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).ResourceIdDimensionNameOverride = (string) content.GetValueForProperty("ResourceIdDimensionNameOverride",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).ResourceIdDimensionNameOverride, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SourceMdmNamespace = (string) content.GetValueForProperty("SourceMdmNamespace",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SourceMdmNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedAggregationType = (string[]) content.GetValueForProperty("SupportedAggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedAggregationType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedTimeGrainType = (string[]) content.GetValueForProperty("SupportedTimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedTimeGrainType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaMetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationMetaMetricSpecification(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).AggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.DimensionPropertiesTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).EnableRegionalMdmAccount = (string) content.GetValueForProperty("EnableRegionalMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).EnableRegionalMdmAccount, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).InternalMetricName = (string) content.GetValueForProperty("InternalMetricName",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).InternalMetricName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).ResourceIdDimensionNameOverride = (string) content.GetValueForProperty("ResourceIdDimensionNameOverride",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).ResourceIdDimensionNameOverride, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SourceMdmNamespace = (string) content.GetValueForProperty("SourceMdmNamespace",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SourceMdmNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedAggregationType = (string[]) content.GetValueForProperty("SupportedAggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedAggregationType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedTimeGrainType = (string[]) content.GetValueForProperty("SupportedTimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).SupportedTimeGrainType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// metric specifications for the operation
    [System.ComponentModel.TypeConverter(typeof(OperationMetaMetricSpecificationTypeConverter))]
    public partial interface IOperationMetaMetricSpecification

    {

    }
}