using Core.Interfaces.Repository;
using Core.Interfaces.Services;

namespace Aplication.Services;

public class RequestService(IRequestRepo repo): IRequestServices
{
    public async Task CheckBTCPrice()
    {
        await repo.CheckBTCPrice();
    }
}