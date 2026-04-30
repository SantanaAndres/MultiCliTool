namespace Core.Interfaces.Repository;

public interface ISearchRepo
{
    public void Search(string targetFile, string searchPattern);
}