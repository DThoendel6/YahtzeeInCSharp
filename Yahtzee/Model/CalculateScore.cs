using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Dominic Thoendel
 * Program: Yahtzee
*/
namespace Yahtzee.Model
{
    class CalculateScore
    {
        public static int CalcScore(string type, List<Die> dice, int yahtzeeCounter)
        {
            int score = 0;
            int[] numbers = new int[5];//number array used to store the values of each die
            int i = 0;
            foreach (Die d in dice)
            {
                if (type == "ones")
                {
                    if (d.DotCount == 1)
                    {
                        score += 1;
                    }
                }
                else if (type == "twos")
                {
                    if (d.DotCount == 2)
                    {
                        score += 2;
                    }
                }
                else if (type == "threes")
                {
                    if (d.DotCount == 3)
                    {
                        score += 3;
                    }
                }
                else if (type == "fours")
                {
                    if (d.DotCount == 4)
                    {
                        score += 4;
                    }
                }
                else if (type == "fives")
                {
                    if (d.DotCount == 5)
                    {
                        score += 5;
                    }
                }
                else if (type == "sixs")
                {
                    if (d.DotCount == 6)
                    {
                        score += 6;
                    }
                }
                else if (type == "chance")
                {
                    score += d.DotCount;
                }
                numbers[i] = d.DotCount;
                i++;
            }
            //search through array to find repeating numbers. Factor score for variable answers
            Array.Sort(numbers);

            if (type == "threeOfAKind")
            {
                if(CheckThrees(numbers))//if there is 3 of a kind
                {
                    foreach (Die d in dice)
                    {
                        score += d.DotCount;
                    }
                }
                return score;
            }
            if (type == "fourOfAKind")
            {
                if (CheckFours(numbers))
                {
                    foreach (Die d in dice)
                    {
                        score += d.DotCount;
                    }
                }
                return score;
            }
            if (type == "fullHouse")
            {
                if (CheckFull(numbers))
                {
                    return 25;
                }
                return score;
            }
            if (type == "smallStraight")
            {
                if (CheckStraight(numbers, "small"))
                {
                    return 30;
                }
                return score;
            }
            if (type == "largeStraight")
            {
                if (CheckStraight(numbers, "large"))
                {
                    return 40;
                }
                return score;
            }
            if (type == "yahtzee")
            {
                if (CheckYahtzee(numbers))
                {
                    if (yahtzeeCounter > 0)
                    {
                        score = 100;
                    }
                    else if (yahtzeeCounter == 0)
                    {
                        score = 50;
                    }
                }
                return score;
            }
            return score;
        }

        private static bool CheckStraight(int[] numbers, string size)
        {
            int[] dist = numbers.Distinct().ToArray();

            if (dist.Length < 4)
            {
                return false;
            }
            if (size == "large")
            {
                if (numbers[0] == (numbers[1] - 1) && numbers[1] == (numbers[2] - 1) && numbers[2] == (numbers[3] - 1) && numbers[3] == (numbers[4] - 1))
                {
                    return true;
                }
                return false;
            }
            if (size == "small")
            {
                if(dist[0] == (dist[1] - 1) && dist[1] == (dist[2] - 1) && dist[2] == (dist[3] - 1))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private static bool CheckFull(int[] numbers)
        {
            if(CheckRepeatingCharacter(numbers, 3))
            {
                int repeatedNumber = GetRepeatNumber(numbers, 3);
                if (FullHouse(repeatedNumber, numbers))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool FullHouse(int repeatedNumber, int[] numbers)
        {
            try
            {
                for (int i = 0; i < 5; i++)//look through the array again for 2 of the same number that is not the repeated number.
                {
                    if (numbers[i] != repeatedNumber)
                    {
                        if (numbers[i + 1] == numbers[i])
                        {   //Full House!
                            return true;
                        }
                    }
                }
            }catch(IndexOutOfRangeException e)
            {
                return false;
            }
            return false;
 
        }

        private static int GetRepeatNumber(int[] numbers, int amountRepeats)
        {
            for (int n = 0; n <= (5 - amountRepeats); n++)
            {
                if (numbers[n] == numbers[n + (amountRepeats - 1)])
                {
                    return numbers[n];
                }
            }
            throw new NotImplementedException();
        }

        private static bool CheckYahtzee(int[] numbers)
        {
            //return true if a number repeats 5 times
            return CheckRepeatingCharacter(numbers, 5);
        }

        private static bool CheckFours(int[] numbers)
        {
            return CheckRepeatingCharacter(numbers, 4);
        }

        private static bool CheckThrees(int[] numbers)
        {
            //return true if a number repeats 3 times
            return CheckRepeatingCharacter(numbers, 3);
        }

        private static bool CheckRepeatingCharacter(int[] numbers, int amountRepeats)
        {
            for(int n=0; n<=(5-amountRepeats); n++)
            {
                if(numbers[n] == numbers[n + (amountRepeats - 1)])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
