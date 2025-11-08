using Newtonsoft.Json;

public enum UserPermissionLevel
{
    PublicAccess,
    StandardUser,
    SystemAdmin
}

public abstract class BaseApiRequest
{
    [JsonIgnore]
    public abstract string EndpointName { get; }

    [JsonIgnore]
    public abstract string EndpointDescription { get; }

    public abstract UserPermissionLevel MinimumRequiredPermission { get; }

    public string? InitiatorIdentifier { get; internal set; }
}

public class BaseApiResponse
{
    public bool OperationSuccessful { get; set; } = true;
    public string? FailureReasonMessage { get; set; }
}