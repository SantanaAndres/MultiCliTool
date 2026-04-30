using System.Security.Cryptography;
using Core.Interfaces.Repository;

namespace Infrastructure.Repository;

public class PasswordGeneratorRepo: IPasswordGeneratorRepo
{
    public string GeneratePassword(int length)
    {
        const string Alphabet = "ABCDEFGHJKMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz123456789";
        
        return string.Create(length, Alphabet, (chars, state) =>
        {
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = state[RandomNumberGenerator.GetInt32(state.Length)];
            }
        });    
    }
}