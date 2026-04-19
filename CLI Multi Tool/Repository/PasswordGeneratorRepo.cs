using System.Security.Cryptography;
using CLI_Multi_Tool.Interfaces;
using Microsoft.VisualBasic;

namespace CLI_Multi_Tool.Repository;

public class PasswordGeneratorRepo: IPasswordGeneratorRepo
{
        
    public string GeneratePassword()
    {
        const string Alphabet = "ABCDEFGHJKMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz123456789";
        
        return string.Create(15, Alphabet, (chars, state) =>
        {
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = state[RandomNumberGenerator.GetInt32(state.Length)];
            }
        });    
    }
}