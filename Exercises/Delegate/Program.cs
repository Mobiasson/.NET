class Program
{
	// 1. Deklarera en egen delegat-typ
    static string FullName(string firstName, string lastName)
    {
        Func<string, string, string> myFunc = (f, l) => $"{f} {l}";
        string result = myFunc.Invoke(firstName, lastName);
        Console.WriteLine(result);
        return result;
    }

	// 2. Använd generiskt delegat
    static string GenericDelegate(string firstName, string lastName)
    {
        Func<string, string, string> myFunc = (firstName, lastName) => $"{firstName} {lastName}";
        string result = myFunc.Invoke(firstName, lastName);
        Console.WriteLine(result);
        return result;
    }

	// 3. Metod som tar delegat som inparameter
	static void DelegateParameter(Func<string, string, string> funcArray) {
	string[] firstNames = {"Mikael", "Signe", "Abo"};
	string[] lastNames = {"Ros Tobiasson", "Blix Herrlander", "Blix Tobiasson"};
		for(int i = 0; i < 3; i++) {
			Console.WriteLine(funcArray.Invoke(firstNames[i], lastNames[i]));
		}
	}

	// 4. Skriv ut summan av två värden
	static void SumWithLambda(int firstNum, int secondNum) {
	Func<int, int, int> myFunc = (f, s) => f + s;
	int result = myFunc.Invoke(firstNum, secondNum);
	Console.WriteLine(result);
	}

	//5. Returnera summan av två värden
	static int SumTwoValues(int i, int j) {
	int sum = 0;
	Func<int, int, int> myFunc = (i, j) =>
		return sum;
	}

    static void Main(string[] args) {
	DelegateParameter((firstName , lastName) => $"{firstName} {lastName}");
	SumWithLambda(10, 5);
	DelegateParameter((firstName, lastName) => $"{firstName} {lastName}");
    }
}
