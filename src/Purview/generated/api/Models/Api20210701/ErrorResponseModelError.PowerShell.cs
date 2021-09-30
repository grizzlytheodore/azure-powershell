namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell;

    /// <summary>Gets or sets the error.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseModelErrorTypeConverter))]
    public partial class ErrorResponseModelError
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorResponseModelError"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelError" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelError DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ErrorResponseModelError(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorResponseModelError"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelError" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelError DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ErrorResponseModelError(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorResponseModelError"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ErrorResponseModelError(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorModelTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Target, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorResponseModelError"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ErrorResponseModelError(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorModelTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)this).Target, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ErrorResponseModelError" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelError FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Gets or sets the error.
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseModelErrorTypeConverter))]
    public partial interface IErrorResponseModelError

    {

    }
}