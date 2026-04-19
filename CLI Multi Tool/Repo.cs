namespace CLI_Multi_Tool;

public class Repo
{
    public string Search(/*string startFolder*/)
    {
        string startFolder = """C:\Users\CompuTechPTY\RiderProjects\CLI Multi Tool\""";
        DirectoryInfo dir = new DirectoryInfo(startFolder);
        var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
        
        var fileQuery = from file in fileList
            where file.Extension == ".sln"
            orderby file.Name
            select file;
        
        var newestFile = (from file in fileQuery
                orderby file.CreationTime
                select new { file.FullName, file.CreationTime })
            .Last();
        
        return $"\r\nThe newest .sln file is {newestFile.FullName}. Creation time: {newestFile.CreationTime}";
    }
}