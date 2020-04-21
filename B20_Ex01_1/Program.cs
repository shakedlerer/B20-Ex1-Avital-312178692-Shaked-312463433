﻿using System;

namespace B20_Ex01_1
{
    public class Program
    {
        private const int k_NumOfNumbers = 3;
        private const int k_LenOfInput = 9;

        public static void Main()
        {
            start();
        }

        private static void start()
        {
            int inputInDecimal1, inputInDecimal2, inputInDecimal3, numOfNumbers = 3, lenOfInput = 9;
            string inputInBinary1, inputInBinary2, inputInBinary3;

            Console.WriteLine("Please enter " + numOfNumbers + " " + lenOfInput + "-digits binary numbers.");

            Console.WriteLine("Please enter the first number: ");
            inputInBinary1 = getValidInput();

            Console.WriteLine("Please enter the second number: ");
            inputInBinary2 = getValidInput();

            Console.WriteLine("Please enter the third number: ");
            inputInBinary3 = getValidInput();

            inputInDecimal1 = convertFromBinaryToDecimal(inputInBinary1);
            inputInDecimal2 = convertFromBinaryToDecimal(inputInBinary2);
            inputInDecimal3 = convertFromBinaryToDecimal(inputInBinary3);

            printStatisticsOfInput(inputInDecimal1, inputInDecimal2, inputInDecimal3, inputInBinary1, inputInBinary2, inputInBinary3);

            Console.ReadLine();
        }

        private static string getValidInput()
        {
            string inputStr;
            bool isValidInput;

            do
            {
                inputStr = getInput();
                isValidInput = checkIfValidInput(inputStr);

                if (!isValidInput)
                {
                    Console.WriteLine("Not valid input. Please enter a valid input: ");
                }
            }
            while (isValidInput == !true);

            return inputStr;
        }

        private static string getInput()
        {
            string inputStr = Console.ReadLine();

            return inputStr;
        }

        private static void printStatisticsOfInput(int i_InputNum1, int i_InputNum2, int i_InputNum3,
                                                   string i_InputStr1, string i_InputStr2, string i_InputStr3)
        {
            string decNumStr1 = i_InputNum1.ToString();
            string decNumStr2 = i_InputNum2.ToString();
            string decNumStr3 = i_InputNum3.ToString();

            Console.WriteLine("The input numbers in Decimal Format are:");
            printDecNum(i_InputNum1);
            printDecNum(i_InputNum2);
            printDecNum(i_InputNum3);

            printAvgNumOfZerosInNum(i_InputStr1, i_InputStr2, i_InputStr3);
            printAvgNumOfOnesInNum(i_InputStr1, i_InputStr2, i_InputStr3);

            printHowManyArePowersOfTwo(i_InputNum1, i_InputNum2, i_InputNum3);

            printHowManyAreAscOrder(decNumStr1, decNumStr2, decNumStr3);

            printMaxNum(i_InputNum1, i_InputNum2, i_InputNum3);
            printMinNum(i_InputNum1, i_InputNum2, i_InputNum3);
        }

        private static void printDecNum(int i_Num)
        {
            Console.WriteLine(i_Num);
        }

        private static void printAvgNumOfZerosInNum(string i_Str1, string i_Str2, string i_Str3)
        {
            int numOfNumbers = 3;
            float avg = avgNumOfZerosInNum(i_Str1, i_Str2, i_Str3);

            Console.WriteLine("Average num of Zeros in all {0} numbers is: {1:0.##}", numOfNumbers, avg);
        }

        private static float avgNumOfZerosInNum(string i_Str1, string i_Str2, string i_Str3)
        {
            int totalZerosCount = 0, numOfNumbers = 3;
            float avgOfZeros = 0;

            totalZerosCount += countNumOfZeros(i_Str1);
            totalZerosCount += countNumOfZeros(i_Str2);
            totalZerosCount += countNumOfZeros(i_Str3);

            return avgOfZeros = (float)totalZerosCount / numOfNumbers;
        }

        private static int countNumOfZeros(string i_Str)
        {
            int countZeros = 0, lenOfInput = 9;

            for (int i = 0; i < lenOfInput; i++)
            {
                if (i_Str[i] == '0')
                {
                    countZeros++;
                }
            }

            return countZeros;
        }

        private static void printAvgNumOfOnesInNum(string i_Str1, string i_Str2, string i_Str3)
        {
            int numOfNumbers = 3;
            float avg = avgNumOfOnesInNum(i_Str1, i_Str2, i_Str3);

            Console.WriteLine("Average num of Ones in all {0} numbers is: {1:0.##}", numOfNumbers, avg);
        }

        private static float avgNumOfOnesInNum(string i_Str1, string i_Str2, string i_Str3)
        {
            int totalOnesCount = 0, numOfNumbers = 3;
            float avgOfOnes = 0;

            totalOnesCount += countNumOfOnes(i_Str1);
            totalOnesCount += countNumOfOnes(i_Str2);
            totalOnesCount += countNumOfOnes(i_Str3);

            return avgOfOnes = (float)totalOnesCount / numOfNumbers;
        }

        private static int countNumOfOnes(string i_Str)
        {
            int countOnes = 0, lenOfInput = 9;

            for (int i = 0; i < lenOfInput; i++)
            {
                if (i_Str[i] == '1')
                {
                    countOnes++;
                }
            }

            return countOnes;
        }

        private static void printHowManyArePowersOfTwo(int i_Num1, int i_Num2, int i_Num3)
        {
            int countPowersOfTwo = 0, numOfNumbers = 3;

            if (isPowerOfTwo(i_Num1))
            {
                countPowersOfTwo++;
            }

            if (isPowerOfTwo(i_Num2))
            {
                countPowersOfTwo++;
            }

            if (isPowerOfTwo(i_Num3))
            {
                countPowersOfTwo++;
            }

            Console.WriteLine("{0} of the {1} input numbers are Power of 2", countPowersOfTwo, numOfNumbers);
        }

        private static bool isPowerOfTwo(int i_Num)
        {
            while (((i_Num % 2) == 0) && i_Num > 1)
            {
                i_Num /= 2;
            }

            return i_Num == 1;
        }

        private static void printHowManyAreAscOrder(string i_Str1, string i_Str2, string i_Str3)
        {
            int countAscOrder = 0, numOfNumbers = 3;

            if (isDigitsInAscendingOrder(i_Str1))
            {
                countAscOrder++;
            }

            if (isDigitsInAscendingOrder(i_Str2))
            {
                countAscOrder++;
            }

            if (isDigitsInAscendingOrder(i_Str3))
            {
                countAscOrder++;
            }

            Console.WriteLine("{0} of the {1} input numbers' digits are in Ascending order", countAscOrder, numOfNumbers);
        }

        private static bool isDigitsInAscendingOrder(string i_Str)
        {
            bool digitsInAscendingOrder = true;

            for (int i = 1; i < i_Str.Length && digitsInAscendingOrder; i++)
            {
                if (i_Str[i] <= i_Str[i - 1])
                {
                    digitsInAscendingOrder = false;
                }
            }

            return digitsInAscendingOrder;
        }

        private static void printMaxNum(int i_Num1, int i_Num2, int i_Num3)
        {
            int tempMax = Math.Max(i_Num1, i_Num2);
            int max = Math.Max(tempMax, i_Num3);

            Console.WriteLine("The Max num is {0}", max);
        }

        private static void printMinNum(int i_Num1, int i_Num2, int i_Num3)
        {
            int tempMin = Math.Min(i_Num1, i_Num2);
            int min = Math.Min(tempMin, i_Num3);

            Console.WriteLine("The Min num is {0}", min);
        }

        private static int convertFromCharToInt(char i_Chr)
        {
            return i_Chr - '0';
        }

        private static int convertFromBinaryToDecimal(string i_Str)
        {
            int currentBinaryDigit;
            int decimalNumber = 0;
            int mostRightIndex = i_Str.Length - 1;
            int powerByIndex;

            for (int indexInStr = mostRightIndex; indexInStr >= 0; indexInStr--)
            {
                currentBinaryDigit = convertFromCharToInt(i_Str[indexInStr]);
                powerByIndex = getPowerByIndex(i_Str, indexInStr);
                decimalNumber += multiplyDigitByTwoPower(currentBinaryDigit, powerByIndex);
            }

            return decimalNumber;
        }

        private static int getPowerByIndex(string i_Str, int i_IndexInStr)
        {
            return i_Str.Length - i_IndexInStr - 1;
        }

        private static int multiplyDigitByTwoPower(int i_BinaryDigit, int i_PowerByIndex)
        {
            int powerOfTwoByIndex = (int)Math.Pow(2, i_PowerByIndex);
            return i_BinaryDigit * powerOfTwoByIndex;
        }

        private static bool checkIfValidInput(string i_Str)
        {
            return isInputLenValid(i_Str) && isInputContainOnlyZeroOne(i_Str);
        }

        private static bool isInputLenValid(string i_Str)
        {
            int lenOfInput = 9;
            return i_Str.Length == lenOfInput;
        }

        private static bool isInputContainOnlyZeroOne(string i_Str)
        {
            bool inputContainOnlyZeroOne = true;

            for (int i = 0; i < i_Str.Length && inputContainOnlyZeroOne; i++)
            {
                if (i_Str[i] != '0' && i_Str[i] != '1')
                {
                    inputContainOnlyZeroOne = false;
                }
            }

            return inputContainOnlyZeroOne;
        }
    }
}