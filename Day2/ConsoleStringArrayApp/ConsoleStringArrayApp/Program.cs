

using System;

class Program()
{
    static void Main(string[] names) 
    {
       // if (names.Length == 5)
        {
            NamesChar(names);

        }


    }
    static void NamesChar(string[] args)
    {
        string CharName = string.Empty;

        for (int index=0; index<args.Length; index++)
        {
           
            if(args[index].Length >=8)
            {

                CharName += args[index];

                //Console.WriteLine("name of person is:" + args[index]);
            }
            else
            {
                Console.WriteLine(index + " name is not with 8 characters");
            }
           
        }
        Console.WriteLine("Names with 8 characters are " + CharName);
    }
}