//Mauricio Acosta
//10-18-22
//AddTwoNumbers
string numberOne = "";
string numberTwo = "";
int numOne;
int numTwo;
string playAgain = "yes";
bool isConverted = false;
bool isConverted2 = false;
while (playAgain == "yes")
{
    Console.Clear();
    Console.WriteLine("Lets add two numbers");
    while (isConverted == false)
    {
        Console.WriteLine("Enter your first number");
        numberOne = Console.ReadLine();
        isConverted = Int32.TryParse(numberOne, out numOne);
        if (isConverted == false)
        {
            Console.WriteLine("Enter a valid Number");
        }
    }





    while (isConverted2 == false)
    {
        Console.WriteLine("Enter the second number");
        numberTwo = Console.ReadLine();
        isConverted2 = Int32.TryParse(numberTwo, out numTwo);
        if (isConverted2 == false)
        {
            Console.WriteLine("Enter a valid Number");
        }
    }



    Console.WriteLine("Your sum is:" + (numberOne + numberTwo));

    Console.WriteLine("Would you like to play again, type yes to play again");

    playAgain = Console.ReadLine();
}
