using System;
using System.Collections.Generic;
					
public class ShortChar
{
	public static string procVowel(string param){
		
        // To save the vowel
        var vowel = new List<char>();
        // To count the occurence using dict
        var countVow = new Dictionary<char, int>();

        for (int i = 0; i < param.Length; i++) {
            char vow = param[i];
            
            // Condition to check and find the vowel in input, also to exclude the whitespace
            if (!char.IsWhiteSpace(vow) && vow == 'a' || vow == 'i' || vow == 'u' || vow == 'e' || vow == 'o') {
                vowel.Add(vow);
                if (!countVow.ContainsKey(vow)) {
                    countVow[vow] = i;
                }
            }
        }

        // Sort based on occurence
        for (int i = 1; i < vowel.Count; i++) {
            char vow = vowel[i];
            int j = i - 1;

            // Moving the vowel[j] to the correct position based on the occurence 
            while (j >= 0 && countVow[vowel[j]] > countVow[vow]) {
                vowel[j + 1] = vowel[j];
                j -= 1;
            }

            vowel[j + 1] = vow;
        }

		return new string(vowel.ToArray());
	}
	
	public static string procConsonant(string param){
		
        // To save the consonant
        var consonant = new List<char>();
        // To count the occurence using dict
        var countCons = new Dictionary<char, int>();

        for (int i = 0; i < param.Length; i++) {
            char cons = param[i];
            
            // Condition to check and find the consonant in input, also to exclude the whitespace
            if (!char.IsWhiteSpace(cons) && cons != 'a' && cons != 'i' && cons != 'u' && cons != 'e' && cons != 'o') {
                consonant.Add(cons);
                if (!countCons.ContainsKey(cons)) {
                    countCons[cons] = i;
                }
            }
        }

        // Sort based on occurence
        for (int i = 1; i < consonant.Count; i++) {
            char cons = consonant[i];
            int j = i - 1;

            // Moving the vowel[j] to the correct position based on the occurence 
            while (j >= 0 && countCons[consonant[j]] > countCons[cons]) {
                consonant[j + 1] = consonant[j];
                j -= 1;
            }

            consonant[j + 1] = cons;
        }

		return new string(consonant.ToArray());
	}
	
	// public static void Main(string[] args)
	// {
	// 	Console.Write("Input one line of words (S) : ");
	// 	string input = Console.ReadLine();
		
	// 	string charVowel = procVowel(input.ToLower());
	// 	string charConsonant = procConsonant(input.ToLower());
			
	// 	Console.WriteLine("Vowel Characters : ");
	// 	Console.WriteLine(charVowel);
	// 	Console.WriteLine("Consonant Characters : ");
	// 	Console.WriteLine(charConsonant);
	// }
}
