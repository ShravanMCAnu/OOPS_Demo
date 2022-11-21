// See https://aka.ms/new-console-template for more information
using OOPS_Demo;

InputData input=new InputData();
input.InterfaceMethod();
input.GetName();

Console.WriteLine("Enter Age");
int ageNoCheck = int.Parse(Console.ReadLine());
input.SetAge(ageNoCheck);

AgeAndBankBalance objAgeAndBankBalance = new AgeAndBankBalance();

Console.WriteLine("Enter Age");
int ageCheck = int.Parse(Console.ReadLine());
objAgeAndBankBalance.SetAge(ageCheck);

objAgeAndBankBalance.GetBalance();