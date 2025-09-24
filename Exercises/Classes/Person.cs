class Person {
    public string firstName = "Bob";
    public string lastName = "Bobsson";
	public Person? mother;
	public Person? father;


    public string GetFullName() {
        return $"{firstName} {lastName}";
	}

	public string GetFullName(string title) {
	string fullName = GetFullName();
	return $"{title} {fullName}";
	}

	public string GetFullNameReversed() {
	string fullName = GetFullName();
	return new string(fullName.Reverse().ToArray());
	}

	public string GetSelfAndParents() {
		string fullName = GetFullName();
		return new string($"{fullName} - Mother: {mother} - Father {father}");
	}

}

