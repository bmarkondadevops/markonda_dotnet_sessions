using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerThisPointerApp.Model
{
    internal class Player:Object
    {
        private string name;
        private int age;
        private int id;
        private const int MIN_AGE = 18;

        public Player(int id,string name,int age) {
            this.id = id;
            this.name = name;
            this.age = age;

            Console.WriteLine("player created");
        }

        //constructor chaining
        public Player(int id, string name):this( id,name, MIN_AGE)
        {
           
        }


        public Player WhoIsElder(Player secondPlayer) {

            //Player x;x expects an object of Player class

            if(this.age == secondPlayer.age)
            {
                return null; 
            }

            return secondPlayer.age > this.age ? secondPlayer : this;


        }

        public int Id { 
          get { return id; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }


    }
}
