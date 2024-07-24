using Kama.ApiManagement.Core.DataSource;

namespace Kama.ApiManagement.Domain.Services;

public class RefreshTokenService : Service, IRefreshTokenService
{
    public RefreshTokenService(IRefreshTokenDataSource dataSource) 
    {
        _dataSource = dataSource;
    }
    private readonly IRefreshTokenDataSource _dataSource;

    public Task<Result<RefreshToken>> AddAsync(RefreshToken model)
    {
        model.ID = Guid.NewGuid();
        return _dataSource.AddAsync(model);
    }
    public Task<Result<RefreshToken>> UpdateExpireDateAsync(RefreshToken model)
        => _dataSource.UpdateExpireDateAsync(model);
}
