namespace Core.Interfaces.Repository;

public interface IPasswordGeneratorRepo
{
    public string GeneratePassword(int length);
}