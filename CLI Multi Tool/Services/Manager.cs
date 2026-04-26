using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool;

public class Manager(IPasswordServices passwordServices, ISearchService searchService): IManager
{
    public void serviceManager()
    {
        Console.WriteLine("Type 1 if you want to search a file something in the machine");
        var decision = Console.Read();

        if (decision == '1')
        {
            searchService.Search();
        }
        else
        {
             passwordServices.GeneratePassword();
        }
    }
}