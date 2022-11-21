namespace OOPS_Demo
{
    public class InputData : AbstractClass1, IInterface  //Using Inheritance (Multiple Inheritance)
    {
        private string? name;
        private int age;

       // using Encapsulation with Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Implementing Interface Method
        public void InterfaceMethod()
        {
            Console.WriteLine(" This is Method1");
        }
        //Implementing Abstract Class
        public override void GetName()
        {
            Console.WriteLine("Enter a value to Name:");
            Name = Console.ReadLine();
            Console.WriteLine(" Name is " + Name);
        }


        //Using Encapsulation with Methods
        //And Polymorphism 
        public virtual void SetAge(int age)
        {
            if(age < 25)
            {
                Console.WriteLine("Age below 25 are Not elgible");
            }
            else
            {
                this.age = age;
                Console.WriteLine(" Age : " + age);

            }
        }
        public virtual int GetAge()
        {
            return age;
        }
    }
}
