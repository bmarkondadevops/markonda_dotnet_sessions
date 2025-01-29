using ManBoyInterffaceApp.Models;

namespace ManBoyInterffaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

          //  AtTheMovies(man);//man is IEmotionable
            AtTheMovies(boy);

           
           
        }

        public static void AtTheParty(IMannerable obj) {
            Console.WriteLine("AtThe party");
            obj.Wish();
            obj.Depart();
            Console.WriteLine(" party over");
        }

        public static void AtTheMovies(IEmotionable obj)
        {
            Console.WriteLine("Movies startss..");
            obj.Cry();
            obj.Laugh();
             Console.WriteLine("Movies ends..");
        }
    }
}
