using System;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

class CommandApp1
{
    static void Main(string[] userNames)
    {
        //Console.WriteLine("Welcome to command line arguments!!!");
        Console.WriteLine($"The length of userName :{userNames.Length}");

        //for(int i = 0; i < userNames.Length; i++)
        //{
        //   System.Console.WriteLine("Given string are:" + userNames[i]);
        //}

        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed,please pass the arguments");
            return;

        }
        //Print the userName
        foreach (string name in userNames)
        {            
            Console.WriteLine("Given user names are:" + name);
        }
        Console.WriteLine("-----------------");
        //Print userNames in reverse order

        for (int j = userNames.Length - 1; j >= 0; j--)
        {

            Console.WriteLine("User name is :" + userNames[j]);
            string name = userNames[j];

            var sb = new StringBuilder();

            for (int x = name.Length - 1; x >= 0; x--)
            {
                sb.Append(name[x]);
            }
            // Print reversed string
           
            Console.WriteLine("Reverse string: "+sb.ToString());
        }


        // Sort the userNames in alphabetical order
        Console.WriteLine("-----------------");
        Array.Sort(userNames);

        // Print the sorted array
        foreach (var str in userNames)
        {          
            
            Console.WriteLine(str);
        }

    }
}
