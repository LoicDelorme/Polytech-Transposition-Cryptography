using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptographyModel
{
    public class TranspositionKeyOffsetHelper
    {
        public static char[] ALPHABET = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static int[] parseKey(string key)
        {
            int[] keyOffsetResult = new int[key.Length];
            int currentOffset = 0;
            char currentChar;

            for (int primaryIndex = 0; primaryIndex < ALPHABET.Length; primaryIndex++)
            {
                currentChar = ALPHABET[primaryIndex];
                if (key.Contains(currentChar) || key.Contains(Char.ToLower(currentChar)))
                {
                    for(int secondaryIndex = 0; secondaryIndex < key.Length; secondaryIndex++)
                    {
                        if (key[secondaryIndex].Equals(currentChar) || key[secondaryIndex].Equals(Char.ToLower(currentChar)))
                        {
                            keyOffsetResult[secondaryIndex] = currentOffset;
                            currentOffset++;
                        }
                    }
                }
            }

            return keyOffsetResult;
        }
    }
}
