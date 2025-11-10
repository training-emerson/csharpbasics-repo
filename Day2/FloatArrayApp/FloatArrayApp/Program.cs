using System;

class Program()
{

    static void Main(string[] FloatArray)
    {
        if (FloatArray.Length > 0)
        {
            numberSum(FloatArray);
            Console.WriteLine("End of Main");
        }
        else
        {
            Console.WriteLine("Enter parameters");
        }
    }


    static void numberSum(string[] args)
    {
        float initSum = 0.0f;
        float PreviousValue = 0.0f;
        float MaxValue = 0.0f;
        float length = args.Length;
        for (int index = 0; index < length; index++)
        {
           float CurrentValue = float.Parse(args[index]); //passing value from array and changing string to float 
            initSum = initSum+CurrentValue; //doing cummulative sum
            if (CurrentValue>=PreviousValue)
            {
               MaxValue = CurrentValue;
               PreviousValue = CurrentValue;

            }
            else
            {
                MaxValue = PreviousValue;
            }
            
        }
        Console.WriteLine("summation is: "+initSum);
        //Console.WriteLine(initSum);
        Console.WriteLine("maximum number is: "+ MaxValue);
        //Console.WriteLine(MaxValue);
    }
}