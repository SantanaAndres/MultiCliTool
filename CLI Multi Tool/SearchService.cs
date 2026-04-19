using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool;

public class SearchService(ISearchRepo repo): ISearchService
{
    public string Search()
    {
        try
        {
            var targetFile = Console.ReadLine();
            var searchPattern = Console.ReadLine();
            
            if (!Directory.Exists(targetFile))
                return repo.Search(targetFile, searchPattern);
            else 
                return repo.Search(targetFile, searchPattern);
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}