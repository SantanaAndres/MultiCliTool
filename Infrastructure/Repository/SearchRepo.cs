using Core.Interfaces.Repository;

namespace Infrastructure.Repository;

public class SearchRepo: ISearchRepo
{
    public void Search(string lookingFor, string searchPattern)
    {
        try
        {
            string[] files = Directory.GetFiles(searchPattern, lookingFor, SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            string[] dirs = Directory.GetDirectories(searchPattern);
            foreach (var dir in dirs)
            {
                Search(lookingFor, dir);
            }
        }
        catch (Exception)
        {
            
        }
    }
}