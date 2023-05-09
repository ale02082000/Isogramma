using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {


     var alfabeto = new int [26];



        foreach(var Letter in word.ToLower())
        {

            
            if (Char.IsLetter(Letter))
            {
                alfabeto [Letter - 'a']++;
                if (alfabeto[Letter - 'a'] > 1)
                    return false;
            }
        }
        return true;
    }

}