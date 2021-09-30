// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job Properties</summary>
    public partial class JobProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json ? new JobProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject into a new instance of <see cref="JobProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal JobProperties(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudError.FromJson(__jsonError) : Error;}
            {_deliveryInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject>("deliveryInfo"), out var __jsonDeliveryInfo) ? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDeliveryInfo.FromJson(__jsonDeliveryInfo) : DeliveryInfo;}
            {_transferType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("transferType"), out var __jsonTransferType) ? (string)__jsonTransferType : (string)TransferType;}
            {_isCancellable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean>("isCancellable"), out var __jsonIsCancellable) ? (bool?)__jsonIsCancellable : IsCancellable;}
            {_isDeletable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean>("isDeletable"), out var __jsonIsDeletable) ? (bool?)__jsonIsDeletable : IsDeletable;}
            {_isShippingAddressEditable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean>("isShippingAddressEditable"), out var __jsonIsShippingAddressEditable) ? (bool?)__jsonIsShippingAddressEditable : IsShippingAddressEditable;}
            {_isPrepareToShipEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean>("isPrepareToShipEnabled"), out var __jsonIsPrepareToShipEnabled) ? (bool?)__jsonIsPrepareToShipEnabled : IsPrepareToShipEnabled;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : StartTime : StartTime;}
            {_detail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject>("details"), out var __jsonDetails) ? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDetails.FromJson(__jsonDetails) : Detail;}
            {_cancellationReason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("cancellationReason"), out var __jsonCancellationReason) ? (string)__jsonCancellationReason : (string)CancellationReason;}
            {_deliveryType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("deliveryType"), out var __jsonDeliveryType) ? (string)__jsonDeliveryType : (string)DeliveryType;}
            {_isCancellableWithoutFee = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean>("isCancellableWithoutFee"), out var __jsonIsCancellableWithoutFee) ? (bool?)__jsonIsCancellableWithoutFee : IsCancellableWithoutFee;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="JobProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="JobProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            }
            AddIf( null != this._deliveryInfo ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) this._deliveryInfo.ToJson(null,serializationMode) : null, "deliveryInfo" ,container.Add );
            AddIf( null != (((object)this._transferType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._transferType.ToString()) : null, "transferType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isCancellable ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean((bool)this._isCancellable) : null, "isCancellable" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isDeletable ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean((bool)this._isDeletable) : null, "isDeletable" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isShippingAddressEditable ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean((bool)this._isShippingAddressEditable) : null, "isShippingAddressEditable" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isPrepareToShipEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean((bool)this._isPrepareToShipEnabled) : null, "isPrepareToShipEnabled" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            }
            AddIf( null != this._detail ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) this._detail.ToJson(null,serializationMode) : null, "details" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._cancellationReason)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._cancellationReason.ToString()) : null, "cancellationReason" ,container.Add );
            }
            AddIf( null != (((object)this._deliveryType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._deliveryType.ToString()) : null, "deliveryType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isCancellableWithoutFee ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonBoolean((bool)this._isCancellableWithoutFee) : null, "isCancellableWithoutFee" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}