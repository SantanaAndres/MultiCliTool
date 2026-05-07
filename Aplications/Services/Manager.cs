using Core.Interfaces.Services;

namespace Aplication.Services;

public class Manager(
    IPasswordServices passwordServices, 
    ISearchService searchService,
    IRequestServices requestServices
    ): IManager
{
    public async Task serviceManager()
    {
        Console.WriteLine("Type 1 if you want to search a file something in the machine");
        var decision = Console.Read();

        if (decision == '1')
        {
            searchService.Search();
        }
        else if(decision == '2')
        {
             passwordServices.GeneratePassword();
             
        }
        else
        {
            await requestServices.CheckBTCPrice();
        }
    }
}