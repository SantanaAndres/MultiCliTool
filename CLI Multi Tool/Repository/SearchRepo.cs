using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool.Repository;

public class SearchRepo: ISearchRepo
{
    public string Search(string lookingFor, string searchPattern)
    {
        var targetFile = "";
        try
        {
            string[] files = Directory.GetFiles(searchPattern, lookingFor, SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                Console.WriteLine(file);
                targetFile = file;
            }

            string[] dirs = Directory.GetDirectories(searchPattern);
            foreach (var dir in dirs)
            {
                if(dir != null)
                    Search(dir, lookingFor);
            }
            return targetFile;
        }
        catch (Exception)
        {
            Console.WriteLine("Access denied: {0}", searchPattern);
            return "";
        }
    }
}