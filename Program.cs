//Mauricio Acosta
//10-18-22
//AddTwoNumbers

string playAgain = "yes";

while (playAgain == "yes")
{
    Console.Clear();
    Console.WriteLine("Lets add two numbers");
Console.WriteLine("Enter your first number");
string numberOne = Console.ReadLine();

Console.WriteLine("Enter the second number");
string numberTwo = Console.ReadLine();

int num1 = Convert.ToInt32(numberOne);
int num2 = Convert.ToInt32(numberTwo);


Console.WriteLine("Your sum is:" + (num1 + num2));

Console.WriteLine("Would you like to play again, type yes to play again");

playAgain = Console.ReadLine();
}
