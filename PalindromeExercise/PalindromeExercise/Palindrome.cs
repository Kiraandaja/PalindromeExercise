using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        
            public bool IsAPalindrome(string word)
            {
                //reverse the word
                var reversed = "";
                for (int i = word.Length - 1; i>=0; i--)
                {
                    reversed += word[i];
                }
                //compare the original w/ the reversed
                if (reversed.ToLower() == word.ToLower())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
               

               

       
    }
}
