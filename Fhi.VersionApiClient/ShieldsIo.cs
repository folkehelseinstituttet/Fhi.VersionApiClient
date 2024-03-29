﻿namespace Fhi.Common.VersionApiClient;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/// <summary>
/// Generated by NSwag from swagger.json
/// To be used with Badges in Shields.io, ref https://shields.io/endpoint
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ShieldsIo
{
    [Newtonsoft.Json.JsonProperty("schemaVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]

    public int SchemaVersion { get; set; } = default!;


    [Newtonsoft.Json.JsonProperty("label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Label { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Message { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Color { get; set; } = default!;

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member