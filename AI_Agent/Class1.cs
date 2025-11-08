public class FiatCurrencyTransferRequest : BaseApiRequest
{
    public override string EndpointName => "FiatCurrencyTransfer";
    public override string EndpointDescription => "Initiates a transfer of fiat currency from one user's account to another user's account.";
    public override UserPermissionLevel MinimumRequiredPermission => UserPermissionLevel.StandardUser;
    public string SourceUserAccountId { get; set; } = string.Empty;
    public string TargetUserIdentifier { get; set; } = string.Empty;
    public decimal TransferAmount { get; set; }
    public string CurrencyCode { get; set; } = string.Empty;
    public string? TransactionNote { get; set; }
    public string? TwoFactorAuthenticationCode { get; set; }
}

public class FiatCurrencyTransferResponse : BaseApiResponse
{
    public Guid TransactionReferenceId { get; set; }
    public decimal ActualTransferredAmount { get; set; }
    public string TransferredCurrencyCode { get; set; } = string.Empty;
    public DateTimeOffset TransactionCompletionTime { get; set; }
    public decimal SenderAccountNewBalance { get; set; }
    public string RecipientConfirmationDisplay { get; set; } = string.Empty;
}
