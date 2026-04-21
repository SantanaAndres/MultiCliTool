namespace CLI_Multi_Tool.Interfaces;

public interface IPasswordGeneratorRepo
{
    public string GeneratePassword(int length);
}