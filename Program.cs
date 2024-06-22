using System;

class Program
{
    static void Main(string[] args)
    {
        
        //////////////////////////////////////////////////////////////////////////////
        /////////// TASK 1 : Problem : Sort Character (50 Poin) (NDL010)//////////////
        //////////////////////////////////////////////////////////////////////////////
        
        // Calling methods from ShortChar class
        Console.Write("Input one line of words (S) : ");
		string input = Console.ReadLine();
        string charVowel = ShortChar.procVowel(input.ToLower());
        string charConsonant = ShortChar.procConsonant(input.ToLower());

        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(charVowel);
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(charConsonant);


        //////////////////////////////////////////////////////////////////////////////
        //// TASK 2 : PSBB ( Pembatasan Sosial Berskala Besar ) (60 Poin) (NDL011)////
        //////////////////////////////////////////////////////////////////////////////
        string helloMessage = PSBB.hello("Mark..");
        Console.WriteLine(helloMessage);
    }
}
