using DNX.Models;

namespace DNX.Response
{
    public record LoginResponse
        (bool Flag, string Message = null!, AuthUser AuthUser = null!, Guid? TenantId = null, string? TenantDatabaseName = null);
    public record BoolandMessReponse
        (bool Flag, string Message = null!);
    
}
