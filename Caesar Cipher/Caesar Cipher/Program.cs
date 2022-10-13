using System.Diagnostics;

static string encrypt(string input, int cipher)
    {
        int alphpos = 0;
        List<string> newword = new List<string> { };
        List<string> alphabet= new List<string> { "a", "b","c","d","e","f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsPunctuation(input[i]) == true)
            {
            newword.Add(input[i].ToString());
            }
            else
            {
                if (input[i].ToString().ToLower() == "a")
            {
                newword.Add(alphabet[26 + cipher]);
            }
                else
                {
                alphpos = alphabet.IndexOf(input[i].ToString().ToLower());
                newword.Add(alphabet[alphpos + cipher]);
                }
            }
            
        }
        string result = String.Join("",newword);
        return result;
    }

Console.WriteLine(encrypt("Helloz", 3));

static string decrypt(string input, int cipher)
{
    int alphpos = 0;
    List<string> newword = new List<string> { };
    List<string> alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    for (int i = 0; i < input.Length; i++)
    {

        if (Char.IsPunctuation(input[i]) == true)
        {
            newword.Add(input[i].ToString());
        }
        else
        {
            if (input[i].ToString().ToLower() == "a")
            {
                newword.Add(alphabet[26 - cipher]);
            }
            else
            {
                alphpos = alphabet.IndexOf(input[i].ToString().ToLower());
                newword.Add(alphabet[alphpos - cipher]);
            }
        }

    }
    string result = String.Join("", newword);
    return result;

}
Console.WriteLine(decrypt("khooraza", 3));

//tried to start decrept without cipher. as you may be able to tell, didn't go that far
//static string decryptmega(string input)
//{

//    return "";
//}