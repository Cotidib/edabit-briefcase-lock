using System;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MinTurns("4089", "5672");
            MinTurns("1111", "1100");
            MinTurns("2391", "4984");
            
        }

        /*
        A briefcase has a 4-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards.
        Create a function that returns the smallest number of turns it takes to transform the lock from the current combination 
        to the target combination. One turn is equivalent to rolling a number forwards or backwards by one.
        Both locks are in string format.
        A 9 rolls forward to 0, and a 0 rolls backwards to a 9.
        -------------------------------------------------------------------------------------------------------------------------
        To illustrate:
        current-lock: 4089
        target-lock: 5672
        What is the minimum number of turns it takes to transform 4089 to 5672?
        -------------Test:-------------------------------------------------------------------------------------------------------
        MinTurns("4089", "5672") ➞ 9
        MinTurns("1111", "1100") ➞ 2
        MinTurns("2391", "4984") ➞ 10
        */

        public static int MinTurns(string current, string target) 
        {

            int totalRolls = 0;

            //Convert to arrays of ints
            int[] currentNumbers = current.Select(x => (int)char.GetNumericValue(x)).ToArray();
            //Array.ForEach(currentNumbers, Console.WriteLine);
            
            int[] targetNumbers = target.Select(x => (int)char.GetNumericValue(x)).ToArray();
            //Array.ForEach(targetNumbers, Console.WriteLine);

            //Compare difference between same rolling-number
            for(int i=0; i<currentNumbers.Length; i++){
                //Console.WriteLine(targetNumbers[i] - currentNumbers[i]);
                int elementSubstraction = targetNumbers[i] - currentNumbers[i];
                int difference = Math.Abs(elementSubstraction); 
                if( difference < 6){
                    totalRolls += difference;
                }
                else{
                    int smallerDifferrence = 10 - difference;
                    totalRolls += smallerDifferrence;
                }
            }

            Console.WriteLine(totalRolls);
            return totalRolls;
        }

        
        

        
    }
}
