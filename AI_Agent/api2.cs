using System.Text.Json;

public class ApiEndpointDefinition
{
    public string Id { get; set; }
    public string SchemaVersion { get; set; }
    public string DisplayName { get; set; }
    public string Summary { get; set; }
}

public class DataFormatSchema
{
    public string SchemaVersion { get; set; }
    public JsonDocument InputDataSchema { get; set; }
    public JsonDocument OutputResultSchema { get; set; }
}

public interface IEndpointRunner
{
    IReadOnlyList<ApiEndpointDefinition> GetAvailableEndpoints();
    Task<DataFormatSchema> GetEndpointSchema(string endpointId);
    Task<JsonDocument> ExecuteEndpointAsync(JsonDocument payload);
}