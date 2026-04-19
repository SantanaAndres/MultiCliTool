using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool;

public class SearchService(ISearchRepo repo): ISearchService
{
    public string Search()
    {
        try
        {
            var userInput = Console.ReadLine();
            
            if (!Directory.Exists(userInput))
                return repo.Search(userInput);
            else 
                return repo.Search(userInput);
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}