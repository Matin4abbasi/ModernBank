
namespace HexChecker;

public class HexChecker
{
    public bool ValidateHex(string hexCode)
    {
        
        Boolean check = false;
        if (string.IsNullOrEmpty(hexCode) || hexCode[0] != '#')
        {
            return false;
        }
        else if (hexCode.Length != 7)
        {
            return false;
        }
        else
        {
            for (int i = 1; i < hexCode.Length; i++)
            {
                char word = hexCode[i];
                if ((word < '0' && word > '9') || (word < 'A' && word > 'F') || (word < 'a' && word > 'f'))
                {
                    return false;
                }

                check = true;

            }

            if (check)
            {
                return true;
            }
            else return false;
        }

    }
}