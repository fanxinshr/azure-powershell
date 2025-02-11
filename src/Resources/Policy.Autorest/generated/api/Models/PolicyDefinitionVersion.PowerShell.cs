// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PowerShell;

    /// <summary>The ID of the policy definition version.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyDefinitionVersionTypeConverter))]
    public partial class PolicyDefinitionVersion
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersion" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersion DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyDefinitionVersion(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersion" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersion DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PolicyDefinitionVersion(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyDefinitionVersion" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PolicyDefinitionVersion" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersion FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyDefinitionVersion(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyType = (string) content.GetValueForProperty("PolicyType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Mode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Mode = (string) content.GetValueForProperty("Mode",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Mode, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyRule = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny) content.GetValueForProperty("PolicyRule",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyRule, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ParameterDefinitionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyDefinitionVersion(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionVersionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyType = (string) content.GetValueForProperty("PolicyType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Mode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Mode = (string) content.GetValueForProperty("Mode",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Mode, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyRule = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny) content.GetValueForProperty("PolicyRule",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).PolicyRule, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IAny) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ParameterDefinitionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionVersionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The ID of the policy definition version.
    [System.ComponentModel.TypeConverter(typeof(PolicyDefinitionVersionTypeConverter))]
    public partial interface IPolicyDefinitionVersion

    {

    }
}