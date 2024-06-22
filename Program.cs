using System;

class Program
{
    static void Main(string[] args)
    {
        
        //////////////////////////////////////////////////////////////////////////////
        /////////////////////// TASK 1 : Sort Character //////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        
        Console.WriteLine("TASK 1 : Sort Character");
        Console.WriteLine("#################################");

        // Calling methods from ShortChar class
        Console.Write("Input one line of words (S) : ");
		string input = Console.ReadLine();
        string charVowel = ShortChar.procVowel(input.ToLower());
        string charConsonant = ShortChar.procConsonant(input.ToLower());

        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(charVowel);
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(charConsonant);

        Console.WriteLine("\n");

        //////////////////////////////////////////////////////////////////////////////
        /////////////// TASK 2 : PSBB ( Pembatasan Sosial Berskala Besar ) ///////////
        //////////////////////////////////////////////////////////////////////////////
        
        Console.WriteLine("TASK 2 : PSBB - Pembatasan Sosial Berskala Besar");
        Console.WriteLine("#################################");
        
        Console.Write("Input the number of families : ");
        int inputNum = int.Parse(Console.ReadLine());

        Console.Write("Input the number of members in the family (separated by a space) : ");
        string[] inputFamily = Console.ReadLine().Split();

        // Validating input length
        if (inputFamily.Length != inputNum) {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }


        string result = PSBB.MiniBus(inputNum, inputFamily);
        Console.WriteLine(result);
    }
}
