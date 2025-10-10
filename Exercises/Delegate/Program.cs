class Program
{
    static string FullName(string firstName, string lastName)
    {
        Func<string, string, string> myFunc = (f, l) => $"{f} {l}";
        string result = myFunc.Invoke(firstName, lastName);
        Console.WriteLine(result);
        return result;
    }


    static string GenericDelegate(string firstName, string lastName)
    {
        Func<string, string, string> myFunc = (firstName, lastName) => $"{firstName} {lastName}";
        string result = myFunc.Invoke(firstName, lastName);
        Console.WriteLine(result);
        return result;
    }

	static void DelegateParameter(Func<string, string, string> funcArray) {
	string[] firstNames = {"Mikael", "Signe", "Abo"};
	string[] lastNames = {"Ros Tobiasson", "Blix Herrlander", "Blix Tobiasson"};
		for(int i = 0; i < 3; i++) {
			Console.WriteLine(funcArray.Invoke(firstNames[i], lastNames[i]));
		}
	}

	static void SumWithLambda(int firstNum, int secondNum) {
	Func<int, int, int> myFunc = (f, s) => f + s;
	int result = myFunc.Invoke(firstNum, secondNum);
	Console.WriteLine(result);
	}



    static void Main(string[] args) {
	DelegateParameter((firstName , lastName) => $"{firstName} {lastName}");
	SumWithLambda(10, 5);

    }
}
