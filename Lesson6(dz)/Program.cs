//Урок 2

string myString = "254";
int number = int.Parse(myString);
Console.WriteLine(number.GetType());
string newString = number.ToString();
Console.WriteLine(newString.GetType());
Console.WriteLine(newString);
