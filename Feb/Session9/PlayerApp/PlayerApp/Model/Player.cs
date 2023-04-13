using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private readonly int id;
        private int age;
        private string name;
        

        public Player(int id,int age,string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            Console.WriteLine("inside 3 phase constructor");
        }
        public Player(int id,string name):this(id,18,name)
        {
            Console.WriteLine("inside two phase constructor");
        }
        public  int Id
        {
            get
            {
                return id;
            }
        }
        
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public Player WhoIsElder(Player playerSecond)
        {
            return playerSecond.Age > this.Age ? this : playerSecond;
           
                
           
        }
    }
}
