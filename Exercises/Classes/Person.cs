class Person {
    public string firstName { get; set; } = "default";
    public string lastName { get; set; } = "default2";

    public string GetFullName() {
        return $"{firstName} {lastName}";
    }

	public string GetFullNameReversed() {
	string fullName = GetFullName();
	return new string(fullName.Reverse().ToArray());
	}
}
