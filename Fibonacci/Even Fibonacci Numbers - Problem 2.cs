// See https://aka.ms/new-console-template for more information

// Receive user input and convert input into int (should be 4000000)
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Schema;
Console.WriteLine("Would you like to give me a ceiling below which I can calculate the sum of all even Fibonacci values?");
int Ceiling = Convert.ToInt32(Console.ReadLine());

//Sum will keep track of the sum of all even fibonacci numbers.
int Sum = 0;
//First two Fibonacci numbers
int Fibonacci1 = 1;
int Fibonacci2 = 2;
//New Fibonacci number Fibonacci 1 and 2 will add up to
int NewFibonacci = 0;

while (Fibonacci1 < Ceiling && Fibonacci2 < Ceiling && NewFibonacci < Ceiling)
{
    NewFibonacci = Fibonacci1 + Fibonacci2;
    //If any of the Fibonacci values are even
    if (Fibonacci1 % 2 == 0 && Fibonacci1 < Ceiling) { Sum += Fibonacci1; };
    if (Fibonacci2 % 2 == 0 && Fibonacci2 < Ceiling) { Sum += Fibonacci2; }; 
    if (NewFibonacci % 2 == 0 && NewFibonacci < Ceiling) { Sum += NewFibonacci; };
    //Show user none of the numbers are above the ceiling
    Console.Write(Fibonacci1 + " - " + Fibonacci2 + " - ");
    //Make sure the values being written are not above the ceiling
    if (NewFibonacci < Ceiling) { Console.WriteLine(NewFibonacci); }
    else { Console.WriteLine(); };
        //Reassign the Fibonacci values for next loop
        Fibonacci1 = Fibonacci2;
    Fibonacci2 = NewFibonacci;
}
;
Console.WriteLine("The sum of all even Fibonacci values between and include 1 and " + Ceiling + " is...");
Console.WriteLine(Sum + "!!!");
Console.ReadLine();
