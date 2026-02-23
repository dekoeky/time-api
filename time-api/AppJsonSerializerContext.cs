using System.Text.Json.Serialization;

[JsonSerializable(typeof(DateTime))]
[JsonSerializable(typeof(DateTimeOffset))]
[JsonSerializable(typeof(DateOnly))]
[JsonSerializable(typeof(TimeOnly))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
    // TODO: investigate constructor
    // TODO: explicitly put indented?
}
