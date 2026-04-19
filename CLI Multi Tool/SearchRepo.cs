using CLI_Multi_Tool.Interfaces;

namespace CLI_Multi_Tool;

public class SearchRepo: ISearchRepo
{
    public string Search(string startFolder)
    {
        DirectoryInfo dir = new DirectoryInfo("C:\\Users\\CompuTechPTY\\Downloads");
        var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
        
        var fileQuery = from file in fileList
            where file.Name.Contains(startFolder)
            orderby file.Name
            select file;
        
        var newestFile = (from file in fileQuery
                orderby file.CreationTime
                select new { file.FullName, file.CreationTime })
            .Last();
        
        return $"\r\nThe newest file is {newestFile.FullName}. Creation time: {newestFile.CreationTime}";
    }
}