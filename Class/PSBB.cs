using System;
using System.Collections.Generic;
					
public class PSBB 
{
    public static string MiniBus(int count, string[] membersTotal){
        
        // Parsing the string in List membersTotal to int
        int[] members = new int[count];

        for (int i = 0; i < count; i++) {
            members[i] = int.Parse(membersTotal[i]);
        }

        // Sorting the family member
        Array.Sort(members);

        int busNeeded = 0;
        int x = 0;
        int y = members.Length - 1;

        // Group the family
        while (x <= y) {
            if (members[x] + members[y] <= 4) {
                x += 1;
            } 
            y -= 1;

            busNeeded += 1;
        }

        return $"Minimum bus required is : {busNeeded}";
    }
}