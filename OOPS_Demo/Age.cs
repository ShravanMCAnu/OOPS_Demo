using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    internal class AgeAndBankBalance : InputData, IInterface2
    {
        
        // Using Encapsulation with Methods
        private int age;

        //implemented From IInterface2
        public int Bankbalance { get; set; }

        public void GetBalance()
        {
            Console.WriteLine("Enter Balance");
            Bankbalance= 0;
            if (Bankbalance < 0)
            {
                Console.WriteLine("You have Negative Balance");
            }
            else
            {
                Bankbalance=int.Parse(Console.ReadLine());
                Console.WriteLine(" Processed.....");

            }
            Balance();
        }

        //implemented From IInterface2
        public void Balance()
        {
            Console.WriteLine(Bankbalance);
        }

        public override int GetAge()
        {
           return age;

        }
        public override void SetAge(int age)
        {
            this.age = age;
        }

    }
}
