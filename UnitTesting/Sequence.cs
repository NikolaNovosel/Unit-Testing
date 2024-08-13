using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class Sequence
    {
        public static int CountMaxUnequalSequence(string? input)
        {
            if(string.IsNullOrEmpty(input)) return 0;
            
            int currentIndex = 1;

            int maxNumber = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentIndex++;
                }

                else
                {
                    if (currentIndex > maxNumber)
                    {
                        maxNumber = currentIndex;
                    }
                    currentIndex = 1;
                }
            }

            if (currentIndex > maxNumber)
            {
                maxNumber = currentIndex;
            }

            return maxNumber;
        }

        public static int CountMaxEqualSequenceAlphabet(string? input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            if (input.Length == 1 && !IsLatinLetter(input[0])) return 0;

            if (input.Length == 1 && IsLatinLetter(input[0])) return 1;

            int currentIndex = 1;

            int maxNumber = 0;

            bool validSequence = false;

            for (int i = 1; i < input.Length; i++)
            {
                if (IsLatinLetter(input[i]) && IsLatinLetter(input[i - 1]))
                {
                    if (input[i] == input[i - 1])
                    {
                        currentIndex++;
                        validSequence = true;
                    }
                    else
                    {
                        if (currentIndex > maxNumber)
                        {
                            maxNumber = currentIndex;
                        }
                        currentIndex = 1;
                    }
                }
                else
                {
                    if (validSequence && currentIndex > maxNumber)
                    {
                        maxNumber = currentIndex;
                    }
                    currentIndex = 1;
                }
            }

            if (validSequence && currentIndex > maxNumber)
            {
                maxNumber = currentIndex;
            }

            return maxNumber;
        }
        public static int CountMaxEqualSequenceDigit(string? input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            if (input.Length == 1 && !char.IsDigit(input[0])) return 0;

            if (input.Length == 1 && char.IsDigit(input[0])) return 1;

            int currentIndex = 1;

            int maxNumber = 0;

            bool validSequence = false;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && char.IsDigit(input[i - 1]))
                {
                    if (input[i] == input[i - 1])
                    {
                        currentIndex++;
                        validSequence = true;
                    }
                    else
                    {
                        if (currentIndex > maxNumber)
                        {
                            maxNumber = currentIndex;
                        }
                        currentIndex = 1;
                    }
                }
                else
                {
                    if (validSequence && currentIndex > maxNumber)
                    {
                        maxNumber = currentIndex;
                    }
                    currentIndex = 1;
                }
            }

            if (validSequence && currentIndex > maxNumber)
            {
                maxNumber = currentIndex;
            }

            return maxNumber;
        }
        private static bool IsLatinLetter(char c) => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }
}
