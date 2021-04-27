using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    class Game
    {
        List<Die> Dice = new List<Die>(5);

        public Game() { }

        public Game(List<Die> dice) 
        {
            Dice = dice;
        }

        public static int CalcScore(string type, List<Die> dice, int yahtzeeCounter)
        {
            int score = 0;
            int searchCriteria;
            int[] numbers = new int[5];
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

            if (score == 0)
            {
                for (int n = 0; n < 5; n++)
                {
                    searchCriteria = numbers[n];
                    try
                    {
                        if (numbers[n + 1] == searchCriteria)
                        {   //if the first 2 numbers in the sorted array are equal, it will check the 3rd number
                            //if 3 numbers are equal to each other, that fits the criteria for the rest
                            //of the score boxes until 4-of-a-kind or yahtzee.

                            if (numbers[n + 2] == searchCriteria)
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
                                if (numbers[n + 3] == searchCriteria)
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
                        }
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
                }
            }

            return score;
        }
    }
}
