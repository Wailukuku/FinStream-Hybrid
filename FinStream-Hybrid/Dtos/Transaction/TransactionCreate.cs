namespace FinStream_Hybrid.Dtos.Transaction
{
    public record TransactionCreate(
         decimal Amount,
         string Description,
         string Category = "Général"
    );
}
