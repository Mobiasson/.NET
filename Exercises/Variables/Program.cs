/* 1. Hälsa på användaren
Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen. */
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, your name is {name}");

// 2. Multiplicera två tal
// Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade med varandra.
Console.WriteLine("Write a randon number");
string firstInput = Console.ReadLine();
Console.WriteLine("Write another random number");
string secondInput = Console.ReadLine();

if (int.TryParse(firstInput, out int value1) && (int.TryParse(secondInput, out int value2)))
{
    int sum = value1 * value2;
    Console.WriteLine($"{value1} * {value2} = {sum}");
}

// 3. Verifiera lösenord
// Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det
// i en variabel. När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.
//
string password = "abc123";
Console.WriteLine("Skriv in ett lösenord");
string input = Console.ReadLine();
while (password != input)
{
    Console.WriteLine("Wrong password! Try again!");
    input = Console.ReadLine();
}
Console.WriteLine("Correct!");

/* 4. Jämför tal
Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre, större eller lika med 100. */
int target = 100;
Console.WriteLine("Guess the number");
string guess = Console.ReadLine();
int value = (int.TryParse(guess, out int result) ? result : 0);
while (value != target)
{
    if (value > 100)
        Console.WriteLine("That is too high");
    else if (value < 100)
        Console.WriteLine("That is too low");
    else
        Console.WriteLine("That is correct!");
    Console.WriteLine("Guess again!");
    guess = Console.ReadLine();
    value = int.TryParse(guess, out result) ? result : 0;
}
Console.WriteLine("Correct");
