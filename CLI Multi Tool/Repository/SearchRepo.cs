using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool.Repository;

public class SearchRepo: ISearchRepo
{
    public string Search(string targetFile, string searchPattern)
    {
        DirectoryInfo dir = new DirectoryInfo(searchPattern);
        var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
        
        var fileQuery = from file in fileList
            where file.Name.Contains(targetFile)
            orderby file.Name
            select file;
        
        var newestFile = (from file in fileQuery
                orderby file.CreationTime
                select new { file.FullName, file.CreationTime })
            .Last();
        
        return $"\r\nThe newest file is {newestFile.FullName}. Creation time: {newestFile.CreationTime}";
    }
}