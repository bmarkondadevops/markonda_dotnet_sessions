using System;
using InterfaceExerciseApp.Models;

namespace InterfaceExerciseApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Create instance for Boy
            IEmotionable emotionable = new Boy();
            AtTheMovies(emotionable);
            Console.WriteLine("");

            //Create instance for Man class
            IMannerable mannerable = new Man();
            AtTheParty(mannerable);
            Console.WriteLine("");

            //Create instance for Boy and Man class
            var man = new Man();
            var boy = new Boy();
            AtTheParty(man);
            Console.WriteLine("");
            AtTheParty(boy);
            Console.WriteLine("");

            //Passing man and boy in AtTheMovies() method 
           // AtTheMovies(man);  //here Error :Not inherited 
            Console.WriteLine("");
            AtTheMovies(boy);
            Console.WriteLine("");

        }

        private static void AtTheParty(IMannerable mannerable)
        {
            mannerable.Wish();
            mannerable.Depart();
        }

        static void AtTheMovies(IEmotionable emotionable)
        {
            emotionable.Cry();
            emotionable.Laugh();

        }


    }
}
