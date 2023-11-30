using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownBoard
{
    public class calculations
    {
        public static int RNG()
        {
            Random rnd = new Random();
            return rnd.Next(100, 1000);
        }
        public static int ChooseFromArray(int[] array)
        {


            Random random = new Random();
            int randomIndex = random.Next(0, array.Length);

            int chosenElement = array[randomIndex];

            // Remove the chosen element from the array


            //return chosenElement;
            return randomIndex;
        }
        public static int ChooseFromArray(char[] array)
        {


            Random random = new Random();
            int randomIndex = random.Next(0, array.Length);

            int chosenElement = array[randomIndex];

            // Remove the chosen element from the array


            //return chosenElement;
            return randomIndex;
        }
    }

    public class vowel
    {
        public static char[] GenerateVowelsArray()
        {
            // Distribution of vowels: A=15, E=21, I=13, O=13, U=5
            char[] vowels = new char[15 + 21 + 13 + 13 + 5];

            // Fill the array with vowels based on the specified distribution
            int index = 0;
            index = FillVowels(vowels, 'A', 15, index);
            index = FillVowels(vowels, 'E', 21, index);
            index = FillVowels(vowels, 'I', 13, index);
            index = FillVowels(vowels, 'O', 13, index);
            FillVowels(vowels, 'U', 5, index);

            return vowels;
        }

        public static int FillVowels(char[] array, char vowel, int count, int startIndex)
        {
            for (int i = startIndex; i < startIndex + count; i++)
            {
                array[i] = vowel;
            }
            return startIndex + count;
        }


    }
    public class consonant
    {
        public static char[] GenerateConsonantsArray()
        {
            // Distribution of consonants
            int totalConsonants = 2 + 3 + 6 + 2 + 3 + 2 + 1 + 1 + 5 + 4 + 8 + 4 + 1 + 9 + 9 + 9 + 1 + 1 + 1 + 1 + 1;
            char[] consonants = new char[totalConsonants];

            // Fill the array with consonants based on the specified distribution
            int index = 0;
            index = FillConsonants(consonants, 'B', 2, index);
            index = FillConsonants(consonants, 'C', 3, index);
            index = FillConsonants(consonants, 'D', 6, index);
            index = FillConsonants(consonants, 'F', 2, index);
            index = FillConsonants(consonants, 'G', 3, index);
            index = FillConsonants(consonants, 'H', 2, index);
            index = FillConsonants(consonants, 'J', 1, index);
            index = FillConsonants(consonants, 'K', 1, index);
            index = FillConsonants(consonants, 'L', 5, index);
            index = FillConsonants(consonants, 'M', 4, index);
            index = FillConsonants(consonants, 'N', 8, index);
            index = FillConsonants(consonants, 'P', 4, index);
            index = FillConsonants(consonants, 'Q', 1, index);
            index = FillConsonants(consonants, 'R', 9, index);
            index = FillConsonants(consonants, 'S', 9, index);
            index = FillConsonants(consonants, 'T', 9, index);
            index = FillConsonants(consonants, 'V', 1, index);
            index = FillConsonants(consonants, 'W', 1, index);
            index = FillConsonants(consonants, 'X', 1, index);
            index = FillConsonants(consonants, 'Y', 1, index);
            FillConsonants(consonants, 'Z', 1, index);

            return consonants;
        }

        public static int FillConsonants(char[] array, char consonant, int count, int startIndex)
        {
            for (int i = startIndex; i < startIndex + count; i++)
            {
                array[i] = consonant;
            }
            return startIndex + count;
        }
    }

    public class largeNum
    {
        public static int[] GenerateLargeNumbersArray()
        {
            // Distribution of numbers
            int[] numbers = { 25, 50, 75, 100 };

            return numbers;
        }
    }
    public class smallNum
    {
        public static int[] GenerateSmallNumbersArray()
        {
            // Distribution of numbers 1 through 10 with each number appearing twice
            int[] numbers = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            return numbers;
        }
    }
}
