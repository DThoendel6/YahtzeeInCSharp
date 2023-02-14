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
            int fullHouseMatch3;
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
                /*
                for (int n = 0; n < 5; n++)
                {
                    searchCriteria = numbers[n];
                    try
                    {
                        if (numbers[n + 1] == searchCriteria)//if(numbers[1] == numbers[0]
                        {   //if the first 2 numbers in the sorted array are equal, it will check the 3rd number
                            //if 3 numbers are equal to each other, that fits the criteria for the rest
                            //of the score boxes until 4-of-a-kind or yahtzee.

                            if (numbers[n + 2] == searchCriteria)//if(numbers[2] == numbers[0]
                            {   //if you've made it this far, you found your 3-of-a-kind!
                                if (type == "threeOfAKind")
                                {
                                    foreach (Die d in dice)
                                    {
                                        score += d.DotCount;
                                    }
                                    return score;
                                }
                                if (type == "fullHouse")
                                {
                                    fullHouseMatch3 = searchCriteria;//example if there are 3 4's, will search 
                                    for (int b = 0; b < 5; b++)      //through the array again for 2 of the same number that is not 4.
                                    {
                                        if (numbers[b] != fullHouseMatch3)
                                        {
                                            if (numbers[b + 1] == numbers[b])
                                            {   //Full House!
                                                return 25;
                                            }
                                        }
                                    }

                                }
                                if (numbers[n + 3] == searchCriteria)//if(numbers[4] == numbers[0]
                                {   //4-of-a-kind
                                    if (type == "fourOfAKind")
                                    {
                                        foreach (Die d in dice)
                                        {
                                            score += d.DotCount;
                                        }
                                        return score;
                                    }
                                    if (numbers[n + 4] == searchCriteria)
                                    {   //YAHTZEE!
                                        if (type == "yahtzee")
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
                                }
                            }
                        }//Begin search for straights
                        else if (numbers[n + 1] == searchCriteria + 1)//works 11234. 
                        {
                            if (numbers[n + 2] == searchCriteria + 2)//breaks 12234
                            {
                                if (numbers[n + 3] == searchCriteria + 3)//doesn't work for 12334.
                                {   //small straight
                                    if (type == "smallStraight")
                                    {
                                        return 30;
                                    }

                                    if (numbers[n + 4] == searchCriteria + 4)
                                    {   //large straight
                                        if (type == "largeStraight")
                                        {
                                            return 40;
                                        }
                                    }
                                }
                                else if (numbers[n + 3] == searchCriteria + 2)//passes 12334
                                {
                                    if (numbers[n + 4] == searchCriteria + 3)
                                    {
                                        if (type == "smallStraight")
                                        {
                                            return 30;
                                        }
                                    }
                                }
                            }
                            else if (numbers[n + 3] == searchCriteria + 2)//passes 12234
                            {
                                if (numbers[n + 4] == searchCriteria + 3)//12234
                                {
                                    if (type == "smallStraight")
                                    {
                                        return 30;
                                    }
                                }
                            }
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                }*/

                return score;
        }

        private static bool CheckStraight(int[] numbers, string size)
        {
            try
            {
                for (int n = 0; n < numbers.Length; n++)
                {
                    int searchCriteria = numbers[n];
                    if (numbers[n + 1] == searchCriteria + 1)//works 11234. 
                    {
                        if (numbers[n + 2] == searchCriteria + 2)//breaks 12234
                        {
                            if (numbers[n + 3] == searchCriteria + 3)//doesn't work for 12334.
                            {   //small straight
                                if (type == "smallStraight")
                                {
                                    return 30;
                                }

                                if (numbers[n + 4] == searchCriteria + 4)
                                {   //large straight
                                    if (type == "largeStraight")
                                    {
                                        return 40;
                                    }
                                }
                            }
                            else if (numbers[n + 3] == searchCriteria + 2)//passes 12334
                            {
                                if (numbers[n + 4] == searchCriteria + 3)
                                {
                                    if (type == "smallStraight")
                                    {
                                        return 30;
                                    }
                                }
                            }
                        }
                        else if (numbers[n + 3] == searchCriteria + 2)//passes 12234
                        {
                            if (numbers[n + 4] == searchCriteria + 3)//12234
                            {
                                if (type == "smallStraight")
                                {
                                    return 30;
                                }
                            }
                        }
                    }
                }
            }catch (IndexOutOfRangeException e)
            {

            }
            throw new NotImplementedException();
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
                for (int i = 0; i < 5; i++)      //through the array again for 2 of the same number that is not the repeated number.
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
            //return true if a number repeats 4 times
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
