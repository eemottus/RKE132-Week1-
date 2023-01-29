// This is a comment

//Rakendus küsib kasutajanime
//Rakendus tervitab 

Console.WriteLine("Enter your name:");
//String - sõne
String userName = Console.ReadLine();

Console.WriteLine("Hello, " + userName);

//String interpolation
Console.WriteLine($"Hello, {userName}!");