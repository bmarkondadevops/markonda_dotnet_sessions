using MovableInterfaceApp.Model;

namespace MovableInterfaceApp
{

    abstract class Account { };

    class SavingAccount : Account { }

    class CurrentAccount:Account { };

    internal class Program
    {
        static void Main(string[] args)
        {
            //Account[] accounts = new Account[3];
            //accounts[0] = new CurrentAccount();
            //accounts[1] = new SavingAccount();

            IMovable[] movables = new IMovable[3];
            movables[0] = new Car("Honda city","1234");
            movables[1] = new Bike("Bajaj pulsar", "1122");
            movables[2] = new Car("Benz S", "23456");
           
            StartRace(movables);
        }

        static void  StartRace(IMovable[] movables) {
            Console.WriteLine("Starting..race");
            foreach (IMovable x in movables) {
                x.Move();
            }


            Console.WriteLine("ending...race");

        }
    }
}
