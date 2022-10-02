namespace Application.UnitTests.Common;

public static  class GenerateRandomString
{
    
    public static string NextStrings(this Random rnd, int lenght)
    {
        const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz ";
        char[] chars = new char[lenght];

        for (int i = 0; i < lenght; i++)
        {
            chars[i] = allowedChars[rnd.Next(0, allowedChars.Length)];
        }

        return new string(chars);
    }
}