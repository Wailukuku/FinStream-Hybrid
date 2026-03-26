namespace FinStream_Hybrid.Dtos.Transaction
{
    public record TransactionResponse(
    Guid Id,               
    decimal Amount,
    string Description,
    string Category,
    DateTime CreatedAt    
);
}
