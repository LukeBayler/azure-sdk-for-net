// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for NotificationStageName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationStageName
    {
        [EnumMember(Value = "DevicePrepared")]
        DevicePrepared,
        [EnumMember(Value = "Dispatched")]
        Dispatched,
        [EnumMember(Value = "Delivered")]
        Delivered,
        [EnumMember(Value = "PickedUp")]
        PickedUp,
        [EnumMember(Value = "AtAzureDC")]
        AtAzureDC,
        [EnumMember(Value = "DataCopy")]
        DataCopy
    }
    internal static class NotificationStageNameEnumExtension
    {
        internal static string ToSerializedValue(this NotificationStageName? value)
        {
            return value == null ? null : ((NotificationStageName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this NotificationStageName value)
        {
            switch( value )
            {
                case NotificationStageName.DevicePrepared:
                    return "DevicePrepared";
                case NotificationStageName.Dispatched:
                    return "Dispatched";
                case NotificationStageName.Delivered:
                    return "Delivered";
                case NotificationStageName.PickedUp:
                    return "PickedUp";
                case NotificationStageName.AtAzureDC:
                    return "AtAzureDC";
                case NotificationStageName.DataCopy:
                    return "DataCopy";
            }
            return null;
        }

        internal static NotificationStageName? ParseNotificationStageName(this string value)
        {
            switch( value )
            {
                case "DevicePrepared":
                    return NotificationStageName.DevicePrepared;
                case "Dispatched":
                    return NotificationStageName.Dispatched;
                case "Delivered":
                    return NotificationStageName.Delivered;
                case "PickedUp":
                    return NotificationStageName.PickedUp;
                case "AtAzureDC":
                    return NotificationStageName.AtAzureDC;
                case "DataCopy":
                    return NotificationStageName.DataCopy;
            }
            return null;
        }
    }
}
