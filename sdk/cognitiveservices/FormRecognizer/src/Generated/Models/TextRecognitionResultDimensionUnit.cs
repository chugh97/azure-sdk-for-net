// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextRecognitionResultDimensionUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextRecognitionResultDimensionUnit
    {
        [EnumMember(Value = "pixel")]
        Pixel,
        [EnumMember(Value = "inch")]
        Inch
    }
    internal static class TextRecognitionResultDimensionUnitEnumExtension
    {
        internal static string ToSerializedValue(this TextRecognitionResultDimensionUnit? value)
        {
            return value == null ? null : ((TextRecognitionResultDimensionUnit)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextRecognitionResultDimensionUnit value)
        {
            switch( value )
            {
                case TextRecognitionResultDimensionUnit.Pixel:
                    return "pixel";
                case TextRecognitionResultDimensionUnit.Inch:
                    return "inch";
            }
            return null;
        }

        internal static TextRecognitionResultDimensionUnit? ParseTextRecognitionResultDimensionUnit(this string value)
        {
            switch( value )
            {
                case "pixel":
                    return TextRecognitionResultDimensionUnit.Pixel;
                case "inch":
                    return TextRecognitionResultDimensionUnit.Inch;
            }
            return null;
        }
    }
}
