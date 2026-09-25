using DNX.Models.Accounting.ExcelImport;

namespace DNX.Services.Accounting.ExcelImport;

public interface IAccountBalanceExcelImportService
{
    Task<AccountBalanceExcelPreview> ReadAndValidateAsync(
        Stream excelStream,
        string fileName,
        ExcelAccountingImportTarget target,
        CancellationToken cancellationToken = default);

    Task<AccountBalanceImportResult> CommitAsync(
        CommitAccountBalanceImportRequest request,
        CancellationToken cancellationToken = default);
}
