using System;
using System.Collections.Generic;
					
public class PSBB 
{
    public static string MiniBus(int count, string[] membersTotal){
        
        // Validating input length
        if (membersTotal.Length != count) {
            Console.WriteLine("Input must be equal with count of family");
            return count;
        }

        // Parsing the string in List membersTotal to int
        int[] members = new int[count];

        for (int i = 0; i < count; i++) {
            members[i] = int.Parse(membersTotal[i]);
        }

        // Totalling Mini Bus needed
        int busess = 0;

        foreach (int person in members) {
            if (person > 4) {
                busess += (person / 4);
            } else {
                busess += 1;
            }
        }

        Console.Write("Minimum bus required is: ");
        return busess;
    }
}